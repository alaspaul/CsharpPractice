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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Comments
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
    
    #line 3 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Comments/Comments.Default.cshtml")]
    public partial class Comments_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Comments.Mvc.Models.CommentsListViewModel>
    {
        public Comments_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\Comments\Comments.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("id", Tuple.Create(" id=\"", 265), Tuple.Create("\"", 319)
, Tuple.Create(Tuple.Create("", 270), Tuple.Create("comments-", 270), true)
            
            #line 9 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 279), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 279), false)
);

WriteLiteral(" data-sf-role=\"comments-wrapper\"");

WriteAttribute("class", Tuple.Create(" class=\"", 352), Tuple.Create("\"", 380)
            
            #line 9 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                    , Tuple.Create(Tuple.Create("", 360), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 360), false)
, Tuple.Create(Tuple.Create(" ", 375), Tuple.Create("mt-5", 376), true)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 441), Tuple.Create("\"", 480)
            
            #line 10 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetSettings
            
            #line default
            #line hidden
, 449), false)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"comments-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 544), Tuple.Create("\"", 584)
            
            #line 11 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 552), Tuple.Create<System.Object, System.Int32>(Model.SerializedWidgetResources
            
            #line default
            #line hidden
, 552), false)
);

WriteLiteral(" />\r\n\r\n    <div");

WriteLiteral(" class=\"row mb-4\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-lg-7 d-flex align-items-end\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"mb-0\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-total-count\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comments-header\"");

WriteLiteral("></span>\r\n            </h3>\r\n\r\n");

            
            #line 20 "..\..MVC\Views\Comments\Comments.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..MVC\Views\Comments\Comments.Default.cshtml"
             if (!Model.ThreadIsClosed)
            {

            
            #line default
            #line hidden
WriteLiteral("                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 930), Tuple.Create("\"", 1016)
, Tuple.Create(Tuple.Create("", 937), Tuple.Create("#comment-submit-", 937), true)
            
            #line 22 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(HttpUtility.UrlEncode(Model.ThreadKey))
            
            #line default
            #line hidden
, 953), false)
);

WriteLiteral(" data-sf-role=\"comments-new-form-button\"");

WriteLiteral(" class=\"ms-5\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                                                                          Write(Html.Resource("LeaveComment"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 23 "..\..MVC\Views\Comments\Comments.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-lg-5 d-flex justify-content-end align-items-end\"");

WriteLiteral(" data-sf-orderby-css-active-class=\"link-dark pe-none\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 27 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                  Write(Html.Resource("OrderBy"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-new-button\"");

WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                           Write(Html.Resource("NewestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-sort-old-button\"");

WriteLiteral(" class=\"ms-2\"");

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                        Write(Html.Resource("OldestOnTop"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"list-loading-indicator\"");

WriteLiteral(" class=\"mb-4 ms-5 ps-2\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"spinner-border text-primary\"");

WriteLiteral(" role=\"status\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">Loading...</span>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"comments-container\"");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral("></div>\r\n\r\n");

            
            #line 42 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\Comments\Comments.Default.cshtml"
     if(Model.EnablePaging)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-load-more-button\"");

WriteLiteral(" class=\"ms-5 ps-2 mb-5\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                               Write(Html.Resource("LoadMoreComments"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 45 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 47 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\Comments\Comments.Default.cshtml"
     if (Model.ThreadIsClosed)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                    Write(Html.Resource("CommentsThreadIsClosedMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 50 "..\..MVC\Views\Comments\Comments.Default.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" data-sf-role=\"comments-new-form\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2307), Tuple.Create("\"", 2367)
, Tuple.Create(Tuple.Create("", 2312), Tuple.Create("comment-submit-", 2312), true)
            
            #line 54 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2327), Tuple.Create<System.Object, System.Int32>(HttpUtility.HtmlEncode(Model.ThreadKey)
            
            #line default
            #line hidden
, 2327), false)
);

WriteLiteral(" >\r\n");

            
            #line 55 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                
            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                 if (Model.RequiresApproval)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" data-sf-role=\"comments-new-pending-approval-message\"");

WriteLiteral(">");

            
            #line 57 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                     Write(Html.Resource("CommentPendingApproval"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 58 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"d-flex gap-3\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2752), Tuple.Create("\"", 2783)
            
            #line 62 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2758), Tuple.Create<System.Object, System.Int32>(Model.UserAvatarImageUrl
            
            #line default
            #line hidden
