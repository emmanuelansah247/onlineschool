#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_en_Student_Question), @"mvc.1.0.view", @"/Views/en_Student/Question.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/en_Student/Question.cshtml", typeof(AspNetCore.Views_en_Student_Question))]
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
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32692d40dd7b6e5fb4b591c1827ee17caa62cd3d", @"/Views/en_Student/Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_en_Student_Question : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button cursor_pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "en_Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuestionStudentProvidedSolutionAdd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("UPLOAD SELECTED FILE AS SOLUTION"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "QuestionStudentProvidedSolutionDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/student/question.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
  
    Layout = "~/Views/Shared/_en_ApprovedLayout.cshtml";
    ViewData["Title"] = "Program Questions | Bim-Edu ";
    Programme v_Program = ViewData["v_Program"] as Programme;
    List<Course> v_Courses = ViewData["v_Courses"] as List<Course>;
    

#line default
#line hidden
            BeginContext(294, 289, true);
            WriteLiteral(@"

<section class=""approved_page_wrapper"">

    <div class=""approved_page_container"">

        <h1 class=""welcome_title""> Questions And Assignment Upload Page </h1>


        <section class=""document_list_wrapper"">
            <div class=""document_list_container clear_float"">

");
            EndContext();
#line 22 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                 if(v_Program.Questions != null && v_Program.Questions.Count() > 0 ){
                    foreach(Question item in v_Program.Questions){
                        if(!item.isremoved){


#line default
#line hidden
            BeginContext(786, 311, true);
            WriteLiteral(@"                            <figure class=""item clear_float"">

                                <section class=""main_question section clear_float"">
                                    <div class=""left"">
                                        <div class=""title"">
                                            ");
            EndContext();
            BeginContext(1098, 16, false);
#line 31 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 191, true);
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    <div class=\"right\">\r\n                                        ");
            EndContext();
            BeginContext(1305, 441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d10383", async() => {
                BeginContext(1357, 90, true);
                WriteLiteral("\r\n                                            <input type=\"text\" name=\"Id\" class=\"hide_it\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1447, "\"", 1471, 1);
#line 36 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
WriteAttributeValue("", 1455, item.QuestionId, 1455, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1472, 48, true);
                WriteLiteral("/>\r\n                                            ");
                EndContext();
                BeginContext(1520, 177, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d11328", async() => {
                    BeginContext(1687, 6, true);
                    WriteLiteral(" View ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1529, "~/", 1529, 2, true);
#line 37 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 1531, GeneralStoredNames.Questions_Directory, 1531, 39, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1570, "/", 1570, 1, true);
#line 37 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 1571, item.FilePath, 1571, 14, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                BeginContext(1697, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(1746, 216, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </section>\r\n                                    \r\n                                <section class=\"student_upload section clear_float\">\r\n\r\n");
            EndContext();
#line 45 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                      
                                        int n_count = 0;
                                        string user_id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                                        QuestionStudentProvidedSolution activeQuestionStudentProvidedSolution = null;
                                        foreach(QuestionStudentProvidedSolution item_count in item.QuestionStudentProvidedSolutions){
                                            if(item_count.isremoved == false && item_count.ApplicationUserId == user_id){
                                                n_count = n_count + 1;
                                                activeQuestionStudentProvidedSolution = item_count;
                                            }
                                        }
                                    

#line default
#line hidden
            BeginContext(2846, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                     if(n_count < 1){


#line default
#line hidden
            BeginContext(2905, 126, true);
            WriteLiteral("                                            <figure class=\"top clear_float\">\r\n                                                ");
            EndContext();
            BeginContext(3031, 852, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d16699", async() => {
                BeginContext(3113, 92, true);
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"QuestionId\"");
                EndContext();
                BeginWriteAttribute("value", " \r\n                                                        value=\"", 3205, "\"", 3287, 1);
#line 62 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
WriteAttributeValue("", 3271, item.QuestionId, 3271, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3288, 102, true);
                WriteLiteral("/>\r\n                                                    <input type=\"hidden\" name=\"ApplicatioinUserId\"");
                EndContext();
                BeginWriteAttribute("value", " \r\n                                                        value=\"", 3390, "\"", 3464, 1);
#line 64 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
WriteAttributeValue("", 3456, user_id, 3456, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3465, 161, true);
                WriteLiteral("/>\r\n                                                    <input type=\"file\" class=\"input\" name=\"IFormFile\"/>\r\n                                                    ");
                EndContext();
                BeginContext(3626, 200, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d18401", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3826, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3883, 57, true);
            WriteLiteral("\r\n                                            </figure>\r\n");
            EndContext();
#line 70 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"

                                    } else{


#line default
#line hidden
            BeginContext(3989, 248, true);
            WriteLiteral("                                        <figure class=\"down\">\r\n                                            <div class=\"left\">\r\n                                                <div class=\"title\">\r\n                                                    ");
            EndContext();
            BeginContext(4238, 63, false);
#line 76 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                               Write(activeQuestionStudentProvidedSolution.ApplicationUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4301, 54, true);
            WriteLiteral("\r\n                                                    ");
            EndContext();
            BeginContext(4356, 62, false);
#line 77 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                               Write(activeQuestionStudentProvidedSolution.ApplicationUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4418, 288, true);
            WriteLiteral(@" - 
                                                    Solution
                                                </div>
                                            </div>
                                            <div class=""right"">
                                                ");
            EndContext();
            BeginContext(4706, 872, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d23243", async() => {
                BeginContext(4758, 117, true);
                WriteLiteral("\r\n\r\n                                                    <input type=\"hidden\" name=\"QuestionStudentProvidedSolutionId\"");
                EndContext();
                BeginWriteAttribute("value", " \r\n                                                        value=\"", 4875, "\"", 5013, 1);
#line 85 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
WriteAttributeValue("", 4941, activeQuestionStudentProvidedSolution.QuestionStudentProvidedSolutionId, 4941, 72, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5014, 58, true);
                WriteLiteral("/>\r\n\r\n                                                    ");
                EndContext();
                BeginContext(5072, 210, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d24344", async() => {
                    BeginContext(5272, 6, true);
                    WriteLiteral(" View ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5081, "~/", 5081, 2, true);
#line 87 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 5083, GeneralStoredNames.Questions_Directory, 5083, 39, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 5122, "/", 5122, 1, true);
#line 87 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 5123, activeQuestionStudentProvidedSolution.FilePath, 5123, 47, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
                BeginContext(5282, 56, true);
                WriteLiteral("\r\n\r\n                                                    ");
                EndContext();
                BeginContext(5338, 181, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d26674", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5519, 52, true);
                WriteLiteral("\r\n\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
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
            BeginContext(5578, 105, true);
            WriteLiteral("\r\n                                            </div>\r\n                                        </figure>\r\n");
            EndContext();
#line 96 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"

                                    }

#line default
#line hidden
            BeginContext(5724, 48, true);
            WriteLiteral("\r\n                                </section>\r\n\r\n");
            EndContext();
#line 101 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                     if(activeQuestionStudentProvidedSolution != null){
                                        

#line default
#line hidden
#line 102 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                         foreach(QuestionLecturerEvaluateStudentSolution activeQuestionLecturerEvaluateStudentSolution 
                                                    in activeQuestionStudentProvidedSolution.QuestionLecturerEvaluateStudentSolutions){
                                            

#line default
#line hidden
#line 104 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                             if(activeQuestionLecturerEvaluateStudentSolution.isremoved == false){

#line default
#line hidden
            BeginContext(6251, 575, true);
            WriteLiteral(@"                                            <section class=""lecturer_upload section clear_float"">
                                                <div class=""left"">
                                                    <div class=""title"">
                                                        Lecturer Evaluation Of Your Solution
                                                    </div>
                                                </div>
                                                <div class=""right"">
                                                        ");
            EndContext();
            BeginContext(6826, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d31715", async() => {
                BeginContext(7038, 6, true);
                WriteLiteral(" View ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6835, "~/", 6835, 2, true);
#line 112 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 6837, GeneralStoredNames.Questions_Directory, 6837, 39, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 6876, "/", 6876, 1, true);
#line 112 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
AddHtmlAttributeValue("", 6877, activeQuestionLecturerEvaluateStudentSolution.FilePath, 6877, 55, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7048, 150, true);
            WriteLiteral("\r\n                                                </div>                                    \r\n                                            </section>\r\n");
            EndContext();
#line 116 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                            }

#line default
#line hidden
#line 116 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                             

                                        }

#line default
#line hidden
#line 118 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                                         
                                }

#line default
#line hidden
            BeginContext(7325, 41, true);
            WriteLiteral("\r\n                            </figure>\r\n");
            EndContext();
#line 122 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Student\Question.cshtml"
                         }
                    }
                }

#line default
#line hidden
            BeginContext(7436, 72, true);
            WriteLiteral("\r\n            </div>\r\n        </section>\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7525, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7531, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32692d40dd7b6e5fb4b591c1827ee17caa62cd3d35320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7599, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
