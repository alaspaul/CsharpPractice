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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.SubscribeForm
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
    
    #line 9 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    using Telerik.Sitefinity.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SubscribeForm/SubscribeForm.SubscribeForm.cshtml")]
    public partial class SubscribeForm_SubscribeForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.EmailCampaigns.Mvc.Models.SubscribeFormViewModel>
    {
        public SubscribeForm_SubscribeForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 15 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 19 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
  
    var hasValidationMessage = Html.ValidationMessageFor(m => m.Email) != null;
    var attributes = new Dictionary<string, object>()
{
        { "class", "form-control" },
        { "type", "email" },
        { "aria-required", "true" }
    };

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId("SubscribeFormInfo") + " " + Html.UniqueId("SubscribeFormValidatonInfo"));
    }
    else
    {
        attributes.Add("aria-describedby", Html.UniqueId("SubscribeFormInfo"));
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1562), Tuple.Create("\"", 1585)
            
            #line 38 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1570), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1570), false)
);

WriteLiteral(">\r\n");

            
            #line 39 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
     using (Html.BeginFormSitefinity("Subscribe", "SubscribeForm"))
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3");

WriteLiteral(" class=\"mb-0\"");

WriteLiteral(">");

            
            #line 41 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                    Write(Html.Resource("Subscribe"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 42 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"mb-3 text-muted\"");

WriteAttribute("id", Tuple.Create(" id=\'", 1762), Tuple.Create("\'", 1802)
            
            #line 43 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SubscribeFormInfo")
            
            #line default
            #line hidden
, 1767), false)
);

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 44 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.Resource("SubscribeMail"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 46 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"

        if (ViewBag.IsSucceeded == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral(". ");

            
            #line 50 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                       Write(Html.Resource("ThankYouMessage"));

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 50 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                                          Write(ViewBag.Email);

            
            #line default
            #line hidden
WriteLiteral(")\r\n            </div>\r\n");

            
            #line 52 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
        }

        
            
            #line default
            #line hidden
            
            #line 54 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 54 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                     
        if (!string.IsNullOrEmpty(ViewBag.Error))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 58 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 60 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
        }

        
            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
          



            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"my-3\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 77 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
       Write(Html.LabelFor(u => u.Email, Html.Resource("Email"), new { @class = "form-label" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

WriteLiteral(" class=\"d-flex gap-2\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 80 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.TextBoxFor(m => m.Email, attributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <button");

WriteLiteral(" class=\"btn btn-primary ms-2\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" ");

            
            #line 81 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                               Write(SystemManager.IsDesignMode ? "disabled" : "" );

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 81 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
                                                                                                               Write(Html.Resource("ButtonSubscribe"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("                ");

            
            #line 82 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n\r\n");

            
            #line 85 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 85 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
             if (Html.ValidationMessageFor(m => m.Email) != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteAttribute("id", Tuple.Create(" id=\'", 4027), Tuple.Create("\'", 4076)
            
            #line 87 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
, Tuple.Create(Tuple.Create("", 4032), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SubscribeFormValidatonInfo")
            
            #line default
            #line hidden
, 4032), false)
);

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 88 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
               Write(Html.ValidationMessageFor(u => u.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");

            
            #line 90 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 92 "..\..MVC\Views\SubscribeForm\SubscribeForm.SubscribeForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591