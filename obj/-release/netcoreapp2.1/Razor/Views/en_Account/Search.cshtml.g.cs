#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "753c29cfcd01cb020cbe5ef9787203db5ec005fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_en_Account_Search), @"mvc.1.0.view", @"/Views/en_Account/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/en_Account/Search.cshtml", typeof(AspNetCore.Views_en_Account_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753c29cfcd01cb020cbe5ef9787203db5ec005fe", @"/Views/en_Account/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_en_Account_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bim_edu.Models.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/account/search.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
  
    Layout = "~/Views/Shared/_en_Layout.cshtml";
    ViewData["Title"] = "Login | Bim-Edu";
    List<SearchViewModel> result = ViewData["Vresult"] as List<SearchViewModel>;

#line default
#line hidden
            BeginContext(225, 104, true);
            WriteLiteral("\r\n\r\n<section class=\"entity_page clear_float\">\r\n\r\n    <div class=\"entity_page_container clear_float\">\r\n\r\n");
            EndContext();
#line 15 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
         if(result.Count() < 1){


#line default
#line hidden
            BeginContext(365, 352, true);
            WriteLiteral(@"            <figure class=""item"">
                <h3>
                    <a class=""title"">
                       SORRY! NO RESULTS FOUND
                     </a> 
                </h3>
                <p class=""description"">
                    Try using shorter and fewer words during search
                </p>

            </figure>
");
            EndContext();
#line 28 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"

        }

#line default
#line hidden
            BeginContext(730, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
         foreach(SearchViewModel item in result){

#line default
#line hidden
            BeginContext(783, 77, true);
            WriteLiteral("            <figure class=\"item\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(860, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "753c29cfcd01cb020cbe5ef9787203db5ec005fe6830", async() => {
                BeginContext(953, 25, true);
                WriteLiteral("\r\n                       ");
                EndContext();
                BeginContext(979, 10, false);
#line 35 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
                  Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(989, 23, true);
                WriteLiteral("\r\n                     ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
                                         WriteLiteral(item.Controller);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
                                                                       WriteLiteral(item.Action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1016, 113, true);
            WriteLiteral(" \r\n                </h3>\r\n                <h5 class=\"subtitle\"> Bim-Edu School Programs > \r\n                     ");
            EndContext();
            BeginContext(1130, 11, false);
#line 39 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
                Write(item.Action);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 88, true);
            WriteLiteral(" \r\n                </h5>\r\n                <p class=\"description\">\r\n                     ");
            EndContext();
            BeginContext(1230, 17, false);
#line 42 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
                Write(item.Desscription);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 49, true);
            WriteLiteral("\r\n                </p>\r\n\r\n            </figure>\r\n");
            EndContext();
#line 46 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\en_Account\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1307, 30, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1354, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1360, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "753c29cfcd01cb020cbe5ef9787203db5ec005fe11239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1426, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bim_edu.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
