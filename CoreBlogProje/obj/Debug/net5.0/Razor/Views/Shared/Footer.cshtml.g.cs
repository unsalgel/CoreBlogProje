#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Shared\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7bf8b9aa85833950c0e95d9e91cce06bd21d831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Footer), @"mvc.1.0.view", @"/Views/Shared/Footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7bf8b9aa85833950c0e95d9e91cce06bd21d831", @"/Views/Shared/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ac4bf5729f5e3696c8c4452144c0f4b68a8ae4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 footer-grid-agileits-w3ls text-left"">
                <h3>Hakkımızda</h3>
                <p>Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convallis at tellus.Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convallis at tellus.Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convallis at tellus.Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convallis at tellus.Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convaCurabitur non nulla sit amet nisl tempus convallis quis ac lectus. lacinia eget consectetur sed, convallis</p>
                <div class=""read"">
                    <a href=""/About/Index/"" class=""btn btn-primary read-m"">Devamını Oku >></a>
                ");
            WriteLiteral("</div>\r\n            </div>\r\n            ");
#nullable restore
#line 11 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Shared\Footer.cshtml"
       Write(await Component.InvokeAsync("FooterLast3Post"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            <!-- subscribe -->\r\n            ");
#nullable restore
#line 14 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Shared\Footer.cshtml"
       Write(await Html.PartialAsync("/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <span>Google+</span>
                            </a>
 ");
            WriteLiteral(@"                       </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-pinterest-p""></i>
                                <span>Pinterest</span>
                            </a>
                        </li>
                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 52 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\CoreBlogProje\CoreBlogProje\Views\Shared\Footer.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Weblog. All Rights Reserved | Design by\r\n                    <a href=\"http://w3layouts.com/\">W3layouts</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
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
