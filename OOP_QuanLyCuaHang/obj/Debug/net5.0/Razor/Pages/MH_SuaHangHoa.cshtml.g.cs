#pragma checksum "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4d50329826273f1e5560f8aa1e01ebe592cc05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OOP_QuanLyCuaHang.Pages.Pages_MH_SuaHangHoa), @"mvc.1.0.razor-page", @"/Pages/MH_SuaHangHoa.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4d50329826273f1e5560f8aa1e01ebe592cc05", @"/Pages/MH_SuaHangHoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5408b2edf1d93ae9247f96f9810adfa072be90", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_MH_SuaHangHoa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 5 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
 if(Model.HangHoa != null)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d4d50329826273f1e5560f8aa1e01ebe592cc053917", async() => {
                WriteLiteral("\r\n    <label for=\"fname\">Tên hàng:</label><br>\r\n    <input type=\"text\" name=\"ten\"");
                BeginWriteAttribute("value", " value=\"", 209, "\"", 239, 1);
#nullable restore
#line 9 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 217, Model.HangHoa.TenHang, 217, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Loại hàng:</label><br>\r\n    <input type=\"text\" name=\"loai\"");
                BeginWriteAttribute("value", " value=\"", 328, "\"", 359, 1);
#nullable restore
#line 11 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 336, Model.HangHoa.LoaiHang, 336, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Hạn dùng:</label><br>\r\n    <input type=\"text\" name=\"han\"");
                BeginWriteAttribute("value", " value=\"", 446, "\"", 476, 1);
#nullable restore
#line 13 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 454, Model.HangHoa.HanDung, 454, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Công ty:</label><br>\r\n    <input type=\"text\" name=\"congty\"");
                BeginWriteAttribute("value", " value=\"", 565, "\"", 594, 1);
#nullable restore
#line 15 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 573, Model.HangHoa.CongTy, 573, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Năm sản xuất:</label><br>\r\n    <input type=\"text\" name=\"nam\"");
                BeginWriteAttribute("value", " value=\"", 685, "\"", 718, 1);
#nullable restore
#line 17 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 693, Model.HangHoa.NamSanXuat, 693, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <label for=\"fname\">Giá bán:</label><br>\r\n    <input type=\"text\" name=\"gia\"");
                BeginWriteAttribute("value", " value=\"", 804, "\"", 833, 1);
#nullable restore
#line 19 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
WriteAttributeValue("", 812, Model.HangHoa.GiaBan, 812, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><br>\r\n    <input type=\"submit\" value=\"Luu\">\r\n    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Minh\VB2 CNTT\PP Lap trinh huong doi tuong\OOP_QuanLyCuaHang\OOP_QuanLyCuaHang\Pages\MH_SuaHangHoa.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OOP_QuanLyCuaHang.Pages.MH_SuaHangHoaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_QuanLyCuaHang.Pages.MH_SuaHangHoaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OOP_QuanLyCuaHang.Pages.MH_SuaHangHoaModel>)PageContext?.ViewData;
        public OOP_QuanLyCuaHang.Pages.MH_SuaHangHoaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
