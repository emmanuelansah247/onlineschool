#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Home\Feedback.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fa0971e594eae60c12cf638b1de75825cf6a5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Feedback), @"mvc.1.0.view", @"/Views/Home/Feedback.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Feedback.cshtml", typeof(AspNetCore.Views_Home_Feedback))]
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
#line 1 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\_ViewImports.cshtml"
using bim_edu;

#line default
#line hidden
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\_ViewImports.cshtml"
using bim_edu.Models;

#line default
#line hidden
#line 3 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\_ViewImports.cshtml"
using bim_edu.Session;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fa0971e594eae60c12cf638b1de75825cf6a5c", @"/Views/Home/Feedback.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Feedback : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/payment/succeeded.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Home\Feedback.cshtml"
  
    string heading = ViewData["heading"] as string;
    string description = ViewData["description"] as string;
    ViewData["Title"] = heading + " - Bim-Edu";

#line default
#line hidden
            BeginContext(172, 195, true);
            WriteLiteral("\r\n<section class=\"page_wrapper\">\r\n\r\n    <div class=\"page_container\">\r\n\r\n                <div class=\"status_container\">\r\n                        <h1 class=\"heading\"> \r\n                            ");
            EndContext();
            BeginContext(368, 7, false);
#line 14 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Home\Feedback.cshtml"
                       Write(heading);

#line default
#line hidden
            EndContext();
            BeginContext(375, 112, true);
            WriteLiteral(" \r\n                        </h1>\r\n                        <p class=\"description\"> \r\n                            ");
            EndContext();
            BeginContext(488, 11, false);
#line 17 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Home\Feedback.cshtml"
                       Write(description);

#line default
#line hidden
            EndContext();
            BeginContext(499, 91, true);
            WriteLiteral(" \r\n                        </p>\r\n                </div>\r\n\r\n        </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(607, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(613, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c6fa0971e594eae60c12cf638b1de75825cf6a5c5893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(682, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(687, 2, true);
            WriteLiteral("\r\n");
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
