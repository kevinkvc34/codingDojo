#pragma checksum "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968668c3ff689473dc9ebbd0a624724125f5e6c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dash), @"mvc.1.0.view", @"/Views/Home/Dash.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dash.cshtml", typeof(AspNetCore.Views_Home_Dash))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968668c3ff689473dc9ebbd0a624724125f5e6c7", @"/Views/Home/Dash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dash : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
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
            BeginContext(18, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(53, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "968668c3ff689473dc9ebbd0a624724125f5e6c73350", async() => {
                BeginContext(59, 193, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Welcome</title>\r\n");
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
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(261, 914, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "968668c3ff689473dc9ebbd0a624724125f5e6c74741", async() => {
                BeginContext(267, 237, true);
                WriteLiteral("\r\n    <a href=\"/logout\">Logout!</a>\r\n    Successfully logged in!\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Wedding</th>\r\n            <th>Date</th>\r\n            <th>Guests</th>\r\n            <th>Action</th>\r\n        </tr>\r\n");
                EndContext();
#line 20 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
          
            foreach(var x in Model.weddings) {

#line default
#line hidden
                BeginContext(564, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(611, 12, false);
#line 23 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                   Write(x.FirstHuman);

#line default
#line hidden
                EndContext();
                BeginContext(623, 3, true);
                WriteLiteral(" & ");
                EndContext();
                BeginContext(627, 13, false);
#line 23 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                                   Write(x.SecondHuman);

#line default
#line hidden
                EndContext();
                BeginContext(640, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(672, 8, false);
#line 24 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                   Write(x.DateOf);

#line default
#line hidden
                EndContext();
                BeginContext(680, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(712, 18, false);
#line 25 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                   Write(x.Attendants.Count);

#line default
#line hidden
                EndContext();
                BeginContext(730, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 26 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                         if(x.Attendants.Any(m => m.User == Model.user)) {

#line default
#line hidden
                BeginContext(813, 34, true);
                WriteLiteral("                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 847, "\"", 878, 2);
                WriteAttributeValue("", 854, "unrsvp-user/", 854, 12, true);
#line 27 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
WriteAttributeValue("", 866, x.WeddingId, 866, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(879, 18, true);
                WriteLiteral(">UnRSVP</a></td>\r\n");
                EndContext();
#line 28 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                        } else {

#line default
#line hidden
                BeginContext(931, 34, true);
                WriteLiteral("                            <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 965, "\"", 994, 2);
                WriteAttributeValue("", 972, "rsvp-user/", 972, 10, true);
#line 29 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
WriteAttributeValue("", 982, x.WeddingId, 982, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(995, 16, true);
                WriteLiteral(">RSVP</a></td>\r\n");
                EndContext();
#line 30 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
                        }

#line default
#line hidden
                BeginContext(1038, 23, true);
                WriteLiteral("                </tr>\r\n");
                EndContext();
#line 32 "C:\Users\kevin\Desktop\codingDojo\C#\WeddingPlanner\Views\Home\Dash.cshtml"
            }
        

#line default
#line hidden
                BeginContext(1087, 81, true);
                WriteLiteral("    </table>\r\n    <a href=\"/wedding/new\"class=\"btn btn-primary\">New Wedding</a>\r\n");
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
            BeginContext(1175, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
