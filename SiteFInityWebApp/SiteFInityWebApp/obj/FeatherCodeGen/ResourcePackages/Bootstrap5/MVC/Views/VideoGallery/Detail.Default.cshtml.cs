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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.VideoGallery
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
    
    #line 3 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/VideoGallery/Detail.Default.cshtml")]
    public partial class Detail_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery.VideoDetailsViewModel>
    {

#line 83 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection(string arrow)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 84 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
 
    bool isRtl = ((Html.RenderDirAttribute().ToString() == "dir=\"rtl\"") ? true : false);

    if (arrow == "next" && !isRtl || arrow == "prev" && isRtl)
    {
        

#line default
#line hidden

#line 89 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-right"));


#line default
#line hidden

#line 89 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 93 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-left"));


#line default
#line hidden

#line 93 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 95 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
}
#line default
#line hidden

        public Detail_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
  
    var tmbWidth = string.Empty;
    var tmbHeight = string.Empty;

    if (Model.Width != null && Model.Width != 0)
    {
        tmbWidth = string.Format("width={0}", Model.Width);

    }
    else if (Model.Item.Fields.Width != null && Model.Item.Fields.Width != 0)
    {
        tmbWidth = string.Format("width={0}", Model.Item.Fields.Width);
    }

    if (Model.Height != null && Model.Height != 0)
    {
        tmbHeight = string.Format("height={0}", Model.Height);
    }
    else if (Model.Item.Fields.Height != null && Model.Item.Fields.Height != 0)
    {
        tmbHeight = string.Format("height={0}", Model.Item.Fields.Height);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 893), Tuple.Create("\"", 916)
            
            #line 30 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 901), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 901), false)
);

WriteLiteral(" ");

            
            #line 30 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <figure");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\"", 1037), Tuple.Create("\"", 1084)
            
            #line 31 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1055), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" VideoTitle")
            
            #line default
            #line hidden
, 1055), false)
);

WriteLiteral(">\r\n        <figcaption");

WriteLiteral(" class=\"h2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1118), Tuple.Create("\"", 1152)
            
            #line 32 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1123), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" VideoTitle")
            
            #line default
            #line hidden
, 1123), false)
);

WriteLiteral(" ");

            
            #line 32 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                             Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 32 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                      Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</figcaption>\r\n        <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                     Write(Html.Resource("VideoTakenOn"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(Model.Item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
       Write(DataResolver.Resolve(@Model.Item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        <p ");

            
            #line 39 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
      Write(Html.InlineEditingFieldAttributes("Description", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(" id=\'");

            
            #line 39 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                        Write(Html.UniqueId("VideoInfo"));

            
            #line default
            #line hidden
WriteLiteral("\'>");

            
            #line 39 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                     Write(Html.HtmlSanitize((string)Model.Item.Fields.Description));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <div");

WriteLiteral(" class=\"d-flex justify-content-center bg-light\"");

WriteLiteral(">\r\n            <video");

WriteAttribute("src", Tuple.Create(" src=\"", 1819), Tuple.Create("\"", 1850)
            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1825), Tuple.Create<System.Object, System.Int32>(Html.Raw(Model.MediaUrl)
            
            #line default
            #line hidden
, 1825), false)
);

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteLiteral(" controls=\"controls\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1893), Tuple.Create("\'", 1939)
            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                              , Tuple.Create(Tuple.Create("", 1911), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoTitle")
            
            #line default
            #line hidden
, 1911), false)
);

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 1940), Tuple.Create("\'", 1986)
            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                              , Tuple.Create(Tuple.Create("", 1959), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("VideoInfo")
            
            #line default
            #line hidden
, 1959), false)
);

WriteLiteral(" ");

            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                                                                                      Write(tmbWidth);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 41 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                                                                                                                                                Write(tmbHeight);

            
            #line default
            #line hidden
WriteLiteral("></video>\r\n        </div>\r\n\r\n    </figure>\r\n");

            
            #line 45 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
     if (ViewBag.ItemIndex != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <nav");

WriteLiteral(" role=\"navigation\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2126), Tuple.Create("\"", 2175)
            
            #line 47 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2139), Tuple.Create<System.Object, System.Int32>(Html.Resource(" PreviousNextVideo")
            
            #line default
            #line hidden
, 2139), false)
);

WriteLiteral(" class=\"d-flex justify-content-between mb-3\"");

WriteLiteral(">\r\n");

            
            #line 48 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
              
                var previousItemIndex = ViewBag.ItemIndex == 1 ? Model.TotalItemsCount : ViewBag.ItemIndex - 1;
                var nextItemIndex = ViewBag.ItemIndex == Model.TotalItemsCount ? 1 : ViewBag.ItemIndex + 1;
            
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 53 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 53 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2557), Tuple.Create("\"", 2606)
            
            #line 55 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2570), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToPreviousVideo")
            
            #line default
            #line hidden
, 2570), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 2607), Tuple.Create("\"", 2756)
            
            #line 55 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2614), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.PreviousItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, previousItemIndex)
            
            #line default
            #line hidden
, 2614), false)
);

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 2865), Tuple.Create("\"", 2965)
, Tuple.Create(Tuple.Create("", 2878), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 2878), false)
            
            #line 57 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                     , Tuple.Create(Tuple.Create("", 2938), Tuple.Create<System.Object, System.Int32>(GetCaretDirection(" prev")
            
            #line default
            #line hidden
, 2938), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n");

WriteLiteral("                    ");

            
            #line 59 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("PreviousVideo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </a>\r\n");

            
            #line 61 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 63 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.PreviousItem != null || Model.NextItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>");

            
            #line 65 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                 Write(Html.HtmlSanitize((string)string.Format(Html.Resource("IndexOfTotal"), ViewBag.ItemIndex, Model.TotalItemsCount)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 66 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 68 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 68 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
             if (Model.NextItem != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 3438), Tuple.Create("\"", 3483)
            
            #line 70 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3451), Tuple.Create<System.Object, System.Int32>(Html.Resource(" GoToNextVideo")
            
            #line default
            #line hidden
, 3451), false)
);

WriteAttribute("href", Tuple.Create(" href=\"", 3484), Tuple.Create("\"", 3625)
            
            #line 70 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3491), Tuple.Create<System.Object, System.Int32>(HyperLinkHelpers.GetDetailPageUrl(Model.NextItem, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, ViewBag.UrlKeyPrefix, nextItemIndex)
            
            #line default
            #line hidden
, 3491), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 71 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
               Write(Html.Resource("NextVideo"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-18\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 3783), Tuple.Create("\"", 3883)
, Tuple.Create(Tuple.Create("", 3796), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 3796), false)
            
            #line 73 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                     , Tuple.Create(Tuple.Create("", 3856), Tuple.Create<System.Object, System.Int32>(GetCaretDirection(" next")
            
            #line default
            #line hidden
, 3856), false)
);

WriteLiteral(" class=\"fa-primary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n                </a>\r\n");

            
            #line 76 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </nav>\r\n");

            
            #line 78 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"

        
            
            #line default
            #line hidden
            
            #line 79 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
   Write(Html.ActionLink(Html.Resource("BackToAllVideos"), "Index"));

            
            #line default
            #line hidden
            
            #line 79 "..\..MVC\Views\VideoGallery\Detail.Default.cshtml"
                                                                   
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
