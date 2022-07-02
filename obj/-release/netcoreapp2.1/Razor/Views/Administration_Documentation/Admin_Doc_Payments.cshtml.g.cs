#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration_Documentation\Admin_Doc_Payments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "641226fa24422e0f381927cb6bfc73e269b4e71d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Documentation_Admin_Doc_Payments), @"mvc.1.0.view", @"/Views/Administration_Documentation/Admin_Doc_Payments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration_Documentation/Admin_Doc_Payments.cshtml", typeof(AspNetCore.Views_Administration_Documentation_Admin_Doc_Payments))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"641226fa24422e0f381927cb6bfc73e269b4e71d", @"/Views/Administration_Documentation/Admin_Doc_Payments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Documentation_Admin_Doc_Payments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration_Two", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminStudentFeeToPay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/administration_documentation/admin_docs.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration_Documentation\Admin_Doc_Payments.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    ViewData["Title"] = "How To Use Bim-Edu Payments Page | Admin ";
    List<Course> courses = ViewData["vCourse"] as List<Course>;

#line default
#line hidden
            BeginContext(225, 687, true);
            WriteLiteral(@"

<section class=""admin_page_wrapper"">

    <div class=""admin_page_container clear_float"">

        <div class=""note"">
                <span class=""title""> NOTE: </span> 
                <p class=""message"">
                    This Section Shows How To Use The PAYMENTS Page.
                    Payments Are Mostly Fees.
                </p>
        </div>

        <figure class=""item"">
            <h2 class=""heading""> ADD NEW PAYMENT FOR A STUDENT </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Payment Page.
                        ");
            EndContext();
            BeginContext(912, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "641226fa24422e0f381927cb6bfc73e269b4e71d7020", async() => {
                BeginContext(1014, 86, true);
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
            BeginContext(1104, 1774, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        Select The Student From The 'Student Name' Dropdown List
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Select The Payment Type From The 'Payment Type' Dropdown List
                    </span>
                </p>

                <p>
                    <span class=""number""> 4. </span>
                    <span class=""instruction""> 
                        Enter The Amount (Total Amount That Is Associated With This Payment) In The 'Amount' Section
                    </span>
                </p>

                <p>
                    <span class=""number""> 5. </span>
                    <span class=""instruction""> 
                        Ent");
            WriteLiteral(@"er The Amount Paid (Amount The Student Has Paid Concerning This Payment) In The 'Paid' Section
                    </span>
                </p>

                <p>
                    <span class=""number""> 6. </span>
                    <span class=""instruction""> 
                       Click On 'Add Payment' To Add The New Payment
                    </span>
                </p>

            </div>
        </figure>

        <figure class=""item"">
            <h2 class=""heading""> UPDATE PAYMENT FOR A STUDENT </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Payment Page.
                        ");
            EndContext();
            BeginContext(2878, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "641226fa24422e0f381927cb6bfc73e269b4e71d10686", async() => {
                BeginContext(2980, 86, true);
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
            BeginContext(3070, 1689, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        Select The Student From The 'Student Name' Dropdown List
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        Click On 'View Payments To Pay' To List All The Payments For The Student
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Go To Any Of The Listed Payments
                    </span>
                </p>

                <p>
                    <span class=""number""> 4. </span>
                    <span class=""instruction""> 
                        Update The Necessary Information For A Specific Paym");
            WriteLiteral(@"ent
                    </span>
                </p>

                <p>
                    <span class=""number""> 5. </span>
                    <span class=""instruction""> 
                       Click On 'Update' To Update The Specificied Payment
                    </span>
                </p>

            </div>
        </figure>

        <figure class=""item"">
            <h2 class=""heading""> DELETE PAYMENT FOR A STUDENT </h2>
            <div class=""instructions"">

                <p>
                    <span class=""number""> 1. </span>
                    <span class=""instruction""> Go to the Payment Page.
                        ");
            EndContext();
            BeginContext(4759, 192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "641226fa24422e0f381927cb6bfc73e269b4e71d14268", async() => {
                BeginContext(4861, 86, true);
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
            BeginContext(4951, 1162, true);
            WriteLiteral(@"
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        Select The Student From The 'Student Name' Dropdown List
                    </span>
                </p>

                <p>
                    <span class=""number""> 2. </span>
                    <span class=""instruction""> 
                        Click On 'View Payments To Pay' To List All The Payments For The Student
                    </span>
                </p>

                <p>
                    <span class=""number""> 3. </span>
                    <span class=""instruction""> 
                        Go To Any Of The Listed Payments
                    </span>
                </p>

                <p>
                    <span class=""number""> 4. </span>
                    <span class=""instruction""> 
                        Click On 'Delete' To Delete A Specific Payment
    ");
            WriteLiteral("                </span>\r\n                </p>\r\n                \r\n            </div>\r\n        </figure>\r\n    \r\n    </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6136, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "641226fa24422e0f381927cb6bfc73e269b4e71d17506", async() => {
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
                BeginContext(6227, 2, true);
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
