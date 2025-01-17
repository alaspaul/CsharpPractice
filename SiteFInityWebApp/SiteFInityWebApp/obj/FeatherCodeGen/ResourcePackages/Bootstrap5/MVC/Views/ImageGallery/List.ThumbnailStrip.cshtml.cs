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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.ImageGallery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 10 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    #line 4 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Web.Script.Serialization;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 5 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/List.ThumbnailStrip.cshtml")]
    public partial class List_ThumbnailStrip : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {

#line 95 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection(string arrow)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 96 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 
    bool isRtl = ((Html.RenderDirAttribute().ToString() == "dir=\"rtl\"")?true:false);
     
    if (arrow == "next" && !isRtl || arrow == "prev" && isRtl)
    {
        

#line default
#line hidden

#line 101 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("carousel-control-next-icon"));


#line default
#line hidden

#line 101 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                        ;
    }
    else
    {
        

#line default
#line hidden

#line 105 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("carousel-control-prev-icon"));


#line default
#line hidden

#line 105 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                        ;
    }


#line default
#line hidden
});

#line 107 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
}
#line default
#line hidden

        public List_ThumbnailStrip()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ImageGallery/thumbnail-strip.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 16 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
  
    bool hasItems = Model.Items.Count() > 0;
    bool isBackendDesignMode = SystemManager.IsDesignMode && !SystemManager.IsPreviewMode;
    dynamic firstItem = null;

    if (hasItems && isBackendDesignMode)
    {
        firstItem = Model.Items.FirstOrDefault();
    }

    ThumbnailViewModel thumbnailViewModel = (ThumbnailViewModel)firstItem;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"sf-Gallery\"");

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 1001), Tuple.Create("\"", 1044)
            
            #line 29 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1014), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 1014), false)
);

WriteLiteral(">\r\n");

            
            #line 30 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (hasItems)
{
		if (isBackendDesignMode)
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral(">");

            
            #line 34 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                            Write(firstItem.DataItem.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

            
            #line 35 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral(">");

            
            #line 36 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                 Write(firstItem.DataItem.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 37 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"text-muted mb-3\"");

WriteLiteral("><span");

WriteLiteral(" class=\"js-Gallery-index text-muted mb-3\"");

WriteLiteral(">1</span> of ");

            
            #line 38 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                       Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 39 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"position-relative bg-secondary d-flex justify-content-center align-items-" +
"center mb-4 js-Gallery-image\"");

WriteLiteral(">\r\n\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\'js-Gallery-prev sf-Gallery-prev position-absolute start-0 h-100 d-flex al" +
"ign-items-center\'");

WriteAttribute("title", Tuple.Create(" title=\"", 1601), Tuple.Create("\"", 1644)
            
            #line 41 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 1609), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToPreviousImage")
            
            #line default
            #line hidden
, 1609), false)
);

WriteLiteral("><span");

WriteAttribute("class", Tuple.Create(" class=\"", 1651), Tuple.Create("\"", 1685)
            
            #line 41 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                                , Tuple.Create(Tuple.Create("", 1659), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("prev")
            
            #line default
            #line hidden
, 1659), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\r\n\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\'js-Gallery-next sf-Gallery-next position-absolute end-0 h-100 d-flex alig" +
"n-items-center\'");

WriteAttribute("title", Tuple.Create(" title=\"", 1845), Tuple.Create("\"", 1884)
            
            #line 42 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                            , Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(Html.Resource("GoToNextImage")
            
            #line default
            #line hidden
, 1853), false)
);

WriteLiteral("><span");

WriteAttribute("class", Tuple.Create(" class=\"", 1891), Tuple.Create("\"", 1925)
            
            #line 42 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                          , Tuple.Create(Tuple.Create("", 1899), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("next")
            
            #line default
            #line hidden
, 1899), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span></a>\r\n        <img");

WriteLiteral(" loading=\"lazy\"");

WriteAttribute("src", Tuple.Create(" src=\"", 1986), Tuple.Create("\"", 2022)
            
            #line 43 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1992), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.MediaUrl
            
            #line default
            #line hidden
, 1992), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 2023), Tuple.Create("\"", 2056)
            
            #line 43 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2031), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.Title
            
            #line default
            #line hidden
