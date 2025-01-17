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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.TextField
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
    
    #line 9 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 12 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 11 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..MVC\Views\TextField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/TextField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 14 "..\..MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- InputCssClass class variable -->\r\n\r\n");

            
            #line 17 "..\..MVC\Views\TextField\Write.Default.cshtml"
   
    var inputCssClass = "";
    HashSet<TextType> availableOptions = new HashSet<TextType>() { TextType.Text, TextType.Password, TextType.Date, TextType.DateTimeLocal, TextType.Month, TextType.Time,
    TextType.Week, TextType.Number, TextType.Email, TextType.Url, TextType.Tel, TextType.Color };

    if (availableOptions.Contains(Model.InputType))
    {
        inputCssClass = "form-control";
    }

    var isRequired = Model.ValidatorDefinition.Required.HasValue && Model.ValidatorDefinition.Required.Value ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1329), Tuple.Create("\"", 1357)
            
            #line 31 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1337), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1337), false)
, Tuple.Create(Tuple.Create(" ", 1352), Tuple.Create("my-3", 1353), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1459), Tuple.Create("\'", 1572)
, Tuple.Create(Tuple.Create("", 1467), Tuple.Create("{\"maxLength\":\"", 1467), true)
            
            #line 32 "..\..MVC\Views\TextField\Write.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 1481), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 1481), false)
, Tuple.Create(Tuple.Create("", 1517), Tuple.Create("\",", 1517), true)
, Tuple.Create(Tuple.Create(" ", 1519), Tuple.Create("\"minLength\":", 1520), true)
, Tuple.Create(Tuple.Create(" ", 1532), Tuple.Create("\"", 1533), true)
            
            #line 32 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1534), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1534), false)
, Tuple.Create(Tuple.Create("", 1570), Tuple.Create("\"}", 1570), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1636), Tuple.Create("\'", 1916)
, Tuple.Create(Tuple.Create("", 1644), Tuple.Create("{\"maxLength\":\"", 1644), true)
            
            #line 33 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 1658), false)
, Tuple.Create(Tuple.Create("", 1710), Tuple.Create("\",", 1710), true)
, Tuple.Create(Tuple.Create(" ", 1712), Tuple.Create("\"required\":", 1713), true)
, Tuple.Create(Tuple.Create(" ", 1724), Tuple.Create("\"", 1725), true)
            
            #line 33 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                    , Tuple.Create(Tuple.Create("", 1726), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RequiredViolationMessage
            
            #line default
            #line hidden
, 1726), false)
, Tuple.Create(Tuple.Create("", 1777), Tuple.Create("\",", 1777), true)
, Tuple.Create(Tuple.Create(" ", 1779), Tuple.Create("\"invalid\":", 1780), true)
, Tuple.Create(Tuple.Create(" ", 1790), Tuple.Create("\"", 1791), true)
            
            #line 33 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                      , Tuple.Create(Tuple.Create("", 1792), Tuple.Create<System.Object, System.Int32>(Html.Resource("InvalidEntryMessage")
            
            #line default
            #line hidden
, 1792), false)
, Tuple.Create(Tuple.Create("", 1829), Tuple.Create("\",", 1829), true)
, Tuple.Create(Tuple.Create(" ", 1831), Tuple.Create("\"regularExpression\":", 1832), true)
, Tuple.Create(Tuple.Create(" ", 1852), Tuple.Create("\"", 1853), true)
            
            #line 33 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1854), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1854), false)
, Tuple.Create(Tuple.Create("", 1914), Tuple.Create("\"}", 1914), true)
);

WriteLiteral(" />\r\n\r\n    <label");

WriteLiteral(" class=\"form-label\"");

WriteAttribute("for", Tuple.Create(" for=\'", 1953), Tuple.Create("\'", 1984)
            
            #line 35 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1959), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1959), false)
);

WriteLiteral(">");

            
            #line 35 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" \r\n        id=\'", 2028), Tuple.Create("\'", 2068)
            
            #line 37 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2043), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 2043), false)
);

WriteAttribute("type", Tuple.Create("\r\n        type=\"", 2069), Tuple.Create("\"", 2119)
            
            #line 38 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2085), Tuple.Create<System.Object, System.Int32>(Model.InputType.ToHtmlInputType()
            
            #line default
            #line hidden
, 2085), false)
);

WriteAttribute("class", Tuple.Create("\r\n        class=\"", 2120), Tuple.Create("\"", 2151)
            
            #line 39 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2137), Tuple.Create<System.Object, System.Int32>(inputCssClass
            
            #line default
            #line hidden
, 2137), false)
);

WriteAttribute("name", Tuple.Create("\r\n        name=\"", 2152), Tuple.Create("\"", 2194)
            
            #line 40 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2168), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 2168), false)
);

WriteAttribute("placeholder", Tuple.Create("\r\n        placeholder=\"", 2195), Tuple.Create("\"", 2240)
            
            #line 41 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2218), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 2218), false)
);

WriteAttribute("value", Tuple.Create("\r\n        value=\"", 2241), Tuple.Create("\"", 2270)
            
            #line 42 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2258), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 2258), false)
);

WriteAttribute("aria-required", Tuple.Create("\r\n        aria-required=\"", 2271), Tuple.Create("\"", 2307)
            
            #line 43 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2296), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2296), false)
);

WriteLiteral("\r\n        data-sf-role=\"text-field-input\"");

WriteLiteral("\r\n        ");

            
            #line 45 "..\..MVC\Views\TextField\Write.Default.cshtml"
   Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
          if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                   Write(Html.UniqueId("TextboxInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                 Write(Html.UniqueId("TextboxErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                    } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                Write(Html.UniqueId("TextboxErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 46 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                                                                                                                                                                                   } 
            
            #line default
            #line hidden
WriteLiteral(" />\r\n        \r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2635), Tuple.Create("\'", 2677)
            
            #line 48 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2640), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxErrorMessage")
            
            #line default
            #line hidden
, 2640), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"invalid-feedback\"");

WriteLiteral("></div>\r\n\r\n");

            
            #line 50 "..\..MVC\Views\TextField\Write.Default.cshtml"
     
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\TextField\Write.Default.cshtml"
      if (hasDescription) 
     {

            
            #line default
            #line hidden
WriteLiteral("         <p");

WriteAttribute("id", Tuple.Create(" id=\'", 2825), Tuple.Create("\'", 2859)
            
            #line 52 "..\..MVC\Views\TextField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2830), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxInfo")
            
            #line default
            #line hidden
, 2830), false)
);

WriteLiteral(" class=\"form-text\"");

WriteLiteral(">");

            
            #line 52 "..\..MVC\Views\TextField\Write.Default.cshtml"
                                                            Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 53 "..\..MVC\Views\TextField\Write.Default.cshtml"
     }

            
            #line default
            #line hidden
WriteLiteral("\r\n     \r\n</div>\r\n\r\n");

            
            #line 58 "..\..MVC\Views\TextField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/TextField/text-field.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
