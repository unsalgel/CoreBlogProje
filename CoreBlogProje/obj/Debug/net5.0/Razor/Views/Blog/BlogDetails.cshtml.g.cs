#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a8283c0a689107e2e4bf5c09eb6984b9eb7fe5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogDetails), @"mvc.1.0.view", @"/Views/Blog/BlogDetails.cshtml")]
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
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\_ViewImports.cshtml"
using CoreBlogProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\_ViewImports.cshtml"
using CoreBlogProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8283c0a689107e2e4bf5c09eb6984b9eb7fe5c", @"/Views/Blog/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ac4bf5729f5e3696c8c4452144c0f4b68a8ae4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
  
    ViewData["Title"] = "BlogDetails";
    Layout = "~/Views/Shared/UserLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"banner-bottom\">\r\n    <!--/blog-->\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <!--left-->\r\n            <div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n");
#nullable restore
#line 14 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"blog-grid-top\">\r\n                        <div class=\"b-grid-top\">\r\n                            <div class=\"blog_info_left_grid\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 620, "\"", 658, 3);
            WriteAttributeValue("", 627, "/Blog/BlogDetails/", 627, 18, true);
#nullable restore
#line 19 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 645, item.BlogID, 645, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 657, "/", 657, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 702, "\"", 723, 1);
#nullable restore
#line 20 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 708, item.BlogImage, 708, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 742, "\"", 748, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                            </div>
                            <div class=""blog-info-middle"">
                                <ul>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 27 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                                                                           Write(Convert.ToDateTime(item.BlogCreateDate).ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-thumbs-up""></i> 201 Likes
                                        </a>
                                    </li>
                                     <li>
                                        <a href=""#"">
                                            <i class=""far fa-user""></i>Yazar: ");
#nullable restore
#line 37 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                                                                         Write(item.WriterUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i>");
#nullable restore
#line 42 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                                                                     Write(ViewBag.val);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Yorum
                                        </a>
                                    </li>

                                </ul>
                            </div>
                        </div>

                        <h3>    
                            <a");
            BeginWriteAttribute("href", " href=\"", 2283, "\"", 2321, 3);
            WriteAttributeValue("", 2290, "/Blog/BlogDetails/", 2290, 18, true);
#nullable restore
#line 51 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 2308, item.BlogID, 2308, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2320, "/", 2320, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                                                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                        </h3>\r\n                        <p>");
#nullable restore
#line 53 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                      Write(item.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n");
            WriteLiteral(@"                    <div class=""comment-top"">
                        <h4>Yorumlar</h4>
                        <div id=""listcom"">
                        
                            <!--Yorumlar buraya listeleniyor-->
                        </div>

                    </div>
                    <div class=""comment-top"">
                        <h4>Yorum Yap</h4>
                        
                        <div class=""comment-bottom"">
                            <input class=""form-control"" type=""text"" id=""CommentUserName"" name=""CommentUserName"" placeholder=""İsim & Soyisim""");
            BeginWriteAttribute("required", " required=\"", 3056, "\"", 3067, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <input class=\"form-control\" type=\"hidden\" name=\"BlogID\" id=\"BlogID\"");
            BeginWriteAttribute("value", " value=\"", 3166, "\"", 3186, 1);
#nullable restore
#line 70 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 3174, item.BlogID, 3174, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"ID\"");
            BeginWriteAttribute("required", " required=\"", 3204, "\"", 3215, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                             <textarea class=\"form-control\" name=\"CommentContent\" id=\"CommentContent\" placeholder=\"Yorumunuz..\"");
            BeginWriteAttribute("required", " required=\"", 3346, "\"", 3357, 0);
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n                            <input type=\"hidden\" name=\"CommentDate\" id=\"CommentDate\"");
            BeginWriteAttribute("value", " value=\"", 3456, "\"", 3477, 1);
#nullable restore
#line 72 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
WriteAttributeValue("", 3464, DateTime.Now, 3464, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <button type=\"submit\" id=\"btncommentadd\"  class=\"btn btn-primary submit\">Yorum Yap</button>                         \r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 76 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <!--//left-->\r\n            <!--right-->\r\n            <!--Sağ kısım-->\r\n        ");
#nullable restore
#line 82 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Blog\BlogDetails.cshtml"
   Write(await Html.PartialAsync("/Views/Blog/BlogDetailsSideBar.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!--//right-->\r\n        </div>\r\n    </div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script>
            //Yorum listeleme
          
            $(document).ready(function () {
                let id = $(""#BlogID"").val();
                $.ajax({
                    contentType: ""application/json"",
                    dataType: ""json"",
                    type: ""Get"",
                    data: { BlogID: id },
                    url: ""/Comment/CommentList/"",
                    success: function (funk) {
                        let values = jQuery.parseJSON(funk);   
                        if (values.length==0){
                            $('#listcom').html(`Henüz Yorum yok Hadi ilk yorumu sen yap !`);
                        }else{
                            let htmlst = ``;
                            $.each(values, (index, value) => {
                                htmlst += `<div class=""media""><img style=""width:64px; height:64px;"" src=${value.UserImage} alt="""" class=""img-fluid"" />  <div class=""media-body""> <h5 class=""mt-0"">${value.CommentUserName}</h5><p>");
                WriteLiteral(@"${value.CommentContent}</p></div></div>`;
                            });
                            $(""#listcom"").html(htmlst);
                        }                
                    }
                });
            });
            //Yorum ekleme
               $(""#btncommentadd"").click(function (event) {
                event.preventDefault();
                let values = {
                    BlogID: $(""#BlogID"").val(),
                    CommentUserName: $(""#CommentUserName"").val(),
                    CommentTitle: $(""#CommentTitle"").val(),
                    CommentContent: $(""#CommentContent"").val(),
                    CommentDate: $(""#CommentDate"").val()
                };
                $.ajax({
                    type: ""Post"",
                    url: ""/Comment/CommentAdd/"",
                    data: values,
                    success: function (fnk1) {
                       let value = jQuery.parseJSON(fnk1);
                        let htmlstr = ``;
        ");
                WriteLiteral(@"                 htmlstr = `<div class=""media""><img style=""width:64px; height:64px;"" src=${value.UserImage} alt="""" class=""img-fluid"" />  <div class=""media-body""> <h5 class=""mt-0"">${value.CommentUserName}</h5><p>${value.CommentContent}</p></div></div>`;
                        $(""#listcom"").append(htmlstr);                  
                    }
                });
            });
        </script>
    ");
            }
            );
            WriteLiteral("        <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js\"></script>\r\n    </section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
