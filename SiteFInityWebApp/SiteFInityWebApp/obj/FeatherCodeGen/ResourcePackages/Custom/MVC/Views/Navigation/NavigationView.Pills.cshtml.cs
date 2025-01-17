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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.Navigation
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
    
    #line 8 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Navigation/NavigationView.Pills.cshtml")]
    public partial class NavigationView_Pills : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 34 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node, int i)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 35 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    if (node.ChildNodes.Count > 0)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item dropdown\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1309), Tuple.Create("\"", 1357)
, Tuple.Create(Tuple.Create("", 1317), Tuple.Create("nav-link", 1317), true)
, Tuple.Create(Tuple.Create(" ", 1325), Tuple.Create("dropdown-toggle", 1326), true)

#line 39 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1341), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1342), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 1358), Tuple.Create("\'", 1406)

#line 39 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1363), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("pillsDropdownMenuLink" + i)

#line default
#line hidden
, 1363), false)
);

WriteLiteralTo(__razor_helper_writer, " role=\"button\"");

WriteLiteralTo(__razor_helper_writer, " data-bs-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " data-bs-auto-close=\"outside\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 39 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                                                                                                                                   WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu\"");

WriteAttributeTo(__razor_helper_writer, "aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1574), Tuple.Create("\'", 1635)

#line 40 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1592), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("pillsDropdownMenuLink" + i)

#line default
#line hidden
, 1592), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 41 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(node, i));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </ul>\r\n        </li>\r\n");


#line 44 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }
    else
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n            <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1794), Tuple.Create("\"", 1826)
, Tuple.Create(Tuple.Create("", 1802), Tuple.Create("nav-link", 1802), true)

#line 48 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 1810), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1811), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1827), Tuple.Create("\"", 1843)

#line 48 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1834), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1844), Tuple.Create("\"", 1869)

#line 48 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1853), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 48 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                             WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n        </li>\r\n");


#line 50 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
    }


#line default
#line hidden
});

#line 51 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 54 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node, int i)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 55 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    int j = 0;
    foreach (var childNode in node.ChildNodes)
    {
        if (childNode.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2179), Tuple.Create("\"", 2220)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("nav-item", 2187), true)
, Tuple.Create(Tuple.Create(" ", 2195), Tuple.Create("dropdown", 2196), true)

#line 61 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2204), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 2205), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2244), Tuple.Create("\"", 2291)
, Tuple.Create(Tuple.Create("", 2252), Tuple.Create("dropdown-item", 2252), true)
, Tuple.Create(Tuple.Create(" ", 2265), Tuple.Create("pe-4", 2266), true)

#line 63 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2270), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2271), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 2292), Tuple.Create("\"", 2313)

#line 63 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 2299), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 2299), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 64 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </a>\r\n                <span");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 2398), Tuple.Create("\"", 2460)
, Tuple.Create(Tuple.Create("", 2406), Tuple.Create("p-1", 2406), true)
, Tuple.Create(Tuple.Create(" ", 2409), Tuple.Create("position-absolute", 2410), true)
, Tuple.Create(Tuple.Create(" ", 2427), Tuple.Create("top-0", 2428), true)
, Tuple.Create(Tuple.Create(" ", 2433), Tuple.Create("end-0", 2434), true)

#line 66 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 2439), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 2440), false)
);

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 2461), Tuple.Create("\'", 2514)

#line 66 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
         , Tuple.Create(Tuple.Create("", 2466), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink" + i + j)

#line default
#line hidden
, 2466), false)
);

WriteLiteralTo(__razor_helper_writer, " role=\"button\"");

WriteLiteralTo(__razor_helper_writer, " data-bs-auto-close=\"outside\"");

WriteLiteralTo(__razor_helper_writer, " data-bs-toggle=\"dropdown\"");

WriteLiteralTo(__razor_helper_writer, " aria-haspopup=\"true\"");

WriteLiteralTo(__razor_helper_writer, " aria-expanded=\"false\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                    <svg");

WriteLiteralTo(__razor_helper_writer, " class=\"svg-inline--fa fa-w-16\"");

