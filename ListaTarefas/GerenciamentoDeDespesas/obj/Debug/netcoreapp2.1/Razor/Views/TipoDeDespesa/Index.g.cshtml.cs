#pragma checksum "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88bd24207cc6189958a550b26ada9dfbc15f3aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoDeDespesa_Index), @"mvc.1.0.view", @"/Views/TipoDeDespesa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TipoDeDespesa/Index.cshtml", typeof(AspNetCore.Views_TipoDeDespesa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bd24207cc6189958a550b26ada9dfbc15f3aee", @"/Views/TipoDeDespesa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7af168e1a2b0e20638f0978af67de2103cb1aa8", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoDeDespesa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciamentoDeDespesas.Models.TipoDeDespesa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TipoDeDespesa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(176, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(197, 114, true);
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        #btnControle {\r\n          margin-left: 14px;\r\n        }\r\n    </style>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(314, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 17 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(359, 35, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n\r\n\r\n");
            EndContext();
#line 26 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
     if (TempData["confirmacao"] != null)
    {


#line default
#line hidden
            BeginContext(446, 172, true);
            WriteLiteral("        <div class=\"alert alert-success alert-dismissible\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>");
            EndContext();
            BeginContext(619, 23, false);
#line 31 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
               Write(TempData["confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(642, 27, true);
            WriteLiteral("</strong>\r\n        </div>\r\n");
            EndContext();
#line 33 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(678, 36, true);
            WriteLiteral("\r\n    <p id=\"btnControle\">\r\n        ");
            EndContext();
            BeginContext(714, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22676c4032904793a27fa2259ff7958a", async() => {
                BeginContext(798, 9, true);
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
            BeginContext(811, 18, true);
            WriteLiteral("\r\n    </p>\r\n\r\n    ");
            EndContext();
            BeginContext(829, 464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042d1a4fd07141f39b73501a96352479", async() => {
                BeginContext(899, 387, true);
                WriteLiteral(@"

        <div class=""form-group"">
            <div class=""input-group col-md-6"">
                <input class=""form-control"" name=""txtProcurar"" />
                <div class=""input-group-append"">
                    <button type=""submit"" class=""btn btn-outline-primary""> <i class=""fa fa-search-plus""></i> </button>
                </div>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1293, 310, true);
            WriteLiteral(@"


    <table id=""dados"" class=""table table-hover table-striped display responsive nowrap table-sm "" cellspacing=""0"" width=""100%"">
        <thead>
            <tr>
                <th>#</th>
                <th>Nome</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 62 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1660, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1707, 20, false);
#line 65 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
                   Write(item.TipoDeDespesaId);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1759, 9, false);
#line 66 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1768, 76, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">\r\n                        ");
            EndContext();
            BeginContext(1844, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49bfbd951ced4f30963ce5351b8f13a9", async() => {
                BeginContext(1946, 39, true);
                WriteLiteral("<i class=\"material-icons\">Atualizar</i>");
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
#line 68 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
                                                                                           WriteLiteral(item.TipoDeDespesaId);

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
            BeginContext(1989, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2017, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63811e4d7f641bab08332cf3df410f1", async() => {
                BeginContext(2116, 37, true);
                WriteLiteral("<i class=\"material-icons\">Deletar</i>");
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
#line 69 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
                                                                                        WriteLiteral(item.TipoDeDespesaId);

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
            BeginContext(2157, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 73 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\GerenciamentoDeDespesas\Views\TipoDeDespesa\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2226, 144, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <nav aria-label=\"Navegação de página exemplo\">\r\n        <ul class=\"pagination justify-content-center\">\r\n\r\n");
            EndContext();
            BeginContext(2751, 47, true);
            WriteLiteral("\r\n        </ul>\r\n\r\n    </nav>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2816, 35, true);
                WriteLiteral("\r\n    <script>\r\n\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciamentoDeDespesas.Models.TipoDeDespesa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
