#pragma checksum "C:\Users\exam\source\repos\MyBiz\MyBiz\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "464e3483b70b6d60d8c001e5d1f188dc3abe5c8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\exam\source\repos\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\exam\source\repos\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\exam\source\repos\MyBiz\MyBiz\Views\_ViewImports.cshtml"
using MyBiz.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"464e3483b70b6d60d8c001e5d1f188dc3abe5c8b", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10c0689abe03c74d7b3a69a5048be20a934e98bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464e3483b70b6d60d8c001e5d1f188dc3abe5c8b4248", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>MyBiz - Themplate</title>
    <!-- CSS only -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <!-- Font Awesome CDN -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "464e3483b70b6d60d8c001e5d1f188dc3abe5c8b5234", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "464e3483b70b6d60d8c001e5d1f188dc3abe5c8b7117", async() => {
                WriteLiteral(@"
    <!-- Nav Starts -->
    <nav>
        <div class=""container"">
            <!-- Top Nav Starts -->
            <div class=""top-nav d-flex justify-content-between"">
                <div class=""top-left"">
                    <ul class=""d-flex gap-3 align-items-center"">
                        <li><a");
                BeginWriteAttribute("href", " href=\"", 1126, "\"", 1133, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""bi bi-envelope"">&nbsp;</i>contact@example.com</a></li>
                        <li><p><i class=""bi bi-phone""></i>&nbsp;1 5589 55488 55</p></li>
                    </ul>

                </div>
                <div class=""top-right"">
                    <ul class=""d-flex gap-3"">
                        <li><a href=""#""><i class=""fa-brands fa-twitter""></i></a></li>
                        <li><a href=""#""><i class=""fa-brands fa-instagram""></i></a></li>
                        <li><a href=""#""><i class=""fa-brands fa-linkedin-in""></i></a></li>
                        <li><a href=""#""><i class=""fa-brands fa-facebook""></i></a></li>
                    </ul>
                </div>
            </div>
            <!-- Top Nav Ends -->
            <!-- Below Nav Starts -->
            <div class=""below-nav d-flex justify-content-between"">
                <div class=""logo"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 2058, "\"", 2065, 0);
                EndWriteAttribute();
                WriteLiteral(@"><p>My<span class=""logo-to-color"">Biz</span> </p></a>
                </div>
                <div>
                    <ul class=""d-flex gap-4"">
                        <li><a href=""#"">Home</a></li>
                        <li><a href=""#"">About</a></li>
                        <li><a href=""#"">Services</a></li>
                        <li><a href=""#"">Portfolio</a></li>
                        <li><a href=""#"">Team</a></li>
                        <li><a href=""#"">Contact</a></li>
                    </ul>
                </div>
            </div>
            <!-- Below Nav Ends -->
        </div>
    </nav>
    ");
#nullable restore
#line 57 "C:\Users\exam\source\repos\MyBiz\MyBiz\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer>
        <div class=""footer-top text-white gap-5 justify-content-center pt-5"">
            <div class=""first"">
                <p class=""title"">MyBiz</p>
                <p class=""addrss"">
                    A108 Adam Street
                    NY 535022, USA
                </p>
                <p>Phone: +1 5589 55488 55</p>
                <p>Email: info@example.com </p>
                <div class=""d-flex gap-2"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 3180, "\"", 3187, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-facebook\"></i></a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 3247, "\"", 3254, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 3315, "\"", 3322, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-twitter\"></i></a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 3381, "\"", 3388, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                </div>\r\n            </div>\r\n            <ul>\r\n                Useful Links\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 3540, "\"", 3547, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 3551, "\"", 3558, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Home</li>\r\n                <li> <a");
                BeginWriteAttribute("href", " href=\"", 3637, "\"", 3644, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>About us</li>\r\n                <li> <a");
                BeginWriteAttribute("href", " href=\"", 3727, "\"", 3734, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Services</li>\r\n                <li> <a");
                BeginWriteAttribute("href", " href=\"", 3817, "\"", 3824, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Terms of Service</li>\r\n                <li> <a");
                BeginWriteAttribute("href", " href=\"", 3915, "\"", 3922, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Privacy Policy</li>\r\n            </ul>\r\n            <ul>\r\n                Our Services\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 4077, "\"", 4084, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 4088, "\"", 4095, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Web Design</li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 4179, "\"", 4186, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 4190, "\"", 4197, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Web Development</li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 4286, "\"", 4293, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 4297, "\"", 4304, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Product Management</li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 4396, "\"", 4403, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 4407, "\"", 4414, 0);
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-arrow-right-short\"></i></a>Marketing</li>\r\n                <li><a");
                BeginWriteAttribute("href", " href=\"", 4497, "\"", 4504, 0);
                EndWriteAttribute();
                WriteLiteral("><a");
                BeginWriteAttribute("href", " href=\"", 4508, "\"", 4515, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""bi bi-arrow-right-short""></i></a>Graphic design</li>
            </ul>
            <div>
                <p>Our Newsletter</p>
                <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                <div class=""d-flex"">
                    <input type=""text"" class=""form-control"">
                    <button class=""btn btn-primary"">Subscribe</button>
                </div>
            </div>
        </div>
        <div class=""copyright d-flex justify-content-center"">
            <div class=""text-center mt-3 text-white"">
                <p style=""margin-bottom: 10px;"">&copy; Copyright MyBiz. All Rights Reserved</p>
                <p>Designed by <span style=""color: #01B1D7;"">BootstrapMade</span></p>
            </div>
        </div>
    </footer>



    <!-- JavaScript Bundle with Popper -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqkt");
                WriteLiteral("iwsUTF55Jfv3qYSDhgCecCxMW52nD2\" crossorigin=\"anonymous\"></script>\r\n");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
