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

namespace SiteFInityWebApp.ResourcePackages.Custom.MVC.Views.EventScheduler
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
    
    #line 8 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Events.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/EventScheduler/Detail.EventDetails.cshtml")]
    public partial class Detail_EventDetails : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentDetailsViewModel>
    {
        public Detail_EventDetails()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 490), Tuple.Create("\"", 513)
            
            #line 12 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 498), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 498), false)
);

WriteLiteral(" ");

            
            #line 12 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                        Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)Model.Item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"row me-3\"");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"col-auto position-relative\"");

WriteLiteral(">\r\n            <span ");

            
            #line 15 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                      Write(Model.Item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span");

WriteLiteral(" class=\"position-absolute top-50 start-100 translate-middle p-2 border border-lig" +
"ht rounded-circle\"");

WriteAttribute("style", Tuple.Create(" style=\"", 924), Tuple.Create("\"", 977)
, Tuple.Create(Tuple.Create("", 932), Tuple.Create("background:", 932), true)
            
            #line 16 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                        , Tuple.Create(Tuple.Create(" ", 943), Tuple.Create<System.Object, System.Int32>(Model.Item.EventCalendarColour()
            
            #line default
            #line hidden
, 944), false)
);

WriteLiteral("></span>\r\n        </h1>\r\n    </div>\r\n");

            
            #line 19 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 19 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.EventDates())) 
	{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\r\n        <time");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                            Write(Model.Item.EventDates());

            
            #line default
            #line hidden
WriteLiteral("</time> ");

            
            #line 22 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                            Write(Html.CommentsCount(string.Empty, Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 24 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <div");

WriteLiteral(" class=\"bg-light p-4 mb-4\"");

WriteLiteral(">\r\n");

            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 27 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.City) || !string.IsNullOrEmpty(Model.Item.Fields.Country) || !string.IsNullOrEmpty(Model.Item.Fields.Location))
    {
            
            #line default
            #line hidden
WriteLiteral("<address>\r\n\r\n");

            
            #line 30 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 30 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.City) && !string.IsNullOrEmpty(Model.Item.Fields.Country))
        {
            
            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.City);

            
            #line default
            #line hidden
WriteLiteral(" <span>,</span> ");

            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                   
            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                              Write(Model.Item.Fields.Country);

            
            #line default
            #line hidden
            
            #line 32 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 34 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        Write(string.IsNullOrEmpty(Model.Item.Fields.City) ? Model.Item.Fields.Country : Model.Item.Fields.City);

            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                                

            
            #line default
            #line hidden
WriteLiteral("             <br>\r\n");

            
            #line 39 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 41 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.Street))
        {
            
            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Street);

            
            #line default
            #line hidden
            
            #line 43 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                     

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 45 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("         ");

            
            #line 46 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
          if (!string.IsNullOrEmpty(Model.Item.Fields.Location))
        {       
                
            
            #line default
            #line hidden
            
            #line 48 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                        
                
            
            #line default
            #line hidden
            
            #line 49 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
           Write(Model.Item.Fields.Location);

            
            #line default
            #line hidden
            
            #line 49 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           
        }

            
            #line default
            #line hidden
WriteLiteral("    </address>\r\n");

            
            #line 52 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <div>\r\n");

            
            #line 55 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 55 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactName))
        {
            
            
            #line default
            #line hidden
            
            #line 57 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactName);

            
            #line default
            #line hidden
            
            #line 57 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 59 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 61 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 61 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactPhone))
        {
            
            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactPhone);

            
            #line default
            #line hidden
            
            #line 63 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                           

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 65 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 67 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 67 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactCell))
        {
            
            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.ContactCell);

            
            #line default
            #line hidden
            
            #line 69 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                          

            
            #line default
            #line hidden
WriteLiteral("            <br>\r\n");

            
            #line 71 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("            \r\n");

            
            #line 73 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 73 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactEmail))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2802), Tuple.Create("\"", 2849)
, Tuple.Create(Tuple.Create("", 2809), Tuple.Create("mailto:", 2809), true)
            
            #line 75 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 2816), Tuple.Create<System.Object, System.Int32>(Model.Item.Fields.ContactEmail
            
            #line default
            #line hidden
, 2816), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 75 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                          Write(Model.Item.Fields.ContactEmail);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

WriteLiteral("            <br>\r\n");

            
            #line 77 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 79 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        
            
            #line default
            #line hidden
            
            #line 79 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
         if (!string.IsNullOrEmpty(Model.Item.Fields.ContactWeb))
        {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3027), Tuple.Create("\"", 3091)
            
            #line 81 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3034), Tuple.Create<System.Object, System.Int32>(Html.UrlSanitize((string)Model.Item.Fields.ContactWeb)
            
            #line default
            #line hidden
, 3034), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 81 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                           Write(Model.Item.Fields.ContactWeb);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 82 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n\r\n");

            
            #line 85 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 85 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (ViewBag.AllowCalendarExport)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"mt-3\"");

WriteLiteral(">\r\n            <span>");

            
            #line 88 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
             Write(Html.Resource("AddTo"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <ul");

WriteLiteral(" class=\"list-inline d-inline-block\"");

WriteLiteral(">\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3393), Tuple.Create("\"", 3432)
            
            #line 90 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3400), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateOutlookUrl()
            
            #line default
            #line hidden
, 3400), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 90 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                   Write(Html.Resource("OutlookEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3552), Tuple.Create("\"", 3588)
            
            #line 91 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3559), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateICalUrl()
            
            #line default
            #line hidden
, 3559), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 91 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                Write(Html.Resource("ICalEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a>,</li>\r\n                <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 3705), Tuple.Create("\"", 3743)
            
            #line 92 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
, Tuple.Create(Tuple.Create("", 3712), Tuple.Create<System.Object, System.Int32>(Model.Item.GenerateGoogleUrl()
            
            #line default
            #line hidden
, 3712), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 92 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                                                  Write(Html.Resource("GoogleEventExporterTitle"));

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            </ul>\r\n        </div>\r\n");

            
            #line 95 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("   \r\n    </div>\r\n    \r\n\r\n");

            
            #line 100 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 100 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Summary))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"lead\"");

WriteLiteral(" ");

            
            #line 102 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                   Write(Html.InlineEditingFieldAttributes("Summary", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 102 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                             Write(Html.HtmlSanitize((string)Model.Item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 103 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 106 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 106 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Description))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p>\r\n");

WriteLiteral("            ");

            
            #line 109 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
       Write(Model.Item.Fields.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </p>\r\n");

            
            #line 111 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 113 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    
            
            #line default
            #line hidden
            
            #line 113 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
     if (!string.IsNullOrEmpty(Model.Item.Fields.Content))
    {        

            
            #line default
            #line hidden
WriteLiteral("        <p ");

            
            #line 115 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
      Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 115 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
                                                                Write(Html.HtmlSanitize((string)Model.Item.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 116 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 118 "..\..MVC\Views\EventScheduler\Detail.EventDetails.cshtml"
Write(Html.CommentsList(Model.Item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
