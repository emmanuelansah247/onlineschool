#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a72d88e78a1b556d74aefb429833b0f1250d8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Foundation), @"mvc.1.0.view", @"/Views/Student/Foundation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Foundation.cshtml", typeof(AspNetCore.Views_Student_Foundation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a72d88e78a1b556d74aefb429833b0f1250d8c", @"/Views/Student/Foundation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Foundation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.UploadedDocumentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ApplicationUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("IFormFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IFormFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadStudentDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("upload_box"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUploadedDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button cursor_pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString(" Remove "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/student/foundation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
  
    Layout = "~/Views/Shared/_ApprovedLayout.cshtml";
    ViewData["Title"] = "Foundation Bim-Edu Student";
    var documents = datacontext.UploadedDocuments.ToList();
    ApplicationUser user = ViewData[GeneralStoredNames.Bim_Edu_Application_User] as ApplicationUser;
    ProgrammeApplication activeProgrammeApplication = ViewData[GeneralStoredNames.Bim_Edu_Active_Programme_Application] as ProgrammeApplication;


#line default
#line hidden
            BeginContext(552, 2319, true);
            WriteLiteral(@"

<section class=""approved_page_wrapper"">

    <div class=""approved_page_container"">
            <h2 class=""welcome_title""> Évaluation des fondamentaux  </h2>

            <figure class=""desciption_wrapper spacious"">
                <p class=""main_description"">
                    Sur cette page, vous trouverez des informations sur votre progression dans	le respect 
                    des exigences pour devenir un étudiant en quête de diplôme. 
                </p>

                <p class=""sub_description"">
                    Les étudiants qui suivent les cours de Fondements de Bim-­Edu sont tenus de:
                </p>
                <div class=""description_list"">
                    <div class=""list_item"">
                        <span class=""number"">1.</span>
                        Envoyer leurs documents	d'admission 
                    </div>
                    <div class=""list_item"">
                        <span class=""number"">2.</span>
                        Avoir une ");
            WriteLiteral(@"moyenne cumulative de 12,00/20 au minimum dans chacun des deux premiers cours ou alors vous serrez autorisé à suivre à 
                        nouveau jusqu'à trois autres cours pour pouvoir obtenir une moyenne de 12,00/20 ou plus.	
                        
                    </div>
                </div>

                <p class=""sub_description"">
                    Les étudiants qui suivent les cours de Fondements de Bim-­‐Edu	sont tenus de: 
                </p>
                <div class=""description_list"">
                    <div class=""list_item"">
                        <span class=""number"">1.</span>
                        Envoyer leurs documents d'admission 
                    </div>
                    <div class=""list_item"">
                        <span class=""number"">2.</span>
                        Avoir une moyenne cumulative de 14,00/20	dans chacun des trois premiers cours ou alors vous serrez autorises à 
                        suivre à nouveau un cours supplémentaire");
            WriteLiteral(@" afin d’obtenir une	 moyenne de 14,00/20.
                    </div>
                </div>

            </figure>

            <figure class=""program_wrapper spacious"">
                Votre admission pour étudier en 
                <span class=""change_color""> ");
            EndContext();
            BeginContext(2872, 55, false);
#line 60 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                       Write(activeProgrammeApplication.Programme.Certification.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2927, 21, true);
            WriteLiteral("\r\n                en ");
            EndContext();
            BeginContext(2949, 41, false);
#line 61 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
              Write(activeProgrammeApplication.Programme.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2990, 1159, true);
            WriteLiteral(@" dépend
                </span>   
                de votre réussite comme 
                <span class=""change_color""> étudiant dans les cours non diplômant. </span>
                 Ci-­‐dessous, vous pourrez lire des informations	détaillées sur votre statut. 
                Veuillez contacter votre conseiller d’admission si vous avez d'autres questions. 
            </figure>

            <figure class=""upload_documents spacious"">
                <h2 class=""title""> <span class=""number"">1</span> TELEVERSEZ VOS DOCUMENTS DE CANDIDATURE </h2>
                <p class=""details""> 
                    Vous devez téléverser ici votre diplôme d'études secondaires ou tout autre diplôme en 
                    fonction de votre niveau d’étude, vos relevés de notes en Anglais, en Français ou en Espagnol (avec la date	d'obtention du diplôme). 
                    Les diplômes et les relevés de notes qui ne sont pas dans l’une des langues citées plus haut doivent être soumis avec 
                    une");
            WriteLiteral(" traduction officielle notariée.\r\n                </p>\r\n\r\n                <div class=\"stand_out clear_float\">\r\n                        ");
            EndContext();
            BeginContext(4149, 1322, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a72d88e78a1b556d74aefb429833b0f1250d8c14614", async() => {
                BeginContext(4247, 719, true);
                WriteLiteral(@"
                            <div class=""top clear_float"">
                                <div class=""left_side""> <label class=""button cursor_pointer"" for=""IFormFile""> Choisir le fichier </label> </div>
                                <div class=""right_side""> <label class=""button cursor_pointer"" for=""Upload""> Téléverser  </label> </div>
                            </div>
                            <div class=""bottom"">
                                <textarea rows=""10"" class=""add_comments"" id=""FileName"" name=""Description"" placeholder=""Nom de fichier ""></textarea>
                            </div>
                            <div class=""hide_it"">
                                <input  type=""hidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4966, "\"", 5024, 1);
#line 88 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
WriteAttributeValue("", 4974, activeProgrammeApplication.ProgrammeApplicationId, 4974, 50, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5025, 67, true);
                WriteLiteral(" name=\"ProgrammeApplicationId\" />\r\n                                ");
                EndContext();
                BeginContext(5092, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03a72d88e78a1b556d74aefb429833b0f1250d8c16266", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 89 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ApplicationUserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                WriteLiteral("_Name_ ");
#line 89 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                                                      WriteLiteral(user.FirstName);

#line default
#line hidden
                WriteLiteral(" _ ");
#line 89 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                                                                        WriteLiteral(user.LastName);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5203, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5237, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03a72d88e78a1b556d74aefb429833b0f1250d8c19101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 90 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IFormFile);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5299, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5333, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03a72d88e78a1b556d74aefb429833b0f1250d8c21028", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5402, 62, true);
                WriteLiteral("\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5471, 185, true);
            WriteLiteral("\r\n                        <div class=\"files_table\">\r\n                            <h3 class=\"files_title\"> Fichiers téléversés  </h3>\r\n                            <table class=\"table\">\r\n");
            EndContext();
#line 97 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                 foreach(UploadedDocument UploadedDocument in activeProgrammeApplication.UploadedDocuments){
                                    var description = UploadedDocument.Description;
                                    if(description.Length > 50){
                                      description = description.Substring(0,49) + "...";
                                    }

#line default
#line hidden
            BeginContext(6062, 74, true);
            WriteLiteral("                                <tr>\r\n                                    ");
            EndContext();
            BeginContext(6136, 551, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a72d88e78a1b556d74aefb429833b0f1250d8c25025", async() => {
                BeginContext(6228, 64, true);
                WriteLiteral("\r\n                                        <td class=\"filename\"> ");
                EndContext();
                BeginContext(6293, 11, false);
#line 104 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                                         Write(description);

#line default
#line hidden
                EndContext();
                BeginContext(6304, 102, true);
                WriteLiteral("  </td>\r\n                                        <td class=\"hide_it\"> <input name=\"UploadedDocumentId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6406, "\"", 6450, 1);
#line 105 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
WriteAttributeValue("", 6414, UploadedDocument.UploadedDocumentId, 6414, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6451, 80, true);
                WriteLiteral("/> </td>\r\n                                        <td class=\"button_container\"> ");
                EndContext();
                BeginContext(6531, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03a72d88e78a1b556d74aefb429833b0f1250d8c26490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
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
                BeginContext(6636, 44, true);
                WriteLiteral(" </td>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6687, 41, true);
            WriteLiteral("\r\n                                </tr>\r\n");
            EndContext();
#line 109 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Foundation.cshtml"
                                }

#line default
#line hidden
            BeginContext(6763, 785, true);
            WriteLiteral(@"                            </table>
                        </div>
                </div>
                <p class=""sub_details"">

                   Vous	pouvez téléverser jusqu'à 3 documents. Chaque document doit faire 20 Mo ou moins. Nous	ne pouvons accepter que les formats PNG, 
                   JPG, GIF,PDF, XLS, DOCX ou XLSX.
                </p>

            </figure>

            <figure class=""meet_criteria spacious"">
                <h2 class=""title""> <span class=""number"">2</span> REMPLIR LES CRITÈRES ACADÉMIQUES  </h2>
                <p class=""details"">
                    Vos notes seront évaluées une fois que vous aurez soumis tous vos documents, comme	requis ci-­‐dessus
                </p>
            </figure>
    </div>

</section>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7565, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(7571, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03a72d88e78a1b556d74aefb429833b0f1250d8c30933", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7641, 370, true);
                WriteLiteral(@"

    <Script>
      var FileName = document.getElementById('FileName');
      var IFormFile = document.getElementById('IFormFile');
      IFormFile.onchange = function(){
          filepath_with_extension = IFormFile.value.split('\\')[2];
          filename = filepath_with_extension.split('.')[0];
          FileName.value = filename;
      }
    </Script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public bim_edu.DataContect.Controllers.BimEduDataContext datacontext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bim_edu.Models.UploadedDocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
