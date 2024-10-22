function Get-PackageVersion($package)
{
    if($package -and $package.Version)
    {
		[convert]::ToInt32($package.Version.ToString().Replace("-beta", "").Replace("-preview", "").Replace(".", ""), 10)
    }
    else
    {
        return 0;
    }
}

function Get-BuildProject($project)
{
    return [Microsoft.Build.Evaluation.ProjectCollection]::GlobalProjectCollection.GetLoadedProjects($project.FullName) | Select-Object -First 1
}

function ApplyProjectTransformations($project)
{
	$transformations = Get-Content "$PSScriptRoot\transformations\Project.transform.json" -Raw | ConvertFrom-Json    

	foreach($item in $transformations.items)
	{
		switch ($item.transform)
		{
			"Remove" 
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}

				$itemFilePath = $null
				if($item.type -eq "Content")
				{
					$itemFilePath = Join-Path $project.DirectoryPath $item.include
				}
				if($item.type -eq "Reference")
				{
					$itemFilePath = Join-Path $project.DirectoryPath "\bin\$($item.include).dll"
				}
				
				if($itemFilePath -ne $null -and (Test-Path $itemFilePath))
				{
					try
					{						
						Write-Warning "Deleting '$itemFilePath' from the FileSystem..."
						Remove-Item $itemFilePath -Force
					} catch {
						Write-Warning "Could not delete '$itemFilePath' from the FileSystem!"
					}
				}

				break
			}

			"InsertIfMissing"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode -eq $null)
				{
					$project.AddItem($item.type, $item.include)
				}
				break
			}

			"Replace"
			{
				$itemNode = $project.Items | Where-Object { $_.ItemType -eq $item.type -and $_.EvaluatedInclude.Split(",")[0] -eq $item.include } | Select-Object -First 1
				if($itemNode)
				{
					$project.RemoveItem($itemNode)
				}
				$project.AddItem($item.type, $item.include)
				break
			}
		}
	}

	foreach($import in $transformations.imports)
	{
		if($import.transform -eq "Remove")
		{
			$importNode = $project.Xml.Imports | Where-Object { $_.Project -eq $import.project } | Select-Object -First 1
			if($importNode)
			{
				$project.Xml.RemoveChild($importNode)
			}
		}
	}

	$project.Save()
}

function TransformXML($xml, $xdt, $output)
{
    Add-Type -LiteralPath "$PSScriptRoot\lib\Microsoft.Web.XmlTransform.dll"

    $xmldoc = New-Object Microsoft.Web.XmlTransform.XmlTransformableDocument
    $xmldoc.PreserveWhitespace = $true
    $xmldoc.Load($xml)

    $transf = New-Object Microsoft.Web.XmlTransform.XmlTransformation($xdt)
    if ($transf.Apply($xmldoc) -eq $false)
    {
        throw "Transformation for '$xml' FAILED!"
    }
    
    $xmldoc.Save($output)
    $xmldoc.Dispose()
}

