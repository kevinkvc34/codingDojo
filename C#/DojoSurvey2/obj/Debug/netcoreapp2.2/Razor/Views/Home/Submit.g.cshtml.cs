#pragma checksum "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\Home\Submit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6872c57532013f3c3e32d8939616f5bd91fb71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submit), @"mvc.1.0.view", @"/Views/Home/Submit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Submit.cshtml", typeof(AspNetCore.Views_Home_Submit))]
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
#line 1 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\_ViewImports.cshtml"
using DojoSurvey2;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\_ViewImports.cshtml"
using DojoSurvey2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6872c57532013f3c3e32d8939616f5bd91fb71", @"/Views/Home/Submit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb4a7870d16d938133bb3cc90c52ee505b81fa06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Submit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoSurvey2.Models.Survey>
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
            BeginContext(34, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(69, 220, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6872c57532013f3c3e32d8939616f5bd91fb713365", async() => {
                BeginContext(75, 207, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title>Dojo Survey w/ Models</title>\r\n");
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
            BeginContext(289, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(291, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6872c57532013f3c3e32d8939616f5bd91fb714770", async() => {
                BeginContext(297, 16, true);
                WriteLiteral("\r\n    <h1>Name: ");
                EndContext();
                BeginContext(314, 10, false);
#line 11 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\Home\Submit.cshtml"
         Write(Model.name);

#line default
#line hidden
                EndContext();
                BeginContext(324, 26, true);
                WriteLiteral(" </h1>\r\n    <h1>Language: ");
                EndContext();
                BeginContext(351, 14, false);
#line 12 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\Home\Submit.cshtml"
             Write(Model.language);

#line default
#line hidden
                EndContext();
                BeginContext(365, 25, true);
                WriteLiteral("</h1>\r\n    <h1>Location: ");
                EndContext();
                BeginContext(391, 14, false);
#line 13 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\Home\Submit.cshtml"
             Write(Model.location);

#line default
#line hidden
                EndContext();
                BeginContext(405, 24, true);
                WriteLiteral("</h1>\r\n    <h1>Comment: ");
                EndContext();
                BeginContext(430, 13, false);
#line 14 "C:\Users\kevin\Desktop\codingDojo\C#\DojoSurvey2\Views\Home\Submit.cshtml"
            Write(Model.comment);

#line default
#line hidden
                EndContext();
                BeginContext(443, 7, true);
                WriteLiteral("</h1>\r\n");
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
            BeginContext(457, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoSurvey2.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
