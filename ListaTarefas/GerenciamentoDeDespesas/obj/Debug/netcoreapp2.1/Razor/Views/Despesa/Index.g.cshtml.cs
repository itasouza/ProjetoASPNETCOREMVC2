#pragma checksum "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fcc07bfe22a0e2544e7d04510e525d2e53afaa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Despesa_Index), @"mvc.1.0.view", @"/Views/Despesa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Despesa/Index.cshtml", typeof(AspNetCore.Views_Despesa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcc07bfe22a0e2544e7d04510e525d2e53afaa3", @"/Views/Despesa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7af168e1a2b0e20638f0978af67de2103cb1aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Despesa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciamentoDeDespesas.Models.Despesa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Despesa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control selectpicker escolherMes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-show-subtext", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-live-search", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_GastoTotalMes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GraficoTotalMes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(141, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(205, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(248, 59, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
            EndContext();
#line 18 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
     if (TempData["confirmacao"] != null)
    {


#line default
#line hidden
            BeginContext(359, 172, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>");
            EndContext();
            BeginContext(532, 23, false);
#line 23 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
               Write(TempData["confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(555, 27, true);
            WriteLiteral("</strong>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(591, 38, true);
            WriteLiteral("\r\n\r\n    <p id=\"btnControle\">\r\n        ");
            EndContext();
            BeginContext(629, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5a08719e6724ad6ad74c78a18850be9", async() => {
                BeginContext(699, 9, true);
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
            BeginContext(712, 403, true);
            WriteLiteral(@"
    </p>



    <div class=""form-group col-lg-12"">
        <label for=""genero"">Selecione um Mês*</label>
        <div class=""input-group"">
            <div class=""input-group-addon"">
                <span class=""glyphicon glyphicon-plus pink"" data-toggle=""modal"" data-placement=""right""
                      title=""Selecione um mês"">
                </span>
            </div>
            ");
            EndContext();
            BeginContext(1115, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c4089b0c4a4881b488e9c00e32fbdf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 43 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Mes;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1272, 94, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            EndContext();
            BeginContext(1366, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8646823b0a7d48348a731ddefc54c309", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1399, 409, true);
            WriteLiteral(@"
        </div>
    </div>


    <table id=""dados"" class=""table table-hover  table-striped display responsive nowrap table-sm "" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                <th>#</th>
                <th>Mês</th>
                <th>Tipo Despesa</th>
                <th>Valor</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 66 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1865, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1912, 14, false);
#line 69 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                   Write(item.DespesaId);

#line default
#line hidden
            EndContext();
            BeginContext(1926, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1958, 13, false);
#line 70 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                   Write(item.Mes.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1971, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2003, 23, false);
#line 71 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                   Write(item.TipoDeDespesa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2026, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2058, 10, false);
#line 72 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                   Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(2068, 76, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(2144, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9bbccfef9ae4643bb17090fe8ba9ab7", async() => {
                BeginContext(2225, 39, true);
                WriteLiteral("<i class=\"material-icons\">Atualizar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                                                                            WriteLiteral(item.DespesaId);

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
            BeginContext(2268, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2296, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ffba0f49c764a0faefc76eba299ed69", async() => {
                BeginContext(2374, 37, true);
                WriteLiteral("<i class=\"material-icons\">Deletar</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
                                                                         WriteLiteral(item.DespesaId);

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
            BeginContext(2415, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 79 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\Despesa\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2484, 34, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            EndContext();
            BeginContext(2781, 14, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2813, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(2821, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b69d5e458e4461a9ef9ee051dd7380f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2868, 1396, true);
                WriteLiteral(@"

    <script>

        CarregarDadosGastosTotaisMes();

        $(document).ready(function () {

            $('#dados').DataTable({
                ""orderMulti"": false,
                ""paging"": false,
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
                        ""sFirst"": ");
                WriteLiteral(@"""Primeiro"",
                        ""sLast"": ""Último""
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
            BeginContext(4267, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciamentoDeDespesas.Models.Despesa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
