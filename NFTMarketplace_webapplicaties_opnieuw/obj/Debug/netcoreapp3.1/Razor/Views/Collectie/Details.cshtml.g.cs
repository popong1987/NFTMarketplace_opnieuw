#pragma checksum "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81efd56bb1e3c9807f807370ec0d7542f82e67b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collectie_Details), @"mvc.1.0.view", @"/Views/Collectie/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81efd56bb1e3c9807f807370ec0d7542f82e67b8", @"/Views/Collectie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133ac8ccb0e17ed72a1b6ba8807b2da11daf88a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Collectie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NFTMarketplace_webapplicaties_opnieuw.Viewmodels.CollectieDetailsViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
  
    ViewData["Title"] = @Model.Naam;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .jumbotron {\r\n        background-image: url(\"");
#nullable restore
#line 8 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                          Write(Model.Afbeelding);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        background-color: black;
        height: 40vh;
        width: auto;
        background-position: center center;
        background-repeat: no-repeat;
    }
</style>
<div class=""jumbotron jumbotron-fluid"">
</div>

<div class=""m-5"">
    <h1 class=""text-primary text-uppercase""> ");
#nullable restore
#line 20 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                                        Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"text-primary\">");
#nullable restore
#line 21 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                       Write(Model.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 25 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
     foreach (var product in Model.Producten)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 bg-dark\">\r\n            <div class=\"card m-2 bg-dark\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 763, "\"", 788, 1);
#nullable restore
#line 29 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
WriteAttributeValue("", 769, product.Afbeelding, 769, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title text-uppercase text-primary\">");
#nullable restore
#line 31 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                                                                  Write(product.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text text-primary\">");
#nullable restore
#line 32 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                                                 Write(product.Beschrijving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text text-primary\">price: €");
#nullable restore
#line 33 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                                                         Write(product.Prijs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81efd56bb1e3c9807f807370ec0d7542f82e67b88075", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"
                                                                                               WriteLiteral(product.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "D:\Webapplicaties\NFTMarketplace_webapplicaties_opnieuw\NFTMarketplace_webapplicaties_opnieuw\Views\Collectie\Details.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NFTMarketplace_webapplicaties_opnieuw.Viewmodels.CollectieDetailsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
