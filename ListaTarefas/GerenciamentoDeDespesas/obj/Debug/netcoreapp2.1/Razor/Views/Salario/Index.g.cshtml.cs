#pragma checksum "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b8c86a81d9e696b5cceb8c553bb35a7757ba05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salario_Index), @"mvc.1.0.view", @"/Views/Salario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Salario/Index.cshtml", typeof(AspNetCore.Views_Salario_Index))]
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
#line 1 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\_ViewImports.cshtml"
using GerenciamentoDeDespesas;

#line default
#line hidden
#line 2 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\_ViewImports.cshtml"
using GerenciamentoDeDespesas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b8c86a81d9e696b5cceb8c553bb35a7757ba05", @"/Views/Salario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7af168e1a2b0e20638f0978af67de2103cb1aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Salario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciamentoDeDespesas.Models.Salario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Salario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 71, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n\r\n        <br />\r\n        <br />\r\n\r\n");
            EndContext();
#line 15 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
         if (TempData["confirmacao"] != null)
        {


#line default
#line hidden
            BeginContext(236, 184, true);
            WriteLiteral("            <div class=\"alert alert-success alert-dismissible\">\r\n                <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n                <strong>");
            EndContext();
            BeginContext(421, 23, false);
#line 20 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                   Write(TempData["confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(444, 31, true);
            WriteLiteral("</strong>\r\n            </div>\r\n");
            EndContext();
#line 22 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(488, 44, true);
            WriteLiteral("\r\n        <p id=\"btnControle\">\r\n            ");
            EndContext();
            BeginContext(532, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbbc68590c347a38f4fd8736288702d", async() => {
                BeginContext(602, 9, true);
                WriteLiteral("Adicionar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 402, true);
            WriteLiteral(@"
        </p>

    

        <table id=""dados"" class=""table table-hover  table-striped display responsive nowrap table-sm "" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Mês</th>
                    <th>Valor</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 41 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1082, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1137, 14, false);
#line 44 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                       Write(item.SalarioId);

#line default
#line hidden
            EndContext();
            BeginContext(1151, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1187, 13, false);
#line 45 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                       Write(item.Mes.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1236, 10, false);
#line 46 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                       Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 84, true);
            WriteLiteral("</td>\r\n                        <td class=\"text-right\">\r\n                            ");
            EndContext();
            BeginContext(1330, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76fa06ed06cf4a20b0a374d4b540a5dc", async() => {
                BeginContext(1411, 39, true);
                WriteLiteral("<i class=\"material-icons\">Atualizar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                                                                                WriteLiteral(item.SalarioId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1454, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1486, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd432dd42cd849838719cf5bf28a976a", async() => {
                BeginContext(1564, 37, true);
                WriteLiteral("<i class=\"material-icons\">Deletar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                                                                             WriteLiteral(item.SalarioId);

#line default
#line hidden
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
            EndContext();
            BeginContext(1605, 62, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 53 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Salario\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1686, 56, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1760, 1350, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {

            $('#dados').DataTable({
                ""orderMulti"": false,
                ""paging"": true,
                ""info"": false,
                ""language"": {
                    ""lengthMenu"": ""Visualizando _MENU_ Registros por página"",
                    ""zeroRecords"": ""Não existe registros para visualização"",
                    ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""No records available"",
                    ""sLoadingRecords"": ""Carregando..."",
                    ""sProcessing"": ""Processando..."",
                    ""sZeroRecords"": ""Nenhum registro encontrado"",
                    ""sSearch"": ""Pesquisar"",
                    ""infoFiltered"": ""(filtered from _MAX_ total records)"",
                    ""oPaginate"": {
                        ""sNext"": ""Próximo"",
                        ""sPrevious"": ""Anterior"",
                        ""sFirst"": ""Primeiro"",
                        ""sLast"": ");
                WriteLiteral(@"""Último""
                    },
                    ""oAria"": {
                        ""sSortAscending"": "": Ordenar colunas de forma ascendente"",
                        ""sSortDescending"": "": Ordenar colunas de forma descendente""
                    }
                }
            });

        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(3113, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciamentoDeDespesas.Models.Salario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
