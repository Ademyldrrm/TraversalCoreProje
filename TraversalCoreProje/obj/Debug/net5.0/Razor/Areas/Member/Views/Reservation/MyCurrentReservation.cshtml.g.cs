#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0cac2e79fcde6ed76d2992775a7147f3f816b31ec8248bddac7758b00ebc962d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyCurrentReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
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
#line 1 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0cac2e79fcde6ed76d2992775a7147f3f816b31ec8248bddac7758b00ebc962d", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a2f149ca4a9944edb17b61a98a84eb4808e3df359f07471e1c05de7d2a7f5e76", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyCurrentReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
  
    ViewData["Title"] = "MyCurrentReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aktif Rezervasyonlarım</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Reservasyon Tarihi</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591