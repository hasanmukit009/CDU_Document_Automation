#pragma checksum "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9cebea94eed38bf34b9b9626f0404b0da0e97e"
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
#line 1 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\_ViewImports.cshtml"
using DMS.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\_ViewImports.cshtml"
using DMS.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9cebea94eed38bf34b9b9626f0404b0da0e97e", @"/Views/Home/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be8df83adfac8ee8e703d1dd07ae876a55d07e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DMS.Web.Models.UnitInformationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col-sm-6\">\r\n        </div><!-- /.col -->\r\n        <div class=\"col-sm-6\">\r\n            <ol class=\"breadcrumb float-sm-right\">\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9cebea94eed38bf34b9b9626f0404b0da0e97e4605", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"">Dashboard</li>
            </ol>
        </div><!-- /.col -->
    </div><!-- /.row -->
</div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <table id=""tblDashboard"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Change Request</th>
                                <th>Unit Code</th>
                                <th>Unit Coordinator</th>
                                <th>Course Coordinator</th>
                                <th>Admin</th>
                                <th>Reviewer1</th>
                                <th>Reviewer2</th>
                                <th>Approver</th>
                                <th>Status</th>
                            </tr>
                        </thead>
   ");
            WriteLiteral("                     <tbody>\r\n");
#nullable restore
#line 38 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 42 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ChangeRequest));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 45 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UnitCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 48 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "UC")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 51 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.UnitCoordinator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 53 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UnitCoordinator));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                               
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 60 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "CC")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 63 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssignedCourseCoordinator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 65 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AssignedCourseCoordinator));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                                         
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 72 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "Admin")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 75 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssignedAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 77 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AssignedAdmin));

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 84 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "Reviewer")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 87 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssignedReviewer1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 89 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AssignedReviewer1));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 96 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "Reviewer")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 99 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssignedReviewer2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 101 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AssignedReviewer2));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 108 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.CurrentPosition == "Approver")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 111 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssignedApprover));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 113 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.AssignedApprover));

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                                                                                
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 120 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                         if (item.Status == "Approved")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-success\">\r\n                                                ");
#nullable restore
#line 123 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 125 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge bg-danger\">\r\n                                                ");
#nullable restore
#line 129 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 131 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 134 "E:\Repository\CDU Document Automation\CDU_Document_Automation\DMS.Web\Views\Home\DashBoard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</div>");
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
