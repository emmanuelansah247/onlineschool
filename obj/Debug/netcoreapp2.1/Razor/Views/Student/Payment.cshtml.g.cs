#pragma checksum "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dab2b07ae924f3882f30927a5e688887879b04a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Payment), @"mvc.1.0.view", @"/Views/Student/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Payment.cshtml", typeof(AspNetCore.Views_Student_Payment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dab2b07ae924f3882f30927a5e688887879b04a", @"/Views/Student/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffce18d423ce8e12750d9aa6ceef67e722d82c34", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/internal/student/payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
  
    Layout = "~/Views/Shared/_ApprovedLayout.cshtml";
    ViewData["Title"] = "Payment | Bim-Edu ";
    ApplicationUser user = ViewData[GeneralStoredNames.Bim_Edu_Application_User] as ApplicationUser;
    ProgrammeApplication activeProgrammeApplication = ViewData[GeneralStoredNames.Bim_Edu_Active_Programme_Application] as ProgrammeApplication;
    

#line default
#line hidden
            BeginContext(365, 827, true);
            WriteLiteral(@"

<section class=""approved_page_wrapper"">
    
    <div class=""approved_page_container"">

            <div class=""payment_intro"">
                <h2 class=""payment_title""> PAIEMENTS DUS </h2>
                <p class=""payment_description""> 

                    Bim-­‐Edu Institute Of Management est une institution qui promeut l’accès à un enseignement supérieur de 
                    qualité et à moindres cout. Afin de s’inscrire dans la durabilité, nous facturons des frais minimes. 
                    Pour toute question	ou information supplémentaire,contactez 

                    <a class=""change_color"" href=""mailto:registrar@bim-edu.us"">
                        payments@bim-edu.us
                    </a>
                </p>
            </div>

            <div class=""payments_table"">

");
            EndContext();
#line 31 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
             foreach(StudentFeeToPay studentFeeToPay in activeProgrammeApplication.StudentFeesToPay){


#line default
#line hidden
            BeginContext(1297, 465, true);
            WriteLiteral(@"                <table class=""table"">
                    <tr class=""heading"">
                        <td> Date de création </td>
                        <td> Nature de la transaction </td>
                        <td> Item </td>
                        <td> Montant total  </td>
                        <td> Montant versé  </td>
                    </tr>
                    <tr class=""values"">
                        <td> 
                            ");
            EndContext();
            BeginContext(1763, 29, false);
#line 43 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                       Write(studentFeeToPay.DateInitiated);

#line default
#line hidden
            EndContext();
            BeginContext(1792, 93, true);
            WriteLiteral(" \r\n                        </td>\r\n                        <td> \r\n                            ");
            EndContext();
            BeginContext(1886, 20, false);
#line 46 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                       Write(studentFeeToPay.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1906, 93, true);
            WriteLiteral(" \r\n                        </td>\r\n                        <td> \r\n                            ");
            EndContext();
            BeginContext(2000, 41, false);
#line 49 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                       Write(activeProgrammeApplication.Programme.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 95, true);
            WriteLiteral(" \r\n                        </td>\r\n                        <td> \r\n                            $ ");
            EndContext();
            BeginContext(2137, 22, false);
#line 52 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                         Write(studentFeeToPay.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2159, 95, true);
            WriteLiteral(" \r\n                        </td>\r\n                        <td> \r\n                            $ ");
            EndContext();
            BeginContext(2255, 20, false);
#line 55 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                         Write(studentFeeToPay.Paid);

#line default
#line hidden
            EndContext();
            BeginContext(2275, 89, true);
            WriteLiteral(" \r\n                        </td>\r\n                    </tr>\r\n\r\n                </table>\r\n");
            EndContext();
#line 60 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                 if(studentFeeToPay.Amount > studentFeeToPay.Paid){
                    var amountowing = studentFeeToPay.Amount - studentFeeToPay.Paid;

#line default
#line hidden
            BeginContext(2519, 120, true);
            WriteLiteral("                    <div class=\"button_container clear_float\">\r\n                        <input class=\"input\" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", "  value=\"", 2639, "\"", 2660, 1);
#line 63 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
WriteAttributeValue("", 2648, amountowing, 2648, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2661, 192, true);
            WriteLiteral("/>\r\n                        <label class=\"label\"> Entrez le montant à payer </label>\r\n                        <div class=\"makepayment_container clear_floating\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("studentfeetopayid", " studentfeetopayid=\"", 2853, "\"", 2907, 1);
#line 66 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
WriteAttributeValue("", 2873, studentFeeToPay.StudentFeeToPayId, 2873, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\"", 2908, "\"", 2936, 1);
#line 66 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
WriteAttributeValue("", 2915, studentFeeToPay.Type, 2915, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("amountowing", " amountowing=\"", 2937, "\"", 2963, 1);
#line 66 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
WriteAttributeValue("", 2951, amountowing, 2951, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2964, 159, true);
            WriteLiteral(" \r\n                            class=\"button cursor_pointer makepayment\"> Faire un paiement  </a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 70 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                }

#line default
#line hidden
#line 70 "C:\Users\pc\Desktop\Lehn\bim-edu-project\Views\Student\Payment.cshtml"
                 

                }

#line default
#line hidden
            BeginContext(3163, 50, true);
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3230, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3238, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3dab2b07ae924f3882f30927a5e688887879b04a11608", async() => {
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
                BeginContext(3305, 3199, true);
                WriteLiteral(@"

    <script> 
        var makepayments = document.getElementsByClassName('makepayment');

        for(var counter=0;counter<makepayments.length;counter++){
            var makepayment = makepayments[counter];
            makepayment.onclick = function(e){
                var Id = e.target.getAttribute('studentfeetopayid');
                var Name = e.target.getAttribute('type');
                var Amount = Number.parseFloat(e.target.parentNode.previousElementSibling.previousElementSibling.value);
                if(Amount > Number.parseFloat(e.target.getAttribute('amountowing'))){
                    alert(""Amount entered is more than what you are owing"");
                }else{
                    e.target.innerText = ""Rediriger..."";
                    ProcessPayment(Id,Name,Amount,e);
                }
                
                
            }
        }

        function ProcessPayment(Id,Name,Amount,e){
            _Id = Id;
            _Name = Name;
            _Amount ");
                WriteLiteral(@"= Amount;

            localStorage.setItem('paypaltotalamount',_Amount);
            var getCredentials = $.ajax({
                type: ""GET"",
                url: baseUrl + ""Payment/GetPaymentCredentials"",
                dataType: ""json"",
                success: function(credentials){
                    var param =  {
                        RunEnvironment: credentials.runEnvironment,
                        ClientId: credentials.clientId,
                        ClientSecret: credentials.clientSecret,
                        returnUrl: baseUrl + credentials.oldStudentPaymentSuccessUrl + ""?totalAmount="" + _Amount,
                        cancelUrl: baseUrl + credentials.oldStudentPaymentCancelUrl,
                        name: _Name,
                        sku: _Id,
                        price:_Amount
                    };

                    var getPaymentLink = $.ajax({
                            type: ""POST"",
                            url: credentials.accessTokenUrl,
   ");
                WriteLiteral(@"                         data: param,
                            dataType: ""text"",
                            success: function(request_feedback){
                                if(request_feedback != null){
                                    location.href = request_feedback;
                                }else{
                                    console.log(""Getting url for payment failed"",request_feedback);
                                    e.target.innerHTML = ""Procesing failed"";
                                }
                            },
                            error: function(error) { 
                                console.log(""Error occured whiles getting url for payment"",error.responseText);
                                    e.target.innerHTML = ""An error occured"";
                            }
                        });
                },
                error: function() { 
                    e.target.innerHTML = ""Error"";
                    console.log(""Fail");
                WriteLiteral("ure getting payment credentials from asp.net failure\");\r\n                }\r\n        });\r\n\r\n        }\r\n        \r\n    </script>\r\n");
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
