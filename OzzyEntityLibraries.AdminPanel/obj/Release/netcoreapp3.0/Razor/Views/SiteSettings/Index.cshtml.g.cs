#pragma checksum "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4048d11d95643dea2a6f87772949e8c613f4e4ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SiteSettings_Index), @"mvc.1.0.view", @"/Views/SiteSettings/Index.cshtml")]
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
#line 1 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
using OzzyEntityLibraries.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
using OzzyEntityLibraries.DTO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4048d11d95643dea2a6f87772949e8c613f4e4ec", @"/Views/SiteSettings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb53494e6c293c2b4df0beb1cc222ab4f7d7d568", @"/Views/_ViewImports.cshtml")]
    public class Views_SiteSettings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeneralSettingsDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor5/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048d11d95643dea2a6f87772949e8c613f4e4ec6088", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048d11d95643dea2a6f87772949e8c613f4e4ec7111", async() => {
                WriteLiteral(@"

    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <strong>Site Genel Ayarlar</strong>
            </div>
            <div class=""card-body card-block"">

 
                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <input type=""hidden"" class=""form-control"" id=""GeneralSettingsId"" name=""GeneralSettingsId""");
                BeginWriteAttribute("value", " value=\"", 719, "\"", 751, 1);
#nullable restore
#line 23 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 727, Model.GeneralSettingsId, 727, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                        <label for=""text-input"" class="" form-control-label"">Site Adı</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""WebSiteName""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1025, "\"", 1051, 1);
#nullable restore
#line 27 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 1033, Model.WebSiteName, 1033, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                 <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Web Site Adresi</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""WebSiteAddress""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1479, "\"", 1508, 1);
#nullable restore
#line 37 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 1487, Model.WebSiteAddress, 1487, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Keywords</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""Keywords""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1922, "\"", 1945, 1);
#nullable restore
#line 47 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 1930, Model.Keywords, 1930, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                 <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Email</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""Email""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2354, "\"", 2374, 1);
#nullable restore
#line 57 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 2362, Model.Email, 2362, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Email Password</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""EmailPassword""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2799, "\"", 2827, 1);
#nullable restore
#line 67 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 2807, Model.EmailPassword, 2807, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Smtp Address</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""SmtpAddress""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3248, "\"", 3274, 1);
#nullable restore
#line 77 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 3256, Model.SmtpAddress, 3256, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Smtp Port</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""SmtpPort""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3689, "\"", 3712, 1);
#nullable restore
#line 87 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 3697, Model.SmtpPort, 3697, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""text-input"" class="" form-control-label"">Telefon</label> 
                    </div>
                    <div class=""col-12 col-md-9"">
                        <input type=""text"" id=""text_input"" name=""Phone""  class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 4122, "\"", 4142, 1);
#nullable restore
#line 97 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 4130, Model.Phone, 4130, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>

                <div class=""row form-group"">
                    <div class=""col col-md-3"">
                        <label for=""textarea-input"" class="" form-control-label"">Firma Adresi</label>
                    </div>
                    <div class=""col-12 col-md-9"">
                        <textarea name=""CompanyAddress"" id=""textarea_input"" rows=""9""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4551, "\"", 4565, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control ckeditor5\">");
#nullable restore
#line 107 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
                                                                                                                              Write(Model.CompanyAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n\n                    </div>\n                </div>\n\n\n                <div class=\"row divrow\">\n                   \n");
#nullable restore
#line 115 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
                     for (int i = 0; i < @Model.SiteLogo.Split(',').Length; i++)
                    {
                        var resimadi = @Model.SiteLogo.Split(',')[i];
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"p-2\">\n                                <h3 class=\"title-3 m-b-30\">\n                                    <i class=\"zmdi zmdi-map\"></i>");
#nullable restore
#line 120 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
                                                            Write(Model.SiteLogo.Split(',')[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </h3>\n                                <div class=\"col-lg-12 col-sm-12 col-xs-12 col-md-12 p-2 text-center\">\n                                    <img");
                BeginWriteAttribute("src", " src=\"", 5299, "\"", 5359, 2);
                WriteAttributeValue("", 5305, "/images/uploads/SiteLogo/", 5305, 25, true);
#nullable restore
#line 123 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 5330, Model.SiteLogo.Split(',')[i], 5330, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"SiteLogo\" data-value=\"file2\" id=\"img2\" width=\"420px\" height=\"240px\" />\n\n                                </div>\n                                 <a href=\"#\" data-href=\"");
#nullable restore
#line 126 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
                                                   Write(resimadi);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"btn btn-outline-warning btn-sm btncikart\" title=\"Güncelle\" >Çıkart</a>\n                            </div>\n");
#nullable restore
#line 128 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                         
                    
                   
                    <div class=""col-md-3"">
                        <div class=""p-2"">
                            <h3 class=""title-3 m-b-30"">
                                <i class=""zmdi zmdi-map""></i>Resim Upload
                            </h3>
                            <div class=""col-lg-12 col-sm-12 col-xs-12 col-md-12 p-2 text-center"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4048d11d95643dea2a6f87772949e8c613f4e4ec18679", async() => {
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
                WriteLiteral("\n                                <input type=\"hidden\" name=\"SiteLogo\" id=\"SiteLogo\"");
                BeginWriteAttribute("value", " value=\"", 6256, "\"", 6279, 1);
#nullable restore
#line 140 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/SiteSettings/Index.cshtml"
WriteAttributeValue("", 6264, Model.SiteLogo, 6264, 15, false);

#line default
#line hidden
#nullable disable
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
                                <i class=""fa fa-dot-circle-o""></i> Güncelle
                            </button>
                            <button type=""reset"" class=""btn btn-danger ");
                WriteLiteral("btn-sm\">\n                                <i class=\"fa fa-ban\"></i> Temizle\n                            </button>\n                        </div>\n                    </div>\n\n\n                </div>\n            </div>\n        </div>\n    \n    </div>\n");
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
<script>
	ClassicEditor
		.create( document.querySelector( '.ckeditor5' ), {
			// toolbar: [ 'heading', '|', 'bold', 'italic', 'link' ]
		} )
		.then( editor => {
			window.editor = editor;
		} )
		.catch( err => {
			console.error( err.stack );
		} );
</script>
<script>
   
    $(""#btnUpload"").on(""click"", function () {
        $(""#fUpload"").click();
    });
    $(""#fUpload"").on(""change"", function (e) {
        var token = $('[name=__RequestVerificationToken]').val();
        var fileUpload = $(this).get(0);
        var files = fileUpload.files;
        var datas = new FormData();
         var images = $(""#SiteLogo"").val();
        var datas = new FormData();

        datas.append(""images"", images);
        datas.append(""__RequestVerificationToken"", token);

        for (var i = 0; i < files.length; i++) {
            datas.append(files[i].name, files[i]);

            const blob = new Blob([files[i]]);
            var tmppath = webkitURL.createObjectURL(blob);

            var isim = files[i].name;
       ");
            WriteLiteral(@"     $('.divrow').prepend('<div class=""p-2 divAppended""><h3 class=""title-3 m-b-30""><i class=""zmdi zmdi-map""></i>' + isim + '</h3><div class=""col-lg-12 col-sm-12 col-xs-12 col-md-12 p-2 text-center""><img src=""' + tmppath + '"" name=""SiteLogo"" data-value=""file2"" id=""img2"" width=""420px"" height=""240px"" /> </div> <a href=""#"" data-href=""' + isim + '"" class=""btn btn-outline-warning btn-sm btncikart"" title=""Güncelle"" >Çıkart</a></div>');
        }
        
        
        $.ajax({
            url: ""/SiteSettings/ImageUpload"",
            method: ""POST"",
            data: datas,
            contentType: false,
            processData: false,
            success: function (result) {
               $(""#SiteLogo"").val(result);
            },
            error: function (err) {
                alert(err.statusText);
            }

        });
        
    });
    function trimChar(string, charToRemove) {

        while (string.charAt(0) == charToRemove) {
            string = string.substring(1);
        }
        while (");
            WriteLiteral(@"string.charAt(string.length - 1) == charToRemove) {
            string = string.substring(0, string.length - 1);
        }

        return string;
    }
    $("".btncikart"").on(""click"", function () {

        var Id = $(""#GeneralSettingsId"").val();
        var veri = $(this).data(""href"");

        var test = $(""#SiteLogo"").val();
        test = test.replace(veri, """").replace("",,"", "","");
        test = trimChar(test, ',');
        $(""#SiteLogo"").val(test);
        $(this).parent().remove();

    });

    //$(function myfunction() {
    //    $(""#btnUpload"").on('click', function () {
    //        var test = $(""#fUpload"");
    //        var test2 = test[0].files.length;
    //        var bilgiler = test[0].files;
    //        var sonuc = """";
    //        if (test2 > 0) {
    //            //for (var i = 0; i < test2; i++) {
    //            //    var DosyaAdi = bilgiler[i].name;
    //            //    var DosyaBoyutu = bilgiler[i].size;
    //            //    var Dosyaturu = bilgiler[i].type;
    //        ");
            WriteLiteral(@"    //    sonuc += ""<li>"" + DosyaAdi + "" "" + DosyaBoyutu + "" bytes. Type :"" + Dosyaturu + ""</li>"";
    //            //}
    //             for (var i = 0; i < test2; i++) {
    //                var DosyaAdi = bilgiler[i].name;
    //                 sonuc += DosyaAdi;


    //            }
    //             $(""#img1"").attr(""src"", sonuc);
    //            alert(sonuc);

    //        }
    //    });
    
  
   

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeneralSettingsDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
