#pragma checksum "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db2a228f3b7a30aa4c910bbc7c18f66085948d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_viewDish), @"mvc.1.0.view", @"/Views/Home/viewDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/viewDish.cshtml", typeof(AspNetCore.Views_Home_viewDish))]
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
#line 1 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2a228f3b7a30aa4c910bbc7c18f66085948d68", @"/Views/Home/viewDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_viewDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 425, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2a228f3b7a30aa4c910bbc7c18f66085948d683365", async() => {
                BeginContext(41, 412, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>View Dish</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(460, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(462, 457, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db2a228f3b7a30aa4c910bbc7c18f66085948d684974", async() => {
                BeginContext(468, 36, true);
                WriteLiteral("\r\n    <a href=\"/\">Home</a>\r\n    <h1>");
                EndContext();
                BeginContext(505, 20, false);
#line 12 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
   Write(ViewBag.Profile.Name);

#line default
#line hidden
                EndContext();
                BeginContext(525, 15, true);
                WriteLiteral("</h1>\r\n    <h3>");
                EndContext();
                BeginContext(541, 20, false);
#line 13 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
   Write(ViewBag.Profile.Chef);

#line default
#line hidden
                EndContext();
                BeginContext(561, 25, true);
                WriteLiteral("</h3>\r\n    <br>\r\n    <h5>");
                EndContext();
                BeginContext(587, 27, false);
#line 15 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
   Write(ViewBag.Profile.Description);

#line default
#line hidden
                EndContext();
                BeginContext(614, 32, true);
                WriteLiteral("</h5>\r\n    <strong>Calories:<p> ");
                EndContext();
                BeginContext(647, 24, false);
#line 16 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
                    Write(ViewBag.Profile.Calories);

#line default
#line hidden
                EndContext();
                BeginContext(671, 41, true);
                WriteLiteral("</p></strong>\r\n    <strong>Tastiness: <p>");
                EndContext();
                BeginContext(713, 25, false);
#line 17 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
                     Write(ViewBag.Profile.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(738, 21, true);
                WriteLiteral("</p></strong>\r\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 759, "\"", 797, 2);
                WriteAttributeValue("", 766, "/delete/", 766, 8, true);
#line 18 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
WriteAttributeValue("", 774, ViewBag.Profile.DishId, 774, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(798, 42, true);
                WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 840, "\"", 876, 2);
                WriteAttributeValue("", 847, "/edit/", 847, 6, true);
#line 19 "C:\Users\kevin\Desktop\codingDojo\C#\CRUDelicious\Views\Home\viewDish.cshtml"
WriteAttributeValue("", 853, ViewBag.Profile.DishId, 853, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(877, 35, true);
                WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 9, true);
            WriteLiteral("\r\n</html>");
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
