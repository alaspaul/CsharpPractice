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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.ImageGallery
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
    
    #line 8 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/List.SimpleList.cshtml")]
    public partial class List_SimpleList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_SimpleList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 576), Tuple.Create("\"", 636)
, Tuple.Create(Tuple.Create("", 584), Tuple.Create("list-unstyled", 584), true)
, Tuple.Create(Tuple.Create(" ", 597), Tuple.Create("d-flex", 598), true)
, Tuple.Create(Tuple.Create(" ", 604), Tuple.Create("flex-wrap", 605), true)
, Tuple.Create(Tuple.Create(" ", 614), Tuple.Create("gap-3", 615), true)
            
            #line 14 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create(" ", 620), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 621), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 637), Tuple.Create("\"", 680)
            
            #line 14 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 650), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 650), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 16 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
     foreach (var item in Model.Items)
    {
        var thumbnailViewModel = (ThumbnailViewModel)item;

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <figure");

WriteLiteral(" class=\"d-flex align-items-center h-100\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 866), Tuple.Create("\"", 973)
            
            #line 20 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 879), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(item.Fields.Description) ? item.Fields.Title : item.Fields.Description
            
            #line default
            #line hidden
, 879), false)
);

WriteLiteral(">\r\n                <img");

WriteLiteral(" loading=\"lazy\"");

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1034), Tuple.Create("\"", 1074)
            
            #line 21 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 1040), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1040), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1075), Tuple.Create("\'", 1173)
            
            #line 21 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
                        , Tuple.Create(Tuple.Create("", 1081), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1081), false)
);

WriteLiteral("\r\n                     ");

            
            #line 22 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                     ");

            
            #line 23 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n            </figure>\r\n        </li>\r\n");

            
            #line 26 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n\r\n");

            
            #line 29 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\ImageGallery\List.SimpleList.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591