, 2758), false)
);

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral("/>\r\n                    </div>\r\n\r\n                    <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 2984), Tuple.Create("\"", 3020)
            
            #line 67 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2990), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 2990), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 67 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                           Write(Html.Resource("LeaveComment"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <textarea");

WriteAttribute("id", Tuple.Create(" id=\"", 3123), Tuple.Create("\"", 3158)
            
            #line 68 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3128), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CommentInput")
            
            #line default
            #line hidden
, 3128), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" aria-required=\"true\"");

WriteLiteral(" data-sf-role=\"comments-new-message\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3237), Tuple.Create("\"", 3281)
            
            #line 68 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                     , Tuple.Create(Tuple.Create("", 3251), Tuple.Create<System.Object, System.Int32>(Html.Resource("LeaveComment")
            
            #line default
            #line hidden
, 3251), false)
);

WriteLiteral(" ></textarea>\r\n                        </div>\r\n\r\n                        <div");

WriteLiteral(" data-sf-role=\"comments-new-logged-out-view\"");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n\r\n                                <div");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                    <label");

WriteAttribute("for", Tuple.Create(" for=\"", 3588), Tuple.Create("\"", 3620)
            
            #line 75 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3594), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 3594), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 75 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                               Write(Html.Resource("YourName"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 3724), Tuple.Create("\"", 3755)
            
            #line 76 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3729), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourName")
            
            #line default
            #line hidden
, 3729), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 3756), Tuple.Create("\"", 3796)
            
            #line 76 "..\..MVC\Views\Comments\Comments.Default.cshtml"
        , Tuple.Create(Tuple.Create("", 3770), Tuple.Create<System.Object, System.Int32>(Html.Resource("YourName")
            
            #line default
            #line hidden
, 3770), false)
);

WriteLiteral(" data-sf-role=\"comments-new-name\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                                </div>\r\n\r\n                                <d" +
"iv");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">\r\n                                    <label");

WriteAttribute("for", Tuple.Create(" for=\"", 3992), Tuple.Create("\"", 4025)
            
            #line 80 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3998), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 3998), false)
);

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 80 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                Write(Html.Resource("EmailOptional"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 4134), Tuple.Create("\"", 4166)
            
            #line 81 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 4139), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("YourEmail")
            
            #line default
            #line hidden
, 4139), false)
);

WriteLiteral(" type=\"email\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4180), Tuple.Create("\"", 4225)
            
            #line 81 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                      , Tuple.Create(Tuple.Create("", 4194), Tuple.Create<System.Object, System.Int32>(Html.Resource("EmailOptional")
            
            #line default
            #line hidden
, 4194), false)
);

WriteLiteral(" data-sf-role=\"comments-new-email\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n                                </div>\r\n\r\n                            </div>" +
"\r\n                        </div>\r\n\r\n");

            
            #line 87 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 87 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                         if (Model.RequiresCaptcha)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" data-sf-role=\"captcha-container\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                                <div>\r\n                                    <im" +
"g");

WriteLiteral(" data-sf-role=\"captcha-image\"");

WriteLiteral(" width=\"180\"");

WriteLiteral(" height=\"50\"");

WriteAttribute("src", Tuple.Create(" src=\"", 4700), Tuple.Create("\"", 4753)
            
            #line 91 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                   , Tuple.Create(Tuple.Create("", 4706), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 4706), false)
);

WriteLiteral(" alt=\"\"");

WriteLiteral(" />\r\n                                </div>\r\n\r\n                                <a" +
"");

WriteLiteral(" data-sf-role=\"captcha-refresh-button\"");

WriteLiteral(" class=\"btn btn-link ps-0 pe-0\"");

WriteLiteral("> ");

            
            #line 94 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                    Write(Html.Resource("NewCode"));

            
            #line default
            #line hidden
WriteLiteral(" </a>\r\n\r\n                                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                                    <label");

WriteLiteral(" class=\"col-form-label col-md-auto\"");

WriteAttribute("for", Tuple.Create(" for=\"", 5075), Tuple.Create("\"", 5106)
            
            #line 97 "..\..MVC\Views\Comments\Comments.Default.cshtml"
   , Tuple.Create(Tuple.Create("", 5081), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("captcha")
            
            #line default
            #line hidden
, 5081), false)
);

WriteLiteral(">");

            
            #line 97 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                         Write(Html.Resource("TypeCodeAbove"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                                    <div");

