#pragma checksum "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b46e79fb1e7d2b6b7b8ebe6676d3163e619044"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReferenceCategory_Index), @"mvc.1.0.view", @"/Views/ReferenceCategory/Index.cshtml")]
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
#line 1 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
using OzzyEntityLibraries.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
using OzzyEntityLibraries.DTO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b46e79fb1e7d2b6b7b8ebe6676d3163e619044", @"/Views/ReferenceCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb53494e6c293c2b4df0beb1cc222ab4f7d7d568", @"/Views/_ViewImports.cshtml")]
    public class Views_ReferenceCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReferenceCategoriesDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
.clickedRed {
  border: 1px solid;
  color: red;

}
</style>
<div class=""col-lg-12"">
    <div class=""card"">
        <div class=""card-header"">
            <strong>Referans Kategorileri</strong>
        </div>
        <div class=""card-body card-block"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b46e79fb1e7d2b6b7b8ebe6676d3163e6190445012", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"row form-group\">\r\n\r\n                    <div class=\"col-12 col-md-9\">\r\n                        <input type=\"text\" id=\"text_input\" name=\"ReferenceCategoryName\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 742, "\"", 750, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                    </div>
                </div>


                <div class=""table-data__tool"">

                    <div class=""table-data__tool-right"">
                        <button class=""au-btn au-btn-icon au-btn--green au-btn--small btnEkle"" style=""display:block"">
                            <i class=""zmdi zmdi-plus""></i>Kategori Ekle
                        </button>
                
                        <a href=""#"" data-id="""" class=""au-btn au-btn-icon au-btn--blue au-btn--small"" id=""btnGuncelle"" style=""display:none"">
                            <i class=""zmdi zmdi-plus""></i>Kategori Güncelle
                        </a>

                    </div>
                    
                </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-12"">
                    <!-- DATA TABLE -->
                    <h3 class=""title-5 m-b-35"">Kategori Listesi</h3>

                    <div class=""table-responsive table-responsive-data2"">
                        <table class=""table table-data2"">
                            <thead>
                                <tr>
                                    
                                    <th>ID</th>
                                    <th>Kategori Adı</th>
                                    <th></th>
                                </tr>
                            </thead>
                                 
                            <tbody>
");
#nullable restore
#line 66 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"tr-shadow\">\r\n                                     \r\n                                        <td><span>");
#nullable restore
#line 70 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                             Write(item.ReferenceCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        <td><span>");
#nullable restore
#line 71 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                             Write(item.ReferenceCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></td> 
                                        
                                        <td>
                                            <div class=""table-data-feature"">
                                              <button class=""item btnGuncelle"" data-toggle=""tooltip"" data-placement=""top"" data-id='");
#nullable restore
#line 75 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                                                                                                              Write(item.ReferenceCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' title=""Güncelle"">
                                                    <i class=""zmdi zmdi-edit""></i>
                                                </button>
                                                <button class=""item btnSil"" data-placement=""top"" title=""Sil"" data-id='");
#nullable restore
#line 78 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                                                                                                 Write(item.ReferenceCategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-toggle=""modal"" data-target=""#myModal"">
                                                    <i class=""zmdi zmdi-delete""></i>
                                                </button>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr class=""spacer""></tr>
");
#nullable restore
#line 85 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/ReferenceCategory/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                                   <!-- END DATA TABLE -->
                </div>
            </div>

        </div>
    </div>
</div>
<!-- Silme işlemini modal a yaptırıyorum -->
<!-- Modal -->
<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Referans Kategorisini Sil</h4>
            </div>
            <div class=""modal-body"">
                <p>Silmek İstediğinizden Emin misiniz?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-id="""" id=""btnSil"" data-dismiss=""modal"">Sil</button>
                <button type=""button"" class=""btn btn-default"" dat");
            WriteLiteral(@"a-dismiss=""modal"">Vazgeç</button>
            </div>
        </div>
    </div>
</div>


<!-- Modal -->
<script>

    /* Delete işlemim */

    var csskodum;
    var veri;
    $("".btnSil"").on(""click"", function () {
        $(""#btnSil"").data(""id"", $(this).data(""id""));

        veri = $(this).parents(""tr.tr-shadow"");
    });

    $(""#btnSil"").on(""click"", function () {
        var Id = $(this).data(""id"");
        $.ajax({
            type: ""POST"",
            url: ""/ReferenceCategory/DeleteReferenceCategory"",
            data: { id: Id },
            dataType: false,
            dataContent: false,
            success: function (data) {

                if (!data) {
                    alert('Veri silinirken bir hata oluştu!');
                } else {
                    veri.remove();
                }
            },
        });
    });

    /* Update işlemim */

    $("".btnGuncelle"").on(""click"", function () {
        $(""#btnGuncelle"").css(""display"", ""block"");
         ");
            WriteLiteral(@"$("".btnEkle"").css(""display"", ""none "");

        if ($(this).parents(""tr.tr-shadow"").hasClass('clickedRed')) {
            $(this).parents(""tr.tr-shadow"").removeClass('clickedRed');
        }
        else {
            $(this).parents(""tr.tr-shadow"").addClass('clickedRed');
        }
        
        var spans = $(this).parents(""tr.tr-shadow"").find(""td span"");
        

        var gelenId = spans.eq(0).text();
        var gelenVeri = spans.eq(1).text();
        $(""#text_input"").val(gelenVeri);
        $(""#btnGuncelle"").data(""id"", gelenId);

    });

    $(""#btnGuncelle"").on(""click"", function () {


        var id = $(this).data(""id"");
        var name = $(""#text_input"").val();
        var veri =
        {
            ReferenceCategoryId: id,
            ReferenceCategoryName: name
        };

        $.ajax({
            type: ""POST"",
            url: ""/ReferenceCategory/UpdateReferenceCategory"",
            data: veri,
            dataType: false,
            dataContent: false,
");
            WriteLiteral("            success: function (data) {\r\n                window.location.href = \"/ReferenceCategory\";\r\n            }\r\n        });\r\n        \r\n    });\r\n\r\n\r\n\r\n   </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReferenceCategoriesDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591