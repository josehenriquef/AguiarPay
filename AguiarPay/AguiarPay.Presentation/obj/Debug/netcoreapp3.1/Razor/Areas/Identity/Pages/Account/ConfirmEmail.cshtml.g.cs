#pragma checksum "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f716eb2b90eeb99fdfaed868a0f41bb500fe8fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
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
#nullable restore
#line 1 "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\_ViewImports.cshtml"
using AguiarPay.Presentation.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AguiarPay.Presentation.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f716eb2b90eeb99fdfaed868a0f41bb500fe8fd5", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b325a51a9ac0f09e5972d0475033dbafd1a887e", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db83925b6f5d1e2be503cef540908b0f382d1e5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirmar email";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\wws\AguiarPay\AguiarPay\AguiarPay.Presentation\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>\r\n    Seu email foi confirmado com sucesso.\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
