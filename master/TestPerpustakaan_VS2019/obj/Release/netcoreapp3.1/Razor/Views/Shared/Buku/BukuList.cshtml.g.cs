#pragma checksum "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "decc829408b4fca7578fb9cf6b0f61d49e3e2061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Buku_BukuList), @"mvc.1.0.view", @"/Views/Shared/Buku/BukuList.cshtml")]
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
#line 1 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
using TestPerpustakaan_VS2019.Library.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
using TestPerpustakaan_VS2019.Library.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decc829408b4fca7578fb9cf6b0f61d49e3e2061", @"/Views/Shared/Buku/BukuList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e073eba97893472df6c92147707a75b7cc32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Buku_BukuList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/css/metisMenu.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/dataTables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jeditable/jquery.jeditable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert-dev.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib_bower/sweetalert/dist/sweetalert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/js/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/script.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/js_custom/buku.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
  
    //ViewData["Title"] = "User List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Ajax Loading Control -->\r\n");
#nullable restore
#line 11 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
Write(Html.Partial("UserControls/AjaxLoadingControl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- User Detail Control -->\r\n");
#nullable restore
#line 14 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
Write(Html.Partial("Buku/BukuDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <div class=\"row border-bottom white-bg page-heading\">\r\n        <div class=\"col-lg-10\">\r\n            <h2>");
#nullable restore
#line 21 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
           Write(ViewData["vdDisplayName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <ol class=\"breadcrumb\">\r\n                <li>\r\n                    <a onclick=\"loadingProcess()\"");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 606, 1);
#nullable restore
#line 24 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
WriteAttributeValue("", 578, Url.Action("Index", "Home"), 578, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Home</a>\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 27 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
               Write(ViewData["vdParentName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"active\">\r\n                    <strong>");
#nullable restore
#line 30 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
                       Write(ViewData["vdDisplayName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                </li>
            </ol>

        </div>

    </div>


    <div style=""position:absolute; margin-top:-65px; margin-left:1020px"">

        <button class=""btn btn-primary btn-sm"" onclick=""getView('', '', '', '', '');""
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
        <");
            WriteLiteral("tbody>\r\n            <tr>\r\n                <td class=\"col-lg-3\">\r\n                    <input id=\"txtJudulBukuFilter\" type=\"text\" placeholder=\"Fullname\" style=\"width:200px\"");
            BeginWriteAttribute("value", " value=\"", 2040, "\"", 2072, 1);
#nullable restore
#line 71 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
WriteAttributeValue("", 2048, ViewData["vdJudulBuku"], 2048, 24, false);

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
                <div");
            WriteLiteral(@" class=""ibox float-e-margins panel panel-primary"">
                    <div class=""ibox-title panel-heading"">
                        <h5>Mode : LIST</h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"" >

                        <table class=""table table-striped table-bordered table-hover bukuTable"" style=""width:100%;"">
                            <thead>
                                <tr>
                                    <th class=""text-center"" width=""5%"">Action</th>
                                    <th class=""text-center"">No.</th>
                                    <th class=""text-center"">ID Book</th>
                                    <th class=""text-center"">Judul Buku</th>
                                    <th class=""text-");
            WriteLiteral(@"center"">Pengarang</th>
                                    <th class=""text-center"">Jenis Buku</th>
                                    <th class=""text-center"">Harga Sewa Per Hari (Rp)</th>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "decc829408b4fca7578fb9cf6b0f61d49e3e206114764", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "decc829408b4fca7578fb9cf6b0f61d49e3e206115943", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "decc829408b4fca7578fb9cf6b0f61d49e3e206117126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206118592", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206119692", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206120792", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206121892", async() => {
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
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206122996", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206124096", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 146 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\Buku\BukuList.cshtml"
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "decc829408b4fca7578fb9cf6b0f61d49e3e206126085", async() => {
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
                WriteLiteral(@"

    <script type=""text/javascript"">

        $(document).ready(function () {

            var myDate = new Date();


            var judulBuku = $(""#txtJudulBukuFilter"").val();          

            var getFilter;
            if (judulBuku == '')
                getFilter = ""/Buku/AjaxHandlerBukuList"";
            else
                getFilter = ""/Buku/AjaxHandlerBukuList/?isFilter=true&judulBuku="" + judulBuku;


            $('.bukuTable').DataTable({
                bServerSide: true,
                sAjaxSource: getBaseURL() + getFilter,
                bProcessing: false,
                aoColumns: [

                    {
                        mRender: function (ID_JudulBuku_Pengarang_JenisBuku_HargaSewa) {

                            var value = ID_JudulBuku_Pengarang_JenisBuku_HargaSewa.split("","");
                            var ID = value[0];
                            var JudulBuku = value[1];
                            var Pengarang = value[2];
              ");
                WriteLiteral(@"              var JenisBuku = value[3];
                            var HargaSewa = value[4];

                            return '<center><a onclick=""getView(' + ID + ', ' + ""'"" + JudulBuku + ""'"" + ', ' + ""'"" + Pengarang + ""'"" + ', ' + ""'"" + JenisBuku + ""'"" + ', ' +
                                                                ""'"" + HargaSewa + ""'"" + ', event);"" ' +
                                   'href=""#"" class=""btn btn-primary btn-sm"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Edit"" > <i class=""fa fa-pencil""></i></a > ' +
                                '&nbsp;&nbsp;<button class=""btn btn-primary btn-sm btnDelete"" onclick=""getDelete(' + ID + ', ' + ""'"" + JudulBuku + ""'"" + ');"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Delete""><i class=""fa fa-trash""></i></button></center>';


                        }
                    },
                    {
                        mRender: function (data, type, row, meta) {

                            return '<center>' + (meta.");
                WriteLiteral(@"row + meta.settings._iDisplayStart + 1) + '</center>';
                        }
                    },
                    { mRender: function (JudulBuku) { return JudulBuku; } },
                    { mRender: function (Pengarang) { return Pengarang; } },
                    { mRender: function (JenisBuku) { return JenisBuku; } },
                    { mRender: function (HargaSewa) { return '<div style=""text-align:right;"">' + HargaSewa + '</div>'; } },

                ],
                lengthMenu: [
                    [10, 20, 50, 100],
                    [10, 20, 50, 100]
                ],
                iDisplayLength: 20,
                filter: null,
                paging: true,
                pagingType: ""full_numbers""
            });

        });



        $('.btnDownload').on('click', function () {

            // COLUMN NAME
            var arrayColumn = new Array();
            var columnData;
            var x = 0;

            $("".bukuTable thead tr th"").eac");
                WriteLiteral(@"h(function () {

                x++;
                arrayColumn[x] = this.innerHTML;
            });

            arrayColumn = removeElementsFromArray(arrayColumn, isNullOrUndefined)
            columnData = arrayColumn.join(""~"");

            var judulBuku = $(""#txtJudulBukuFilter"").val();

            var getFilter;
            if (judulBuku == '')
                getFilter = ""/Buku/DownloadBuku/?columnData="" + columnData;
            else
                getFilter = ""/Buku/DownloadBuku/?isFilter=true&judulBuku="" + judulBuku + ""&columnData="" + columnData;

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
