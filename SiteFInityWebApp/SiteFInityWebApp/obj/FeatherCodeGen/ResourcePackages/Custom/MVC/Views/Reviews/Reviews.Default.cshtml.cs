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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.Reviews
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
    
    #line 8 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Reviews/Reviews.Default.cshtml")]
    public partial class Reviews_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsListViewModel>
    {
        public Reviews_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 523), Tuple.Create("\"", 577)
, Tuple.Create(Tuple.Create("", 528), Tuple.Create("comments-", 528), true)
            
            #line 13 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 537), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 537), false)
);

WriteLiteral(" data-sf-role=\"comments-wrapper\"");

WriteAttribute("class", Tuple.Create(" class=\"", 610), Tuple.Create("\"", 638)
            
            #line 13 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                    , Tuple.Create(Tuple.Create("", 618), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 618), false)
, Tuple.Create(Tuple.Create(" ", 633), Tuple.Create("mt-5", 634), true)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 699), Tuple.Create("\"", 738)
            
            #line 14 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 707), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetSettings
            
            #line default
            #line hidden
, 707), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 802), Tuple.Create("\"", 842)
            
            #line 15 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 810), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetResources
            
            #line default
            #line hidden
, 810), false)
);

WriteLiteral(" />\r\n\r\n    <div");

WriteLiteral(" class=\"row mb-4\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-7 d-flex gap-4 align-items-end\"");

WriteLiteral(">\r\n\r\n            <h3");

WriteLiteral(" class=\"mb-0\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-total-count\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-header\"");

WriteLiteral("></span>\r\n            </h3>\r\n\r\n");

            
            #line 25 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
             if (!Model.ThreadIsClosed)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1196), Tuple.Create("\"", 1282)
, Tuple.Create(Tuple.Create("", 1203), Tuple.Create("#comment-submit-", 1203), true)
            
            #line 27 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1219), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(HttpUtility.UrlEncode(Model.ThreadKey))
            
            #line default
            #line hidden
, 1219), false)
);

WriteLiteral(" data-sf-role=\"comments-new-form-button\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                             Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 28 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" data-sf-role=\"comments-count-list-wrapper\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 31 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("AverageRating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
           Write(Html.CommentsCount(string.Empty, Model.ThreadKey, Model.ThreadType));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n        </div>\r\n\r\n\r\n        <div");

WriteLiteral(" class=\"col-lg-5 d-flex justify-content-end align-items-end\"");

WriteLiteral(" data-sf-orderby-css-active-class=\"link-dark pe-none\"");

WriteLiteral("> \r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-new-button\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 38 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                               Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 38 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                Write(Html.Resource("NewestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-old-button\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("  class=\"ms-2\"");

WriteLiteral("><span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 39 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                             Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 39 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                              Write(Html.Resource("OldestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"list-loading-indicator\"");

WriteLiteral(" class=\"mb-4 ms-5 ps-2\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"spinner-border text-primary\"");

WriteLiteral(" role=\"status\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">Loading...</span>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" data-sf-role=\"comments-container\"");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral("></div>\r\n\r\n");

            
            #line 50 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.EnablePaging)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-load-more-button\"");

WriteLiteral(">");

            
            #line 52 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                        Write(Html.Resource("LoadMoreReviews"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 53 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 55 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.ThreadIsClosed)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">");

            
            #line 57 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("ReviewsThreadIsClosedMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 58 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"comments-new-form\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2890), Tuple.Create("\"", 2950)
, Tuple.Create(Tuple.Create("", 2895), Tuple.Create("comment-submit-", 2895), true)
            
            #line 63 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2910), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 2910), false)
);

WriteLiteral(" class=\"sf-Comments-form\"");

WriteLiteral(">\r\n");

            
            #line 64 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                
            
            #line default
            #line hidden
            
            #line 64 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                 if (Model.RequiresApproval)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" data-sf-role=\"comments-new-pending-approval-message\"");

WriteLiteral(">");

            
            #line 66 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                     Write(Html.Resource("ReviewPendingApproval"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 67 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"d-flex gap-3\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3360), Tuple.Create("\"", 3391)
            
            #line 72 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3366), Tuple.Create<System.Object, System.Int32>(Model.UserAvatarImageUrl
            
            #line default
            #line hidden
, 3366), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 3593), Tuple.Create("\"", 3629)
            
            #line 77 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3599), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3599), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 77 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                           Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 3731), Tuple.Create("\"", 3766)
            
            #line 78 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3736), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3736), false)
);

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(" data-sf-role=\"comments-new-message\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3824), Tuple.Create("\"", 3867)
            
            #line 78 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 3838), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 3838), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></textarea>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                            <fieldset");

