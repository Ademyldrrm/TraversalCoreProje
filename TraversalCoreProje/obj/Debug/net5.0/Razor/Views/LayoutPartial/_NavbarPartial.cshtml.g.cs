#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\LayoutPartial\_NavbarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e1a3a5f8ff1ca8de055206cf75e070a28c10ece89dd19340c5c1e3213f532a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__NavbarPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e1a3a5f8ff1ca8de055206cf75e070a28c10ece89dd19340c5c1e3213f532a67", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"51ae1d7dabbd56ee502a5769309aa88bb50a01c4e2c06bd0855f386a0a09c0fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header id=""site-header"" class=""fixed-top"">
    <div class=""container"">
        <nav class=""navbar navbar-expand-lg stroke"">
            <h1>
                <a class=""navbar-brand mr-lg-5"" href=""/Default/Index/"">
                    Traversal
                </a>
            </h1>
            <!-- if logo is image enable this
            <a class=""navbar-brand"" href=""#index.html"">
                <img src=""image-path"" alt=""Your logo"" title=""Your logo"" style=""height:35px;"" />
            </a> -->
            <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse""
                    data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
                <span class=""navbar-toggler-icon fa icon-close fa-times""></span>
            </button>

            <div class=""collapse navbar-collapse"" ");
            WriteLiteral(@"id=""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Default/Index/"">Ana Sayfa <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""about.html"">Hakkımızda</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Destination/Index/"">Rotalar</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Guide/Index/"">Rehberlerimiz</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Contact/Index/"">İletişim</a>
                    </li>

                </ul>
            </div>
            <div class=""d-lg-block d-none"">
                <a href=""contact.html"" class=""btn btn-style ");
            WriteLiteral(@"btn-secondary"">Rezervasyon Yap</a>
            </div>
            <!-- toggle switch for light and dark theme -->
            <div class=""mobile-position"">
                <nav class=""navigation"">
                    <div class=""theme-switch-wrapper"">
                        <label class=""theme-switch"" for=""checkbox"">
                            <input type=""checkbox"" id=""checkbox"">
                            <div class=""mode-container"">
                                <i class=""gg-sun""></i>
                                <i class=""gg-moon""></i>
                            </div>
                        </label>
                    </div>
                </nav>
            </div>
            <!-- //toggle switch for light and dark theme -->
        </nav>
    </div>
</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
