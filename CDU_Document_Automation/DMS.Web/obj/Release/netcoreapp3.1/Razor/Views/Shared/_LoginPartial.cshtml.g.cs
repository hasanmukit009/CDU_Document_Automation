#pragma checksum "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Shared/_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ecdaa041007d07e8631c5baa963b4ac384c50f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#nullable restore
#line 1 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Shared/_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ecdaa041007d07e8631c5baa963b4ac384c50f", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8281e661d56b0acb33daeb187f748c623fa8d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<ul class=\"navbar-nav\">\n");
#nullable restore
#line 6 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Shared/_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Shared/_LoginPartial.cshtml"
           
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/uvishere/Projects/CDU_Document_Automation/CDU_Document_Automation/DMS.Web/Views/Shared/_LoginPartial.cshtml"
           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
