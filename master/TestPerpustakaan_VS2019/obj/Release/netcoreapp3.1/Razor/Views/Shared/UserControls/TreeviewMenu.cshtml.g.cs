#pragma checksum "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df6aac5919b135434ff51eb3ca071272f0adffef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_UserControls_TreeviewMenu), @"mvc.1.0.view", @"/Views/Shared/UserControls/TreeviewMenu.cshtml")]
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
#nullable restore
#line 2 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
using TestPerpustakaan_VS2019.Library.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6aac5919b135434ff51eb3ca071272f0adffef", @"/Views/Shared/UserControls/TreeviewMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e073eba97893472df6c92147707a75b7cc32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_UserControls_TreeviewMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestPerpustakaan_VS2019.Library.Entities.MenuEntity.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Ajax Loading Control -->\r\n");
#nullable restore
#line 5 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
Write(Html.Partial("UserControls/AjaxLoadingControl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 9 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
 if (Model != null && Model.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
     foreach (var item in Model.Where(x => x.ID != 1)
                               .Where(x => string.IsNullOrEmpty(x.ParentMenuCode)))
    {



        if (ViewData["vdTreeviewMenuCode"] != null)
        {
            if (item.Code == ViewData["vdTreeviewMenuCode"].ToString())
            {
                ViewData["vdActive"] = "active";
            }
            else
            {
                ViewData["vdActive"] = "";
            }
        }
        else
        {
            ViewData["vdActive"] = "";
        }



#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 820, "\"", 928, 1);
#nullable restore
#line 34 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
WriteAttributeValue("", 828, Html.IsSelected(action: item.UrlNav, controller: "Home", cssClass: ViewData["vdActive"].ToString()), 828, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a href=\"#\">\r\n\r\n");
#nullable restore
#line 37 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
                 if (item.DisplayName.ToString().ToLower() == EnumCollection.ParentMenuName.SecurityManagement.ToLower())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fa fa-gears\"></i>\r\n");
#nullable restore
#line 40 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"nav-label\" data-i18n=\"nav.dashboard\">\r\n                    ");
#nullable restore
#line 43 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n\r\n                <span class=\"fa arrow\"></span>\r\n            </a>\r\n\r\n\r\n            <ul class=\"nav nav-second-level collapse\">\r\n\r\n");
#nullable restore
#line 52 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
                 foreach (var item2 in Model.Where(x => !string.IsNullOrEmpty(x.ParentMenuCode) && x.ParentMenuCode == item.Code))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a onclick=\"loadingProcess()\"");
            BeginWriteAttribute("href", " href=\"", 1666, "\"", 1751, 1);
#nullable restore
#line 56 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
WriteAttributeValue("", 1673, Url.Action(item2.UrlNav, "Home", new { code = item.Code + "_" + item2.Code }), 1673, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 57 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
                       Write(item2.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 60 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n\r\n\r\n        </li>\r\n");
#nullable restore
#line 67 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\UserControls\TreeviewMenu.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    function loadingProcess() {\r\n        $(\"#mask\").show();\r\n    }\r\n\r\n</script>");
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
