#pragma checksum "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c869b86bd72f794effb321a0076a60e07fc4c671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_viewWed), @"mvc.1.0.view", @"/Views/Home/viewWed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/viewWed.cshtml", typeof(AspNetCore.Views_Home_viewWed))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c869b86bd72f794effb321a0076a60e07fc4c671", @"/Views/Home/viewWed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_viewWed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
  
    var wedding = ViewBag.wedding;

#line default
#line hidden
            BeginContext(43, 34, true);
            WriteLiteral("<a href=\"/logout\">Logout</a>\r\n<h1>");
            EndContext();
            BeginContext(78, 18, false);
#line 5 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
Write(wedding.FirstHuman);

#line default
#line hidden
            EndContext();
            BeginContext(96, 5, true);
            WriteLiteral(" and ");
            EndContext();
            BeginContext(102, 19, false);
#line 5 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
                       Write(wedding.SecondHuman);

#line default
#line hidden
            EndContext();
            BeginContext(121, 25, true);
            WriteLiteral(" Wedding</h1>\r\n<h3>Date: ");
            EndContext();
            BeginContext(147, 14, false);
#line 6 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
     Write(wedding.DateOf);

#line default
#line hidden
            EndContext();
            BeginContext(161, 32, true);
            WriteLiteral("</h3>\r\n<h5>Guests: </h5>\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
      
        foreach(var y in wedding.Attendants) {

#line default
#line hidden
            BeginContext(249, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(266, 16, false);
#line 11 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
           Write(y.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(282, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(284, 15, false);
#line 11 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
                             Write(y.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(299, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\viewWed.cshtml"
        }
    

#line default
#line hidden
            BeginContext(324, 5, true);
            WriteLiteral("</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
