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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.CheckboxesField
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
    
    #line 4 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CheckboxesField/Write.Default.cshtml")]
    public partial class Write_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.CheckboxesField.CheckboxesFieldViewModel>
    {
        public Write_Default()
        {
        }
        public override void Execute()
        {
            
            #line 7 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
  
    var fieldName = Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 614), Tuple.Create("\"", 642)
            
            #line 14 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 622), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 622), false)
, Tuple.Create(Tuple.Create(" ", 637), Tuple.Create("my-3", 638), true)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"form-label fs-6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 723), Tuple.Create("\'", 764)
            
            #line 15 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 728), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 728), false)
);

WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 859), Tuple.Create("\'", 915)
, Tuple.Create(Tuple.Create("", 867), Tuple.Create("{", 867), true)
, Tuple.Create(Tuple.Create(" ", 868), Tuple.Create("\"required\":", 869), true)
, Tuple.Create(Tuple.Create(" ", 880), Tuple.Create("\"", 881), true)
            
            #line 17 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
  , Tuple.Create(Tuple.Create("", 882), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 882), false)
, Tuple.Create(Tuple.Create("", 913), Tuple.Create("\"}", 913), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"required-validator\"");

WriteAttribute("value", Tuple.Create(" value=\'", 979), Tuple.Create("\'", 1015)
            
            #line 18 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 987), Tuple.Create<System.Object, System.Int32>(Model.IsRequired.ToString()
            
            #line default
            #line hidden
, 987), false)
);

WriteLiteral(" />\r\n\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1052), Tuple.Create("\'", 1106)
            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1070), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupLabel")
            
            #line default
            #line hidden
, 1070), false)
);

WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                       if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                 Write(Html.UniqueId("CheckboxGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                     Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" aria-describedby=\'");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                             Write(Html.UniqueId("CheckboxGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\' ");

WriteLiteral("  ");

            
            #line 20 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                                        } 
            
            #line default
            #line hidden
WriteLiteral(">\r\n");

            
            #line 21 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
          int i = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 22 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 22 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            string selectedValue = !string.IsNullOrEmpty(value) ? value : Model.MetaField.DefaultValue;
            var selctedAttributes = !string.IsNullOrEmpty(selectedValue) && selectedValue.Contains(choice as string) ? "checked" : string.Empty;
            i++;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1864), Tuple.Create("\"", 1905)
            
            #line 29 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1870), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 1870), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">");

            
            #line 29 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                     Write(choice);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1987), Tuple.Create("\"", 2004)
            
            #line 30 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1994), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2005), Tuple.Create("\"", 2045)
            
            #line 30 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2010), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2010), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2071), Tuple.Create("\"", 2086)
            
            #line 30 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 2079), false)
);

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" ");

            
            #line 30 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                            Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"checkbox\" aria-required=\"");

            
            #line 30 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                                                                              Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n            </li>\r\n");

            
            #line 32 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 33 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
         if (Model.HasOtherChoice)
        {
            i++;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"form-check\"");

WriteLiteral(">\r\n                <label");

WriteAttribute("for", Tuple.Create(" for=\"", 2347), Tuple.Create("\"", 2388)
            
            #line 37 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2353), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2353), false)
);

WriteLiteral(" class=\"form-check-label\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 39 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                             Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2630), Tuple.Create("\"", 2647)
            
            #line 41 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2637), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2637), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 2648), Tuple.Create("\"", 2688)
            
            #line 41 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2653), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(fieldName + "_" + i)
            
            #line default
            #line hidden
, 2653), false)
);

WriteLiteral(" class=\"form-check-input\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-checkbox\"");

WriteLiteral(" data-sf-role=\"checkboxes-field-input\"");

WriteLiteral(" role=\"checkbox\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2816), Tuple.Create("\"", 2843)
            
            #line 41 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2832), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2832), false)
);

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" class=\"form-control mt-2\"");

WriteLiteral(" data-sf-checkboxes-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2955), Tuple.Create("\"", 2982)
            
            #line 42 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                          , Tuple.Create(Tuple.Create("", 2971), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2971), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2983), Tuple.Create("\"", 3025)
            
            #line 42 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                   , Tuple.Create(Tuple.Create("", 2996), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2996), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 44 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 3080), Tuple.Create("\'", 3128)
            
            #line 46 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupErrorMessage")
            
            #line default
            #line hidden
, 3085), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"invalid-feedback\"");

WriteLiteral("></div>\r\n");

            
            #line 47 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    
            
            #line default
            #line hidden
            
            #line 47 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
     if (hasDescription)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"form-text\"");

WriteAttribute("id", Tuple.Create(" id=\'", 3288), Tuple.Create("\'", 3328)
            
            #line 49 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 3293), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("CheckboxGroupInfo")
            
            #line default
            #line hidden
, 3293), false)
);

WriteLiteral(">");

            
            #line 49 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
                                                                 Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 50 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n</fieldset>\r\n\r\n");

            
            #line 54 "..\..MVC\Views\CheckboxesField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
