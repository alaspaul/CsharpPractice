#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.DocumentsList
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 8 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/DocumentsList/Detail.DocumentDetails.cshtml")]
    public partial class Detail_DocumentDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.DocumentsList.DocumentDetailsViewModel>
    {

#line 52 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
public System.Web.WebPages.HelperResult GetFileExtensionCssClass(String extension)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 53 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
 

    if (extension == "xlsx")
    {
        

#line default
#line hidden

#line 57 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-green"));


#line default
#line hidden

#line 57 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                      ;
    }
    else if (extension == "doc" || extension == "docx")
    {
        

#line default
#line hidden

#line 61 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-blue"));


#line default
#line hidden

#line 61 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                     ;
    }
	else if (extension == "ppt" || extension == "pptx")
    {
        

#line default
#line hidden

#line 65 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-orange"));


#line default
#line hidden

#line 65 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                       ;
    }
	else if (extension == "pdf")
    {
        

#line default
#line hidden

#line 69 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-red"));


#line default
#line hidden

#line 69 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                    ;
    }
	else if (extension == "zip")
    {
        

#line default
#line hidden

#line 73 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-purple"));


#line default
#line hidden

#line 73 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                       ;
    }
	else
	{
        

#line default
#line hidden

#line 77 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("bg-gray"));


#line default
#line hidden

#line 77 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                     ;
	}


#line default
#line hidden
});

#line 79 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
}
#line default
#line hidden

        public Detail_DocumentDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 455), Tuple.Create("\"", 478)
            
            #line 11 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 463), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 463), false)
);

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n\r\n    <h1>\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </h1>\r\n\r\n    <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                 Write(Html.Resource("PublishedOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("        ");

            
            #line 19 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 21 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n");

            
            #line 24 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 24 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"mt-3\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 943), Tuple.Create("\"", 990)
            
            #line 26 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 956), Tuple.Create<System.Object, System.Int32>(Html.Resource(" DocumentSummary")
            
            #line default
            #line hidden
, 956), false)
);

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
   Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 29 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"d-flex gap-3 align-items-center mt-3\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"flex-shrink-0 pt-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"fa-layers fa-3x\"");

WriteLiteral(">\r\n                <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n                    <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 1293), Tuple.Create("\"", 1370)
, Tuple.Create(Tuple.Create("", 1306), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#file")
, 1306), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                </svg>\r\n                <span");

WriteAttribute("class", Tuple.Create(" class=\"", 1446), Tuple.Create("\"", 1604)
, Tuple.Create(Tuple.Create("", 1454), Tuple.Create("fa-layers-text", 1454), true)
, Tuple.Create(Tuple.Create(" ", 1468), Tuple.Create("fa-layers-bottom-right", 1469), true)
, Tuple.Create(Tuple.Create(" ", 1491), Tuple.Create("text-uppercase", 1492), true)
, Tuple.Create(Tuple.Create(" ", 1506), Tuple.Create("ps-3", 1507), true)
, Tuple.Create(Tuple.Create(" ", 1511), Tuple.Create("pe-3", 1512), true)
, Tuple.Create(Tuple.Create(" ", 1516), Tuple.Create("mb-2", 1517), true)
, Tuple.Create(Tuple.Create(" ", 1521), Tuple.Create("text-white", 1522), true)
            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                           , Tuple.Create(Tuple.Create(" ", 1532), Tuple.Create<System.Object, System.Int32>(GetFileExtensionCssClass(Model.Extension)
            
            #line default
            #line hidden
, 1533), false)
, Tuple.Create(Tuple.Create(" ", 1575), Tuple.Create("sf-icon-txt-", 1576), true)
            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                   , Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.Extension
            
            #line default
            #line hidden
, 1588), false)
);

WriteLiteral(">");

            
            #line 37 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                                                                                                                Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(" role=\"group\"");

WriteLiteral(">\r\n            <div>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1752), Tuple.Create("\"", 1786)
            
            #line 42 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1759), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1759), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 42 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                 Write(Html.Resource("Download"));

            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 42 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                                                         Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n                <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1943), Tuple.Create("\"", 1988)
            
            #line 43 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 1956), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileExtension")
            
            #line default
            #line hidden
, 1956), false)
);

WriteLiteral(">(");

            
            #line 43 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                         Write(Model.Extension);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n            </div>\r\n            <span");

WriteLiteral(" class=\"text-muted small\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2079), Tuple.Create("\"", 2119)
            
            #line 45 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2092), Tuple.Create<System.Object, System.Int32>(Html.Resource(" FileSize")
            
            #line default
            #line hidden
, 2092), false)
);

WriteLiteral(">");

            
            #line 45 "..\..MVC\Views\DocumentsList\Detail.DocumentDetails.cshtml"
                                                                                Write(Math.Ceiling((double)Model.Item.Fields.TotalSize / 1024) + " KB");

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
