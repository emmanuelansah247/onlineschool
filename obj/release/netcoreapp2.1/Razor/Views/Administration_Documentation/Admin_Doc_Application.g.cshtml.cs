#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration_Documentation\Admin_Doc_Application.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d610fc497a00d6742198ea74a4fa3bec4e9a28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Documentation_Admin_Doc_Application), @"mvc.1.0.view", @"/Views/Administration_Documentation/Admin_Doc_Application.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration_Documentation/Admin_Doc_Application.cshtml", typeof(AspNetCore.Views_Administration_Documentation_Admin_Doc_Application))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d610fc497a00d6742198ea74a4fa3bec4e9a28", @"/Views/Administration_Documentation/Admin_Doc_Application.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Documentation_Admin_Doc_Application : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminApproval", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/administration_documentation/admin_docs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration_Documentation\Admin_Doc_Application.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    ViewData["Title"] = "How To Use Bim-Edu Application Page | Admin ";
    List<Course> courses = ViewData["vCourse"] as List<Course>;

#line default
#line hidden
            BeginContext(228, 641, true);
            WriteLiteral(@"

<section class=""admin_page_wrapper"">

    <div class=""admin_page_container clear_float"">

        <div class=""note"">
                <span class=""title""> NOTE: </span> 
                <p class=""message"">
                    This Section Shows How To Use The APPLICATION Page. 
                </p>
        </div>

        <figure class=""item"">
            <h2 class=""heading""> VIEW APPLICATION FILES </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Application Page.
                        ");
            EndContext();
            BeginContext(869, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b345c6b65b594fa09e535898c5db3cf6", async() => {
                BeginContext(960, 86, true);
                WriteLiteral(" \r\n                            Click here to go to the page \r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1050, 1357, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        All The Applications Will Be Shown( Application Shown Here Are Those That Have Been Applied Through The Bim-Edu Website ).
                        Go To Your Desire Application
                        
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Click On View Files (All Files With The Specific Application Will Be Shown)
                    </span>
                </p>

                <p>
                    <span class=""number""> 4. </span>
                    <span class=""instruction""> 
                        Click On View Any File From The Available Files To View It Content
                    </span>
                </p>

            </di");
            WriteLiteral(@"v>
        </figure>

        <figure class=""item"">
            <h2 class=""heading""> APPROVE APPLICATION </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Application Page.
                        ");
            EndContext();
            BeginContext(2407, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8893c1a575294fcf9d0644810e2f76f2", async() => {
                BeginContext(2498, 86, true);
                WriteLiteral(" \r\n                            Click here to go to the page \r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2588, 1053, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        All The Application Will Be Shown( Application Shown Here Are Those That Have Been Applied Through The Bim-Edu Website ).
                        Go To Your Desire Application
                        
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Click On 'Approve' To Approve An Application
                    </span>
                </p>

            </div>
        </figure>
        <figure class=""item"">
            <h2 class=""heading""> REJECT APPLICATION </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Application Pa");
            WriteLiteral("ge.\r\n                        ");
            EndContext();
            BeginContext(3641, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00db66892ef54e8581e7bc5a72181ee6", async() => {
                BeginContext(3732, 86, true);
                WriteLiteral(" \r\n                            Click here to go to the page \r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3822, 779, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        All The Application Will Be Shown( Application Shown Here Are Those That Have Been Applied Through The Bim-Edu Website ).
                        Go To Your Desire Application
                        
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Click On 'Reject' To Reject An Application 
                    </span>
                </p>

            </div>
        </figure>
    
    </div>

</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4618, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4624, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f57f367711d4d7f82a3b7b3780ae127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4715, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bim_edu.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
