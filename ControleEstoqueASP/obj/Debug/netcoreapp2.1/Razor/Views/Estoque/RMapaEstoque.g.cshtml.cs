#pragma checksum "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c9f7631c2db4aada0cb60f6af217405f11c82b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estoque_RMapaEstoque), @"mvc.1.0.view", @"/Views/Estoque/RMapaEstoque.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Estoque/RMapaEstoque.cshtml", typeof(AspNetCore.Views_Estoque_RMapaEstoque))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c9f7631c2db4aada0cb60f6af217405f11c82b", @"/Views/Estoque/RMapaEstoque.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206573e2b9751e0fccf2a266712657af36dee417", @"/Views/_ViewImports.cshtml")]
    public class Views_Estoque_RMapaEstoque : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Estoque>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
  
    ViewData["Title"] = "RMapaEstoque";
    DateTime dataHora = DateTime.Now;

#line default
#line hidden
            BeginContext(111, 44, true);
            WriteLiteral("\r\n<fieldset><legend>Mapa de Estoque - Data: ");
            EndContext();
            BeginContext(156, 8, false);
#line 8 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                                     Write(dataHora);

#line default
#line hidden
            EndContext();
            BeginContext(164, 86, true);
            WriteLiteral("</legend></fieldset>\r\n\r\n<table class=\"table table-bordered\" style=\"margin-top:20px\">\r\n");
            EndContext();
#line 11 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
     for (int i = 1; i < 5; i++)
     {

#line default
#line hidden
            BeginContext(292, 25, true);
            WriteLiteral("        <tr height=100>\r\n");
            EndContext();
#line 14 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
             for (int y = 1; y < 7; y++)
            {

                

#line default
#line hidden
#line 17 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                 foreach (Estoque item in Model)
                {
                    

#line default
#line hidden
#line 19 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                     if (Int32.Parse(item.Localizacao.Substring(1, 1)) == i)
                    {
                        

#line default
#line hidden
#line 21 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                         if (item.Localizacao == ("L" + i + "C" + y) && item.Produto != null)
                         {

#line default
#line hidden
            BeginContext(669, 86, true);
            WriteLiteral("                            <td class=\"bg-danger align-middle text-center text-white\">");
            EndContext();
            BeginContext(756, 16, false);
#line 23 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                                                                                 Write(item.Localizacao);

#line default
#line hidden
            EndContext();
            BeginContext(772, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 24 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                         }

#line default
#line hidden
#line 25 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                         if (item.Localizacao == ("L" + i + "C" + y) && item.Produto == null)
                         {

#line default
#line hidden
            BeginContext(930, 65, true);
            WriteLiteral("                            <td class=\"align-middle text-center\">");
            EndContext();
            BeginContext(996, 16, false);
#line 27 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                                                            Write(item.Localizacao);

#line default
#line hidden
            EndContext();
            BeginContext(1012, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 28 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                         }

#line default
#line hidden
#line 28 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                          
                    }

#line default
#line hidden
#line 29 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                     
                }

#line default
#line hidden
#line 30 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1104, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\GitHub\ControleEstoqueASP\ControleEstoqueASP\Views\Estoque\RMapaEstoque.cshtml"
     }

#line default
#line hidden
            BeginContext(1129, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Estoque>> Html { get; private set; }
    }
}
#pragma warning restore 1591
