#pragma checksum "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5672fc00a7cf2373066246afed042473d92f178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Details), @"mvc.1.0.view", @"/Views/Pessoas/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/Details.cshtml", typeof(AspNetCore.Views_Pessoas_Details))]
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
#line 1 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\_ViewImports.cshtml"
using App4;

#line default
#line hidden
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\_ViewImports.cshtml"
using App4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5672fc00a7cf2373066246afed042473d92f178", @"/Views/Pessoas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d961b880057164904ae12cd2c3710644259a71", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App4.Models.Pessoa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pessoas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml"
  
    ViewData["Title"] = "Informações de " + Model.Nome;

#line default
#line hidden
            BeginContext(91, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(98, 17, false);
#line 6 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(115, 51, true);
            WriteLiteral("</h1>\r\n\r\n<table>\r\n    <tr>\r\n        <p><b>Id</b> - ");
            EndContext();
            BeginContext(167, 26, false);
#line 10 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml"
                  Write(Html.DisplayFor(i => i.Id));

#line default
#line hidden
            EndContext();
            BeginContext(193, 52, true);
            WriteLiteral("</p>\r\n    </tr>\r\n    <tr>\r\n        <p><b>Nome</b> - ");
            EndContext();
            BeginContext(246, 28, false);
#line 13 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml"
                    Write(Html.DisplayFor(i => i.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(274, 53, true);
            WriteLiteral("</p>\r\n    </tr>\r\n    <tr>\r\n        <p><b>Idade</b> - ");
            EndContext();
            BeginContext(328, 29, false);
#line 16 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Details.cshtml"
                     Write(Html.DisplayFor(i => i.Idade));

#line default
#line hidden
            EndContext();
            BeginContext(357, 29, true);
            WriteLiteral("</p>\r\n    </tr>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(386, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5672fc00a7cf2373066246afed042473d92f1785975", async() => {
                BeginContext(454, 14, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App4.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
