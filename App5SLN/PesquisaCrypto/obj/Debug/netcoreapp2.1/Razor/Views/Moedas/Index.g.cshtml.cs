#pragma checksum "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78316e04beca722ceb1254841910eed45cd2659e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Moedas_Index), @"mvc.1.0.view", @"/Views/Moedas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Moedas/Index.cshtml", typeof(AspNetCore.Views_Moedas_Index))]
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
#line 1 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\_ViewImports.cshtml"
using PesquisaCrypto;

#line default
#line hidden
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\_ViewImports.cshtml"
using PesquisaCrypto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78316e04beca722ceb1254841910eed45cd2659e", @"/Views/Moedas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8b6b20da7392c9950c0cff7059db5b96ff2dbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Moedas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PesquisaCrypto.Models.Moedas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Grafico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 32, true);
            WriteLiteral("\r\n<h2>Moedas</h2>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(82, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07f625d4a4034b2f9fe1febdddc5c393", async() => {
                BeginContext(126, 11, true);
                WriteLiteral("Criar Moeda");
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
            BeginContext(141, 64, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n");
            EndContext();
#line 11 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
            BeginContext(249, 185, true);
            WriteLiteral("            <thead>\r\n                <tr>\r\n                    <td>Nome</td>\r\n                    <td>Quantidade</td>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 20 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
                 foreach (var m in Model)
                {

#line default
#line hidden
            BeginContext(496, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(551, 28, false);
#line 23 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
                       Write(Html.DisplayFor(x => m.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(579, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(615, 34, false);
#line 24 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
                       Write(Html.DisplayFor(x => m.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(649, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 26 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(702, 22, true);
            WriteLiteral("            </tbody>\r\n");
            EndContext();
#line 28 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(760, 31, true);
            WriteLiteral("            <p>Sem moedas</p>\r\n");
            EndContext();
#line 32 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(802, 72, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n<div>\r\n    <div class=\"well col-lg-6\">\r\n        ");
            EndContext();
            BeginContext(875, 37, false);
#line 38 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App5SLN\PesquisaCrypto\Views\Moedas\Index.cshtml"
   Write(await Component.InvokeAsync("Moedas"));

#line default
#line hidden
            EndContext();
            BeginContext(912, 35, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(947, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6bf153325c1e4ae0a09f61ffc19695eb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(973, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(999, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d78d8b4f1e446dbe8bd3e4f5832e0f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1050, 1727, true);
            WriteLiteral(@"
<script>

    function PegarMoedas(dados) {
        let moedas = [];
        let index = 0;

        while (index < dados.length) {
            moedas.push(dados[index].nome);
            index++;
        }
        return moedas;
    }

    function PegarQuantidades(dados) {

        let valores = [];
        let index = 0;

        while (index < dados.length) {
            valores.push(dados[index].quantidade);
            index++;
        }

        return valores;
    }

    function PegarCores(quantidade) {

        let cores = [];
        let index = 0;
        while (index < quantidade) {
            let r = Math.floor(Math.random() * 255);
            let g = Math.floor(Math.random() * 255);
            let b = Math.floor(Math.random() * 255);

            let cor = `rgb(${r},${g},${b})`;
            cores.push(cor);
            index++;
        }
        return cores;
    }

    $.ajax({
        type: 'GET',
        url: 'Moedas/DadosGrafico',
        su");
            WriteLiteral(@"ccess: function (dados) {
            new Chart($(""#grafico""), {
                type: 'pie',
                data: {
                    labels: PegarMoedas(dados),
                    dataSet: [{
                        labels: 'Quantidade',
                        borderWidth: 2,
                        backgroundColor: PegarCores(dados.length),
                        data: PegarQuantidades(dados)
                    }]
                },
                options: {
                    title: {
                        display: true,
                        text: 'Quantidade em cada moeda'
                    }
                }
            })
        }
    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PesquisaCrypto.Models.Moedas>> Html { get; private set; }
    }
}
#pragma warning restore 1591