#pragma checksum "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8221dc0b89c058710ff57c28d9da6823bc4ab5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8221dc0b89c058710ff57c28d9da6823bc4ab5", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd61f05288afa416dc7648ea13f996f4ca83cefd", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Education.Models.StudentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<h2>\n    This Is The List Of Students And Their Information\n</h2>\n\n<table>\n");
#nullable restore
#line 9 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
     foreach (var Item in Model.Students)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            <p>Student ID=</p> ");
#nullable restore
#line 13 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                          Write(Item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>Student Name=</p> ");
#nullable restore
#line 16 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                            Write(Item.Student_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>Student LAstName=</p>  ");
#nullable restore
#line 19 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                                 Write(Item.Student_LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>Student Gender=</p> ");
#nullable restore
#line 22 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                              Write(Item.Student_Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>Student Father Name=</p>  ");
#nullable restore
#line 25 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                                    Write(Item.Student_FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>kode meli=</p>   ");
#nullable restore
#line 28 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                           Write(Item.Student_ValidateNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>Student Number=</p>  ");
#nullable restore
#line 31 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                               Write(Item.Student_Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>student address=</p>   ");
#nullable restore
#line 34 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                                 Write(Item.Student_Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <p>City code=</p>  ");
#nullable restore
#line 37 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
                          Write(Item.CityID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            <a");
            BeginWriteAttribute("href", " href=\"", 951, "\"", 985, 2);
            WriteAttributeValue("", 958, "/Student/Delete?ID=", 958, 19, true);
#nullable restore
#line 40 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
WriteAttributeValue("", 977, Item.ID, 977, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                Delete\n            </a>\n        </td>\n        <td>\n            <a");
            BeginWriteAttribute("href", " href=\"", 1069, "\"", 1103, 2);
            WriteAttributeValue("", 1076, "/Student/Update?ID=", 1076, 19, true);
#nullable restore
#line 45 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
WriteAttributeValue("", 1095, Item.ID, 1095, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                Update\n            </a>\n        </td>\n    </tr>\n");
#nullable restore
#line 50 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 52 "/Users/arshia/Projects/Ediucation/Views/Student/Index.cshtml"
Write(Html.ActionLink("Enter New Student","Create"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Education.Models.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