WriteLiteralTo(__razor_helper_writer, " aria-hidden=\"true\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                        <use");

WriteAttributeTo(__razor_helper_writer, "xlink:href", Tuple.Create(" xlink:href=\"", 2735), Tuple.Create("\"", 2828)
, Tuple.Create(Tuple.Create("", 2748), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap5/assets/dist/sprites/solid.svg#")
, 2748), false)

#line 68 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                     , Tuple.Create(Tuple.Create("", 2808), Tuple.Create<System.Object, System.Int32>(GetCaretDirection()

#line default
#line hidden
, 2808), false)
);

WriteLiteralTo(__razor_helper_writer, "></use>\r\n                    </svg>\r\n                </span>\r\n                <ul" +
"");

WriteLiteralTo(__razor_helper_writer, " class=\"dropdown-menu top-0 start-100 mt-n2\"");

WriteAttributeTo(__razor_helper_writer, "aria-labelledby", Tuple.Create(" aria-labelledby=\'", 2954), Tuple.Create("\'", 3020)

#line 71 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 , Tuple.Create(Tuple.Create("", 2972), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("navbarDropdownMenuLink" + i + j)

#line default
#line hidden
, 2972), false)
);

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                    ");


#line 72 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode, j));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                </ul>\r\n            </li>\r\n");


#line 75 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li>\r\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 3199), Tuple.Create("\"", 3246)
, Tuple.Create(Tuple.Create("", 3207), Tuple.Create("dropdown-item", 3207), true)
, Tuple.Create(Tuple.Create(" ", 3220), Tuple.Create("pe-4", 3221), true)

#line 79 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create(" ", 3225), Tuple.Create<System.Object, System.Int32>(GetClass(childNode)

#line default
#line hidden
, 3226), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 3247), Tuple.Create("\"", 3268)

#line 79 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 3254), Tuple.Create<System.Object, System.Int32>(childNode.Url

#line default
#line hidden
, 3254), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 3269), Tuple.Create("\"", 3299)

#line 79 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                 , Tuple.Create(Tuple.Create("", 3278), Tuple.Create<System.Object, System.Int32>(childNode.LinkTarget

#line default
#line hidden
, 3278), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 79 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                                                          WriteTo(__razor_helper_writer, childNode.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n            </li>\r\n");


#line 81 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
        }
        j++;
    }


#line default
#line hidden
});

#line 84 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 87 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 88 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 

    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 92 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 92 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 96 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("active"));


#line default
#line hidden

#line 96 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                           ;
    }


#line default
#line hidden
});

#line 98 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

#line 100 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
public System.Web.WebPages.HelperResult GetCaretDirection()
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 101 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
 
    if (Html.RenderDirAttribute().ToString() != "dir=\"rtl\"")
    {
        

#line default
#line hidden

#line 104 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-right"));


#line default
#line hidden

#line 104 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                         ;
    }
    else
    {
        

#line default
#line hidden

#line 108 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("caret-left"));


#line default
#line hidden

#line 108 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                        ;
    }


#line default
#line hidden
});

#line 110 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
}
#line default
#line hidden

        public NavigationView_Pills()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n\r\n");

            
            #line 14 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
Write(Html.Script(Url.Content("~/ResourcePackages/Bootstrap5/assets/dist/js/bootstrap.min.js"), "frameworks", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 643), Tuple.Create("\"", 666)
            
            #line 16 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
, Tuple.Create(Tuple.Create("", 651), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 651), false)
);

WriteLiteral(">\r\n    <nav");

WriteLiteral(" class=\"navbar navbar-expand-md\"");

WriteLiteral(">\r\n        ");

WriteLiteral("\r\n\r\n        <ul");

WriteLiteral(" class=\"nav nav-pills\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
              
                int i = 0;
                foreach (var node in Model.Nodes)
                {
                    
            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
               Write(RenderRootLevelNode(node, i));

            
            #line default
            #line hidden
            
            #line 25 "..\..MVC\Views\Navigation\NavigationView.Pills.cshtml"
                                                 ;
                    i++;
                }
            
            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n    </nav>\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
