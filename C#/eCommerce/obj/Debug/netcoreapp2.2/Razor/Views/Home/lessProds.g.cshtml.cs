#pragma checksum "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\Home\lessProds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9564a30940a3c5289353c39bd4e5da40900bbcd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_lessProds), @"mvc.1.0.view", @"/Views/Home/lessProds.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/lessProds.cshtml", typeof(AspNetCore.Views_Home_lessProds))]
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
#line 1 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\_ViewImports.cshtml"
using eCommerce;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\_ViewImports.cshtml"
using eCommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9564a30940a3c5289353c39bd4e5da40900bbcd1", @"/Views/Home/lessProds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e59d300b1f24809bdce0b922d068f8fd6f363da2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_lessProds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\Home\lessProds.cshtml"
 foreach(var x in Model) {

#line default
#line hidden
            BeginContext(50, 126, true);
            WriteLiteral("                <div class=\"productimgcontainer\">\r\n                    <div class=\"productimg\"></div>\r\n                    <p>");
            EndContext();
            BeginContext(177, 6, false);
#line 5 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\Home\lessProds.cshtml"
                  Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(183, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(186, 10, false);
#line 5 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\Home\lessProds.cshtml"
                           Write(x.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(196, 37, true);
            WriteLiteral(" Left!)</p>\r\n                </div>\r\n");
            EndContext();
#line 7 "C:\Users\kevin\Desktop\codingDojo\C#\eCommerce\Views\Home\lessProds.cshtml"
            }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
