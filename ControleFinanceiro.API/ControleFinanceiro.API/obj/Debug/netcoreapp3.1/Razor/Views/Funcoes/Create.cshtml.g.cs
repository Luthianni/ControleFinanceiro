#pragma checksum "C:\Users\LuthianniAlves\Documents\ControleFInanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b20e057885d7e5b595482f5803fae0f9dcfa94c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcoes_Create), @"mvc.1.0.view", @"/Views/Funcoes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b20e057885d7e5b595482f5803fae0f9dcfa94c", @"/Views/Funcoes/Create.cshtml")]
    public class Views_Funcoes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleFinanceiro.BLL.Models.Funcao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LuthianniAlves\Documents\ControleFInanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Funcao</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Descricao"" class=""control-label""></label>
                <input asp-for=""Descricao"" class=""form-control"" />
                <span asp-validation-for=""Descricao"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NormalizedName"" class=""control-label""></label>
                <input asp-for=""NormalizedName"" class=""form-control"" />
                <span asp-validation-for=""NormalizedName"" class=""text-dan");
            WriteLiteral(@"ger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ConcurrencyStamp"" class=""control-label""></label>
                <input asp-for=""ConcurrencyStamp"" class=""form-control"" />
                <span asp-validation-for=""ConcurrencyStamp"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\LuthianniAlves\Documents\ControleFInanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControleFinanceiro.BLL.Models.Funcao> Html { get; private set; }
    }
}
#pragma warning restore 1591
