#pragma checksum "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbb15f056e5ed647281d0640284ef181d91a79d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utakmice_Notifikacije), @"mvc.1.0.view", @"/Views/Utakmice/Notifikacije.cshtml")]
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
#line 1 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\_ViewImports.cshtml"
using UETFA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\_ViewImports.cshtml"
using UETFA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbb15f056e5ed647281d0640284ef181d91a79d", @"/Views/Utakmice/Notifikacije.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a516bad03b6fc3954d434653e28a565f4a907a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Utakmice_Notifikacije : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UETFA.Models.Utakmica>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
  
    ViewData["Title"] = "Notifikacije";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span style=""color:white;""> </span>
<h1 style=""color:white;"">Notifikacije o zavrsenim utakmicama</h1>


<table class=""table"">
    <thead>
        <tr style=""color:white"" class=""text-center"">
            <th>
                Obavijest
            </th>
            <th>
                ");
#nullable restore
#line 17 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(Html.DisplayNameFor(model => model.datumUtakmice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(Html.DisplayNameFor(model => model.idTima1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(Html.DisplayNameFor(model => model.idTima2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                Rezultat\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
         for (var i = 0; i < ViewBag.nazivi1.Count; i++)

        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
             foreach (var item in Model.Reverse())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"color:white\" class=\"text-center\">\r\n            <td>\r\n                Zavrsena je utakmica\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(Html.DisplayFor(modelItem => item.datumUtakmice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(ViewBag.nazivi1[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(ViewBag.nazivi2[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
           Write(Html.DisplayFor(modelItem => item.rezTim1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 52 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.rezTim2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
                i++;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Toshiba\Source\Repos\ooad-2020-2021\Grupa1-UETFA\UETFA\UETFA\Views\Utakmice\Notifikacije.cshtml"
             
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UETFA.Models.Utakmica>> Html { get; private set; }
    }
}
#pragma warning restore 1591