function TransformPackagesConfig($packagesConfig)
{
	if(!(Test-Path $packagesConfig))
	{
		Write-Warning "Could not find packages.config..."
		return
	}

	$transformations = Get-Content "$PSScriptRoot\transformations\packages.json" -Raw | ConvertFrom-Json
	$packagesConfigXML = [xml](Get-Content $packagesConfig)

	foreach($item in $transformations.items) 
	{
		$packageNode = $packagesConfigXML.SelectSingleNode("/packages/package[@id='$($item.id)']")

		switch ($item.transform)
		{
			"Remove" 
			{
				if($packageNode) 
				{
					$packageNode.ParentNode.RemoveChild($packageNode)
				}
				break
			}

			"InsertIfMissing"
			{
				if($packageNode -eq $null)
				{
					
					$packageNode = $packagesConfigXML.CreateElement("package")
					$packageNode.SetAttribute("id", $item.id)
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
					$packagesNode = $packagesConfigXML.SelectSingleNode("/packages")
					$packagesNode.AppendChild($packageNode) | out-null
					$packagesSorted = $packagesNode.SelectNodes("package") | Sort id
					$packagesNode.RemoveAll()
					$packagesSorted | foreach { $packagesNode.AppendChild($_) | out-null } 	
				}

				break
			}

			"Replace"
			{
				if($packageNode)
				{
					$packageNode.SetAttribute("version", $item.version)
					$packageNode.SetAttribute("targetFramework", $item.targetFramework)
				}

				break
			}
		}
	}

	$packagesConfigXML.Save($packagesConfig)
}
# SIG # Begin signature block
# MIIxzgYJKoZIhvcNAQcCoIIxvzCCMbsCAQExCzAJBgUrDgMCGgUAMGkGCisGAQQB
# gjcCAQSgWzBZMDQGCisGAQQBgjcCAR4wJgIDAQAABBAfzDtgWUsITrck0sYpfvNR
# AgEAAgEAAgEAAgEAAgEAMCEwCQYFKw4DAhoFAAQUPbTNt93e4o7QB7X1m2O4IM5f
# qZiggisKMIIETjCCAzagAwIBAgINAe5fFp3/lzUrZGXWajANBgkqhkiG9w0BAQsF
# ADBXMQswCQYDVQQGEwJCRTEZMBcGA1UEChMQR2xvYmFsU2lnbiBudi1zYTEQMA4G
# A1UECxMHUm9vdCBDQTEbMBkGA1UEAxMSR2xvYmFsU2lnbiBSb290IENBMB4XDTE4
# MDkxOTAwMDAwMFoXDTI4MDEyODEyMDAwMFowTDEgMB4GA1UECxMXR2xvYmFsU2ln
# biBSb290IENBIC0gUjMxEzARBgNVBAoTCkdsb2JhbFNpZ24xEzARBgNVBAMTCkds
# b2JhbFNpZ24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDMJXaQeQZ4
# Ihb1wIO2hMoonv0FdhHFrYhy/EYCQ8eyip0EXyTLLkvhYIJG4VKrDIFHcGzdZNHr
# 9SyjD4I9DCuul9e2FIYQebs7E4B3jAjhSdJqYi8fXvqWaN+JJ5U4nwbXPsnLJlkN
# c96wyOkmDoMVxu9bi9IEYMpJpij2aTv2y8gokeWdimFXN6x0FNx04Druci8unPvQ
# u7/1PQDhBjPogiuuU6Y6FnOM3UEOIDrAtKeh6bJPkC4yYOlXy7kEkmho5TgmYHWy
# n3f/kRTvriBJ/K1AFUjRAjFhGV64l++td7dkmnq/X8ET75ti+w1s4FRpFqkD2m7p
# g5NxdsZphYIXAgMBAAGjggEiMIIBHjAOBgNVHQ8BAf8EBAMCAQYwDwYDVR0TAQH/
# BAUwAwEB/zAdBgNVHQ4EFgQUj/BLf6guRSSuTVD6Y5qL3uLdG7wwHwYDVR0jBBgw
# FoAUYHtmGkUNl8qJUC99BM00qP/8/UswPQYIKwYBBQUHAQEEMTAvMC0GCCsGAQUF
# BzABhiFodHRwOi8vb2NzcC5nbG9iYWxzaWduLmNvbS9yb290cjEwMwYDVR0fBCww
# KjAooCagJIYiaHR0cDovL2NybC5nbG9iYWxzaWduLmNvbS9yb290LmNybDBHBgNV
# HSAEQDA+MDwGBFUdIAAwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFs
# c2lnbi5jb20vcmVwb3NpdG9yeS8wDQYJKoZIhvcNAQELBQADggEBACNw6c/ivvVZ
# rpRCb8RDM6rNPzq5ZBfyYgZLSPFAiAYXof6r0V88xjPy847dHx0+zBpgmYILrMf8
# fpqHKqV9D6ZX7qw7aoXW3r1AY/itpsiIsBL89kHfDwmXHjjqU5++BfQ+6tOfUBJ2
# vgmLwgtIfR4uUfaNU9OrH0Abio7tfftPeVZwXwzTjhuzp3ANNyuXlava4BJrHEDO
# xcd+7cJiWOx37XMiwor1hkOIreoTbv3Y/kIvuX1erRjvlJDKPSerJpSZdcfL03v3
# ykzTr1EhkluEfSufFT90y1HonoMOFm8b50bOI7355KKL0jlrqnkckSziYSQtjipI
# cJDEHsXo4HAwggWNMIIEdaADAgECAhAOmxiO+dAt5+/bUOIIQBhaMA0GCSqGSIb3
# DQEBDAUAMGUxCzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAX
# BgNVBAsTEHd3dy5kaWdpY2VydC5jb20xJDAiBgNVBAMTG0RpZ2lDZXJ0IEFzc3Vy
# ZWQgSUQgUm9vdCBDQTAeFw0yMjA4MDEwMDAwMDBaFw0zMTExMDkyMzU5NTlaMGIx
# CzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3
# dy5kaWdpY2VydC5jb20xITAfBgNVBAMTGERpZ2lDZXJ0IFRydXN0ZWQgUm9vdCBH
# NDCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAL/mkHNo3rvkXUo8MCIw
# aTPswqclLskhPfKK2FnC4SmnPVirdprNrnsbhA3EMB/zG6Q4FutWxpdtHauyefLK
# EdLkX9YFPFIPUh/GnhWlfr6fqVcWWVVyr2iTcMKyunWZanMylNEQRBAu34LzB4Tm
# dDttceItDBvuINXJIB1jKS3O7F5OyJP4IWGbNOsFxl7sWxq868nPzaw0QF+xembu
# d8hIqGZXV59UWI4MK7dPpzDZVu7Ke13jrclPXuU15zHL2pNe3I6PgNq2kZhAkHnD
# eMe2scS1ahg4AxCN2NQ3pC4FfYj1gj4QkXCrVYJBMtfbBHMqbpEBfCFM1LyuGwN1
# XXhm2ToxRJozQL8I11pJpMLmqaBn3aQnvKFPObURWBf3JFxGj2T3wWmIdph2PVld
# QnaHiZdpekjw4KISG2aadMreSx7nDmOu5tTvkpI6nj3cAORFJYm2mkQZK37AlLTS
# YW3rM9nF30sEAMx9HJXDj/chsrIRt7t/8tWMcCxBYKqxYxhElRp2Yn72gLD76GSm
# M9GJB+G9t+ZDpBi4pncB4Q+UDCEdslQpJYls5Q5SUUd0viastkF13nqsX40/ybzT
# QRESW+UQUOsxxcpyFiIJ33xMdT9j7CFfxCBRa2+xq4aLT8LWRV+dIPyhHsXAj6Kx
# fgommfXkaS+YHS312amyHeUbAgMBAAGjggE6MIIBNjAPBgNVHRMBAf8EBTADAQH/
# MB0GA1UdDgQWBBTs1+OC0nFdZEzfLmc/57qYrhwPTzAfBgNVHSMEGDAWgBRF66Kv
# 9JLLgjEtUYunpyGd823IDzAOBgNVHQ8BAf8EBAMCAYYweQYIKwYBBQUHAQEEbTBr
# MCQGCCsGAQUFBzABhhhodHRwOi8vb2NzcC5kaWdpY2VydC5jb20wQwYIKwYBBQUH
# MAKGN2h0dHA6Ly9jYWNlcnRzLmRpZ2ljZXJ0LmNvbS9EaWdpQ2VydEFzc3VyZWRJ
# RFJvb3RDQS5jcnQwRQYDVR0fBD4wPDA6oDigNoY0aHR0cDovL2NybDMuZGlnaWNl
# cnQuY29tL0RpZ2lDZXJ0QXNzdXJlZElEUm9vdENBLmNybDARBgNVHSAECjAIMAYG
# BFUdIAAwDQYJKoZIhvcNAQEMBQADggEBAHCgv0NcVec4X6CjdBs9thbX979XB72a
# rKGHLOyFXqkauyL4hxppVCLtpIh3bb0aFPQTSnovLbc47/T/gLn4offyct4kvFID
# yE7QKt76LVbP+fT3rDB6mouyXtTP0UNEm0Mh65ZyoUi0mcudT6cGAxN3J0TU53/o
# Wajwvy8LpunyNDzs9wPHh6jSTEAZNUZqaVSwuKFWjuyk1T3osdz9HNj0d1pcVIxv
# 76FQPfx2CWiEn2/K2yCNNWAcAgPLILCsWKAOQGPFmCLBsln1VWvPJ6tsds5vIy30
# fnFqI2si/xK4VC0nftg62fC2h5b9W9FcrBjDTZ9ztwGpn1eqXijiuZQwggWiMIIE
# iqADAgECAhB4AxhCRXCKQc9vAbjutKlUMA0GCSqGSIb3DQEBDAUAMEwxIDAeBgNV
# BAsTF0dsb2JhbFNpZ24gUm9vdCBDQSAtIFIzMRMwEQYDVQQKEwpHbG9iYWxTaWdu
# MRMwEQYDVQQDEwpHbG9iYWxTaWduMB4XDTIwMDcyODAwMDAwMFoXDTI5MDMxODAw
# MDAwMFowUzELMAkGA1UEBhMCQkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYtc2Ex
# KTAnBgNVBAMTIEdsb2JhbFNpZ24gQ29kZSBTaWduaW5nIFJvb3QgUjQ1MIICIjAN
# BgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAti3FMN166KuQPQNysDpLmRZhsuX/
# pWcdNxzlfuyTg6qE9aNDm5hFirhjV12bAIgEJen4aJJLgthLyUoD86h/ao+KYSe9
# oUTQ/fU/IsKjT5GNswWyKIKRXftZiAULlwbCmPgspzMk7lA6QczwoLB7HU3SqFg4
# lunf+RuRu4sQLNLHQx2iCXShgK975jMKDFlrjrz0q1qXe3+uVfuE8ID+hEzX4rq9
# xHWhb71hEHREspgH4nSr/2jcbCY+6R/l4ASHrTDTDI0DfFW4FnBcJHggJetnZ4ir
# uk40mGtwEd44ytS+ocCc4d8eAgHYO+FnQ4S2z/x0ty+Eo7+6CTc9Z2yxRVwZYatB
# g/WsHet3DUZHc86/vZWV7Z0riBD++ljop1fhs8+oWukHJZsSxJ6Acj2T3IyU3ztE
# 5iaA/NLDA/CMDNJF1i7nj5ie5gTuQm5nfkIWcWLnBPlgxmShtpyBIU4rxm1olIbG
# mXRzZzF6kfLUjHlufKa7fkZvTcWFEivPmiJECKiFN84HYVcGFxIkwMQxc6GYNVdH
# fhA6RdktpFGQmKmgBzfEZRqqHGsWd/enl+w/GTCZbzH76kCy59LE+snQ8FB2dFn6
# jW0XMr746X4D9OeHdZrUSpEshQMTAitCgPKJajbPyEygzp74y42tFqfT3tWbGKfG
# kjrxgmPxLg4kZN8CAwEAAaOCAXcwggFzMA4GA1UdDwEB/wQEAwIBhjATBgNVHSUE
# DDAKBggrBgEFBQcDAzAPBgNVHRMBAf8EBTADAQH/MB0GA1UdDgQWBBQfAL9GgAr8
# eDm3pbRD2VZQu86WOzAfBgNVHSMEGDAWgBSP8Et/qC5FJK5NUPpjmove4t0bvDB6
# BggrBgEFBQcBAQRuMGwwLQYIKwYBBQUHMAGGIWh0dHA6Ly9vY3NwLmdsb2JhbHNp
# Z24uY29tL3Jvb3RyMzA7BggrBgEFBQcwAoYvaHR0cDovL3NlY3VyZS5nbG9iYWxz
# aWduLmNvbS9jYWNlcnQvcm9vdC1yMy5jcnQwNgYDVR0fBC8wLTAroCmgJ4YlaHR0
# cDovL2NybC5nbG9iYWxzaWduLmNvbS9yb290LXIzLmNybDBHBgNVHSAEQDA+MDwG
# BFUdIAAwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFsc2lnbi5jb20v
# cmVwb3NpdG9yeS8wDQYJKoZIhvcNAQEMBQADggEBAKz3zBWLMHmoHQsoiBkJ1xx/
# /oa9e1ozbg1nDnti2eEYXLC9E10dI645UHY3qkT9XwEjWYZWTMytvGQTFDCkIKjg
# P+icctx+89gMI7qoLao89uyfhzEHZfU5p1GCdeHyL5f20eFlloNk/qEdUfu1JJv1
# 0ndpvIUsXPpYd9Gup7EL4tZ3u6m0NEqpbz308w2VXeb5ekWwJRcxLtv3D2jmgx+p
# 9+XUnZiM02FLL8Mofnrekw60faAKbZLEtGY/fadY7qz37MMIAas4/AocqcWXsojI
# CQIZ9lyaGvFNbDDUswarAGBIDXirzxetkpNiIHd1bL3IMrTcTevZ38GQlim9wX8w
# ggauMIIElqADAgECAhAHNje3JFR82Ees/ShmKl5bMA0GCSqGSIb3DQEBCwUAMGIx
# CzAJBgNVBAYTAlVTMRUwEwYDVQQKEwxEaWdpQ2VydCBJbmMxGTAXBgNVBAsTEHd3
# dy5kaWdpY2VydC5jb20xITAfBgNVBAMTGERpZ2lDZXJ0IFRydXN0ZWQgUm9vdCBH
# NDAeFw0yMjAzMjMwMDAwMDBaFw0zNzAzMjIyMzU5NTlaMGMxCzAJBgNVBAYTAlVT
# MRcwFQYDVQQKEw5EaWdpQ2VydCwgSW5jLjE7MDkGA1UEAxMyRGlnaUNlcnQgVHJ1
# c3RlZCBHNCBSU0E0MDk2IFNIQTI1NiBUaW1lU3RhbXBpbmcgQ0EwggIiMA0GCSqG
# SIb3DQEBAQUAA4ICDwAwggIKAoICAQDGhjUGSbPBPXJJUVXHJQPE8pE3qZdRodbS
# g9GeTKJtoLDMg/la9hGhRBVCX6SI82j6ffOciQt/nR+eDzMfUBMLJnOWbfhXqAJ9
# /UO0hNoR8XOxs+4rgISKIhjf69o9xBd/qxkrPkLcZ47qUT3w1lbU5ygt69OxtXXn
# HwZljZQp09nsad/ZkIdGAHvbREGJ3HxqV3rwN3mfXazL6IRktFLydkf3YYMZ3V+0
# VAshaG43IbtArF+y3kp9zvU5EmfvDqVjbOSmxR3NNg1c1eYbqMFkdECnwHLFuk4f
# sbVYTXn+149zk6wsOeKlSNbwsDETqVcplicu9Yemj052FVUmcJgmf6AaRyBD40Nj
# gHt1biclkJg6OBGz9vae5jtb7IHeIhTZgirHkr+g3uM+onP65x9abJTyUpURK1h0
# QCirc0PO30qhHGs4xSnzyqqWc0Jon7ZGs506o9UD4L/wojzKQtwYSH8UNM/STKvv
# mz3+DrhkKvp1KCRB7UK/BZxmSVJQ9FHzNklNiyDSLFc1eSuo80VgvCONWPfcYd6T
# /jnA+bIwpUzX6ZhKWD7TA4j+s4/TXkt2ElGTyYwMO1uKIqjBJgj5FBASA31fI7tk
# 42PgpuE+9sJ0sj8eCXbsq11GdeJgo1gJASgADoRU7s7pXcheMBK9Rp6103a50g5r
# mQzSM7TNsQIDAQABo4IBXTCCAVkwEgYDVR0TAQH/BAgwBgEB/wIBADAdBgNVHQ4E
# FgQUuhbZbU2FL3MpdpovdYxqII+eyG8wHwYDVR0jBBgwFoAU7NfjgtJxXWRM3y5n
# P+e6mK4cD08wDgYDVR0PAQH/BAQDAgGGMBMGA1UdJQQMMAoGCCsGAQUFBwMIMHcG
# CCsGAQUFBwEBBGswaTAkBggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQu
# Y29tMEEGCCsGAQUFBzAChjVodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGln
# aUNlcnRUcnVzdGVkUm9vdEc0LmNydDBDBgNVHR8EPDA6MDigNqA0hjJodHRwOi8v
# Y3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkUm9vdEc0LmNybDAgBgNV
# HSAEGTAXMAgGBmeBDAEEAjALBglghkgBhv1sBwEwDQYJKoZIhvcNAQELBQADggIB
# AH1ZjsCTtm+YqUQiAX5m1tghQuGwGC4QTRPPMFPOvxj7x1Bd4ksp+3CKDaopafxp
# wc8dB+k+YMjYC+VcW9dth/qEICU0MWfNthKWb8RQTGIdDAiCqBa9qVbPFXONASIl
# zpVpP0d3+3J0FNf/q0+KLHqrhc1DX+1gtqpPkWaeLJ7giqzl/Yy8ZCaHbJK9nXzQ
# cAp876i8dU+6WvepELJd6f8oVInw1YpxdmXazPByoyP6wCeCRK6ZJxurJB4mwbfe
# Kuv2nrF5mYGjVoarCkXJ38SNoOeY+/umnXKvxMfBwWpx2cYTgAnEtp/Nh4cku0+j
# Sbl3ZpHxcpzpSwJSpzd+k1OsOx0ISQ+UzTl63f8lY5knLD0/a6fxZsNBzU+2QJsh
# IUDQtxMkzdwdeDrknq3lNHGS1yZr5Dhzq6YBT70/O3itTK37xJV77QpfMzmHQXh6
# OOmc4d0j/R0o08f56PGYX/sr2H7yRp11LB4nLCbbbxV7HhmLNriT1ObyF5lZynDw
# N7+YAN8gFk8n+2BnFqFmut1VwDophrCYoCvtlUG3OtUVmDG0YgkPCr2B2RP+v6TR
# 81fZvAT6gt4y3wSJ8ADNXcL50CN/AAvkdgIm2fBldkKmKYcJRyvmfxqkhQ/8mJb2
# VVQrH4D6wPIOK+XW+6kvRBVK5xMOHds3OBqhK/bt1nz8MIIGwDCCBKigAwIBAgIQ
# DE1pckuU+jwqSj0pB4A9WjANBgkqhkiG9w0BAQsFADBjMQswCQYDVQQGEwJVUzEX
# MBUGA1UEChMORGlnaUNlcnQsIEluYy4xOzA5BgNVBAMTMkRpZ2lDZXJ0IFRydXN0
# ZWQgRzQgUlNBNDA5NiBTSEEyNTYgVGltZVN0YW1waW5nIENBMB4XDTIyMDkyMTAw
# MDAwMFoXDTMzMTEyMTIzNTk1OVowRjELMAkGA1UEBhMCVVMxETAPBgNVBAoTCERp
# Z2lDZXJ0MSQwIgYDVQQDExtEaWdpQ2VydCBUaW1lc3RhbXAgMjAyMiAtIDIwggIi
# MA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDP7KUmOsap8mu7jcENmtuh6BSF
# dDMaJqzQHFUeHjZtvJJVDGH0nQl3PRWWCC9rZKT9BoMW15GSOBwxApb7crGXOlWv
# M+xhiummKNuQY1y9iVPgOi2Mh0KuJqTku3h4uXoW4VbGwLpkU7sqFudQSLuIaQyI
# xvG+4C99O7HKU41Agx7ny3JJKB5MgB6FVueF7fJhvKo6B332q27lZt3iXPUv7Y3U
# TZWEaOOAy2p50dIQkUYp6z4m8rSMzUy5Zsi7qlA4DeWMlF0ZWr/1e0BubxaompyV
# R4aFeT4MXmaMGgokvpyq0py2909ueMQoP6McD1AGN7oI2TWmtR7aeFgdOej4TJEQ
# ln5N4d3CraV++C0bH+wrRhijGfY59/XBT3EuiQMRoku7mL/6T+R7Nu8GRORV/zbq
# 5Xwx5/PCUsTmFntafqUlc9vAapkhLWPlWfVNL5AfJ7fSqxTlOGaHUQhr+1NDOdBk
# +lbP4PQK5hRtZHi7mP2Uw3Mh8y/CLiDXgazT8QfU4b3ZXUtuMZQpi+ZBpGWUwFjl
# 5S4pkKa3YWT62SBsGFFguqaBDwklU/G/O+mrBw5qBzliGcnWhX8T2Y15z2LF7OF7
# ucxnEweawXjtxojIsG4yeccLWYONxu71LHx7jstkifGxxLjnU15fVdJ9GSlZA076
# XepFcxyEftfO4tQ6dwIDAQABo4IBizCCAYcwDgYDVR0PAQH/BAQDAgeAMAwGA1Ud
# EwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwgwIAYDVR0gBBkwFzAIBgZn
# gQwBBAIwCwYJYIZIAYb9bAcBMB8GA1UdIwQYMBaAFLoW2W1NhS9zKXaaL3WMaiCP
# nshvMB0GA1UdDgQWBBRiit7QYfyPMRTtlwvNPSqUFN9SnDBaBgNVHR8EUzBRME+g
# TaBLhklodHRwOi8vY3JsMy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVkRzRS
# U0E0MDk2U0hBMjU2VGltZVN0YW1waW5nQ0EuY3JsMIGQBggrBgEFBQcBAQSBgzCB
# gDAkBggrBgEFBQcwAYYYaHR0cDovL29jc3AuZGlnaWNlcnQuY29tMFgGCCsGAQUF
# BzAChkxodHRwOi8vY2FjZXJ0cy5kaWdpY2VydC5jb20vRGlnaUNlcnRUcnVzdGVk
# RzRSU0E0MDk2U0hBMjU2VGltZVN0YW1waW5nQ0EuY3J0MA0GCSqGSIb3DQEBCwUA
# A4ICAQBVqioa80bzeFc3MPx140/WhSPx/PmVOZsl5vdyipjDd9Rk/BX7NsJJUSx4
# iGNVCUY5APxp1MqbKfujP8DJAJsTHbCYidx48s18hc1Tna9i4mFmoxQqRYdKmEIr
# UPwbtZ4IMAn65C3XCYl5+QnmiM59G7hqopvBU2AJ6KO4ndetHxy47JhB8PYOgPvk
# /9+dEKfrALpfSo8aOlK06r8JSRU1NlmaD1TSsht/fl4JrXZUinRtytIFZyt26/+Y
# siaVOBmIRBTlClmia+ciPkQh0j8cwJvtfEiy2JIMkU88ZpSvXQJT657inuTTH4YB
# ZJwAwuladHUNPeF5iL8cAZfJGSOA1zZaX5YWsWMMxkZAO85dNdRZPkOaGK7DycvD
# +5sTX2q1x+DzBcNZ3ydiK95ByVO5/zQQZ/YmMph7/lxClIGUgp2sCovGSxVK05iQ
# RWAzgOAj3vgDpPZFR+XOuANCR+hBNnF3rf2i6Jd0Ti7aHh2MWsgemtXC8MYiqE+b
# vdgcmlHEL5r2X6cnl7qWLoVXwGDneFZ/au/ClZpLEQLIgpzJGgV8unG1TnqZbPTo
# ntRamMifv427GFxD9dAq6OJi7ngE273R+1sKqHB+8JeEeOMIA11HLGOoJTiXAdI/
# Otrl5fbmm9x+LMz/F0xNAKLY1gEOuIvu5uByVYksJxlh9ncBjDCCBuYwggTOoAMC
# AQICEHe9DgOhtwj4VKsGchDZBEcwDQYJKoZIhvcNAQELBQAwUzELMAkGA1UEBhMC
# QkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYtc2ExKTAnBgNVBAMTIEdsb2JhbFNp
# Z24gQ29kZSBTaWduaW5nIFJvb3QgUjQ1MB4XDTIwMDcyODAwMDAwMFoXDTMwMDcy
# ODAwMDAwMFowWTELMAkGA1UEBhMCQkUxGTAXBgNVBAoTEEdsb2JhbFNpZ24gbnYt
# c2ExLzAtBgNVBAMTJkdsb2JhbFNpZ24gR0NDIFI0NSBDb2RlU2lnbmluZyBDQSAy
# MDIwMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEA1kJN+eNPxiP0bB2B
# pjD3SD3P0OWN5SAilgdENV0Gzw8dcGDmJlT6UyNgAqhfAgL3jsluPal4Bb2O9U8Z
# JJl8zxEWmx97a9Kje2hld6vYsSw/03IGMlxbrFBnLCVNVgY2/MFiTH19hhaVml1U
# ulDQsH+iRBnp1m5sPhPCnxHUXzRbUWgxYwr4W9DeullfMa+JaDhAPgjoU2dOY7Yh
# ju/djYVBVZ4cvDfclaDEcacfG6VJbgogWX6Jo1gVlwAlad/ewmpQZU5T+2uhnxge
# ig5fVF694FvP8gwE0t4IoRAm97Lzei7CjpbBP86l2vRZKIw3ZaExlguOpHZ3FUmE
# ZoIl50MKd1KxmVFC/6Gy3ZzS3BjZwYapQB1Bl2KGvKj/osdjFwb9Zno2lAEgiXgf
# kPR7qVJOak9UBiqAr57HUEL6ZQrjAfSxbqwOqOOBGag4yJ4DKIakdKdHlX5yWip7
# FWocxGnmsL5AGZnL0n1VTiKcEOChW8OzLnqLxN7xSx+MKHkwRX9sE7Y9LP8tSooq
# 7CgPLcrUnJiKSm1aNiwv37rL4kFKCHcYiK01YZQS86Ry6+42nqdRJ5E896IazPyH
# 5ZfhUYdp6SLMg8C3D0VsB+FDT9SMSs7PY7G1pBB6+Q0MKLBrNP4haCdv7Pj6JoRb
# dULNiSZ5WZ1rq2NxYpAlDQgg8f8CAwEAAaOCAa4wggGqMA4GA1UdDwEB/wQEAwIB
# hjATBgNVHSUEDDAKBggrBgEFBQcDAzASBgNVHRMBAf8ECDAGAQH/AgEAMB0GA1Ud
# DgQWBBTas43AJJCja3fTDKBZ3SFnZHYLeDAfBgNVHSMEGDAWgBQfAL9GgAr8eDm3
# pbRD2VZQu86WOzCBkwYIKwYBBQUHAQEEgYYwgYMwOQYIKwYBBQUHMAGGLWh0dHA6
# Ly9vY3NwLmdsb2JhbHNpZ24uY29tL2NvZGVzaWduaW5ncm9vdHI0NTBGBggrBgEF
# BQcwAoY6aHR0cDovL3NlY3VyZS5nbG9iYWxzaWduLmNvbS9jYWNlcnQvY29kZXNp
# Z25pbmdyb290cjQ1LmNydDBBBgNVHR8EOjA4MDagNKAyhjBodHRwOi8vY3JsLmds
# b2JhbHNpZ24uY29tL2NvZGVzaWduaW5ncm9vdHI0NS5jcmwwVgYDVR0gBE8wTTBB
# BgkrBgEEAaAyATIwNDAyBggrBgEFBQcCARYmaHR0cHM6Ly93d3cuZ2xvYmFsc2ln
# bi5jb20vcmVwb3NpdG9yeS8wCAYGZ4EMAQQBMA0GCSqGSIb3DQEBCwUAA4ICAQAI
# iHImxq/6rF8GwKqMkNrQssCil/9uEzIWVP0+9DARn4+Y+ZtS3fKiFu7ZeJWmmnxh
# uAS1+OvL9GERM/ZlJbcRQovYaW7H/5W0gUOpfq6/gtZNzBGjg3FqEF4ZBafnbH9W
# 9Khcw04JrVlruPl+pS64/N4OwqD7sATUExvHJ6m5qi0xO89GTJ3rTOy8Lpzxh6N/
# OGlfQUBn9lN96kHvjj37qdQROEbfPOv2zSK9E83w4eblM6C+POR41RvMIPIwc7Ai
# HPaE1ptcAALhKFJL/xJLQOrusBoGBp6E5ufw24RG+3PZK0K2yVc0xxbApushuaoO
# 9/7byuu8F8u4Z+vjPk/bqZSGZFXJCQrA2QRxShFLWmTDvHh4rUxHJmUHmdXNNmCh
# M1Oz9nsq1YlAPHGlq/iZWf3jm5JL3QW9Cwx4BivPU9i9EppbJ4aFP5G+4HiAc1Tf
# px1nK2q2rk2JgCQIUnBQ8wH/RK4vmuDhSQjh4VvXONGeCoqdlCebyqO52+I2auNv
# uVhi4DZ4NgH6waeJeiZTo1y70rLristjCC/+HvNWKeI1m9j/6aW9bUtZLIksL1K7
# tSmQ2kNHvHLdvNm/gMHcsKu0Sx1YNjdk65vhhReaKaL95gjSkv+g+Hzh6afRMI5f
# JlArx6Lil3eK79hNPibrmUBg8zxnDLYIcik1U4E03DCCBx0wggUFoAMCAQICDBDF
# uKcZwc/Yk47GvTANBgkqhkiG9w0BAQsFADBZMQswCQYDVQQGEwJCRTEZMBcGA1UE
# ChMQR2xvYmFsU2lnbiBudi1zYTEvMC0GA1UEAxMmR2xvYmFsU2lnbiBHQ0MgUjQ1
# IENvZGVTaWduaW5nIENBIDIwMjAwHhcNMjMwMTI2MTk1NTU3WhcNMjQwMzExMTky
# MDM1WjCBijELMAkGA1UEBhMCVVMxFjAUBgNVBAgTDU1hc3NhY2h1c2V0dHMxEzAR
# BgNVBAcTCkJ1cmxpbmd0b24xJjAkBgNVBAoTHVBST0dSRVNTIFNPRlRXQVJFIENP
# UlBPUkFUSU9OMSYwJAYDVQQDEx1QUk9HUkVTUyBTT0ZUV0FSRSBDT1JQT1JBVElP
# TjCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAORwjpiXFyN78GUtmjO1
# G5ExlqUzo9135OPnw1vboQbNbXkW16E4X5FwU8BJNtR3C3kn5GNES0K4U0xk1/cr
# ileeIdwK2lLCkuvh/I/vlUS4rQc/YlWJ0XDC1L0Y17fxLiG6azm6v3sgB3eTMKBC
# Sre2gjoPSTZ2NEhHeLc7QH7Ar3t5+89b5WTw4j0ZhPIXGBKAMq8Hb0PQpCUJA/M3
# QWLZg9KfVj0bKDNUfv+FfNF45BlnVLxE25a/T/TTzvOaZBmgMhqEXR05XBPxGpMz
# tTIwffQrlCCFjpo3qguQPQ0vsz0HAwsN1qs8eqGgXjTzr3aJm+UquStrCa78zRGw
# lpUwSqDIRFTFNnbnzDHQVulWNPXXJ10FKhya9tp34mjCXJfVE0EWgUG3zKPd5gih
# EDIA5ClQ67/Q/xfJhnkoN5QBjRsEjT5LLUG+X9M0ZViN9BvPYkU8z0dP4C8A3Xo7
# 3bRmYkjLl0S7ZMTc20cf64KCCPQlLQvrg1VtAt19mp+hh88a/V8X0ZCzPGAndMab
# ndgJUQTOLu6SsensyhtWTw0Yv6S2Gd0Uepr9HIgkKQ9vYyerHAtZvLRUjfzf0w14
# 7j9wtw4m/ssVMKCQgE7COzPZ3IFFgQhNCchb4DffG54ykmRi0T8ug6zukKntr1ZQ
# Lj0jcCQC+V/oXuqPMb+3qoIFAgMBAAGjggGxMIIBrTAOBgNVHQ8BAf8EBAMCB4Aw
# gZsGCCsGAQUFBwEBBIGOMIGLMEoGCCsGAQUFBzAChj5odHRwOi8vc2VjdXJlLmds
# b2JhbHNpZ24uY29tL2NhY2VydC9nc2djY3I0NWNvZGVzaWduY2EyMDIwLmNydDA9
# BggrBgEFBQcwAYYxaHR0cDovL29jc3AuZ2xvYmFsc2lnbi5jb20vZ3NnY2NyNDVj
# b2Rlc2lnbmNhMjAyMDBWBgNVHSAETzBNMEEGCSsGAQQBoDIBMjA0MDIGCCsGAQUF
# BwIBFiZodHRwczovL3d3dy5nbG9iYWxzaWduLmNvbS9yZXBvc2l0b3J5LzAIBgZn
# gQwBBAEwCQYDVR0TBAIwADBFBgNVHR8EPjA8MDqgOKA2hjRodHRwOi8vY3JsLmds
# b2JhbHNpZ24uY29tL2dzZ2NjcjQ1Y29kZXNpZ25jYTIwMjAuY3JsMBMGA1UdJQQM
# MAoGCCsGAQUFBwMDMB8GA1UdIwQYMBaAFNqzjcAkkKNrd9MMoFndIWdkdgt4MB0G
# A1UdDgQWBBSTEUFp+iR9Eu3ntp677EzOOw4ntDANBgkqhkiG9w0BAQsFAAOCAgEA
# eGyf5BqNoCEno6DRvLxPYpoETUWc+X86QFZVeDx3WmHuIvgNqtJU6jGu6ckcH1z0
# dr/tV150p2zwJK9M53zT9YhgSKQHMnxEQYQiz057PyT/QnjYJamIb7x4XPiB7MIe
# Fy4JlE6tH6O1ymT70p0SP714oSOYbP8zdzezRkJNla+gflZ90uGgg0FMcTOf0YEw
# OKMHhES0raFBnnUH3V/E39zvvjsxioYOjCt+cxI+qItKGlGIRPGrBhZUeFpe5iYv
# JjQDfa0zb8eVcN0d/Yd6vIBbyxeO/iiO+qBkgz+4ghD1U9+7Po67Za4Tpf6fND7w
# l4S5pO0lm4o3O1osIxQv0S4FBKP/6ujsbyiQWf3NMA50rh/L7adYP5dFPzI9Z7UR
# iq78wsesI/6hPFletL4h70gkUpv6uVdQfIeu8lR9S494nJ9L/XMzElNhiWPjfmiz
# wJWNN1r3peAV2xrtrcdYSLEU07MhYJi7UQv/O3ymnnml1hQEuumhDES+GwmwdBwP
# 1ihJYflizCRV0AFNpegyLUkWTC9R8zw/QR7wUETNt73CGYmhI7UrJMNxSTy2yCox
# gc9GjbnEkn4TqJ1LcIPFmKDjvpywuCyUzPK0XhLD+fW0AxHuxFEBhAG7tJRVX3r8
# PvBISqd+fzUUgSAQs78pM8UmvB9TpkJI3a4ZrFeLQloxggYuMIIGKgIBATBpMFkx
# CzAJBgNVBAYTAkJFMRkwFwYDVQQKExBHbG9iYWxTaWduIG52LXNhMS8wLQYDVQQD
# EyZHbG9iYWxTaWduIEdDQyBSNDUgQ29kZVNpZ25pbmcgQ0EgMjAyMAIMEMW4pxnB
# z9iTjsa9MAkGBSsOAwIaBQCgeDAYBgorBgEEAYI3AgEMMQowCKACgAChAoAAMBkG
# CSqGSIb3DQEJAzEMBgorBgEEAYI3AgEEMBwGCisGAQQBgjcCAQsxDjAMBgorBgEE
# AYI3AgEVMCMGCSqGSIb3DQEJBDEWBBRL8NftyipWg/AQSvBPtcbbsoczpDANBgkq
# hkiG9w0BAQEFAASCAgDVFDAE/hGrJg7xU/Uz6ksd0tMCnjS5Bz36b4lZBQF4XokX
# GOUjuvGcKcn+qzw4zimuUqofBLeRwAZ9opYuiCUyPVxKUxQZErysfecqS0gr2c4B
# lsn43Qb3fNOY/J1GRHNLX9yErLsN8DLQjJk2Qa8Jhg4YBefmbIHtSumH9ZviYGzf
# w7FuSHJTsOFLh2OrVOAXMZuJRaY0Ldge13qWARE1GMudm0XlFzfU8Zz7asSdErML
# doCyFg6nBldiQ0mtqJLWpWLElHYpVjnI/6T8Ex18NKpIWBcKqTT+UZHvNGxhQcAt
# gc5uRxsEDGBXaAKq+ZYD5UvSytoT6pZ4jA6Swqqrj1rHTihkOiH3W6UmYBQHS5P3
# 60fryj1MdWWFl+TYegddC1ckcdQ0xZ1p4jaDiEDpQbJQjsf0ugLFHGoxIHvSEJHZ
# X7cVguszUa4+Sz7x1SlMKmK9ftkral8sTgq46etoXXZzPRsJLVDpOYbku4tN/qPC
# 5cgNn7+JdCFdv7InF6rp2c5DEFX5Ovb4ecgfTTDCLxpbYcunl7SqajaeWb6xQOjd
# EQe1GQS0FTlrdCAp/v2oYdjlsbNGnTaEveDRXrXCkyP52J7oLl1s1OkLbLNJzQEd
# cojQVSaWuScTlypLQs4SHHZ5yzRRhDXR33vZttd4YfuvpO7oYHptbCPjFA++XKGC
# AyAwggMcBgkqhkiG9w0BCQYxggMNMIIDCQIBATB3MGMxCzAJBgNVBAYTAlVTMRcw
# FQYDVQQKEw5EaWdpQ2VydCwgSW5jLjE7MDkGA1UEAxMyRGlnaUNlcnQgVHJ1c3Rl
# ZCBHNCBSU0E0MDk2IFNIQTI1NiBUaW1lU3RhbXBpbmcgQ0ECEAxNaXJLlPo8Kko9
# KQeAPVowDQYJYIZIAWUDBAIBBQCgaTAYBgkqhkiG9w0BCQMxCwYJKoZIhvcNAQcB
# MBwGCSqGSIb3DQEJBTEPFw0yMzAzMzExMzUzMDRaMC8GCSqGSIb3DQEJBDEiBCCo
# BwnSKNhCTT+xGymu6acKvGDlEADTmO9C8KBYX5MzrzANBgkqhkiG9w0BAQEFAASC
# AgA/bUkwAJj0cIqQuz+5MDhqx+E1InT/7kY/hyZDeROZaV9bYqt8v/k2zXSsX7Zp
# fZopimHZAevIaSdB1/nnwv2iygO54rufPTvQtebfCrXPzzhsmui70apKmfF+v87z
# OB5bzE7FkwqmMmgj+oKxv0ZJf7f1R5dnVI1iA1pInQyqBpOMR1XRV15Ia3IpAT5w
# YCHiXVeP0IIDcnqoz0dY7crQJlURAyoTYWLJyyz1ii73VHgOHhjgvJn24+62wP2m
# QvGVry3wF5HgusaO8MEw4WJatP/ltKoW8BEI/N9fA4B6+uSxzC+ahuiB/or+v4NO
# TE6rkEPSoEG2kBEQqcU3kexRXtORQyZX2ZCkBmvd6uhY6EGqignFtGjcVl36SVYq
# 3o5Vuz3g8uIfZe3XOGhPwyzIc4c1Yi8ZtGw0U4UC8LGE6zLLvdwBqKApQitASIrS
# P4aPFN7t1VPa0ghpf9MVH5RFRoC2hTHrL8jRVKFgnuwFJNOpTRce1xoksRiFNNmq
# tbN2UBAUwbHOaW6efdxucUSptceal8cOD71uzNhzQU0ujsX4ileM2KEGypBQ3e6P
# R724OT3Mxjod1Vcx+ETfKX7g2wTpNRp63dqZ5+EY5FTNW0/hxgM+H2dvORDKpM1D
# 8C65ZNIYNW1bMPTRkf+bX7a6LycDyTZU9p+zfVbHcmDLlw==
# SIG # End signature block
