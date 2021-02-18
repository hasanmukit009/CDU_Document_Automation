#pragma checksum "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0981139193182046c7f2cc974c0e8357ac8d4e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DashBoard), @"mvc.1.0.view", @"/Views/Home/DashBoard.cshtml")]
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
#line 1 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/_ViewImports.cshtml"
using DMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/_ViewImports.cshtml"
using DMS.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0981139193182046c7f2cc974c0e8357ac8d4e3c", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8281e661d56b0acb33daeb187f748c623fa8d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DMS.Web.Models.UnitInformationModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-lg-12"">
    <div class=""text-center"">
        <h4>DashBoard</h4>
    </div>
</div>
<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered table-hover"" id=""dataTable"">
                <thead>
                    <tr>
                        <th style=""width:100px"">C. Request</th>
                        <th style=""width:100px"">U. Code</th>
                        <th style=""width:100px"">UC</th>
                        <th style=""width:100px"">CC</th>
                        <th style=""width:100px"">Admin</th>
                        <th style=""width:100px"">Reviewer1</th>
                        <th style=""width:100px"">Reviewer2</th>
                        <th style=""width:100px"">Approver</th>
                        <th style=""width:100px"">Status</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 33 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ChangeRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 36 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UnitCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 39 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UnitCoordinator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 42 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AssignedCourseCoordinator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 45 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AssignedAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 48 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AssignedReviewer1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 51 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AssignedReviewer2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 54 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AssignedApprover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 57 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 60 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Home/DashBoard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DMS.Web.Models.UnitInformationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591