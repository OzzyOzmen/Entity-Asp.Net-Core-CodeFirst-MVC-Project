#pragma checksum "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e675ebe512c530777797f059381b54f7d5fd055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AddNewUser), @"mvc.1.0.view", @"/Views/Users/AddNewUser.cshtml")]
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
#line 1 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/_ViewImports.cshtml"
using OzzyEntityLibraries.AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/_ViewImports.cshtml"
using OzzyEntityLibraries.AdminPanel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
using OzzyEntityLibraries.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
using OzzyEntityLibraries.DTO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e675ebe512c530777797f059381b54f7d5fd055", @"/Views/Users/AddNewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb53494e6c293c2b4df0beb1cc222ab4f7d7d568", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AddNewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllUserDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/plus.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnUpload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
  
    ViewBag.Title = "Yeni Müşteri Ekle";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd0556180", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd0557205", async() => {
                WriteLiteral(@"

    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <strong>Yeni Kullanıcı Ekle</strong>
            </div>
            <div class=""card-body card-block"">

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Kullanıcı Adı</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""UserName"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 907, "\"", 915, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Kullanıcı Türü</label>
                    </div>

                    <div class=""col-6 col-md-3"">
                        <select id=""selectuserRole"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd0558675", async() => {
                    WriteLiteral("Seçim yapınız");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                             foreach (var item in Model.userRolesDTO)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05510031", async() => {
#nullable restore
#line 40 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                                            Write(item.UserRole);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                   WriteLiteral(item.UserRoleId);

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
#line 41 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </select>\r\n                        <input type=\"hidden\" id=\"UserRoleId\" name=\"UserRoleId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1745, "\"", 1753, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Kullanıcı Parolası</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""password"" id=""text_input"" name=""UserPassword"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2191, "\"", 2199, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Müşteri AdSoyadı</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""NameSurname"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2634, "\"", 2642, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">TC Kimlik No</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""IdentityNumber"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3074, "\"", 3082, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Kullanıcı Telefon</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""Phone"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3510, "\"", 3518, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Kullanıcı Email</label>
                    </div>

                    <div class=""col-12 col-md-9"">
                        <input type=""email"" id=""text_input"" name=""Email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3945, "\"", 3953, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>
                
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Ülke</label>
                    </div>
                    <div class=""col-6 col-md-3"">
                        <select id=""selectCountry"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05515946", async() => {
                    WriteLiteral("Seçim yapınız");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 108 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                             foreach (var item in Model.countriesDTOs)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05517305", async() => {
#nullable restore
#line 110 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                                           Write(item.CountryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                   WriteLiteral(item.CountryId);

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
#line 111 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </select>\r\n                        <input type=\"hidden\" id=\"CountryId\" name=\"CountryId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4789, "\"", 4797, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Şehir</label>
                    </div>
                    <div class=""col-6 col-md-3"">
                        <select id=""selectRegion"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05520197", async() => {
                    WriteLiteral("Seçim yapınız");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 126 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                             foreach (var item in Model.regionsDTOs)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05521554", async() => {
#nullable restore
#line 128 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                                          Write(item.RegionName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                   WriteLiteral(item.RegionId);

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
#line 129 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </select>\r\n                        <input type=\"hidden\" id=\"RegionId\" name=\"RegionId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5607, "\"", 5615, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">İlçe</label>
                    </div>
                    <div class=""col-6 col-md-3"">
                        <select id=""selectTerritory"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05524443", async() => {
                    WriteLiteral("Seçim yapınız");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 144 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                             foreach (var item in Model.territoriesDTOs)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e675ebe512c530777797f059381b54f7d5fd05525804", async() => {
#nullable restore
#line 146 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                                             Write(item.TerritoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"
                                   WriteLiteral(item.TerritoryId);

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
#line 147 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Users/AddNewUser.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </select>\r\n                        <input type=\"hidden\" id=\"TerritoryId\" name=\"TerritoryId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 6443, "\"", 6451, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>


                <div class=""row divrow"">


                    <div class=""col-md-3"">
                        <div class=""p-2"">
                            <h3 class=""title-3 m-b-30"">
                                <i class=""zmdi zmdi-map""></i>Resim Upload
                            </h3>
                            <div class=""col-lg-12 col-sm-12 col-xs-12 col-md-12 p-2 text-center"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e675ebe512c530777797f059381b54f7d5fd05528775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"UserPhoto\" id=\"UserPhoto\"");
                BeginWriteAttribute("value", " value=\"", 7074, "\"", 7082, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            </div>
                        </div>
                        <div class=""row form-group"" style=""display:none"">
                            <div class=""col col-md-3"">

                                <label for=""file-input"" class="" form-control-label"" style=""margin-top:20px;margin-left:15px"">Resim Seç</label>
                            </div>
                            <div class=""col-12 col-md-9"">

                                <input type=""file"" id=""fUpload"" name=""fUpload"" class=""form-control-file"" style=""margin-top:20px"">
                            </div>
                        </div>
                    </div>

                    <div class=""col-md-12"">

                        <div class=""card-footer"">
                            <button type=""submit"" class=""btn btn-primary btn-sm"">
                                <i class=""fa fa-dot-circle-o""></i> Ekle
                            </button>
                            <button type=""reset"" class=");
                WriteLiteral(@"""btn btn-danger btn-sm"">
                                <i class=""fa fa-ban""></i> Temizle
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>$(""#btnUpload"").on(""click"", function () {
        $(""#fUpload"").click();
    });
    $(""#fUpload"").on(""change"", function (e) {
        var token = $('[name=__RequestVerificationToken]').val();
        var fileUpload = $(this).get(0);
        var files = fileUpload.files;
        var datas = new FormData();
        datas.append(""__RequestVerificationToken"", token);
        for (var i = 0; i < files.length; i++) {
            datas.append(files[i].name, files[i]);


            const blob = new Blob([e.target.files[0]]);
            var tmppath = webkitURL.createObjectURL(blob);
            var isim = files[i].name;
            $('.divrow').prepend('<div class=""p-2 divAppended"" id=""divresim_' + (i + 1) + '"" style=""display:block;""><h3 class=""title-3 m-b-30"" id=""baslikid_' + (i + 1) + '""><i class=""zmdi zmdi-map"">' + isim + '</i></h3><div class=""col-lg-12 col-sm-12 col-xs-12 col-md-12 p-2 text-center""><img src=""' + tmppath + '"" name=""UserPhoto"" data-value=""file2"" style=""opacity:0.3"" cla");
            WriteLiteral(@"ss=""img2 imgAppended"" id=""img_' + (i + 1) + '"" width=""420px"" height=""240px"" /></div></div>');
        }
        $.ajax({
            url: ""/Users/ImageUpload"",
            method: ""POST"",
            data: datas,
            contentType: false,
            processData: false,
            success: function (result) {
                $(""#UserPhoto"").val(result);
                $("".imgAppended"").css(""opacity"", ""1"");
            },
            error: function (err) {
                alert(err.statusText);
                $("".divAppended"").remove();
            }

        });

    });


    $(""#selectuserRole"").on(""change"", function () {
        var sectionvalue = $(this).val();
        $(""#UserRoleId"").val(sectionvalue);
    });
    $(""#selectTerritory"").on(""change"", function () {
        var sectionvalue = $(this).val();
        $(""#TerritoryId"").val(sectionvalue);
    });
    $(""#selectRegion"").on(""change"", function () {
        var sectionvalue = $(this).val();
        $(""#Regi");
            WriteLiteral("onId\").val(sectionvalue);\r\n    });\r\n    $(\"#selectCountry\").on(\"change\", function () {\r\n        var sectionvalue = $(this).val();\r\n        $(\"#CountryId\").val(sectionvalue);\r\n    });</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllUserDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
