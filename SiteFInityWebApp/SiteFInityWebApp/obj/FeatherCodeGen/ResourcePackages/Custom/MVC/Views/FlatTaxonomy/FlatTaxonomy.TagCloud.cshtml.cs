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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.FlatTaxonomy
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/FlatTaxonomy/FlatTaxonomy.TagCloud.cshtml")]
    public partial class FlatTaxonomy_TagCloud : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_TagCloud()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 341), Tuple.Create("\"", 390)
            
            #line 8 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
, Tuple.Create(Tuple.Create("", 349), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 349), false)
, Tuple.Create(Tuple.Create(" ", 364), Tuple.Create("list-unstyled", 365), true)
, Tuple.Create(Tuple.Create(" ", 378), Tuple.Create("list-inline", 379), true)
);

WriteLiteral(">\r\n");

            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
     foreach (var taxa in Model.Taxa)
    {
        var cloudSizeClass = "fs-" + (6 - @taxa.CloudSize);
    

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 560), Tuple.Create("\"", 576)
            
            #line 14 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
, Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 567), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 577), Tuple.Create("\"", 600)
            
            #line 14 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
, Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(cloudSizeClass
            
            #line default
            #line hidden
, 585), false)
);

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
                                                   Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <span");

WriteLiteral(" class=\"small text-muted\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
                
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
                 if (Model.ShowItemCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("(");

            
            #line 18 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
                  Write(taxa.Count);

            
            #line default
            #line hidden
WriteLiteral(")\r\n");

            
            #line 19 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\r\n        </li>\r\n");

            
            #line 22 "..\..MVC\Views\FlatTaxonomy\FlatTaxonomy.TagCloud.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591