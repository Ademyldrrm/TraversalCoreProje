#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformationPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "27d170d0efe97df58ecd1b24c4f6d54d1d080d2036023144d0608c0d66730f6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ProfileInformationPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ProfileInformationPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"27d170d0efe97df58ecd1b24c4f6d54d1d080d2036023144d0608c0d66730f6a", @"/Views/Shared/Components/_ProfileInformationPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"51ae1d7dabbd56ee502a5769309aa88bb50a01c4e2c06bd0855f386a0a09c0fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ProfileInformationPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-12 col-xl-4"">
    <div class=""card h-100"">
        <div class=""card-header pb-0 p-3"">
            <div class=""row"">
                <div class=""col-md-8 d-flex align-items-center"">
                    <h6 class=""mb-0"">Profif Bilgileri</h6>
                </div>
                <div class=""col-md-4 text-end"">
                    <a href=""/Member/Profile/Index"">
                        <i class=""fas fa-user-edit text-secondary text-sm"" data-bs-toggle=""tooltip"" data-bs-placement=""top"" title=""Edit Profile""></i>
                    </a>
                </div>
            </div>
            
        </div>
        <div class=""card-body p-3"">
            <p class=""text-sm"">
                Traversal Rezervasyon üye paneline hoş geldiniz sol tarafta bulunan menülerden işlemlerinizi görebilirsiniz
            </p>
            <hr class=""horizontal gray-light my-4"">
            <ul class=""list-group"">
                <li class=""list-group-item border-0 ps-0 pt-0 text-sm""><strong cl");
            WriteLiteral("ass=\"text-dark\">Ad soyad:</strong>");
#nullable restore
#line 22 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformationPartial\Default.cshtml"
                                                                                                              Write(ViewBag.membername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Telefon:</strong>");
#nullable restore
#line 23 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformationPartial\Default.cshtml"
                                                                                                        Write(ViewBag.memberphone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item border-0 ps-0 text-sm\"><strong class=\"text-dark\">Email:</strong>");
#nullable restore
#line 24 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_ProfileInformationPartial\Default.cshtml"
                                                                                                      Write(ViewBag.mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                <li class=""list-group-item border-0 ps-0 text-sm""><strong class=""text-dark"">Konum:</strong> &nbsp; Türkiye</li>
                <li class=""list-group-item border-0 ps-0 pb-0"">
                    <strong class=""text-dark text-sm"">Soyal Medya:</strong> &nbsp;
                    <a class=""btn btn-facebook btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-facebook fa-lg""></i>
                    </a>
                    <a class=""btn btn-twitter btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-twitter fa-lg""></i>
                    </a>
                    <a class=""btn btn-instagram btn-simple mb-0 ps-1 pe-2 py-0"" href=""javascript:;"">
                        <i class=""fab fa-instagram fa-lg""></i>
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>");
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