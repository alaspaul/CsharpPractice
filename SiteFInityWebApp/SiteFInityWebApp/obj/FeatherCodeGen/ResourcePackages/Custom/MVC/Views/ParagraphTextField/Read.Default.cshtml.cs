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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.ParagraphTextField
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ParagraphTextField/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.ParagraphTextField.ParagraphTextFieldViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 373), Tuple.Create("\"", 401)
            
            #line 8 "..\..MVC\Views\ParagraphTextField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 381), false)
, Tuple.Create(Tuple.Create(" ", 396), Tuple.Create("my-3", 397), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\r\n    <strong>");

            
            #line 9 "..\..MVC\Views\ParagraphTextField\Read.Default.cshtml"
       Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    <p>");

            
            #line 10 "..\..MVC\Views\ParagraphTextField\Read.Default.cshtml"
  Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
