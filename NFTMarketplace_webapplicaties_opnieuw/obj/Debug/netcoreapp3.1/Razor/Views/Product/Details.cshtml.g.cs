#pragma checksum "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b16ef0fbe97147f0085f05f0927a3e65bf4a8d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\_ViewImports.cshtml"
using NFTMarketplace_webapplicaties_opnieuw;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\_ViewImports.cshtml"
using NFTMarketplace_webapplicaties_opnieuw.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b16ef0fbe97147f0085f05f0927a3e65bf4a8d4", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133ac8ccb0e17ed72a1b6ba8807b2da11daf88a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NFTMarketplace_webapplicaties_opnieuw.Viewmodels.ProductDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrderProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
  
    ViewData["Title"] = @Model.Naam;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md m-5 align-content-center justify-content-center\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 231, "\"", 254, 1);
#nullable restore
#line 7 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
WriteAttributeValue("", 237, Model.Afbeelding, 237, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:30vw\" />\r\n    </div>\r\n    <div class=\"col-md m-5 align-items-center justify-content-center\">\r\n        <div>\r\n            <h3 class=\"text-primary\">");
#nullable restore
#line 11 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
                                Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <div>\r\n            <p class=\"text-primary\">");
#nullable restore
#line 14 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
                               Write(Model.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md\">\r\n                <p class=\"text-primary\">€ ");
#nullable restore
#line 18 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
                                     Write(Model.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b16ef0fbe97147f0085f05f0927a3e65bf4a8d46674", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b16ef0fbe97147f0085f05f0927a3e65bf4a8d46952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 22 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" value=\"AddToCart\" class=\"btn btn-primary\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md m-5 align-content-center justify-content-center\">\r\n        <h3 class=\"text-primary text-uppercase\">PROPERTIES</h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 35 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
             foreach (var productproperties in Model.ProductProperties)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4 bg-dark d-flex align-items-stretch"">
                    <div class=""card m-1 text-white bg-primary"" style=""width: 18rem;"">
                        <div class=""card-body"">
                            <p class=""card-title text-uppercase"">");
#nullable restore
#line 40 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
                                                            Write(productproperties.Property.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">Rarity: ");
#nullable restore
#line 41 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
                                                    Write(productproperties.Property.Schaarsheid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md m-5 align-content-center justify-content-center\">\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 54 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Product\Details.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NFTMarketplace_webapplicaties_opnieuw.Viewmodels.ProductDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
