#pragma checksum "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97746f4d1cc8c6ff264a140e839b6f11e6d1bab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\_ViewImports.cshtml"
using FaixaEtaria;

#line default
#line hidden
#line 2 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\_ViewImports.cshtml"
using FaixaEtaria.Models;

#line default
#line hidden
#line 1 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
using ViewData.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97746f4d1cc8c6ff264a140e839b6f11e6d1bab3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe3714c5caaf3a5254ce8143415b31fb2ed57ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(69, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(74, 17, false);
#line 7 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(91, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(103, 19, false);
#line 8 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 72, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n\r\n\r\n\r\n");
            EndContext();
#line 14 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
 foreach (var p in ViewData["RecebeProduto"] as List<Produto>)
{

#line default
#line hidden
            BeginContext(261, 22, true);
            WriteLiteral("    <ul>\r\n        <li>");
            EndContext();
            BeginContext(284, 6, false);
#line 17 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
       Write(p.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(290, 19, true);
            WriteLiteral("</li>\r\n        <li>");
            EndContext();
            BeginContext(310, 7, false);
#line 18 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
       Write(p.Preco);

#line default
#line hidden
            EndContext();
            BeginContext(317, 18, true);
            WriteLiteral("</li>\r\n    </ul>\r\n");
            EndContext();
#line 20 "C:\GitHub\ProjetoASPNETCOREMVC2\ListaTarefas\ViewData\Views\Home\About.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
