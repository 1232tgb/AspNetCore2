#pragma checksum "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42453381663517d406667dcdf384f845f97fd4de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Details), @"mvc.1.0.view", @"/Views/Tarefas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/Details.cshtml", typeof(AspNetCore.Views_Tarefas_Details))]
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
#line 1 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\_ViewImports.cshtml"
using App3;

#line default
#line hidden
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\_ViewImports.cshtml"
using App3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42453381663517d406667dcdf384f845f97fd4de", @"/Views/Tarefas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4ec52cbc070cf7a9a14b81c8bb4a87b8c9bd99", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App3.Models.Tarefas>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tarefas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
  
    ViewData["Title"] = $"Tarefa: {Model.Nome} - {Model.Id}";

#line default
#line hidden
            BeginContext(98, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(105, 17, false);
#line 6 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 253, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container\">\r\n    <div style=\"margin-bottom:10px;\" class=\"row\">\r\n        <h3>Tarefa escolhida:</h3>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom:10px;\" class=\"row\">\r\n        <table>\r\n            <tr>\r\n                <td><b>Id</b> - ");
            EndContext();
            BeginContext(376, 8, false);
#line 16 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(384, 78, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Nome</b> - ");
            EndContext();
            BeginContext(463, 10, false);
#line 19 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                             Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(473, 83, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Descrição</b> - ");
            EndContext();
            BeginContext(557, 15, false);
#line 22 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                                  Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(572, 85, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Data inicio</b> - ");
            EndContext();
            BeginContext(658, 12, false);
#line 25 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                                    Write(Model.Inicio);

#line default
#line hidden
            EndContext();
            BeginContext(670, 82, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Data fim</b> - ");
            EndContext();
            BeginContext(753, 9, false);
#line 28 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                                 Write(Model.Fim);

#line default
#line hidden
            EndContext();
            BeginContext(762, 93, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Nível de prioridade</b> - ");
            EndContext();
            BeginContext(856, 17, false);
#line 31 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Details.cshtml"
                                            Write(Model.Importancia);

#line default
#line hidden
            EndContext();
            BeginContext(873, 117, true);
            WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom:10px;\" class=\"row\">\r\n        ");
            EndContext();
            BeginContext(990, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "958d4898bff04d409461733878c2da85", async() => {
                BeginContext(1058, 14, true);
                WriteLiteral("Página inicial");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(1076, 22, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App3.Models.Tarefas> Html { get; private set; }
    }
}
#pragma warning restore 1591