WriteLiteral(" role=\"radiogroup\"");

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(">\r\n                                <legend");

WriteAttribute("id", Tuple.Create(" id=\"", 4099), Tuple.Create("\"", 4134)
            
            #line 83 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4104), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingLegend")
            
            #line default
            #line hidden
, 4104), false)
);

WriteLiteral(" class=\"fs-5\"");

WriteLiteral(">");

            
            #line 83 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                    Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n                                <div");

WriteLiteral(" data-sf-role=\"submit-rating-container\"");

WriteLiteral(" data-sf-rating-selected-css-class=\"text-warning\"");

WriteLiteral(" data-sf-rating-hover-css-class=\"text-primary\"");

WriteLiteral(" data-sf-rating-input-css-class=\"visually-hidden\"");

WriteLiteral(" class=\"text-black-50 fs-4 lh-1\"");

WriteAttribute("id", Tuple.Create(" id=\"", 4435), Tuple.Create("\"", 4469)
            
            #line 84 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 4440), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingStars")
            
            #line default
            #line hidden
, 4440), false)
);

WriteLiteral(">\r\n                                </div>\r\n                            </fieldset" +
">\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" data-sf-role=\"comments-new-logged-out-view\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n\r\n                            <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 4773), Tuple.Create("\"", 4805)
            
            #line 92 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4779), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4779), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 92 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                  Write(Html.Resource("YourName"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 4928), Tuple.Create("\"", 4959)
            
            #line 93 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4933), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4933), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4960), Tuple.Create("\"", 5000)
            
            #line 93 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 4974), Tuple.Create<System.Object, System.Int32>(Html.Resource("YourName")
            
            #line default
            #line hidden
, 4974), false)
);

WriteLiteral(" data-sf-role=\"comments-new-name\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 5184), Tuple.Create("\"", 5217)
            
            #line 97 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5190), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 5190), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 97 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                   Write(Html.Resource("EmailOptional"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 5345), Tuple.Create("\"", 5377)
            
            #line 98 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5350), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 5350), false)
);

WriteLiteral(" type=\"email\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 5391), Tuple.Create("\"", 5436)
            
            #line 98 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 5405), Tuple.Create<System.Object, System.Int32>(Html.Resource("EmailOptional")
            
            #line default
            #line hidden
, 5405), false)
);

WriteLiteral(" data-sf-role=\"comments-new-email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n\r\n");

            
            #line 102 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 102 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                         if (Model.RequiresCaptcha)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" data-sf-role=\"captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                            <div>\r\n                                <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5833), Tuple.Create("\"", 5888)
            
            #line 106 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5839), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent(" assets /dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 5839), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <a");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(" class=\"btn btn-link ps-0 pe-0\"");

WriteLiteral("> ");

            
            #line 109 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n\r\n                            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"col-form-label col-md-auto\"");

WriteAttribute("for", Tuple.Create(" for=\"", 6194), Tuple.Create("\"", 6226)
            
            #line 112 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 6200), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" Captcha")
            
            #line default
            #line hidden
, 6200), false)
);

WriteLiteral(">");

            
            #line 112 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                      Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <div");

WriteLiteral(" class=\"col-md-auto\"");

WriteLiteral(">\r\n                                    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 6370), Tuple.Create("\"", 6401)
            
            #line 114 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 6375), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" Captcha")
            
            #line default
            #line hidden
