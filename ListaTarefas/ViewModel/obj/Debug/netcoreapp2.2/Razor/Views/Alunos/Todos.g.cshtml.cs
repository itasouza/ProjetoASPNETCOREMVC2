#pragma checksum "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be0de4b31b8d257d9fb2e3b87baddc96cecf2e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Todos), @"mvc.1.0.view", @"/Views/Alunos/Todos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alunos/Todos.cshtml", typeof(AspNetCore.Views_Alunos_Todos))]
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
#line 1 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\_ViewImports.cshtml"
using ViewModel;

#line default
#line hidden
#line 2 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\_ViewImports.cshtml"
using ViewModel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be0de4b31b8d257d9fb2e3b87baddc96cecf2e1", @"/Views/Alunos/Todos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147e23ca4f5315fe200c88601892203f60461b1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Todos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel.ViewModels.TodosViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 53, true);
            WriteLiteral("\r\n<div class=\"alert alert-info\">\r\n    <p>Alunos</p>\r\n");
            EndContext();
#line 9 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
     foreach (var item in Model.Alunos)
    {

#line default
#line hidden
            BeginContext(189, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(201, 9, false);
#line 11 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
      Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(210, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 12 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
    }

#line default
#line hidden
            BeginContext(223, 65, true);
            WriteLiteral("</div>\r\n\r\n\r\n<div class=\"alert alert-info\">\r\n    <p>Matérias</p>\r\n");
            EndContext();
#line 18 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
     foreach (var item in Model.Materias)
    {

#line default
#line hidden
            BeginContext(338, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(350, 9, false);
#line 20 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
      Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(359, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewModel\Views\Alunos\Todos.cshtml"
    }

#line default
#line hidden
            BeginContext(372, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel.ViewModels.TodosViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591