#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6f5ad145d7e07762030ddf60f3fecdee648c46c9875dcb5d2869c3f98759a760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiExchange_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
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
#line 1 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DtoLayer.Dtos.Announcement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6f5ad145d7e07762030ddf60f3fecdee648c46c9875dcb5d2869c3f98759a760", @"/Areas/Admin/Views/ApiExchange/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"52d8df8437a46379581910ee0bc86a75d753e0e5b17f1a7278d2fd868a00bc95", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiExchange_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingExhangeViewModel.Exchange_Rates>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table tabl-bordered\">\r\n    <tr>\r\n        <th>Kur Adı</th>      \r\n        <th>kur Oranı</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n          <td>");
#nullable restore
#line 17 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
         Write(item.currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 18 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
         Write(item.exchange_rate_buy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiExchange\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingExhangeViewModel.Exchange_Rates>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
