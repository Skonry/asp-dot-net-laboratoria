#pragma checksum "C:\Users\Wojtek\Source\Repos\asp-dot-net-laboratoria\Views\Products\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185d358b527bdca7329f958f0f349a01d5526d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Add), @"mvc.1.0.view", @"/Views/Products/Add.cshtml")]
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
#line 1 "C:\Users\Wojtek\Source\Repos\asp-dot-net-laboratoria\Views\_ViewImports.cshtml"
using lab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wojtek\Source\Repos\asp-dot-net-laboratoria\Views\_ViewImports.cshtml"
using lab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"185d358b527bdca7329f958f0f349a01d5526d6a", @"/Views/Products/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e3f5c0494a08bb020928239a815887d5c419a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsStatsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Item Added!!!</h1>\r\n<div>Name length: ");
#nullable restore
#line 4 "C:\Users\Wojtek\Source\Repos\asp-dot-net-laboratoria\Views\Products\Add.cshtml"
             Write(Model.NameLength);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsStatsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
