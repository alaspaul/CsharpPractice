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

namespace SiteFInityWebApp.ResourcePackages.Bootstrap5.MVC.Views.News
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
    
    #line 3 "..\..MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\News\List.NewsList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/News/List.NewsList.cshtml")]
    public partial class List_NewsList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_NewsList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 213), Tuple.Create("\"", 236)
            
            #line 7 "..\..MVC\Views\News\List.NewsList.cshtml"
, Tuple.Create(Tuple.Create("", 221), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 221), false)
);

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..MVC\Views\News\List.NewsList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\News\List.NewsList.cshtml"
         foreach (var item in Model.Items)
        {
            var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(" ");

            
            #line 13 "..\..MVC\Views\News\List.NewsList.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3>\r\n                    <a ");

            
            #line 15 "..\..MVC\Views\News\List.NewsList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 15 "..\..MVC\Views\News\List.NewsList.cshtml"
                                                                                 Write(navigateUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 15 "..\..MVC\Views\News\List.NewsList.cshtml"
                                                                                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </h3>\r\n\r\n                <div>\r\n                    <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 20 "..\..MVC\Views\News\List.NewsList.cshtml"
                   Write(item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 21 "..\..MVC\Views\News\List.NewsList.cshtml"
                   Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 22 "..\..MVC\Views\News\List.NewsList.cshtml"
                   Write(DataResolver.Resolve(item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..MVC\Views\News\List.NewsList.cshtml"
               Write(Html.CommentsCount((string)navigateUrl, item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"mt-3 mb-2\"");

WriteLiteral(" ");

            
            #line 28 "..\..MVC\Views\News\List.NewsList.cshtml"
                                  Write(Html.InlineEditingFieldAttributes("Summary", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\News\List.NewsList.cshtml"
                                                                                             Write(Html.HtmlSanitize((string)item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1358), Tuple.Create("\"", 1377)
            
            #line 30 "..\..MVC\Views\News\List.NewsList.cshtml"
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(navigateUrl
            
            #line default
            #line hidden
, 1365), false)
);

WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\News\List.NewsList.cshtml"
                                  Write(Html.Resource("FullStory"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </li>\r\n");

            
            #line 32 "..\..MVC\Views\News\List.NewsList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 35 "..\..MVC\Views\News\List.NewsList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..MVC\Views\News\List.NewsList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\News\List.NewsList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
        {
            currentPage = Model.CurrentPage,
                        totalPagesCount = Model.TotalPagesCount.Value,
                        redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
        }));

            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\News\List.NewsList.cshtml"
          
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591