#pragma checksum "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0958d6f2b311bcf8c9fc7f0c1c1eeb80be31703e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albuns_Index), @"mvc.1.0.view", @"/Views/Albuns/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Albuns/Index.cshtml", typeof(AspNetCore.Views_Albuns_Index))]
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
#line 1 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\_ViewImports.cshtml"
using ProjetoAlbumFotos;

#line default
#line hidden
#line 2 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\_ViewImports.cshtml"
using ProjetoAlbumFotos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0958d6f2b311bcf8c9fc7f0c1c1eeb80be31703e", @"/Views/Albuns/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dcaa7a8c94be0ceb8bfd3f69dbb895ef04028e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Albuns_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoAlbumFotos.Models.Album>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("waves-effect waves-light btn-small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small blue darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small orange darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
  
    ViewData["Title"] = "Albuns";

#line default
#line hidden
            BeginContext(96, 88, true);
            WriteLiteral("\r\n<div class=\"listDestinos\">\r\n\r\n    <div class=\"container\">\r\n\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(184, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0958d6f2b311bcf8c9fc7f0c1c1eeb80be31703e5631", async() => {
                BeginContext(250, 10, true);
                WriteLiteral("Novo Album");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 181, true);
            WriteLiteral("\r\n        </p>\r\n        <table class=\"table striped highlight hover responsive-table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(446, 43, false);
#line 18 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(489, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(569, 46, false);
#line 21 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(615, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(695, 43, false);
#line 24 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(738, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 30 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(929, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1014, 42, false);
#line 34 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1148, 45, false);
#line 37 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1285, 42, false);
#line 40 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DataFim));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1418, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0958d6f2b311bcf8c9fc7f0c1c1eeb80be31703e10525", async() => {
                BeginContext(1500, 9, true);
                WriteLiteral("Atualizar");
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
#line 43 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                                                   WriteLiteral(item.AlbumId);

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
            BeginContext(1513, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1545, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0958d6f2b311bcf8c9fc7f0c1c1eeb80be31703e12996", async() => {
                BeginContext(1632, 5, true);
                WriteLiteral("Fotos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                                                      WriteLiteral(item.AlbumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1641, 99, true);
            WriteLiteral(" |\r\n                            <a class=\"btn-small red darken-4 modal-trigger\" data-target=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1740, "\"", 1772, 3);
            WriteAttributeValue("", 1750, "Excluir(", 1750, 8, true);
#line 45 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
WriteAttributeValue("", 1758, item.AlbumId, 1758, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1771, ")", 1771, 1, true);
            EndWriteAttribute();
            BeginContext(1773, 72, true);
            WriteLiteral(">Excluir</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\src\ProjetoASPNETCOREMVC2\ProjetoImagens\ProjetoAlbumFotos\Views\Albuns\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1864, 471, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>


<!-- Modal Structure -->
<div id=""modal"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar Exclusão</h4>
        <p>Deseja proseguir com a exclusão?</p>
    </div>
    <div class=""modal-footer"">
        <a  class=""modal-close waves-effect waves-green btn-flat btn-Confirmar"">Sim</a>
        <a  class=""modal-close waves-effect waves-green btn-flat"">Não</a>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2353, 599, true);
                WriteLiteral(@"


    <script>


       function Excluir(idRecebido) {

            $("".modal"").modal();

           $("".btn-Confirmar"").on(""click"", function () {

                $.ajax({
                    url: ""/Albuns/Delete"",
                    method: ""POST"",
                    data: { id: idRecebido },
                    success: function (data) {
                        console.log(data);
                        $("".modal"").modal(""close"");
                        location.reload(true);
                    }
                })
            });

        };

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoAlbumFotos.Models.Album>> Html { get; private set; }
    }
}
#pragma warning restore 1591
