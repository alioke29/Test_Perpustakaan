#pragma checksum "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ef3cd81672b66fb6314592e242e6a1f0b09327"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
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
#line 1 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\_ViewImports.cshtml"
using TestPerpustakaan_VS2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\_ViewImports.cshtml"
using TestPerpustakaan_VS2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ef3cd81672b66fb6314592e242e6a1f0b09327", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e073eba97893472df6c92147707a75b7cc32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestPerpustakaan_VS2019.Library.Entities.MenuEntity.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml"
  

    ViewBag.Title = "Dashboard";



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"position:relative; left:0px; top:-30px; z-index:9999; float:left;\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 213, "\"", 248, 1);
#nullable restore
#line 13 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 220, Url.Action("Index", "Home"), 220, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"        TEST
    </a>
</div>


<nav class=""navbar-default navbar-static-side"" role=""navigation"" style=""padding-top:100px;"">
    <div class=""sidebar-collapse"" >
        <ul class=""nav"" id=""side-menu"">


            <li class=""nav-header"">

                <div class=""dropdown profile-element"">


");
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"logo-element\">\r\n\r\n                </div>\r\n            </li>\r\n\r\n\r\n\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 1063, "\"", 1144, 1);
#nullable restore
#line 43 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1071, Html.IsSelected(action: "Index", controller: "Home", cssClass: "active"), 1071, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a onclick=\"loadingProcess()\"");
            BeginWriteAttribute("href", " href=\"", 1193, "\"", 1228, 1);
#nullable restore
#line 44 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1200, Url.Action("Index", "Home"), 1200, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""fa fa-home""></i>
                    <span class=""nav-label"" data-i18n=""nav.dashboard"">
                        Home
                    </span>
                </a>
            </li>

            <!-- Get Treeview Control -->
            ");
#nullable restore
#line 53 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\_Navigation.cshtml"
       Write(Html.Partial("UserControls/TreeviewMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </ul>\r\n    </div>\r\n</nav>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestPerpustakaan_VS2019.Library.Entities.MenuEntity.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
