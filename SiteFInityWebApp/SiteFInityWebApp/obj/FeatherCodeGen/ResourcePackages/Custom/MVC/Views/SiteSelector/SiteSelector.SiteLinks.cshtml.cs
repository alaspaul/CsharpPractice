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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.SiteSelector
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
    
    #line 10 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SiteSelector/SiteSelector.SiteLinks.cshtml")]
    public partial class SiteSelector_SiteLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.SiteSelector.SiteSelectorViewModel>
    {
        public SiteSelector_SiteLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 518), Tuple.Create("\"", 541)
            
            #line 12 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 526), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 526), false)
);

WriteLiteral(">\r\n\r\n    <label");

WriteLiteral(" class=\"form-label mb-0\"");

WriteAttribute("id", Tuple.Create(" id=\'", 581), Tuple.Create("\'", 621)
            
            #line 14 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 586), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SiteSelectorLinks")
            
            #line default
            #line hidden
, 586), false)
);

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                       Write(Html.Resource("Sites"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n   \r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 690), Tuple.Create("\'", 743)
            
            #line 16 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 708), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SiteSelectorLinks")
            
            #line default
            #line hidden
, 708), false)
);

WriteLiteral(">\r\n");

            
            #line 17 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
      
        string currentSite = string.Empty;
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 21 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
     foreach (var site in Model.Sites)
    {
        if (!Model.EachLanguageAsSeparateSite)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"btn btn-light btn-sm pe-none\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                          Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 28 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode)
            {
            
            #line default
            #line hidden
WriteLiteral("   <li><a");

WriteLiteral(" class=\"btn btn-link btn-sm disabled\"");

WriteLiteral(" aria-disabled=\"true\"");

WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                            Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 31 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1286), Tuple.Create("\"", 1302)
            
            #line 34 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 1293), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1293), false)
);

WriteLiteral(" class=\"btn btn-link btn-sm\"");

WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                               Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 35 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else if (Model.SiteLanguagesDisplayMode == SiteLanguagesDisplayMode.SiteNamesAndLanguages)
        {
            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"btn btn-light btn-sm pe-none\"");

WriteLiteral(">");

            
            #line 41 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                          Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 41 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                       Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 42 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteLiteral(" class=\"btn btn-link btn-sm disabled\"");

WriteLiteral(" aria-disabled=\"true\"");

WriteLiteral(">");

            
            #line 45 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                            Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 45 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                                         Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 46 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1981), Tuple.Create("\"", 1997)
            
            #line 49 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 1988), false)
);

WriteLiteral(" class=\"btn btn-link btn-sm\"");

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                               Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral(" - ");

            
            #line 49 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                            Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 50 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
        else
        {
            if(currentSite != site.Name)
            {                                   

            
            #line default
            #line hidden
WriteLiteral("                <li><strong");

WriteLiteral(" class=\"small\"");

WriteLiteral(">");

            
            #line 56 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                     Write(site.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong></li>\r\n");

            
            #line 57 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                currentSite = site.Name;
            }

            if (site.IsCurrent)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><span");

WriteLiteral(" class=\"btn btn-light btn-sm pe-none\"");

WriteLiteral(">");

            
            #line 62 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                          Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</span></li>\r\n");

            
            #line 63 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else if (SystemManager.IsDesignMode && !SystemManager.IsInlineEditingMode && !SystemManager.IsPreviewMode)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteLiteral(" class=\"btn btn-link btn-sm disabled\"");

WriteLiteral(" aria-disabled=\"true\"");

WriteLiteral(">");

            
            #line 66 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                                            Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 67 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
            else
            {


            
            #line default
            #line hidden
WriteLiteral("                <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2802), Tuple.Create("\"", 2818)
            
            #line 71 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
, Tuple.Create(Tuple.Create("", 2809), Tuple.Create<System.Object, System.Int32>(site.Url
            
            #line default
            #line hidden
, 2809), false)
);

WriteLiteral(" class=\"btn btn-link btn-sm\"");

WriteLiteral(">");

            
            #line 71 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
                                                               Write(site.Language);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 72 "..\..MVC\Views\SiteSelector\SiteSelector.SiteLinks.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
