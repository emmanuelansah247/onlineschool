#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8ea52748b1f40c798331b5f723c476ae5c138c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_AdminStudent), @"mvc.1.0.view", @"/Views/Administration/AdminStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/AdminStudent.cshtml", typeof(AspNetCore.Views_Administration_AdminStudent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8ea52748b1f40c798331b5f723c476ae5c138c", @"/Views/Administration/AdminStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_AdminStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.ProgramDocumentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("file"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/administration/adminapproval.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    ViewData["Title"] = "Bim-Edu Students | Admin ";
    List<ApplicationUser> vStudents = ViewData["vStudents"] as List<ApplicationUser>;
    

#line default
#line hidden
            BeginContext(254, 263, true);
            WriteLiteral(@"

<section class=""admin_page_wrapper"">

    <div class=""admin_page_container"">

        <h1 class=""admin_page_title"" > Bim-Edu Students </h1>

        <div class=""applications_wrapper"">
            <div class=""applications_container"">
                
");
            EndContext();
#line 19 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
            foreach(ApplicationUser appuser in vStudents){
               

#line default
#line hidden
#line 20 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                foreach(ProgrammeApplication progapp in appuser.ProgrammeApplications){
                   

#line default
#line hidden
#line 21 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                    if(progapp.isApproved == true){


#line default
#line hidden
            BeginContext(721, 140, true);
            WriteLiteral("                <figure class=\"application\">\r\n                        <div class=\"user_name_and_program_name\">\r\n                            ");
            EndContext();
            BeginContext(862, 17, false);
#line 25 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                       Write(appuser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(879, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(882, 16, false);
#line 25 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                                           Write(appuser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(898, 95, true);
            WriteLiteral(" - \r\n                            <span class=\"program_name\"> \r\n                                ");
            EndContext();
            BeginContext(994, 22, false);
#line 27 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                           Write(progapp.Programme.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1016, 97, true);
            WriteLiteral(" \r\n                            </span> \r\n                        </div>\r\n                        ");
            EndContext();
            BeginContext(1113, 928, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "039e2a9766a0462e9d37645d000d46bb", async() => {
                BeginContext(1169, 247, true);
                WriteLiteral("\r\n                            <div class=\"button_container clear_float\">\r\n                                <a class=\"button cursor_pointer viewfiles\"> View Files </a>\r\n                                <input type=\"hidden\" name=\"PorgramApplicationId\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 1416, "", 1455, 1);
#line 33 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
WriteAttributeValue("", 1424, progapp.ProgrammeApplicationId, 1424, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1455, 82, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"ApplicationUserId\"");
                EndContext();
                BeginWriteAttribute("value", "  value=", 1537, "", 1556, 1);
#line 34 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
WriteAttributeValue("", 1545, appuser.Id, 1545, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1556, 114, true);
                WriteLiteral(" />\r\n                            </div>\r\n\r\n                            <div class=\"files_displayed_container\">\r\n\r\n");
                EndContext();
#line 39 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                             foreach(UploadedDocument progdoc in progapp.UploadedDocuments){

#line default
#line hidden
                BeginContext(1764, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1796, 110, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33139ff3c03140dda08674831bc0ffd7", async() => {
                    BeginContext(1880, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1882, 19, false);
#line 40 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                                                                                                                Write(progdoc.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(1901, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1818, "~/images/uploadeddocuments/", 1818, 27, true);
#line 40 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
AddHtmlAttributeValue("", 1845, progdoc.FilePath, 1845, 17, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1906, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                             }

#line default
#line hidden
                BeginContext(1940, 94, true);
                WriteLiteral("                                \r\n                            </div>\r\n                        ");
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
            BeginContext(2041, 29, true);
            WriteLiteral("\r\n                </figure>\r\n");
            EndContext();
#line 46 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                   }

#line default
#line hidden
#line 46 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                    
                }

#line default
#line hidden
#line 47 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Administration\AdminStudent.cshtml"
                 
               }

#line default
#line hidden
            BeginContext(2129, 54, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2200, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2206, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5918f756257a42dc9a2808ae21f69295", async() => {
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
                BeginContext(2286, 914, true);
                WriteLiteral(@"

    <script>
        var viewfiles = document.getElementsByClassName('viewfiles');
        for(counter=0;counter<viewfiles.length;counter++){
            var viewfile = viewfiles[counter];
            viewfile.onclick = function(e){
                var sliding_div = e.target.parentElement.nextElementSibling;
                var height = sliding_div.scrollHeight;
                if(sliding_div.classList.contains(""active"")){
                    sliding_div.classList.remove('active');
                    for(var n=height;n>0;n--){
                        sliding_div.style.maxHeight = n + ""px"";
                    }
                }else{
                    sliding_div.classList.add('active');
                    for(var n=0;n<height;n++){
                        sliding_div.style.maxHeight = n + ""px"";
                    }
                }
            }
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bim_edu.Models.ProgramDocumentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591