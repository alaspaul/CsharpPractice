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
    
    #line 8 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/Detail.DetailPage.cshtml")]
    public partial class Detail_DetailPage : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery.ImageDetailsViewModel>
    {

#line 74 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection(string arrow)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 75 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
 
    bool isRtl = ((Html.RenderDirAttribute().ToString() == "dir=\"rtl\"")?true:false);
     
    if (arrow == "next" && !isRtl || arrow == "prev" && isRtl)
    {
        

#line default
#line hidden

#line 80 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-right"));


#line default
#line hidden

#line 80 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 84 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-left"));


#line default
#line hidden

#line 84 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 86 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
}
#line default
#line hidden

        public Detail_DetailPage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 533), Tuple.Create("\"", 556)
            
            #line 13 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 541), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 541), false)
);

WriteLiteral(" ");

            
            #line 13 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <figure");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 677), Tuple.Create("\"", 726)
            
            #line 14 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 695), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageCaption")
            
            #line default
            #line hidden
, 695), false)
);

WriteLiteral(">\r\n        <figcaption");

WriteLiteral(" class=\"h2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 760), Tuple.Create("\"", 796)
            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 765), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageCaption")
            
            #line default
            #line hidden
, 765), false)
);

WriteLiteral(" ");

            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                               Write(Html.InlineEditingFieldAttributes("Title", "ShortText" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                                         Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>\r\n        <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                     Write(Html.Resource("ImageTakenOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n\r\n");

WriteLiteral("        ");

            
            #line 23 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
   Write(Html.CommentsCount(string.Empty, @Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <p");

WriteAttribute("id", Tuple.Create(" id=\"", 1294), Tuple.Create("\"", 1334)
            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1299), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageDescription")
            
            #line default
            #line hidden
, 1299), false)
);

WriteLiteral(" ");

            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                               Write(Html.InlineEditingFieldAttributes("Description", "LongText" ));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 25 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                                                              Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <div");

WriteLiteral(" class=\"d-flex justify-content-center bg-light\"");

WriteLiteral(">\r\n            <img");

WriteLiteral(" loading=\"lazy\"");

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\"", 1577), Tuple.Create("\"", 1631)
            
            #line 27 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 1596), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" ImageDescription")
            
            #line default
            #line hidden
, 1596), false)
);

WriteAttribute("src", Tuple.Create(" src=\"", 1632), Tuple.Create("\"", 1663)
            
            #line 27 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                  , Tuple.Create(Tuple.Create("", 1638), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 1638), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\'", 1664), Tuple.Create("\'", 1768)
            
            #line 27 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                                  , Tuple.Create(Tuple.Create("", 1670), Tuple.Create<System.Object, System.Int32>(System.Text.RegularExpressions.Regex.Replace(Model.Item.Fields.AlternativeText, @"[^\w\d_-]", "")
            
            #line default
            #line hidden
, 1670), false)
);

WriteLiteral("\r\n                 ");

            
            #line 28 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetWidthAttributeIfExists(Model.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                 ");

            
            #line 29 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
            Write(Html.GetHeightAttributeIfExists(Model.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n        </div>\r\n    </figure>\r\n\r\n");

            
            #line 33 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 33 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("    <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2005), Tuple.Create("\"", 2054)
            
            #line 35 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create<System.Object, System.Int32>(Html.Resource(" PreviousNextImage")
            
            #line default
            #line hidden
, 2018), false)
);

WriteLiteral(" class=\"d-flex justify-content-between mb-3\"");

WriteLiteral(">\r\n");

            
            #line 36 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
          
        var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
        var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 41 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.PreviousItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2396), Tuple.Create("\"", 2445)
            
            #line 43 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2409), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToPreviousImage")
            
            #line default
            #line hidden
, 2409), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2446), Tuple.Create("\"", 2595)
            
            #line 43 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 2453), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 2453), false)
);

WriteLiteral(">\r\n            <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2688), Tuple.Create("\"", 2787)
, Tuple.Create(Tuple.Create("", 2701), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 2701), false)
            
            #line 45 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             , Tuple.Create(Tuple.Create("", 2761), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("prev")
            
            #line default
            #line hidden
, 2761), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n            </svg>\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("PreviousImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </a>\r\n");

            
            #line 49 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 51 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.PreviousItem != null || @Model.NextItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <span>");

            
            #line 53 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         Write(string.Format(@Html.Resource("IndexOfTotal"), @ViewBag.ItemIndex, @Model.TotalItemsCount));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 54 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 56 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        
            
            #line default
            #line hidden
            
            #line 56 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
         if (Model.NextItem != null)
        {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" class=\"\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3182), Tuple.Create("\"", 3227)
            
            #line 58 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 3195), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToNextImage")
            
            #line default
            #line hidden
, 3195), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3228), Tuple.Create("\"", 3369)
            
            #line 58 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
, Tuple.Create(Tuple.Create("", 3235), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 3235), false)
);

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
       Write(Html.Resource("NextImage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 3503), Tuple.Create("\"", 3602)
, Tuple.Create(Tuple.Create("", 3516), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 3516), false)
            
            #line 61 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
             , Tuple.Create(Tuple.Create("", 3576), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("next")
            
            #line default
            #line hidden
, 3576), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n            </svg>\r\n        </a>\r\n");

            
            #line 64 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </nav>\r\n");

            
            #line 66 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"

    
            
            #line default
            #line hidden
            
            #line 67 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.ActionLink(Html.Resource("BackToAllImages"), "Index"));

            
            #line default
            #line hidden
            
            #line 67 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
                                                               
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 70 "..\..MVC\Views\ImageGallery\Detail.DetailPage.cshtml"
Write(Html.CommentsList(@Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591