, 6375), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n" +
"                        </div>\r\n");

            
            #line 118 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"mt-4\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"comments-new-submit-button\"");

WriteLiteral(" ");

            
            #line 121 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                  Write(SystemManager.IsDesignMode ? "disabled" : "" );

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 121 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                  Write(Html.Resource("Submit"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n      " +
"          </div>\r\n\r\n            </div>\r\n\r\n");

            
            #line 130 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 130 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
             if (Model.AllowSubscription)
            {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"mt-5 ms-5 ps-2\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-text\"");

WriteLiteral(" class=\"text-success\"");

WriteLiteral("></span>\r\n                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-subscribe-button\"");

WriteLiteral(" class=\"link-secondary\"");

WriteLiteral(">\r\n                    <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n                        <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 7328), Tuple.Create("\"", 7409)
, Tuple.Create(Tuple.Create("", 7341), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#envelope")
, 7341), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n                    <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-button-text\"");

WriteLiteral("></span>\r\n                </a>\r\n            </div>\r\n");

            
            #line 141 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(">\r\n                <span></span>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"submit-loading-indicator\"");

WriteLiteral(" class=\"mb-4 mt-4 ms-5 ps-2\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"spinner-border text-primary\"");

WriteLiteral(" role=\"status\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">Loading...</span>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div" +
">\r\n");

            
            #line 155 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning my-4\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"review-new-form-replacement\"");

WriteLiteral(">");

            
            #line 156 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                       Write(Html.Resource("UserAlreadySubmitedReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 157 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"

        if (Model.RequiresAuthentication)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-warning my-4\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"comments-new-requires-authentication\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\'", 8451), Tuple.Create("\'", 8477)
            
            #line 160 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                  , Tuple.Create(Tuple.Create("", 8458), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 8458), false)
);

WriteLiteral(">");

            
            #line 160 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                  Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>");

            
            #line 160 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                                             Write(Html.Resource("ToBeAbleToReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 161 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" data-sf-role=\"single-comment-template\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"d-flex gap-3 mb-4\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"rating-of-resource\"");

WriteAttribute("value", Tuple.Create(" value=\"", 8749), Tuple.Create("\"", 8778)
            
            #line 167 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 8757), Tuple.Create<System.Object, System.Int32>(Html.Resource(" Of")
            
            #line default
            #line hidden
, 8757), false)
);

WriteLiteral(" />\r\n\r\n            <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-sf-role=\"comment-avatar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 8896), Tuple.Create("\"", 8951)
            
            #line 170 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 8902), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent(" assets /dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 8902), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 174 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                         Write(Html.Resource("CommentBy"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-name\"");

WriteLiteral(" class=\"text-muted sf-Comments-list-author\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 176 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                         Write(Html.Resource("From").ToLower());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" class=\"ps-1 pe-1 text-black-50\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">|</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-date\"");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral("></span>\r\n\r\n                <div");

WriteLiteral(" data-sf-role=\"list-rating-wrapper\"");

WriteLiteral(" class=\"d-none d-inline-flex ms-3 text-black-50\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-sf-role=\"list-rating-container\"");

WriteLiteral(" data-sf-rating-selected-css-class=\"text-warning\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></span>\r\n                    <span");

WriteLiteral(" class=\"text-muted sf-Ratings-average\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 183 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                 Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">(</span><span");

WriteLiteral(" data-sf-role=\"list-rating-value\"");

WriteLiteral("></span><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">)</span>\r\n                        <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" data-sf-role=\"list-rating-sr-label\"");

WriteLiteral("></span>\r\n                    </span>\r\n                </div>\r\n\r\n                " +
"<div");

WriteLiteral(" data-sf-role=\"comment-message\"");

WriteLiteral("></div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"rating-template\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span");

WriteLiteral(" class=\"text-muted fs-4\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&#9733;</span></div>\r\n\r\n");

            
            #line 201 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 202 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-list.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
