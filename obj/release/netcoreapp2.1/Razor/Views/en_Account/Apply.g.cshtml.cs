#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53af2fd10383987a17468fc6edbef4682b461cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_en_Account_Apply), @"mvc.1.0.view", @"/Views/en_Account/Apply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/en_Account/Apply.cshtml", typeof(AspNetCore.Views_en_Account_Apply))]
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
#line 4 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53af2fd10383987a17468fc6edbef4682b461cf9", @"/Views/en_Account/Apply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_en_Account_Apply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.ApplyPaymentByPassCodeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("notification_button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApplyPaymentByPassCode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Candidature"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("already_registered_container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("en_Apply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/account/apply.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
  
    Layout = "~/Views/Shared/_en_Layout.cshtml";
    ViewData["Title"] = "Apply for Bim-Edu programme";
    var certifications = TempData["certifications"] as List<Certification>;
    var programmes = TempData["programmes"] as List<Programme>;

#line default
#line hidden
            BeginContext(449, 90, true);
            WriteLiteral("\r\n\r\n<section class=\"page_wrapper\">\r\n\r\n    <div class=\"page_container\">\r\n                \r\n");
            EndContext();
#line 17 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
             if(signInManager.IsSignedIn(User) == false){

#line default
#line hidden
            BeginContext(598, 537, true);
            WriteLiteral(@"                <figure class=""apply_notification"">
                    <h3 class=""notifcation_title""> You Have To Login Or Register Before You Can Apply </h3>

                    <p class=""notification_description"">
                        Before You Can Apply For A Program, You Should Login Or Register With Bim-Edu.
                        After Login Or Registration, You Can Come Back To This Page To Apply
                    </p>

                    <div class=""notification_button_container"">
                        ");
            EndContext();
            BeginContext(1135, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7d2628bc8b644df9cfe944be82e4f59", async() => {
                BeginContext(1210, 7, true);
                WriteLiteral(" LOGIN ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1221, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1247, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9998716d11da4800a1caaf239f7ee39b", async() => {
                BeginContext(1325, 10, true);
                WriteLiteral(" REGISTER ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1339, 79, true);
            WriteLiteral("\r\n                    </div>\r\n                    \r\n                </figure>\r\n");
            EndContext();
#line 32 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
            }
            else{


#line default
#line hidden
            BeginContext(1454, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1466, 2103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34f455fce9b34e93bc5d9ad8a520262c", async() => {
                BeginContext(1495, 248, true);
                WriteLiteral(" \r\n\r\n                    <div class=\"input_wrapper\">\r\n                        <label class=\"label\" for=\"CertificateType\"> Degree Type </label>\r\n                        <select class=\"input\" type=\"text\" id=\"CertificateType\" name=\"CertificateType\">\r\n");
                EndContext();
#line 40 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                     for(int n=0;n<certifications.Count(); n++){

#line default
#line hidden
                BeginContext(1825, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1865, 170, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1f01d8ecf224edf82a4c9dd5d19406b", async() => {
                    BeginContext(1915, 46, true);
                    WriteLiteral("\r\n                                            ");
                    EndContext();
                    BeginContext(1962, 22, false);
#line 42 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                       Write(certifications[n].Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(1984, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 41 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                          WriteLiteral(certifications[n].CertificationId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2035, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                     }

#line default
#line hidden
                BeginContext(2077, 295, true);
                WriteLiteral(@"                        </select>
                    </div>

                    <div class=""input_wrapper"">
                        <label class=""label"" for=""ProgrammeId""> Programme  </label>
                        <select class=""input"" type=""text"" id=""ProgrammeId"" name=""ProgrammeId"">
");
                EndContext();
#line 51 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                     for(int n=0;n<programmes.Count(); n++){

#line default
#line hidden
                BeginContext(2450, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2478, 517, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43af0cf2c25140ada2fd0114d96fd26c", async() => {
                    BeginContext(2903, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(2938, 18, false);
#line 59 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                           Write(programmes[n].Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(2956, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 53 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                          WriteLiteral(programmes[n].ProgrammeId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "fee", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 54 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
AddHtmlAttributeValue("", 2591, programmes[n].ApplicationFee, 2591, 29, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "programfee", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 55 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
AddHtmlAttributeValue("", 2666, programmes[n].Fee, 2666, 18, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "programname", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 56 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
AddHtmlAttributeValue("", 2731, programmes[n].Name, 2731, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "certificateid", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 57 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
AddHtmlAttributeValue("", 2798, programmes[n].CertificationId, 2798, 30, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "description", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 58 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
AddHtmlAttributeValue("", 2875, programmes[n].Description, 2875, 26, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2995, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 61 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
                                     }

#line default
#line hidden
                BeginContext(3037, 525, true);
                WriteLiteral(@"                        </select>
                    </div>

                    <div class=""input_wrapper"">
                        <label class=""label""> Upload CV  </label>
                        <input type=""file"" class=""input"" id=""uploadcv""/>
                        <span class=""show_on_error"" id=""uploadcv_span""></span>
                    </div>

                    <div class=""button_container"">
                        <a id=""apply"" class=""button""> Apply </a>
                    </div>

            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(3569, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3573, 259, true);
            WriteLiteral(@"            <section class=""programme_summary_wrapper"" id=""programme_summary_wrapper"">

                <div class=""programme_summary_container"">

                        <div class=""programme_button_container clear_float"">

                            ");
            EndContext();
            BeginContext(3832, 1240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d064580fab2b4b20b773741a50b95d9a", async() => {
                BeginContext(3924, 536, true);
                WriteLiteral(@"

                                <a class=""button cursor_pointer paid"" id=""alreadypaid""> Already paid ? </a>
                                <div class=""input_values_container"">

                                    <input class=""input"" type=""hidden"" id=""uploadedcvfilename"" name=""UploadedCVFileName""/>
                                    <input class=""input"" type=""hidden"" id=""ProgramIdForPaymentPass"" name=""ProgramId""/>
                                    <input class=""input"" type=""hidden"" id=""UserId"" name=""ApplicationUserId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4460, "\"", 4516, 1);
#line 90 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
WriteAttributeValue("", 4468, User.FindFirst(ClaimTypes.NameIdentifier).Value, 4468, 48, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4517, 330, true);
                WriteLiteral(@"/>
                                    <input class=""input"" type=""text"" name=""Code"" placeholder=""Enter Code"" required/>
                                    <span class=""show_on_error"" asp-valaidation-for=""Code""></span>

                                    <div class=""button_wrapper"">
                                        ");
                EndContext();
                BeginContext(4847, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eac1e8eb945a403798f21927495efc33", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4947, 118, true);
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5072, 977, true);
            WriteLiteral(@"

                           <label class=""cursor_pointer continuetoapply_container"" for=""submitapplication""> 
                               <a class=""button"" id=""continuetoapply""> Continue to make payment </a>
                            </label>

                        </div>

                        <div class="""">
                            <h3 class=""programme_summary_heading""> Programme summary </h3>

                            <div class=""image_container"">
                                <div id=""programme_summary_title"" class=""text_container"">
                                    BSC HUMAN SCIENCE
                                </div>
                            </div>

                            <div id=""programme_summary_description"" class=""description_container""> 

                                Description

                            </div>

                        </div>
                </div>

            </section>
");
            EndContext();
#line 127 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
            }

#line default
#line hidden
            BeginContext(6064, 28, true);
            WriteLiteral("    </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6109, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6115, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d2abfddefa645e5b8a61905230a5cad", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6180, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 135 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"
     if(signInManager.IsSignedIn(User)){


#line default
#line hidden
                BeginContext(6228, 4997, true);
                WriteLiteral(@"    <script> 
        
        var apply= document.getElementById('apply');
        var continuetoapply = document.getElementById('continuetoapply');
        var programme = document.getElementById('ProgrammeId');
        var programidforpaymentpass = document.getElementById('ProgramIdForPaymentPass');
        apply.onclick = function(){
            var form = document.getElementById('form');
            var programme_summary_wrapper = document.getElementById('programme_summary_wrapper');
            var programme_summary_description = document.getElementById('programme_summary_description');
            var programme_summary_title = document.getElementById('programme_summary_title');
            var selected_programme_option = programme.options[programme.selectedIndex];

            programme_summary_description.innerText = selected_programme_option.getAttribute('description');
            programme_summary_title.innerText = selected_programme_option.innerText;
            programidforpaymentp");
                WriteLiteral(@"ass.value = programme.value;

                var formData = new FormData();
                var file = document.getElementById('uploadcv');
                formData.append(""Description"", ""Uploaded CV"");
                formData.append(""IFormFile"", file.files[0]);

                if(file.files[0] == null){
                    document.getElementById('uploadcv_span').innerHTML = ""<h1> Please upload your CV </h1>"";
                    return;
                }
            
                $.ajax({
                        type: ""POST"",
                        contentType: false,
                        processData: false,
                        dataType: ""text"",
                        async:true,
                        data: formData,
                        url: baseUrl + ""en_Account/ApplyDocuments"",
                        enctype: 'multipart/form-data',
                        success: function(result){
                            localStorage.setItem('uploadedcvfilename',result);
 ");
                WriteLiteral(@"                           document.getElementById('uploadedcvfilename').value = localStorage.getItem('uploadedcvfilename');
                            form.classList.add('unactive');
                            programme_summary_wrapper.classList.add('active');
                        },
                        error: function() { 
                            alert(""Something went wrong"");
                        }
                })
            
        }


        continuetoapply.onclick = function(){

            var selected_programme_option = programme.options[programme.selectedIndex];
            continuetoapply.innerText = ""Processing..."";
            location.href = baseUrl + ""en_Payment/ProcessApplicationPayment?ProgrammeId=""+
                            programme.value + ""&UserId=""+ document.getElementById('UserId').value +
                            ""&ApplicationFee="" + selected_programme_option.getAttribute('fee') +
                            ""&ProgramFee="" + selected_progra");
                WriteLiteral(@"mme_option.getAttribute('programfee') +
                            ""&ProgramName="" + selected_programme_option.getAttribute('programname') +
                            ""&UploadedCVFileName="" + localStorage.getItem('uploadedcvfilename');
        }

        var alreadypaid = document.getElementById('alreadypaid');
        alreadypaid.onclick = function(){
            var alreadypaidform = alreadypaid.nextElementSibling;
            var height = alreadypaidform.scrollHeight;
            if(alreadypaidform.classList.contains(""active"")){
                alreadypaidform.classList.remove('active');
                for(var n=height;n>0;n--){
                    alreadypaidform.style.maxHeight = n + ""px"";
                }
            }else{
                alreadypaidform.classList.add('active');
                for(var n=0;n<height;n++){
                    alreadypaidform.style.maxHeight = n + ""px"";
                }
            }

        }



        var CertificateType = document.getEl");
                WriteLiteral(@"ementById('CertificateType');
        ChangeProgramList(CertificateType.value);
        CertificateType.onchange = function(){  
            ChangeProgramList(CertificateType.value) 
        }

        function ChangeProgramList(selected_certificate_value){

           
            for(var prog_count=0;prog_count<programme.options.length;prog_count++){
                var current_option = programme.options[prog_count];
                var selected_program_certificateid = current_option.getAttribute('certificateid');
                if(selected_program_certificateid == selected_certificate_value){
                    current_option.style.display= ""block"";
                     programme.value = selected_program_certificateid
                }else{
                    current_option.style.display= ""none"";
                }
            }
        }
        
    </script>
");
                EndContext();
#line 241 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Apply.cshtml"

    }

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bim_edu.Models.ApplyPaymentByPassCodeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
