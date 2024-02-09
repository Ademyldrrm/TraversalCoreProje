#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "336713fe059d86a2ccbcc9abc6c35a08e09983448285742da711ea299f981e12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"336713fe059d86a2ccbcc9abc6c35a08e09983448285742da711ea299f981e12", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a2f149ca4a9944edb17b61a98a84eb4808e3df359f07471e1c05de7d2a7f5e76", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img{
        border-radius:50%;
    }
</style>

<h1>Rehber Listesi</h1>

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Görsel</th>
        <th>Ad Soyad</th>
        <th>Açıklama</th>
        <th>Durum</th>
        <th>Düzenle</th>
    </tr>
");
#nullable restore
#line 25 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 534, "\"", 551, 1);
#nullable restore
#line 30 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 540, item.Image, 540, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" /></td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
   Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
#nullable restore
#line 35 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
      
        if (item.Status == true)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 724, "\"", 771, 2);
            WriteAttributeValue("", 731, "/Admin/Guide/ChangeToFalse/", 731, 27, true);
#nullable restore
#line 38 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 758, item.GuideId, 758, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 39 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 879, "\"", 925, 2);
            WriteAttributeValue("", 886, "/Admin/Guide/ChangeToTrue/", 886, 26, true);
#nullable restore
#line 42 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 912, item.GuideId, 912, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap</a></td>\r\n");
#nullable restore
#line 43 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1049, 2);
            WriteAttributeValue("", 1013, "/Admin/Guide/EditGuide/", 1013, 23, true);
#nullable restore
#line 46 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1036, item.GuideId, 1036, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 48 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Girişi</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591