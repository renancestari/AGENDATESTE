#pragma checksum "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22771816edbea31f2438806a514c3442af3ca52e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ListaTarefas_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ListaTarefas/Default.cshtml")]
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
#line 1 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\_ViewImports.cshtml"
using AgendaTarefas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\_ViewImports.cshtml"
using AgendaTarefas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22771816edbea31f2438806a514c3442af3ca52e", @"/Views/Shared/Components/ListaTarefas/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f97fb722aa2bf7ccf8c8534cef2057fc25987ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ListaTarefas_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgendaTarefas.Models.Tarefa>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarTarefa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Configurado a view para atualizar e excluir -->\r\n\r\n<div class=\"border border-light shadow rounded rounded-lg p-4\">\r\n");
#nullable restore
#line 16 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
     if(Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"list-group\">\r\n");
#nullable restore
#line 19 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-2\">\r\n                            <span class=\"badge badge-info\">");
#nullable restore
#line 24 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Horario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n\r\n                        <div class=\"col-6\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"col-4\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22771816edbea31f2438806a514c3442af3ca52e6088", async() => {
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tarefaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
                                                                    WriteLiteral(item.TarefaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tarefaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tarefaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tarefaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"#\" class=\"btn btn-sm btn-outline-danger rounded-circle\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1211, "\"", 1268, 6);
            WriteAttributeValue("", 1221, "ConfirmarExclusao(", 1221, 18, true);
#nullable restore
#line 33 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
WriteAttributeValue("", 1239, item.TarefaId, 1239, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1253, ",", 1253, 1, true);
            WriteAttributeValue(" ", 1254, "\'", 1255, 2, true);
#nullable restore
#line 33 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
WriteAttributeValue("", 1256, item.Nome, 1256, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1266, "\')", 1266, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-times-circle\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 37 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 39 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-warning\">Sem tarefas ainda</p>\r\n");
#nullable restore
#line 43 "C:\Users\Renan\Desktop\AgendaTESTE\AgendaTarefas\AgendaTarefas\Views\Shared\Components\ListaTarefas\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgendaTarefas.Models.Tarefa>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
