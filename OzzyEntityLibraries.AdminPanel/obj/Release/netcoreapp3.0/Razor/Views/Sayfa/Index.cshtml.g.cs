#pragma checksum "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ced0184d6133cbf3445d293adf2f2f1525ea680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sayfa_Index), @"mvc.1.0.view", @"/Views/Sayfa/Index.cshtml")]
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
#line 1 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
using OzzyEntityLibraries.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
using OzzyEntityLibraries.DTO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ced0184d6133cbf3445d293adf2f2f1525ea680", @"/Views/Sayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb53494e6c293c2b4df0beb1cc222ab4f7d7d568", @"/Views/_ViewImports.cshtml")]
    public class Views_Sayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PagesDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Güncelle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
  
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
            <strong>Sayfalar</strong>
        </div>
        <div class=""card-body card-block"">
       
            <div class=""row"">
                <div class=""col-md-12"">
                    <!-- DATA TABLE -->
                    <h3 class=""title-5 m-b-35"">Sayfa Listesi</h3>

                    <div class=""table-responsive table-responsive-data2"">
                        <table class=""table table-data2"">
                            <thead>
                                <tr>
                                    
                                    <th>ID</th>
                                    <th>Sayfa Başlık</th>
                                    <th>Sayfa Url Adresi</th>
                                    <th></th>
                                </tr>
                            </thead>
                                 
                           ");
            WriteLiteral(" <tbody>\n");
#nullable restore
#line 42 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr class=\"tr-shadow\">\n                                     \n                                        <td><span>");
#nullable restore
#line 46 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                             Write(item.PageId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                        <td><span>");
#nullable restore
#line 47 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                             Write(item.Pagetitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                        <td><span>");
#nullable restore
#line 48 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                             Write(item.PageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                                       <!--  <td><span> <img src=\" /images/uploads/");
#nullable restore
#line 49 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                                                              Write(item.Photo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" width=""50px"" height=""35px"" /></span></td>-->
                                                       
                                        <td>
                                            <div class=""table-data-feature"">
                                                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ced0184d6133cbf3445d293adf2f2f1525ea6807670", async() => {
                WriteLiteral("\n                                                    <i class=\"zmdi zmdi-edit\"></i>\n                                               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2016, "~/Sayfa/UpdateSayfa/", 2016, 20, true);
#nullable restore
#line 53 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
AddHtmlAttributeValue("", 2036, item.PageId, 2036, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                <button class=\"item btnSil\" data-placement=\"top\" title=\"Sil\" data-id=\'");
#nullable restore
#line 56 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
                                                                                                                 Write(item.PageId);

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
#line 63 "/Users/ozzy/Projects/OzzyEntityLibraries/OzzyEntityLibraries.AdminPanel/Views/Sayfa/Index.cshtml"
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
                <h4 class=""modal-title"">Hizmeti Sil</h4>
            </div>
            <div class=""modal-body"">
                <p>Silmek İstediğinizden Emin misiniz?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-id="""" id=""btnSil"" data-dismiss=""modal"">Sil</button>
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Vazgeç</button>
      ");
            WriteLiteral(@"      </div>
        </div>
    </div>
</div>


<!-- Modal -->
<script>

    /* Delete işlemim */

    var csskodum;
    var veri;
    $("".btnSil"").on(""click"", function () {

         if ($(this).parents(""tr.tr-shadow"").hasClass('clickedRed')) {
            $(this).parents(""tr.tr-shadow"").removeClass('clickedRed');
        }
        else {
            $(this).parents(""tr.tr-shadow"").addClass('clickedRed');
         }

        $(""#btnSil"").data(""id"", $(this).data(""id""));

        veri = $(this).parents(""tr.tr-shadow"");
    });

    $(""#btnSil"").on(""click"", function () {
        var Id = $(this).data(""id"");
        $.ajax({
            type: ""POST"",
            url: ""/Sayfa/DeleteSayfaByID"",
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
        }");
            WriteLiteral(");\n    });\n\n   \n   </script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PagesDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
