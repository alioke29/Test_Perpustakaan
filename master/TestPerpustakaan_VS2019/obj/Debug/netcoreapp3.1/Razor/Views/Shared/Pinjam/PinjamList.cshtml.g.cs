#pragma checksum "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c13afc328d958022d7eefbc5f469ab6b4648c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Pinjam_PinjamList), @"mvc.1.0.view", @"/Views/Shared/Pinjam/PinjamList.cshtml")]
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
#line 1 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
using TestPerpustakaan_VS2019.Library.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
using TestPerpustakaan_VS2019.Library.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c13afc328d958022d7eefbc5f469ab6b4648c8", @"/Views/Shared/Pinjam/PinjamList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e073eba97893472df6c92147707a75b7cc32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Pinjam_PinjamList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/daterangepicker/daterangepicker-bs3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/bootstrap-datepicker/dist/css/bootstrap-datepicker3.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/metisMenu.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jeditable/jquery.jeditable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert-dev.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/daterangepicker/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/js/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/script.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/js_custom/pinjam.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
  
    //ViewData["Title"] = "Pinjam List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Ajax Loading Control -->\r\n");
#nullable restore
#line 11 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
Write(Html.Partial("UserControls/AjaxLoadingControl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Pinjam Detail Control -->\r\n");
#nullable restore
#line 14 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
Write(Html.Partial("Pinjam/PinjamDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n<div class=\"row border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>");
#nullable restore
#line 21 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
       Write(ViewData["vdDisplayName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li>\r\n                <a onclick=\"loadingProcess()\"");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 591, 1);
#nullable restore
#line 24 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
WriteAttributeValue("", 562, Url.Action("Index", "Home" ), 562, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n            </li>\r\n            <li>\r\n                ");
#nullable restore
#line 27 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
           Write(ViewData["vdParentName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li class=\"active\">\r\n                <strong>");
#nullable restore
#line 30 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
                   Write(ViewData["vdDisplayName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
            </li>
        </ol>

    </div>

</div>


<div style=""position:absolute; margin-top:-65px; margin-left:900px"">

    <button class=""btn btn-primary btn-sm"" onclick=""getView('', '', '', '', '', '', '', '', '');""
            data-toggle=""tooltip"" data-placement=""bottom"" title=""Add"">
        <i class=""fa fa-plus""></i>
        NEW
    </button>

    <button class=""btn btn-primary btn-sm btnDownload""
            data-toggle=""tooltip"" data-placement=""bottom"" title=""Export"">
        <i class=""fa fa-download""></i>
        EXPORT
    </button>

</div>



<div class=""row border-bottom btn-primary page-heading"" style=""padding-top:10px; height:70px"">
</div>


<table style=""position:absolute; margin-top:-60px"">
    <thead>
        <tr>
            <th class=""text-left col-lg-3 text-white"">Judul Buku</th>
            <th class=""text-right""></th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td class=""col-lg-3"">
                <input id=""txtJu");
            WriteLiteral("dulBukuFilter\" type=\"text\" placeholder=\"Judul Buku\" style=\"width:200px\"");
            BeginWriteAttribute("value", " value=\"", 1902, "\"", 1940, 1);
#nullable restore
#line 71 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
WriteAttributeValue("", 1910, ViewData["vdJudulBukuFilter"], 1910, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            </td>
            <td align=""left"">
                <span style=""margin-right:0px;"">
                    <button class=""btn btn-white btn-sm"" onclick=""getFilter();""
                            data-toggle=""tooltip"" data-placement=""bottom"" title=""Filter"">
                        <i class=""fa fa-filter btn-primary""></i>
                        &nbsp;<b style=""color:black"">Filter</b>
                    </button>
                    <button class=""btn btn-white btn-sm"" onclick=""getReset();"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Reset"">
                        <i class=""fa fa-refresh btn-primary""></i>
                        &nbsp;<b style=""color:black"">Reset</b>
                    </button>
                </span>
            </td>
        </tr>
    </tbody>
</table>



<div class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins panel panel-primary"">
                <div class=""ibox");
            WriteLiteral(@"-title panel-heading"">
                    <h5>Mode : LIST</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"" style=""overflow:scroll; overflow-x:scroll; overflow-y:hidden;"">

                    <table class=""table table-striped table-bordered table-hover pinjamTable"" style=""width:150%;"">
                        <thead>
                            <tr>
                                <th class=""text-center"" width=""10%"">Action</th>
                                <th class=""text-center"">No.</th>
                                <th class=""text-center"">Judul Buku</th>
                                <th class=""text-center"">Pengarang</th>
                                <th class=""text-center"">Jenis Buku</th>
                                <th class=""text-center"">Harg");
            WriteLiteral(@"a Sewa Per Hari (Rp)</th>
                                <th class=""text-center"">Tanggal Mulai</th>
                                <th class=""text-center"">Tanggal Selesai</th>
                                <th class=""text-center"">Total Sewa</th>
                            </tr>
                        </thead>

                    </table>

                </div>
            </div>
        </div>
    </div>


</div>


");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9c13afc328d958022d7eefbc5f469ab6b4648c816294", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9c13afc328d958022d7eefbc5f469ab6b4648c817473", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9c13afc328d958022d7eefbc5f469ab6b4648c818652", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9c13afc328d958022d7eefbc5f469ab6b4648c819831", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9c13afc328d958022d7eefbc5f469ab6b4648c821014", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"//netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c822480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c823580", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c824680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c825780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c826880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c827981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c829086", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c830187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#nullable restore
#line 152 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Pinjam\PinjamList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c13afc328d958022d7eefbc5f469ab6b4648c832182", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">

        $(document).ready(function () {


            // --------- DATE PICKER ---------
            $('.tanggalMulai').datepicker({
                todayBtn: ""linked"",
                keyboardNavigation: false,
                forceParse: false,
                calendarWeeks: true,
                autoclose: true
            });

            // --------- DATE PICKER ---------
            $('.tanggalSelesai').datepicker({
                todayBtn: ""linked"",
                keyboardNavigation: false,
                forceParse: false,
                calendarWeeks: true,
                autoclose: true
            });



            var myDate = new Date();


            var judulBuku = $(""#txtJudulBukuFilter"").val();

            var getFilter;
            if (judulBuku == '')
                getFilter = ""/Pinjam/AjaxHandlerPinjamList"";
            else
                getFilter = ""/Pinjam/AjaxHandlerPinjamList/?isFilter=true&judulBuku");
                WriteLiteral(@"="" + judulBuku;


            $('.pinjamTable').DataTable({
                bServerSide: true,
                sAjaxSource: getBaseURL() + getFilter,
                bProcessing: false,
                aoColumns: [

                    {
                        mRender: function (ID_IDBuku_JudulBuku_Pengarang_JenisBuku_HargaSewa_TanggalMulai_TanggalSelesai_TotalSewa) {

                            var value = ID_IDBuku_JudulBuku_Pengarang_JenisBuku_HargaSewa_TanggalMulai_TanggalSelesai_TotalSewa.split("","");
                            var ID = value[0];
                            var IDBuku = value[1];
                            var JudulBuku = value[2];
                            var Pengarang = value[3];
                            var JenisBuku = value[4];
                            var HargaSewa = value[5];
                            var TanggalMulai = value[6];
                            var TanggalSelesai = value[7];
                            var TotalSewa = value[8];

   ");
                WriteLiteral(@"                         return '<center><a onclick=""getView(' + ID + ', ' + IDBuku + ', ' + ""'"" + Pengarang + ""'"" + ', ' + ""'"" + JenisBuku + ""'"" + ', ' +
                                ""'"" + HargaSewa + ""'"" + ', ' + ""'"" + TanggalMulai + ""'"" + ', ' + ""'"" + TanggalSelesai + ""'"" + ', ' + ""'"" + TotalSewa + ""'"" + ', event);"" ' +
                                'href=""#"" class=""btn btn-primary btn-sm"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Edit"" > <i class=""fa fa-pencil""></i></a > ' +
                                '&nbsp;&nbsp;<button class=""btn btn-primary btn-sm btnDelete"" onclick=""getDelete(' + ID + ', ' + ""'"" + JudulBuku + ""'"" + ');"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Delete""><i class=""fa fa-trash""></i></button></center>';


                        }
                    },
                    {
                        mRender: function (data, type, row, meta) {

                            return '<center>' + (meta.row + meta.settings._iDisplayStart + 1) + '</cente");
                WriteLiteral(@"r>';
                        }
                    },
                    { mRender: function (JudulBuku) { return JudulBuku; } },
                    { mRender: function (Pengarang) { return Pengarang; } },
                    { mRender: function (JenisBuku) { return JenisBuku; } },
                    { mRender: function (HargaSewa) { return '<div style=""text-align:right;"">' + HargaSewa + '</div>'; } },
                    { mRender: function (TanggalMulai) { return '<div style=""width:100px;"">' + TanggalMulai + '</div>'; } },
                    { mRender: function (TanggalSelesai) { return '<div style=""width:100px;"">' + TanggalSelesai + '</div>'; } },
                    { mRender: function (TotalSewa) { return '<div style=""text-align:right;"">' + TotalSewa + '</div>'; } },

                ],
                lengthMenu: [
                    [10, 20, 50, 100],
                    [10, 20, 50, 100]
                ],
                iDisplayLength: 20,
                filter: null,
       ");
                WriteLiteral(@"         paging: true,
                pagingType: ""full_numbers""
            });



        });



        $('.btnDownload').on('click', function () {

            // COLUMN NAME
            var arrayColumn = new Array();
            var columnData;
            var x = 0;

            $("".pinjamTable thead tr th"").each(function () {

                x++;
                arrayColumn[x] = this.innerHTML;
            });

            arrayColumn = removeElementsFromArray(arrayColumn, isNullOrUndefined)
            columnData = arrayColumn.join(""~"");

            var judulBuku = $(""#txtJudulBukuFilter"").val();

            var getFilter;
            if (judulBuku == '')
                getFilter = ""/Pinjam/DownloadPinjam/?columnData="" + columnData;
            else
                getFilter = ""/Pinjam/DownloadPinjam/?isFilter=true&judulBuku="" + judulBuku + ""&columnData="" + columnData;

            window.location = getBaseURL() + getFilter;

        });


    </script>
");
            }
            );
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
