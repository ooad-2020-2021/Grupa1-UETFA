#pragma checksum "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0210c2bf1d859bb8b6ca133c1d7ba5f9cb5d39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LiveStream_Index), @"mvc.1.0.view", @"/Views/LiveStream/Index.cshtml")]
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
#line 1 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\_ViewImports.cshtml"
using UETFA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\_ViewImports.cshtml"
using UETFA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0210c2bf1d859bb8b6ca133c1d7ba5f9cb5d39", @"/Views/LiveStream/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a516bad03b6fc3954d434653e28a565f4a907a9", @"/Views/_ViewImports.cshtml")]
    public class Views_LiveStream_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UETFA.Controllers.PomocnaLS>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml"
  
    ViewData["Title"] = Model.Tim1 + " " + Model.Rezultat + " " + Model.Tim2;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"text-align: center; margin: auto\">\r\n    <h1 style=\"color:white;\">");
#nullable restore
#line 7 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml"
                        Write(Html.DisplayFor(model => model.Tim1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml"
                                                              Write(Html.DisplayFor(model => model.Rezultat));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.Tim2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br />\r\n    <iframe \r\n            type=\"text/html\" \r\n            width=\"1080\" \r\n            height=\"480\"");
            BeginWriteAttribute("src", " \r\n            src=\"", 433, "\"", 536, 3);
            WriteAttributeValue("", 453, "https://www.youtube.com/embed/live_stream?channel=", 453, 50, true);
#nullable restore
#line 13 "C:\Users\Hana\source\repos\Grupa1-UETFA\UETFA\UETFA\Views\LiveStream\Index.cshtml"
WriteAttributeValue("", 503, Model.FileName, 503, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 518, "&autoplay=1&mute=1", 518, 18, true);
            EndWriteAttribute();
            WriteLiteral("\r\n            frameborder=\"0\"\r\n            allowfullscreen\r\n            allow=\'autoplay\'>\r\n\r\n    </iframe>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UETFA.Controllers.PomocnaLS> Html { get; private set; }
    }
}
#pragma warning restore 1591
