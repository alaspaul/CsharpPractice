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
    
    #line 3 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 7 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 263), Tuple.Create("\"", 317)
, Tuple.Create(Tuple.Create("", 268), Tuple.Create("comments-", 268), true)
            
            #line 8 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 277), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 277), false)
);

WriteLiteral(" data-sf-role=\"comments-wrapper\"");

WriteAttribute("class", Tuple.Create(" class=\"", 350), Tuple.Create("\"", 378)
            
            #line 8 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                    , Tuple.Create(Tuple.Create("", 358), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 358), false)
, Tuple.Create(Tuple.Create(" ", 373), Tuple.Create("mt-5", 374), true)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 439), Tuple.Create("\"", 478)
            
            #line 9 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 447), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetSettings
            
            #line default
            #line hidden
, 447), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 542), Tuple.Create("\"", 582)
            
            #line 10 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 550), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetResources
            
            #line default
            #line hidden
, 550), false)
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

            
            #line 20 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
             if (!Model.ThreadIsClosed)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 936), Tuple.Create("\"", 1022)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("#comment-submit-", 943), true)
            
            #line 22 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 959), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(HttpUtility.UrlEncode(Model.ThreadKey))
            
            #line default
            #line hidden
, 959), false)
);

WriteLiteral(" data-sf-role=\"comments-new-form-button\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                             Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" data-sf-role=\"comments-count-list-wrapper\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 26 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("AverageRating"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 33 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                               Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 33 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 34 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                             Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral(" </span>");

            
            #line 34 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 45 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.EnablePaging)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-load-more-button\"");

WriteLiteral(">");

            
            #line 47 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                        Write(Html.Resource("LoadMoreReviews"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 48 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 50 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
     if (Model.ThreadIsClosed)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">");

            
            #line 52 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                    Write(Html.Resource("ReviewsThreadIsClosedMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 53 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"comments-new-form\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2630), Tuple.Create("\"", 2690)
, Tuple.Create(Tuple.Create("", 2635), Tuple.Create("comment-submit-", 2635), true)
            
            #line 58 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2650), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 2650), false)
);

WriteLiteral(" class=\"sf-Comments-form\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                
            
            #line default
            #line hidden
            
            #line 59 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                 if (Model.RequiresApproval)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" data-sf-role=\"comments-new-pending-approval-message\"");

WriteLiteral(">");

            
            #line 61 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                     Write(Html.Resource("ReviewPendingApproval"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 62 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"d-flex gap-3\"");

WriteLiteral(">\r\n\r\n                    <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3100), Tuple.Create("\"", 3131)
            
            #line 67 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3106), Tuple.Create<System.Object, System.Int32>(Model.UserAvatarImageUrl
            
            #line default
            #line hidden
, 3106), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 3333), Tuple.Create("\"", 3369)
            
            #line 72 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3339), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3339), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 72 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                           Write(Html.Resource("WriteReview"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 3471), Tuple.Create("\"", 3506)
            
            #line 73 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3476), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3476), false)
);

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(" data-sf-role=\"comments-new-message\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3564), Tuple.Create("\"", 3607)
            
            #line 73 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                , Tuple.Create(Tuple.Create("", 3578), Tuple.Create<System.Object, System.Int32>(Html.Resource("WriteReview")
            
            #line default
            #line hidden
, 3578), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></textarea>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                            <fieldset");

WriteLiteral(" role=\"radiogroup\"");

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(">\r\n                                <legend");

WriteAttribute("id", Tuple.Create(" id=\"", 3839), Tuple.Create("\"", 3874)
            
            #line 78 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3844), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingLegend")
            
            #line default
            #line hidden
, 3844), false)
);

WriteLiteral(" class=\"fs-5\"");

WriteLiteral(">");

            
            #line 78 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                    Write(Html.Resource("Rating"));

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n                                <div");

WriteLiteral(" data-sf-role=\"submit-rating-container\"");

WriteLiteral(" data-sf-rating-selected-css-class=\"text-warning\"");

WriteLiteral(" data-sf-rating-hover-css-class=\"text-primary\"");

WriteLiteral(" data-sf-rating-input-css-class=\"visually-hidden\"");

WriteLiteral(" class=\"text-black-50 fs-4 lh-1\"");

WriteAttribute("id", Tuple.Create(" id=\"", 4175), Tuple.Create("\"", 4209)
            
            #line 79 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 4180), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RatingStars")
            
            #line default
            #line hidden
, 4180), false)
);

