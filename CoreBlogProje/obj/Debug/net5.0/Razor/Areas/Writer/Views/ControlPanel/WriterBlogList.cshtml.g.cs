#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6412252ea62a4df07d18f6ed5054892b2d52bf24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_ControlPanel_WriterBlogList), @"mvc.1.0.view", @"/Areas/Writer/Views/ControlPanel/WriterBlogList.cshtml")]
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
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6412252ea62a4df07d18f6ed5054892b2d52bf24", @"/Areas/Writer/Views/ControlPanel/WriterBlogList.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_ControlPanel_WriterBlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
  
    ViewData["Title"] = "WriterBlogList";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6412252ea62a4df07d18f6ed5054892b2d52bf244817", async() => {
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
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Bloglarım</h4>
                <table class=""table table-bordered"">
                    <tr>
                        <th>#</th>
                        <th>Blog Adı</th>
                        <th>Blog Durumu</th>
                        <th>Kategori</th>
                        <th>Bloga git</th>
                        <th>Düzenle</th>
                        <th>Sil</th>
                    </tr>
");
#nullable restore
#line 28 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 31 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                           Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1331, 2);
            WriteAttributeValue("", 1301, "/Blog/BlogDetails/", 1301, 18, true);
#nullable restore
#line 35 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
WriteAttributeValue("", 1319, item.BlogID, 1319, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Bloga Git</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1419, "\"", 1468, 2);
            WriteAttributeValue("", 1426, "/Writer/ControlPanel/EditBlog/", 1426, 30, true);
#nullable restore
#line 36 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
WriteAttributeValue("", 1456, item.BlogID, 1456, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Düzenle</a></td>\r\n                      \r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1575, "\"", 1626, 2);
            WriteAttributeValue("", 1582, "/Writer/ControlPanel/DeleteBlog/", 1582, 32, true);
#nullable restore
#line 38 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
WriteAttributeValue("", 1614, item.BlogID, 1614, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n                <br />\r\n                ");
#nullable restore
#line 43 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\ControlPanel\WriterBlogList.cshtml"
           Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("WriterBlogList",new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n               \r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
