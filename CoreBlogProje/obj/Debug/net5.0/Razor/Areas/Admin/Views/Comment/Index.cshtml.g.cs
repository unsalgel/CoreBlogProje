#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc7f74203eb698617589f198f9d2eb6026cc349"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/Index.cshtml")]
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
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc7f74203eb698617589f198f9d2eb6026cc349", @"/Areas/Admin/Views/Comment/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Comment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";
    string status = "";
    string statusname = "";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""ibox "">
        <div class=""ibox-title"">
            <h5> Yorum Listesi</h5>
            <div class=""ibox-tools"">
                <a class=""collapse-link"">
                    <i class=""fa fa-chevron-up""></i>
                </a>
                <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                    <i class=""fa fa-wrench""></i>
                </a>
                <ul class=""dropdown-menu dropdown-user"">
                    <li>
                        <a href=""#"" class=""dropdown-item"">Config option 1</a>
                    </li>
                    <li>
                        <a href=""#"" class=""dropdown-item"">Config option 2</a>
                    </li>
                </ul>
                <a class=""close-link"">
                    <i class=""fa fa-times""></i>
                </a>
            </div>
        </div>
        <div class=""ibox-content"">
            <table class=""table table-hover "">
                <th");
            WriteLiteral(@"ead>
                    <tr>
                        <th>#</th>
                        <th>Blog Adı</th>
                        <th>Yorum</th>
                        <th>Yorum Durumu</th>
                        <th>Yorumu Onayla</th>
                        <th>Yorumu Gizle</th>
                        <th>Sil</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 48 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                     foreach (var item in Model)
                    {
                        if (item.CommentStatus == true)
                        {
                            status = "Yorum Aktif";
                            statusname = "label label-primary";
                        }
                        else
                        {
                            status = "Yorum Pasif";
                            statusname = "label label-danger";
                        }


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 62 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(item.CommentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 63 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                           Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><span");
            BeginWriteAttribute("class", " class=\"", 2374, "\"", 2393, 1);
#nullable restore
#line 65 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2382, statusname, 2382, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                                                     Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2450, "\"", 2505, 2);
            WriteAttributeValue("", 2457, "/Admin/Comment/CommentStatusTrue/", 2457, 33, true);
#nullable restore
#line 66 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2490, item.CommentID, 2490, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Yorumu Göster</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2597, "\"", 2653, 2);
            WriteAttributeValue("", 2604, "/Admin/Comment/CommentStatusFalse/", 2604, 34, true);
#nullable restore
#line 67 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2638, item.CommentID, 2638, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Yorumu Gizle</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2744, "\"", 2795, 2);
            WriteAttributeValue("", 2751, "/Admin/Comment/DeleteComment/", 2751, 29, true);
#nullable restore
#line 68 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
WriteAttributeValue("", 2780, item.CommentID, 2780, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Areas\Admin\Views\Comment\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