WriteLiteral(">\r\n                                </div>\r\n                            </fieldset" +
">\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" data-sf-role=\"comments-new-logged-out-view\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n\r\n                            <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 4513), Tuple.Create("\"", 4545)
            
            #line 87 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4519), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4519), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 87 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                  Write(Html.Resource("YourName"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 4668), Tuple.Create("\"", 4699)
            
            #line 88 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4673), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 4673), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4700), Tuple.Create("\"", 4740)
            
            #line 88 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 4714), Tuple.Create<System.Object, System.Int32>(Html.Resource("YourName")
            
            #line default
            #line hidden
, 4714), false)
);

WriteLiteral(" data-sf-role=\"comments-new-name\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 4924), Tuple.Create("\"", 4957)
            
            #line 92 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4930), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 4930), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 92 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                   Write(Html.Resource("EmailOptional"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <input");

WriteAttribute("id", Tuple.Create(" id=\"", 5085), Tuple.Create("\"", 5117)
            
            #line 93 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5090), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 5090), false)
);

WriteLiteral(" type=\"email\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 5131), Tuple.Create("\"", 5176)
            
            #line 93 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                  , Tuple.Create(Tuple.Create("", 5145), Tuple.Create<System.Object, System.Int32>(Html.Resource("EmailOptional")
            
            #line default
            #line hidden
, 5145), false)
);

WriteLiteral(" data-sf-role=\"comments-new-email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                            </div>\r\n                        </div>\r\n\r\n");

            
            #line 97 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 97 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                         if (Model.RequiresCaptcha)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" data-sf-role=\"captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                            <div>\r\n                                <img");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 5573), Tuple.Create("\"", 5628)
            
            #line 101 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5579), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent(" assets /dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 5579), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <a");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(" class=\"btn btn-link ps-0 pe-0\"");

WriteLiteral("> ");

            
            #line 104 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n\r\n                            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"col-form-label col-md-auto\"");

WriteAttribute("for", Tuple.Create(" for=\"", 5934), Tuple.Create("\"", 5966)
            
            #line 107 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5940), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" Captcha")
            
            #line default
            #line hidden
, 5940), false)
);

WriteLiteral(">");

            
            #line 107 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                      Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                <div");

WriteLiteral(" class=\"col-md-auto\"");

WriteLiteral(">\r\n                                    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 6110), Tuple.Create("\"", 6141)
            
            #line 109 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 6115), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(" Captcha")
            
            #line default
            #line hidden
, 6115), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteLiteral(" class=\"form-control input-sm\"");

WriteLiteral(" />\r\n                                </div>\r\n                            </div>\r\n" +
"                        </div>\r\n");

            
            #line 113 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div");

WriteLiteral(" class=\"mt-4\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"comments-new-submit-button\"");

WriteLiteral(" ");

            
            #line 116 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                  Write(SystemManager.IsDesignMode ? "disabled" : "" );

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 116 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                  Write(Html.Resource("Submit"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n      " +
"          </div>\r\n\r\n            </div>\r\n\r\n");

            
            #line 125 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 125 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 7068), Tuple.Create("\"", 7149)
, Tuple.Create(Tuple.Create("", 7081), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#envelope")
, 7081), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n                    </svg>\r\n                    <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-button-text\"");

WriteLiteral("></span>\r\n                </a>\r\n            </div>\r\n");

            
            #line 136 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 150 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning my-4\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"review-new-form-replacement\"");

WriteLiteral(">");

            
            #line 151 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                       Write(Html.Resource("UserAlreadySubmitedReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 152 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"

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

WriteAttribute("href", Tuple.Create(" href=\'", 8191), Tuple.Create("\'", 8217)
            
            #line 155 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                  , Tuple.Create(Tuple.Create("", 8198), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 8198), false)
);

WriteLiteral(">");

            
            #line 155 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                  Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>");

            
            #line 155 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                                                                                                                                                                             Write(Html.Resource("ToBeAbleToReview"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 156 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

WriteAttribute("value", Tuple.Create(" value=\"", 8489), Tuple.Create("\"", 8518)
            
            #line 162 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 8497), Tuple.Create<System.Object, System.Int32>(Html.Resource(" Of")
            
            #line default
            #line hidden
, 8497), false)
);

WriteLiteral(" />\r\n\r\n            <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" data-sf-role=\"comment-avatar\"");

WriteAttribute("src", Tuple.Create(" src=\"", 8636), Tuple.Create("\"", 8691)
            
            #line 165 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
, Tuple.Create(Tuple.Create("", 8642), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent(" assets /dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 8642), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 169 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
                                         Write(Html.Resource("CommentBy"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-name\"");

WriteLiteral(" class=\"text-muted sf-Comments-list-author\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 171 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 178 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
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

            
            #line 196 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Reviews/rating.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 197 "..\..MVC\Views\Reviews\Reviews.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-list.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
