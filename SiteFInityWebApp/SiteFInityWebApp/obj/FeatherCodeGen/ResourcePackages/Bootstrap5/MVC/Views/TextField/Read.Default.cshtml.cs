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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.TextField
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/TextField/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.TextField.TextFieldViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteAttribute("class", Tuple.Create(" class=\"", 95), Tuple.Create("\"", 123)
            
            #line 3 "..\..MVC\Views\TextField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 103), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 103), false)
, Tuple.Create(Tuple.Create(" ", 118), Tuple.Create("my-3", 119), true)
);

WriteLiteral(" data-sf-role=\"text-field-container\"");

WriteLiteral(">\r\n    <strong>");

            
            #line 4 "..\..MVC\Views\TextField\Read.Default.cshtml"
       Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n    <p>");

            
            #line 5 "..\..MVC\Views\TextField\Read.Default.cshtml"
  Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 257), Tuple.Create("\"", 290)
            
            #line 6 "..\..MVC\Views\TextField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 264), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 264), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 291), Tuple.Create("\"", 311)
            
            #line 6 "..\..MVC\Views\TextField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 299), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 299), false)
);

WriteLiteral(" />\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591