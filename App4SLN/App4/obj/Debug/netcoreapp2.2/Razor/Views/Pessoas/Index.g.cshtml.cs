#pragma checksum "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cb531df4672c872da933575571c0f624e0a27bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pessoas/Index.cshtml", typeof(AspNetCore.Views_Pessoas_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb531df4672c872da933575571c0f624e0a27bb", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d961b880057164904ae12cd2c3710644259a71", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App4.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Idosos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(81, 57, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n<div style=\"margin-bottom:10px;\">\r\n    ");
            EndContext();
            BeginContext(138, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cb531df4672c872da933575571c0f624e0a27bb4522", async() => {
                BeginContext(182, 21, true);
                WriteLiteral("Adicionar nova pessoa");
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
            BeginContext(207, 17, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 11 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
     if (Model.ToList().Count > 0)
    {
        

#line default
#line hidden
            BeginContext(1222, 47, false);
#line 38 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
   Write(await Html.PartialAsync("_Adolescentes", Model));

#line default
#line hidden
            EndContext();
#line 38 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
                                                        ;
        

#line default
#line hidden
            BeginContext(1281, 42, false);
#line 39 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
   Write(await Html.PartialAsync("_Adultos", Model));

#line default
#line hidden
            EndContext();
#line 39 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
                                                   ;

#line default
#line hidden
            BeginContext(1326, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1334, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7cb531df4672c872da933575571c0f624e0a27bb7192", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 40 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1374, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
       
    }
    else
    {

#line default
#line hidden
            BeginContext(1409, 46, true);
            WriteLiteral("        <h2>Não há pessoas cadastradas.</h2>\r\n");
            EndContext();
#line 46 "C:\Users\THIAGO\Desktop\GitPasta\AspNetCore2\App4SLN\App4\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1462, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App4.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
