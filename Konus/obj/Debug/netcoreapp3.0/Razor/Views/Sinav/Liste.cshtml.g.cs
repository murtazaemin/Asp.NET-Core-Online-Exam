#pragma checksum "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aace77c476fa8e2fcb8bea11bb56f24c6b088af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sinav_Liste), @"mvc.1.0.view", @"/Views/Sinav/Liste.cshtml")]
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
#line 1 "C:\Users\MEA\source\repos\Konus\Konus\Views\_ViewImports.cshtml"
using Konus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aace77c476fa8e2fcb8bea11bb56f24c6b088af0", @"/Views/Sinav/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a271014482a2b12de325aa47ec6d94addf3325", @"/Views/_ViewImports.cshtml")]
    public class Views_Sinav_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
  
    ViewData["Title"] = "Liste";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
  
    var id = ViewBag.id ;
    var baslik = ViewBag.baslik;
    var tarih = ViewBag.tarih;
    int count = Enumerable.Count(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Sınav Listesi</h2>

<table class=""table table-bordered"" id=""SinavListe"">
    <thead>
        <tr>
            <th>ID</th>
            <th>BAŞLIK</th>
            <th>TARİH</th>
            <th>Sil</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 25 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
         for(int i = 0; i < count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
               Write(id[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
               Write(baslik[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
               Write(tarih[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><button class=\"btn btn-danger SinavSil\" data-id=\"");
#nullable restore
#line 31 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
                                                                Write(id[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Sil</button> </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\MEA\source\repos\Konus\Konus\Views\Sinav\Liste.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
