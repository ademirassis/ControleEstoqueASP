#pragma checksum "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d5109c8a1efd16945a25befe7d847913eb61e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimento_Index), @"mvc.1.0.view", @"/Views/Movimento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movimento/Index.cshtml", typeof(AspNetCore.Views_Movimento_Index))]
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
#line 1 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\_ViewImports.cshtml"
using ControleEstoqueASP;

#line default
#line hidden
#line 2 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\_ViewImports.cshtml"
using ControleEstoqueASP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d5109c8a1efd16945a25befe7d847913eb61e3", @"/Views/Movimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d1035c855257631bd9da4d84a0d846405380bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    DateTime dataHora = DateTime.Now;

#line default
#line hidden
            BeginContext(153, 54, true);
            WriteLiteral("\r\n\r\n<h2>Gerenciamento de Movimentações</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(207, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "872dcb167e154e29a4e41248a1efdfab", async() => {
                BeginContext(257, 19, true);
                WriteLiteral("Cadastrar Movimento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(280, 448, true);
            WriteLiteral(@"
</p>

<table style=""margin-top:15px;margin-bottom:15px"" class=""table table-hover"">
    <thead>
        <tr>
            <th>Produto</th>
            <th>Categoria</th>
            <th>Fornecedor</th>
            <th>Quantidade</th>
            <th>Valor Unitário</th>
            <th>Valor Total</th>
            <th>Tipo Movimento</th>
            <th>Criado em</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
         foreach (Movimento item in Model)
        {

#line default
#line hidden
            BeginContext(783, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(822, 17, false);
#line 33 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.Produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(839, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(867, 19, false);
#line 34 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(886, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(914, 20, false);
#line 35 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.Fornecedor.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(934, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(962, 26, false);
#line 36 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.Quantidade.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(988, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1016, 33, false);
#line 37 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.Produto.Preco.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 39 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
                      
                        double subtotal = item.Produto.Preco * item.Quantidade;
                    

#line default
#line hidden
            BeginContext(1206, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1227, 23, false);
#line 42 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(subtotal.ToString("C2"));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 45, true);
            WriteLiteral("\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(1296, 18, false);
#line 44 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.TipoMovimento);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1342, 13, false);
#line 45 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
               Write(item.CriadoEm);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1404, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e965f690f350499a89189124d72ab6dd", async() => {
                BeginContext(1506, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1518, 60, true);
            WriteLiteral("\r\n                </td>                \r\n            </tr>\r\n");
            EndContext();
#line 51 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1589, 63, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>\r\n    <b>Dados atualizados em: </b> ");
            EndContext();
            BeginContext(1653, 8, false);
#line 55 "C:\Users\aiury\OneDrive\Git\Microsoft\Projetos\ControleEstoqueASP\ControleEstoqueASP\Views\Movimento\Index.cshtml"
                             Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(1661, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
