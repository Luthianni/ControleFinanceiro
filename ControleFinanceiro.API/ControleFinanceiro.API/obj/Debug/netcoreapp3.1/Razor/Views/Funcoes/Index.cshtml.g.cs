#pragma checksum "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93836e5b75831b3f71ba616c252c18e5a228b63d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcoes_Index), @"mvc.1.0.view", @"/Views/Funcoes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93836e5b75831b3f71ba616c252c18e5a228b63d", @"/Views/Funcoes/Index.cshtml")]
    public class Views_Funcoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleFinanceiro.BLL.Models.Funcao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NormalizedName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NormalizedName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ConcurrencyStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1208, "\"", 1231, 1);
#nullable restore
#line 46 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
WriteAttributeValue("", 1223, item.Id, 1223, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1284, "\"", 1307, 1);
#nullable restore
#line 47 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
WriteAttributeValue("", 1299, item.Id, 1299, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1362, "\"", 1385, 1);
#nullable restore
#line 48 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
WriteAttributeValue("", 1377, item.Id, 1377, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\luthianni.alves.AJAXTI\OneDrive - AJL INFORMATICA LTDA\repos\Luthianni\ControleFinanceiro\ControleFinanceiro.API\ControleFinanceiro.API\Views\Funcoes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleFinanceiro.BLL.Models.Funcao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
