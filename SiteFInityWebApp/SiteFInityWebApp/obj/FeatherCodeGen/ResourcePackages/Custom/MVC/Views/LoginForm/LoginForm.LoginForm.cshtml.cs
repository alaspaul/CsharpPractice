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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.LoginForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 8 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using System.Linq.Expressions;
    
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
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 15 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Abstractions;
    
    #line default
    #line hidden
    
    #line 13 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 16 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Security.CSRF;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 14 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    #line 17 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    using Telerik.Sitefinity.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginForm/LoginForm.LoginForm.cshtml")]
    public partial class LoginForm_LoginForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.LoginFormViewModel>
    {

#line 106 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<LoginFormViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 107 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"my-3\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 130 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label), new { @class = "form-label" }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n");


#line 132 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 132 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 135 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 135 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 139 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 139 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 143 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 143 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 150 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        

#line default
#line hidden

#line 150 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 6366), Tuple.Create("\'", 6393)

#line 152 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 6371), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 6371), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 153 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n");


#line 155 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 157 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"


#line default
#line hidden
});

#line 157 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
}
#line default
#line hidden

#line 159 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
public System.Web.WebPages.HelperResult GetProviderCssClass(String name)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 160 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
 
    if (name.Contains("facebook"))
    {
        

#line default
#line hidden

#line 163 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-primary"));


#line default
#line hidden

#line 163 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                 ;
    }
    else if (name.Contains("google"))
    {
        

#line default
#line hidden

#line 167 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-danger"));


#line default
#line hidden

#line 167 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                ;
    }
    else if (name.Contains("linkedin"))
    {
        

#line default
#line hidden

#line 171 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-primary"));


#line default
#line hidden

#line 171 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                 ;
    }
    else if (name.Contains("microsoft"))
    {
        

#line default
#line hidden

#line 175 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-info"));


#line default
#line hidden

#line 175 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                              ;
    }
    else if (name.Contains("twitter"))
    {
        

#line default
#line hidden

#line 179 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-info"));


#line default
#line hidden

#line 179 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                              ;
    }
    else
    {
        

#line default
#line hidden

#line 183 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-dark"));


#line default
#line hidden

#line 183 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                              ;
    }


#line default
#line hidden
});

#line 185 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
}
#line default
#line hidden

        public LoginForm_LoginForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 20 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 21 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/jquery.validate/1.8.1/jquery.validate.js", "jquery", false, false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
Write(Html.Script("//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js", "jquery", false, false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 24 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
  
    var hasExternalProviders = Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0;
    var rowClass = hasExternalProviders ? "row" : "";
    var colClass = hasExternalProviders ? "col-lg-6" : "";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1473), Tuple.Create("\"", 1496)
            
            #line 30 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1481), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1481), false)
);

WriteLiteral(">\r\n");

            
            #line 31 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 31 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
     using (Html.BeginFormSitefinity(@Request.Url.Query, null, null, FormMethod.Post, new Dictionary<string, object>
{ { "role", "form" } }, true))
    {
        
            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
   Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 34 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                     ;


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1711), Tuple.Create("\"", 1728)
            
            #line 36 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1719), Tuple.Create<System.Object, System.Int32>(rowClass
            
            #line default
            #line hidden
, 1719), false)
);

WriteLiteral(">\r\n            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1748), Tuple.Create("\"", 1765)
            
            #line 37 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(colClass
            
            #line default
            #line hidden
, 1756), false)
);

WriteLiteral(">\r\n                <h3>");

            
            #line 38 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
               Write(Html.Resource("LoginFormLogInLegendHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 40 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if ((!string.IsNullOrEmpty(Request.QueryStringGet("err")) && ViewBag.ControllerId.Equals(Request.QueryStringGet("sf_login_cntrl_id"))) || Model.LoginError)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 42 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                                  Write(Html.Resource("IncorrectCredentialsMessage"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 43 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 45 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("UserName", u => u.UserName, "LoginUserName", "text", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                ");

            
            #line 47 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(FormGroupPanel("Password", u => u.Password, "LoginPassword", "password", null, new Dictionary<string, object>() { { "aria-required", "true" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 49 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 49 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRememberMe || Model.ShowForgotPasswordLink)
                {
                    var isPulledRight = Model.ShowRememberMe ? "ms-auto" : "";


            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"d-flex my-3\"");

WriteLiteral(">\r\n");

            
            #line 54 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 54 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                         if (Model.ShowRememberMe)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                                <label");

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                                    ");

            
            #line 58 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.CheckBoxFor(u => u.RememberMe, new { @class = "form-check-input" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                    ");

            
            #line 59 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                               Write(Html.Resource("RememberMe"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");

            
            #line 62 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

            
            #line 63 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                         if (Model.ShowForgotPasswordLink)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3346), Tuple.Create("\"", 3368)
            
            #line 65 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 3354), Tuple.Create<System.Object, System.Int32>(isPulledRight
            
            #line default
            #line hidden
, 3354), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 66 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                           Write(Html.ActionLink(Html.Resource("ForgottenPasword"), "ForgotPassword"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </div>\r\n");

            
            #line 68 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

            
            #line 70 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n                <div");

WriteLiteral(" class=\"my-3\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 73 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                              Write(SystemManager.IsDesignMode ? "disabled" : "" );

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 73 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                                                              Write(Html.Resource("LoginFormLogInButton"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                </div>\r\n\r\n");

WriteLiteral("                ");

            
            #line 76 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 78 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 78 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                 if (Model.ShowRegistrationLink)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"my-3\"");

WriteLiteral(">\r\n                        <div>");

            
            #line 81 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        Write(Html.Resource("NotRegisteredYet"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4076), Tuple.Create("\"", 4105)
            
            #line 82 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
, Tuple.Create(Tuple.Create("", 4083), Tuple.Create<System.Object, System.Int32>(Model.RegisterPageUrl
            
            #line default
            #line hidden
, 4083), false)
);

WriteLiteral(">");

            
            #line 82 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                    Write(Html.Resource("LoginFormRegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n");

            
            #line 84 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n\r\n");

            
            #line 87 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            
            
            #line default
            #line hidden
            
            #line 87 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
             if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                    <h3>");

            
            #line 90 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                   Write(Html.Resource("UseAccountIn"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                    <div");

WriteLiteral(" class=\"d-grid gap-3 my-3\"");

WriteLiteral(">\r\n");

            
            #line 92 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 92 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                         foreach (var provider in Model.ExternalProviders)
                        {
                            var classToBeAdd = "btn btn-lg border " + GetProviderCssClass(provider.Value);

                            
            
            #line default
            #line hidden
            
            #line 96 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                       Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
            
            #line 96 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
                                                                                                                                                

                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n");

            
            #line 101 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");

            
            #line 103 "..\..MVC\Views\LoginForm\LoginForm.LoginForm.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591