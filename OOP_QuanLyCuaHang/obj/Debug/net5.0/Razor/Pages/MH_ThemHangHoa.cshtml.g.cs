#pragma checksum "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_ThemHangHoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf4a3d2ae7a11bb484c83dd4a17f0ddc70be781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_QuanLyCuaHang.Pages.Pages_MH_ThemHangHoa), @"mvc.1.0.razor-page", @"/Pages/MH_ThemHangHoa.cshtml")]
namespace OOP_QuanLyCuaHang.Pages
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
#line 1 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\_ViewImports.cshtml"
using OOP_QuanLyCuaHang;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf4a3d2ae7a11bb484c83dd4a17f0ddc70be781", @"/Pages/MH_ThemHangHoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5408b2edf1d93ae9247f96f9810adfa072be90", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_MH_ThemHangHoa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cf4a3d2ae7a11bb484c83dd4a17f0ddc70be7813484", async() => {
                WriteLiteral("\r\n\r\n    <label for=\"fname\">Mã hàng:</label><br>\r\n    <input type=\"text\" name=\"MaHang\"");
                BeginWriteAttribute("value", " value=\"", 166, "\"", 174, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Tên hàng:</label><br>\r\n    <input type=\"text\" name=\"TenHang\"");
                BeginWriteAttribute("value", " value=\"", 265, "\"", 273, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Loại hàng:</label><br>\r\n    <input type=\"text\" name=\"LoaiHang\"");
                BeginWriteAttribute("value", " value=\"", 366, "\"", 374, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Hạn dùng:</label><br>\r\n    <input type=\"text\" name=\"HanDung\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 473, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Công ty:</label><br>\r\n    <input type=\"text\" name=\"CongTy\"");
                BeginWriteAttribute("value", " value=\"", 562, "\"", 570, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Năm sản xuất:</label><br>\r\n    <input type=\"text\" name=\"NamSanXuat\"");
                BeginWriteAttribute("value", " value=\"", 668, "\"", 676, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Giá bán:</label><br>\r\n    <input type=\"text\" name=\"GiaBan\"");
                BeginWriteAttribute("value", " value=\"", 765, "\"", 773, 0);
                EndWriteAttribute();
                WriteLiteral("><br>\r\n\r\n    <input type=\"submit\" value=\"Luu\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_ThemHangHoa.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_QuanLyCuaHang.Pages.MH_ThemHangHoaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_QuanLyCuaHang.Pages.MH_ThemHangHoaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_QuanLyCuaHang.Pages.MH_ThemHangHoaModel>)PageContext?.ViewData;
        public OOP_QuanLyCuaHang.Pages.MH_ThemHangHoaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591