#pragma checksum "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e041a81c765170d1de28fc4f54226fc0777b195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefas_Index), @"mvc.1.0.view", @"/Views/Tarefas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefas/Index.cshtml", typeof(AspNetCore.Views_Tarefas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e041a81c765170d1de28fc4f54226fc0777b195", @"/Views/Tarefas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4ec52cbc070cf7a9a14b81c8bb4a87b8c9bd99", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App3.Models.Tarefas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(83, 7, true);
            WriteLiteral("\r\n<h2> ");
            EndContext();
            BeginContext(91, 17, false);
#line 7 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 57, true);
            WriteLiteral("</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 11 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
         if (Model.ToList().Count > 0)
        {

#line default
#line hidden
            BeginContext(216, 409, true);
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nome</th>
                        <th>Descrição</th>
                        <th>Início</th>
                        <th>Fim</th>
                        <th>Importância</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 25 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                     foreach (Tarefas t in Model)
                    {

#line default
#line hidden
            BeginContext(699, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(762, 4, false);
#line 28 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Id);

#line default
#line hidden
            EndContext();
            BeginContext(766, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(806, 6, false);
#line 29 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(812, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(852, 11, false);
#line 30 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(863, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(903, 8, false);
#line 31 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Inicio);

#line default
#line hidden
            EndContext();
            BeginContext(911, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(951, 5, false);
#line 32 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Fim);

#line default
#line hidden
            EndContext();
            BeginContext(956, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(996, 13, false);
#line 33 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                           Write(t.Importancia);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 73, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1082, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fb94268d0e14a1a90da5e744a3369a8", async() => {
                BeginContext(1148, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                                                          WriteLiteral(t.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1160, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1194, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e3b8b5372f4c21ae993a81561263c3", async() => {
                BeginContext(1262, 9, true);
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
#line 36 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                                                         WriteLiteral(t.Id);

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
            BeginContext(1275, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(1309, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f6cf24cb5845878749df33c3036ccb", async() => {
                BeginContext(1376, 7, true);
                WriteLiteral("Deletar");
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
#line 37 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                                                         WriteLiteral(t.Id);

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
            BeginContext(1387, 104, true);
            WriteLiteral("\r\n                                \r\n\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1514, 50, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 46 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1600, 50, true);
            WriteLiteral("            <h3>Não há tarefas cadastradas.</h3>\r\n");
            EndContext();
#line 50 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App3SLN\App3\Views\Tarefas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1661, 43, true);
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(1704, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d399e7055284c978a695d2acdcb6951", async() => {
                BeginContext(1748, 16, true);
                WriteLiteral("Cadastrar Tarefa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1768, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App3.Models.Tarefas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
