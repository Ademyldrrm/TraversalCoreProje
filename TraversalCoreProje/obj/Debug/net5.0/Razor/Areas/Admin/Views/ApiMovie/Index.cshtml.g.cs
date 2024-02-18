#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c0f0cd2309cf83d47c20b7d3a3b6069b414ba4658c1e8ffc2f58838f7272c2be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiMovie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c0f0cd2309cf83d47c20b7d3a3b6069b414ba4658c1e8ffc2f58838f7272c2be", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"52d8df8437a46379581910ee0bc86a75d753e0e5b17f1a7278d2fd868a00bc95", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiMovie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApiMovieViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Top 100 Imdb Listeleme</h1>\r\n\r\n<table class=\"table tabl-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Film Adı</th>\r\n        <th>Imdb Puanı</th>\r\n        <th>Yapım yılı</th>\r\n        <th>Resim</th>\r\n        <th>Fragman</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 21 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
           Write(item.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
           Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
           Write(item.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
           Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 582, "\"", 599, 1);
#nullable restore
#line 25 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 588, item.image, 588, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:50px; width:50px;\"></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 659, "\"", 681, 1);
#nullable restore
#line 26 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 666, item.imdb_link, 666, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Fragmanı izle</a></td>\r\n        </tr>\n");
#nullable restore
#line 28 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApiMovieViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
