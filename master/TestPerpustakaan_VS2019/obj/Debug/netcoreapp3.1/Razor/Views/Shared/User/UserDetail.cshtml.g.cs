#pragma checksum "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57957aa371d927907c4ae1d902365d3653b2ee27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_User_UserDetail), @"mvc.1.0.view", @"/Views/Shared/User/UserDetail.cshtml")]
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
#line 1 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
using TestPerpustakaan_VS2019.Library.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57957aa371d927907c4ae1d902365d3653b2ee27", @"/Views/Shared/User/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e073eba97893472df6c92147707a75b7cc32", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_User_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "False", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "True", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
  
    ViewData["Title"] = "User Detail Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""modal-form-userdetail"" class=""modal"" aria-hidden=""true""
     data-keyboard=""false"" data-backdrop=""static""
     style=""top:0%; left:0%; width:100%; overflow:hidden;  "">

    <div class=""modal-dialog"">
        <div class=""modal-content"" style=""width:120%;"">
            <div class=""modal-header btn-primary"">

");
            WriteLiteral("                <h4 class=\"modal-title font-bold\"><div id=\"title\"></div></h4>\r\n            </div>\r\n\r\n            <div class=\"modal-body\" style=\"height:100%; \">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee275793", async() => {
                WriteLiteral("\r\n\r\n                    <input type=\"hidden\" id=\"hdnId\"");
                BeginWriteAttribute("value", " value=\"", 850, "\"", 858, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

                    <div class=""form-group"">
                        <label class=""col-lg-3"">User Name</label>
                        <div class=""col-lg-5"">
                            <input id=""txtUserName"" type=""text"" placeholder=""User Name"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1135, "\"", 1143, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""col-lg-3"">Password</label>
                        <div class=""col-lg-5"">
                            <input id=""txtPass"" type=""password"" placeholder=""Password"" maxlength=""16"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1491, "\"", 1499, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <span class=""text-danger"">(alpha numeric max. 16 character)</span>
                        </div>
                        <span style=""position:relative; margin-left:0px; "">
                            <input id=""chkIsShowPass"" type=""checkbox"" />&nbsp;&nbsp;
                            <button class=""btn btn-primary btn-sm btnGeneratePass""
                                    data-toggle=""tooltip"" data-placement=""bottom"" title=""Generate Password"">
                                <i class=""fa fa-gear""></i>&nbsp;&nbsp;Auto Generate
                            </button>
                        </span>
                    </div>

                    <div class=""form-group"">
                        <label class=""col-lg-3"">Confirm Password</label>
                        <div class=""col-lg-5"">
                            <input id=""txtConfirmPass"" type=""password"" placeholder=""Confirm Password"" maxlength=""8"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2479, "\"", 2487, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""col-lg-3"">Fullname</label>
                        <div class=""col-lg-5"">
                            <input id=""txtFullname"" type=""text"" placeholder=""Fullname"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2820, "\"", 2828, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n");
                WriteLiteral(@"
                    <div class=""form-group"" style=""padding-left:15px;"">

                        <table style=""width:85%;"">
                            <tr>
                                <td style=""width:350px;"">
                                    <b>Email</b>
                                </td>
                                <td style=""padding-left:20px; width:350px;"">
                                    <b>Location</b>
                                </td>
                            </tr>
                            <tr>
                                <td style=""width:350px;"">
                                    <input id=""txtEmail"" type=""text"" placeholder=""Email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3948, "\"", 3956, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </td>\r\n                                <td style=\"padding-left:20px; width:350px;\">\r\n                                    <input id=\"hiddenLocationId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4155, "\"", 4163, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <select class=\"form-control\" id=\"ddlLocation\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2710400", async() => {
                    WriteLiteral("-- select location --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 88 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                         foreach (var itemLocation in (ViewData["vdLocationList"] as List<LocationEntity.Location>))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2712083", async() => {
#nullable restore
#line 90 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                                                        Write(itemLocation.LocationName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                               WriteLiteral(itemLocation.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </td>
                            </tr>
                            <tr height=""10"">
                                <td></td>
                                <td></td>
                            </tr>
                            <tr>
                                <td style=""width:350px;"">
                                    <b>Role</b>
                                </td>
                                <td style=""padding-left:20px; width:350px;"">
                                    <b>Is Active</b>
                                </td>
                            </tr>
                            <tr>
                                <td style=""width:350px;"">                             
                                        <input id=""hiddenRoleId"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 5551, "\"", 5559, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <select class=\"form-control\" id=\"ddlRole\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2715522", async() => {
                    WriteLiteral("-- Select role --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                             foreach (var itemRole in (ViewData["vdRoleList"] as List<RoleEntity.Role>))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2717198", async() => {
#nullable restore
#line 114 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                                                        Write(itemRole.RoleName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                                   WriteLiteral(itemRole.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 115 "D:\My Project Freelancer\TestKairos\SourceCode\TestPerpustakaan_VS2019\Views\Shared\User\UserDetail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </select>
                           
                                </td>
                                <td style=""padding-left:20px; width:350px;"">
                                    <input id=""hiddenIsActive"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 6333, "\"", 6341, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <select class=\"form-control\" id=\"ddlIsActive\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2720024", async() => {
                    WriteLiteral("Inactive");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57957aa371d927907c4ae1d902365d3653b2ee2721290", async() => {
                    WriteLiteral("Active");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </td>
                            </tr>

                        </table>

                    </div>


                    <div class=""form-group hide"">
                        <label class=""col-lg-3"">Is Login</label>
                        <div class=""col-lg-3"">
                            <input id=""hiddenIsLogin"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 7013, "\"", 7021, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input id=\"chkIsLogin\" type=\"checkbox\" />\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                <br />

                <div class=""modal-footer"" style=""width:100%; left:0%;"">
                    <button class=""btn btn-primary"" type=""button"" style=""width:20%; left:0;""
                            onclick=""getClose();"">
                        <b>Cancel</b>
                    </button>
                    <button class=""btn btn-primary"" type=""button"" style=""width:20%; left:0;""
                            onclick=""getSave();"">
                        <b>Save</b>
                    </button>

                </div>


            </div>


        </div>
    </div>
</div>



<script type=""text/javascript"">

            $(document).ready(function () {

                $('#chkIsShowPass').on('click', function (e) {

                    if ($('#chkIsShowPass').is(':checked')) {
                        $(""#txtPass"").attr('type', 'text');
                    } else {
                        $(""#txtPass"").attr('type', 'password');
                    }

    ");
            WriteLiteral(@"            });

            });


            // Generate Password
            $('.btnGeneratePass').on('click', function (e) {

                $.ajax({
                    url: getBaseURL() + '/User/GeneratePassword/',
                    type: 'GET',
                    dataType: 'json',
                    success: function (json) {

                        $(""#txtPass"").val(json.value);
                    },
                    error: function (json) {
                        alert(json);
                    }
                });

                return e.preventDefault();
            });

</script>

");
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
