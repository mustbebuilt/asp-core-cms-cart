#pragma checksum "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29e6dd2ed97f95d02233d2e0aee354b5b1198e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieDetails), @"mvc.1.0.view", @"/Views/Home/MovieDetails.cshtml")]
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
#line 1 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/_ViewImports.cshtml"
using MyFilmMVCV1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/_ViewImports.cshtml"
using MyFilmMVCV1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29e6dd2ed97f95d02233d2e0aee354b5b1198e49", @"/Views/Home/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6783fa0fdf0f223c7a9574b89b3209b87f8a15c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyFilmMVCV1.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
  
    ViewData["Title"] = @Model.FilmTitle;
    ViewData["PageHeading"] = @Model.FilmTitle;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"shoppingCart\">\r\n    ");
#nullable restore
#line 9 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
Write(await Component.InvokeAsync("ShoppingCart"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<section>\r\n\r\n    <div class=\"mainImage\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29e6dd2ed97f95d02233d2e0aee354b5b1198e494294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 283, "~/images/", 283, 9, true);
#nullable restore
#line 15 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
AddHtmlAttributeValue("", 292, Model.FilmImage, 292, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
AddHtmlAttributeValue("", 315, Model.FilmTitle, 315, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"filmInfo\">\r\n        <h2>");
#nullable restore
#line 19 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
       Write(Model.FilmTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <p>");
#nullable restore
#line 20 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
      Write(Model.FilmDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Certificate: ");
#nullable restore
#line 21 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
                   Write(Model.FilmCertificate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Streaming Price: &pound;");
#nullable restore
#line 22 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
                               Write((Model.FilmPrice).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e6dd2ed97f95d02233d2e0aee354b5b1198e497330", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 645, "\"", 666, 1);
#nullable restore
#line 24 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
WriteAttributeValue("", 653, Model.FilmID, 653, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"FilmID\" name=\"FilmID\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 730, "\"", 754, 1);
#nullable restore
#line 25 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
WriteAttributeValue("", 738, Model.FilmTitle, 738, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" id=\"FilmTitle\" name=\"FilmTitle\" />\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 824, "\"", 848, 1);
#nullable restore
#line 26 "/Users/martincooper/Projects/MyFilmMVCV1/MyFilmMVCV1/Views/Home/MovieDetails.cshtml"
WriteAttributeValue("", 832, Model.FilmPrice, 832, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""FilmPrice"" name=""FilmPrice"" />
            <div>
                <label for=""OrderQuantity"">Quantity</label>
                <input type=""number"" id=""OrderQuantity"" name=""OrderQuantity"" min=""1"" max=""10"" value=""1"" />
            </div>
            <div>
                <input type=""submit"" value=""Add To Cart"" class=""cta"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyFilmMVCV1.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
