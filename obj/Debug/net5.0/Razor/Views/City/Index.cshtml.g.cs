#pragma checksum "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02d53c58de823080ee0e5e948931b67d7ef1e41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_City_Index), @"mvc.1.0.view", @"/Views/City/Index.cshtml")]
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
#line 1 "/Users/arshia/Projects/Ediucation/Views/_ViewImports.cshtml"
using Ediucation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arshia/Projects/Ediucation/Views/_ViewImports.cshtml"
using Ediucation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02d53c58de823080ee0e5e948931b67d7ef1e41", @"/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd61f05288afa416dc7648ea13f996f4ca83cefd", @"/Views/_ViewImports.cshtml")]
    public class Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Education.Models.CityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<table>\n    This is the List of Cities\n");
#nullable restore
#line 6 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
     foreach (var item in Model.Cities)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n\n            <td>\n                ");
#nullable restore
#line 11 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n            </td>\n            <td>\n                ");
#nullable restore
#line 14 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
           Write(item.City_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n           <td>\n               ");
#nullable restore
#line 17 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
          Write(item.ProvinceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n           </td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 399, 2);
            WriteAttributeValue("", 375, "/City/Delete?ID=", 375, 16, true);
#nullable restore
#line 20 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
WriteAttributeValue("", 391, item.ID, 391, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    Delete\n                </a>\n            </td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 503, "\"", 534, 2);
            WriteAttributeValue("", 510, "/City/Update?ID=", 510, 16, true);
#nullable restore
#line 25 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
WriteAttributeValue("", 526, item.ID, 526, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    Update\n                </a>\n            </td>\n        </tr>\n");
#nullable restore
#line 30 "/Users/arshia/Projects/Ediucation/Views/City/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Education.Models.CityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
