#pragma checksum "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9c074dde03e36f0efccc81e406766e7ef87b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimento_Detalhes), @"mvc.1.0.view", @"/Views/Movimento/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movimento/Detalhes.cshtml", typeof(AspNetCore.Views_Movimento_Detalhes))]
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
#line 1 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\_ViewImports.cshtml"
using ControleEstoqueASP;

#line default
#line hidden
#line 2 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9c074dde03e36f0efccc81e406766e7ef87b6e", @"/Views/Movimento/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206573e2b9751e0fccf2a266712657af36dee417", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimento_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movimento>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Movimento/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(111, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(118, 18, false);
#line 8 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
Write(Model.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(136, 110, true);
            WriteLiteral(" </h3>\r\n\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <td><b>Tipo Movimento: </b></td>\r\n        <td> ");
            EndContext();
            BeginContext(247, 19, false);
#line 13 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
        Write(Model.TipoMovimento);

#line default
#line hidden
            EndContext();
            BeginContext(266, 80, true);
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Localidade: </b></td>\r\n        <td> ");
            EndContext();
            BeginContext(347, 21, false);
#line 17 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
        Write(Model.EnderecoEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(368, 80, true);
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Quantidade: </b></td>\r\n        <td> ");
            EndContext();
            BeginContext(449, 16, false);
#line 21 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
        Write(Model.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(465, 75, true);
            WriteLiteral(" </td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Preço: </b></td>\r\n        <td> ");
            EndContext();
            BeginContext(541, 34, false);
#line 25 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
        Write(Model.Produto.Preco.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(575, 77, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Categoria: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(653, 20, false);
#line 29 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
       Write(Model.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(673, 78, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Fornecedor: </b></td>\r\n        <td>");
            EndContext();
            BeginContext(752, 21, false);
#line 33 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
       Write(Model.Fornecedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(773, 76, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Criado em:</b></td>\r\n        <td>");
            EndContext();
            BeginContext(850, 14, false);
#line 37 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Detalhes.cshtml"
       Write(Model.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(864, 76, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n\r\n<div>\r\n    <div class=\"float-right\">\r\n        ");
            EndContext();
            BeginContext(940, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca52e5c94d4d2aa05d304a11c95985", async() => {
                BeginContext(997, 6, true);
                WriteLiteral("Voltar");
                EndContext();
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
            EndContext();
            BeginContext(1007, 27, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br/>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movimento> Html { get; private set; }
    }
}
#pragma warning restore 1591