WriteLiteral(" class=\"col-md-auto\"");

WriteLiteral(">\r\n                                        <input");

WriteAttribute("id", Tuple.Create(" id=\"", 5258), Tuple.Create("\"", 5288)
            
            #line 99 "..\..MVC\Views\Comments\Comments.Default.cshtml"
, Tuple.Create(Tuple.Create("", 5263), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("captcha")
            
            #line default
            #line hidden
, 5263), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-sf-role=\"captcha-input\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("/>\r\n                                    </div>\r\n                                <" +
"/div>\r\n\r\n                            </div>\r\n");

            
            #line 104 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                        <div");

WriteLiteral(" class=\"mt-4\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" data-sf-role=\"comments-new-submit-button\"");

WriteLiteral(" ");

            
            #line 108 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                  Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 108 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                                                                 Write(Html.Resource("Submit"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n      " +
"          </div>\r\n\r\n            </div>\r\n\r\n");

            
            #line 117 "..\..MVC\Views\Comments\Comments.Default.cshtml"
            
            
            #line default
            #line hidden
            
            #line 117 "..\..MVC\Views\Comments\Comments.Default.cshtml"
             if (Model.AllowSubscription)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"mt-5 ms-5 ps-2\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-text\"");

WriteLiteral(" class=\"text-success\"");

WriteLiteral("></span>\r\n                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"comments-subscribe-button\"");

WriteLiteral(" class=\"link-secondary\"");

WriteLiteral(">\r\n                        <svg");

WriteLiteral(" class=\"svg-inline--fa fa-w-16\"");

WriteLiteral(">\r\n\t\t\t\t\t\t\t<use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 6219), Tuple.Create("\"", 6300)
, Tuple.Create(Tuple.Create("", 6232), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#envelope")
, 6232), false)
);

WriteLiteral(" class=\"fa-secondary\"");

WriteLiteral("></use>\r\n\t\t\t\t\t\t</svg>\r\n                        <span");

WriteLiteral(" data-sf-role=\"comments-subscribe-button-text\"");

WriteLiteral("></span>\r\n                    </a>\r\n                </div>\r\n");

            
            #line 128 "..\..MVC\Views\Comments\Comments.Default.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">\r\n                <span></span>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" data-sf-role=\"list-loading-indicator\"");

WriteLiteral(" class=\"mb-4 mt-4 ms-5 ps-2\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"spinner-border text-primary\"");

WriteLiteral(" role=\"status\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">Loading...</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");

            
            #line 140 "..\..MVC\Views\Comments\Comments.Default.cshtml"

        if (Model.RequiresAuthentication)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" data-sf-role=\"comments-new-requires-authentication\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\'", 7117), Tuple.Create("\'", 7143)
            
            #line 143 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                          , Tuple.Create(Tuple.Create("", 7124), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 7124), false)
);

WriteLiteral(">");

            
            #line 143 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                                          Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>");

            
            #line 143 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                                                                                                                                     Write(Html.Resource("ToBeAbleToComment"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 144 "..\..MVC\Views\Comments\Comments.Default.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");

WriteLiteral("\r\n    <div");

WriteLiteral(" data-sf-role=\"single-comment-template\"");

WriteLiteral(" class=\"invisible\"");

WriteLiteral(">\r\n\r\n        <div");

WriteLiteral(" class=\"d-flex gap-3 mb-4\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"flex-shrink-0\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" alt=\"User avatar\"");

WriteLiteral(" data-sf-role=\"comment-avatar\"");

WriteLiteral(" width=\"40\"");

WriteLiteral(" height=\"40\"");

WriteAttribute("src", Tuple.Create(" src=\"", 7530), Tuple.Create("\"", 7583)
            
            #line 152 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                 , Tuple.Create(Tuple.Create("", 7536), Tuple.Create<System.Object, System.Int32>(Url.WidgetContent("assets/dist/img/dummy.jpg")
            
            #line default
            #line hidden
, 7536), false)
);

WriteLiteral("/>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 155 "..\..MVC\Views\Comments\Comments.Default.cshtml"
                                         Write(Html.Resource("CommentBy"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteLiteral(" data-sf-role=\"comment-name\"");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral("></span>\r\n                <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 157 "..\..MVC\Views\Comments\Comments.Default.cshtml"
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

WriteLiteral(" data-sf-role=\"comment-message\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");

            
            #line 169 "..\..MVC\Views\Comments\Comments.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/comments-list.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
