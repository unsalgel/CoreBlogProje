#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba648a8b0f1bb3f81e194ee068454d0fd66f7319"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_WriterTodayMessageList_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/WriterTodayMessageList/Default.cshtml")]
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
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba648a8b0f1bb3f81e194ee068454d0fd66f7319", @"/Areas/Writer/Views/Shared/Components/WriterTodayMessageList/Default.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_WriterTodayMessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WritersMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Bugün Gelen Mesajlar </h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>Gönderici Adı</th>
                                <th>Konusu</th>
                                <th>Detay</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 18 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 21 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
                                    Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 22 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
                                    Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 972, "\"", 1019, 2);
            WriteAttributeValue("", 979, "/Writer/Message/MessageDetails2/", 979, 32, true);
#nullable restore
#line 23 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
WriteAttributeValue("", 1011, item.ID, 1011, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Mesaj Detayı</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Writer\Views\Shared\Components\WriterTodayMessageList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WritersMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
