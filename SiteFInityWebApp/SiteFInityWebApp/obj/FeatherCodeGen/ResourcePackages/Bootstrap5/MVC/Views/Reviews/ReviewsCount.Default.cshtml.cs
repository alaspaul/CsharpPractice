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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Reviews
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
    
    #line 3 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Reviews/ReviewsCount.Default.cshtml")]
    public partial class ReviewsCount_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsCountViewModel>
    {
        public ReviewsCount_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" data-sf-role=\"comments-count-wrapper\"");

WriteLiteral(" data-sf-thread-key=\"");

            
            #line 8 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                          Write(Model.ThreadKey);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" class=\"d-inline-flex align-items-center gap-2\"");

WriteLiteral(">\r\n\r\n    <span");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"d-inline-flex gap-1 align-items-center\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" data-sf-rating-selected-css-class=\"text-warning\"");

WriteLiteral(" class=\"text-black-50 lh-1\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n            <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 14 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                         Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">(</span><span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">)</span>\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" data-sf-role=\"list-rating-sr-label\"");

WriteLiteral("></span>\r\n            </span>\r\n        </span>\r\n    </span>\r\n\r\n    <a");

WriteLiteral(" data-sf-role=\"comments-count-anchor\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1083), Tuple.Create("\"", 1108)
            
            #line 21 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1090), Tuple.Create<System.Object, System.Int32>(Model.NavigateUrl
            
            #line default
            #line hidden
, 1090), false)
);

WriteLiteral(">\r\n        <span");

WriteLiteral(" data-sf-role=\"comments-count-anchor-text\"");

WriteLiteral("></span>\r\n    </a>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"service-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1238), Tuple.Create("\"", 1265)
            
            #line 24 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1246), Tuple.Create<System.Object, System.Int32>(ViewBag.ServiceUrl
            
            #line default
            #line hidden
, 1246), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-count-resources\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1335), Tuple.Create("\'", 1534)
, Tuple.Create(Tuple.Create("", 1343), Tuple.Create("{\"commentsPlural\":", 1343), true)
, Tuple.Create(Tuple.Create(" ", 1361), Tuple.Create("\"", 1362), true)
            
            #line 25 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
            , Tuple.Create(Tuple.Create("", 1363), Tuple.Create<System.Object, System.Int32>(Html.Resource("ReviewsPlural")
            
            #line default
            #line hidden
, 1363), false)
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create("\",", 1394), true)
, Tuple.Create(Tuple.Create(" ", 1396), Tuple.Create("\"leaveComment\":\"", 1397), true)
            
            #line 25 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 1413), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 1413), false)
, Tuple.Create(Tuple.Create("", 1442), Tuple.Create("\",", 1442), true)
, Tuple.Create(Tuple.Create(" ", 1444), Tuple.Create("\"comment\":\"", 1445), true)
            
            #line 25 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1456), Tuple.Create<System.Object, System.Int32>(Html.Resource("Review")
            
            #line default
            #line hidden
, 1456), false)
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create("\",", 1480), true)
, Tuple.Create(Tuple.Create(" ", 1482), Tuple.Create("\"averageRating\":\"", 1483), true)
            
            #line 25 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1500), Tuple.Create<System.Object, System.Int32>(Html.Resource("AverageRating")
            
            #line default
            #line hidden
, 1500), false)
, Tuple.Create(Tuple.Create("", 1531), Tuple.Create("\"", 1531), true)
, Tuple.Create(Tuple.Create(" ", 1532), Tuple.Create("}", 1533), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"rating-of-resource\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1598), Tuple.Create("\"", 1627)
            
            #line 26 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1606), Tuple.Create<System.Object, System.Int32>(Html.Resource(" Of")
            
            #line default
            #line hidden
, 1606), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" class=\"fs-4 lh-1\"");

WriteLiteral(">&#9733;</span></div>\r\n\r\n");

            
            #line 32 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 33 "..\..MVC\Views\Reviews\ReviewsCount.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-count.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