, 2031), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2057), Tuple.Create("\"", 2098)
            
            #line 43 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                        , Tuple.Create(Tuple.Create("", 2063), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.AlternativeText
            
            #line default
            #line hidden
, 2063), false)
);

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteLiteral("\r\n                  ");

            
            #line 44 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                  ");

            
            #line 45 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n\r\n\t</p>\r\n");

            
            #line 48 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		}
		else
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("></h2>\r\n");

            
            #line 52 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("></p>\r\n");

            
            #line 54 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"text-muted mb-3\"");

WriteLiteral(" aria-live=\"polite\"");

WriteLiteral(" aria-atomic=\"true\"");

WriteLiteral("><span");

WriteLiteral(" class=\"js-Gallery-index\"");

WriteLiteral("></span> of ");

            
            #line 55 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                            Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 56 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div");

WriteLiteral(" class=\"carousel slide js-Gallery-image mb-4\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"carousel-inner bg-secondary\"");

WriteLiteral(">\r\n\t\t\t<div");

WriteLiteral(" class=\"carousel-item active d-flex justify-content-center\"");

WriteLiteral(">\r\n\t\t\t\t<img");

WriteLiteral(" class=\"d-block mw-100 h-auto\"");

WriteLiteral(" alt=\"...\"");

WriteLiteral(">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<button");

WriteLiteral(" class=\"js-Gallery-prev carousel-control-prev\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 2926), Tuple.Create("\"", 2960)
            
            #line 64 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2934), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("prev")
            
            #line default
            #line hidden
, 2934), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n\t\t\t<span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 65 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                     Write(Html.Resource(" GoToPreviousImage"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t</button>\r\n\t\t<button");

WriteLiteral(" class=\"js-Gallery-next carousel-control-next\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(">\r\n\t\t\t<span");

WriteAttribute("class", Tuple.Create(" class=\"", 3161), Tuple.Create("\"", 3195)
            
            #line 68 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 3169), Tuple.Create<System.Object, System.Int32>(GetCaretDirection("next")
            
            #line default
            #line hidden
, 3169), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n\t\t\t<span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 69 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                     Write(Html.Resource(" GoToNextImage"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t</button>\r\n\t</div>\r\n");

            
            #line 72 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
	}
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n\r\n\t<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container mb-4\"");

WriteLiteral(">\r\n\t\t<div");

WriteLiteral(" class=\"sf-Gallery-thumbs js-Gallery-thumbs d-flex align-items-stretch flex-wrap " +
"gap-3\"");

WriteLiteral(">\r\n");

            
            #line 79 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
			
            
            #line default
            #line hidden
            
            #line 79 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
              int itemIndex = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 80 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
			
            
            #line default
            #line hidden
            
            #line 80 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             foreach(var item in Model.Items)
			{
				var itemViewModel = (ThumbnailViewModel)item;
		

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" class=\"d-flex align-items-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3670), Tuple.Create("\"", 3696)
            
            #line 84 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
      , Tuple.Create(Tuple.Create("", 3678), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 3678), false)
);

WriteLiteral(" data-item=\"");

            
            #line 84 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                                Write(Html.GetSerializedImage(item));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-detail-url=\"");

            
            #line 84 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                                                                                 Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n\t\t\t\t\t<img");

WriteLiteral(" loading=\"lazy\"");

WriteLiteral(" class=\"mw-100 h-auto\"");

WriteAttribute("src", Tuple.Create(" src=\"", 3926), Tuple.Create("\"", 3961)
            
            #line 85 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 3932), Tuple.Create<System.Object, System.Int32>(itemViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 3932), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 3962), Tuple.Create("\"", 3996)
            
            #line 85 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                       , Tuple.Create(Tuple.Create("", 3968), Tuple.Create<System.Object, System.Int32>(item.Fields.AlternativeText
            
            #line default
            #line hidden
, 3968), false)
);

WriteLiteral(" \r\n\t\t\t\t\t\t\t\t");

            
            #line 86 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                           Write(Html.GetWidthAttributeIfExists(itemViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t\t\t\t\t\t\t");

            
            #line 87 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                           Write(Html.GetHeightAttributeIfExists(itemViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n\t\t\t\t</a>\r\n");

            
            #line 89 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
				itemIndex++;
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n");

WriteLiteral("\r\n");

            
            #line 108 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 110 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 115 "..\..MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
