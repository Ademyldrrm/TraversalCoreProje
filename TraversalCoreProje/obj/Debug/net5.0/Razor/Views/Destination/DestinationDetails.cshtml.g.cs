#pragma checksum "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e9f197fa81ebdd99679be7b61efd31596ace9e3a302caa3da710aaebf74342f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destination_DestinationDetails), @"mvc.1.0.view", @"/Views/Destination/DestinationDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e9f197fa81ebdd99679be7b61efd31596ace9e3a302caa3da710aaebf74342f1", @"/Views/Destination/DestinationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"51ae1d7dabbd56ee502a5769309aa88bb50a01c4e2c06bd0855f386a0a09c0fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Destination_DestinationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Destination>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/images/c1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Liberty/assets/images/c3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
  
    ViewData["Title"] = "DestinationDetails";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9f197fa81ebdd99679be7b61efd31596ace9e3a302caa3da710aaebf74342f15612", async() => {
                WriteLiteral(@"

  <section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
      <div class=""container"">
        <h2 class=""title"">Tur Detayları</h2>
        <ul class=""breadcrumbs-custom-path mt-2"">
          <li><a href=""/Default/Index"">Ana Sayfa</a></li>
          <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span>Rehberin  Yorumları</li>
        </ul>
      </div>
    </div>
  </section>

  <div class=""py-5 w3l-homeblock1 text-center"">
    <div class=""container mt-md-3"">
            <h3 class=""blog-desc-big text-center mb-4"">
                Alanında en yetkin rehberlerimizle
                en güncel seyahat hikayelerimizi okumalısınız!
            </h3>
        <div class=""blog-post-align"">
            <div class=""blog-post-img"">
                    <a href=""#"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9f197fa81ebdd99679be7b61efd31596ace9e3a302caa3da710aaebf74342f16795", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"blog-post-info\">\r\n                <div class=\"author align-items-center mb-1\">\r\n                    <a href=\"#\">");
#nullable restore
#line 36 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                           Write(Model.Guide.NameSurname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a> in <a href=""#url"">Traversal</a>
                </div>
                <ul class=""blog-meta"">
                    <li class=""meta-item blog-lesson"">
                        <span class=""meta-value""> June 13, 2020 </span>
                    </li>
                    <li class=""meta-item blog-students"">
                        <span class=""meta-value""> 6min read</span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<section class=""blog-post-main w3l-homeblock1"">
    <!--/blog-post-->
    <div class=""blog-content-inf pb-5"">
        <div class=""container pb-lg-4"">
            <div class=""single-post-image"">
                <div class=""post-content"">
                        <img");
                BeginWriteAttribute("src", " src=\"", 2105, "\"", 2128, 1);
#nullable restore
#line 56 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 2111, Model.CoverImage, 2111, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:1170px;height:500px\" class=\"radius-image img-fluid mb-5\"");
                BeginWriteAttribute("alt", " alt=\"", 2199, "\"", 2205, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"single-post-content\">\r\n                <p class=\"alphabet mb-4\"><span class=\"big-letter\">A</span>");
#nullable restore
#line 60 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                                                                     Write(Model.Details1);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </p>
                
                <blockquote class=""blockquote my-5"">
                    <div class=""icon-quote""><span class=""fa fa-quote-left"" aria-hidden=""true""></span></div>
                    Gezi Tur Seyahat Rotalar
                    <footer class=""blockquote-footer mt-3"">
                        Smith lara</footer>
                </blockquote>
                <h3 class=""blog-desc-big m-0 mb-4"">Excepteur sint occaecat non proident</h3>
               
                <div class=""sing-post-thumb mb-5 row pt-3"">
                    <div class=""col-sm-6"">
                            <a href=""#url""><img");
                BeginWriteAttribute("src", " src=\"", 3042, "\"", 3065, 1);
#nullable restore
#line 73 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3048, Model.CoverImage, 3048, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px;height:400px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3131, "\"", 3137, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    </div>\r\n                    <div class=\"col-sm-6 mt-sm-0 mt-3\">\r\n                            <a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=\"", 3277, "\"", 3296, 1);
#nullable restore
#line 76 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
WriteAttributeValue("", 3283, Model.Image2, 3283, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:400px;height:400px;\" class=\"img-fluid radius-image\"");
                BeginWriteAttribute("alt", " alt=\"", 3362, "\"", 3368, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <h3 class=\"blog-desc-big m-0 mb-lg-4 mb-3\">2. Paragraf</h3>\r\n                <p class=\"mb-4\">");
#nullable restore
#line 80 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
                           Write(Model.Details2);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
               
               

                <div class=""d-grid left-right mt-5 pb-md-5"">
                    <div class=""buttons-singles tags"">
                        <h4>Etiketler :</h4>
                        <a href=""#blog-tag"">Seyahat</a>
                        <a href=""#blog-tag"">Gezi</a>
                        <a href=""#blog-tag"">Otel</a>
                        <a href=""#blog-tag"">Yemek</a>
                    </div>
                    <div class=""buttons-singles"">
                        <h4>Paylaş :</h4>
                        <a href=""#blog-share""><span class=""fa fa-facebook"" aria-hidden=""true""></span></a>
                        <a href=""#blog-share""><span class=""fa fa-twitter"" aria-hidden=""true""></span></a>
                        <a href=""#blog-share""><span class=""fa fa-google-plus"" aria-hidden=""true""></span></a>
                        <a href=""#blog-share""><span class=""fa fa-pinterest-p"" aria-hidden=""true""></span></a>
                    </div>
               ");
                WriteLiteral(@" </div>

                <!--//author-card-->
                <div class=""author-card mt-5"">
                    <div class=""row align-items-center"">
                        <div class=""col-sm-3 col-6"">
                            <div>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9f197fa81ebdd99679be7b61efd31596ace9e3a302caa3da710aaebf74342f114409", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-sm-9 mt-sm-0 mt-3"">
                            <h3 class=""mb-3 title"">Alexander Ronald</h3>
                            <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Provident, sed et excepturi.
                                Distinctio fugit odit? Fugit ipsam. Lorem ipsum dolor sit.
                            </p>
                            <ul class=""author-icons mt-4"">
                                <li><a class=""facebook"" href=""#url""><span class=""fa fa-facebook""
                                            aria-hidden=""true""></span></a> </li>
                                <li><a class=""twitter"" href=""#url""><span class=""fa fa-twitter""
                                            aria-hidden=""true""></span></a></li>
                                <li><a class=""google"" href=""#url""><span class=""fa fa-google-plus""
                                            aria-hidden=""tr");
                WriteLiteral(@"ue""></span></a></li>
                                <li><a class=""linkedin"" href=""#url""><span class=""fa fa-linkedin""
                                            aria-hidden=""true""></span></a></li>
                                <li><a class=""github"" href=""#url""><span class=""fa fa-github""
                                            aria-hidden=""true""></span></a>
                                </li>
                                <li><a class=""dribbble"" href=""#url""><span class=""fa fa-dribbble""
                                            aria-hidden=""true""></span></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!--//author-card-->
                    ");
#nullable restore
#line 133 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
               Write(await Component.InvokeAsync("_CommentList",new{id=ViewBag.i}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 134 "C:\Users\AdemYildirim\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Destination\DestinationDetails.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/AddComment.cshtml", new { id = ViewBag.destid }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n               \r\n            </div>\r\n        </div>\r\n        <!--//blog-post-->\r\n\r\n    </div></section>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Destination> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
