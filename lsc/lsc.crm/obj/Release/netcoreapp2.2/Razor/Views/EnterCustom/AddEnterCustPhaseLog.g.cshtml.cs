#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b4a5aef3e26520c128ef7ccf2abaf9b38b4aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EnterCustom_AddEnterCustPhaseLog), @"mvc.1.0.view", @"/Views/EnterCustom/AddEnterCustPhaseLog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EnterCustom/AddEnterCustPhaseLog.cshtml", typeof(AspNetCore.Views_EnterCustom_AddEnterCustPhaseLog))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
using lsc.Model.Enume;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b4a5aef3e26520c128ef7ccf2abaf9b38b4aee", @"/Views/EnterCustom/AddEnterCustPhaseLog.cshtml")]
    public class Views_EnterCustom_AddEnterCustPhaseLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lsc.Model.EnterCustomer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
  
    ViewData["Title"] = "更新阶段，添加联系记录";
    int types = ViewBag.types;
    Layout = "~/Pages/_LayoutNone.cshtml";
    if (types!=0)
    {
        Layout = "~/Pages/_Layout.cshtml";
    }

#line default
#line hidden
            BeginContext(258, 279, true);
            WriteLiteral(@"<form class=""layui-form"" method=""post"" id=""addform"">
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">阶段</label>
        <div class=""layui-input-inline"">
            <select class=""layui-form-select"" name=""Phase"">
                <option value=""1""  ");
            EndContext();
            BeginContext(539, 50, false);
#line 18 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                               Write(Model.Phase == PhaseEnume.Pre_sale ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(590, 50, true);
            WriteLiteral(">售前跟踪</option>\r\n                <option value=\"2\" ");
            EndContext();
            BeginContext(642, 61, false);
#line 19 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.Demand_Confirmation ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(704, 50, true);
            WriteLiteral(">需求确定</option>\r\n                <option value=\"3\" ");
            EndContext();
            BeginContext(756, 50, false);
#line 20 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.In_Sales ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(807, 50, true);
            WriteLiteral(">售中跟单</option>\r\n                <option value=\"4\" ");
            EndContext();
            BeginContext(859, 55, false);
#line 21 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.Sign_Contract ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(915, 50, true);
            WriteLiteral(">签约洽谈</option>\r\n                <option value=\"5\" ");
            EndContext();
            BeginContext(967, 52, false);
#line 22 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.After_Sale ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1020, 50, true);
            WriteLiteral(">成交售后</option>\r\n                <option value=\"6\" ");
            EndContext();
            BeginContext(1072, 49, false);
#line 23 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.Invalid ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1122, 50, true);
            WriteLiteral(">跟单失败</option>\r\n                <option value=\"7\" ");
            EndContext();
            BeginContext(1174, 48, false);
#line 24 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.Shelve ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1223, 50, true);
            WriteLiteral(">暂且搁置</option>\r\n                <option value=\"8\" ");
            EndContext();
            BeginContext(1275, 47, false);
#line 25 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
                              Write(Model.Phase == PhaseEnume.Other ? "selected":"");

#line default
#line hidden
            EndContext();
            BeginContext(1323, 490, true);
            WriteLiteral(@">其他阶段</option>
            </select>
        </div>
    </div>
    <div class=""layui-form-item layui-form-text"">
        <label class=""layui-form-label"">说明</label>
        <div class=""layui-input-block"">
            <textarea class=""layui-textarea layui-hide"" name=""Rem"" lay-verify=""content"" id=""Rem"" required></textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-inline"">
            <input type=""hidden"" name=""EnterCustomerID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1813, "\"", 1832, 1);
#line 37 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
WriteAttributeValue("", 1821, Model.ID, 1821, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1833, 50, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"types\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1883, "\"", 1899, 1);
#line 38 "D:\gitCode\crm\lsc\lsc.crm\Views\EnterCustom\AddEnterCustPhaseLog.cshtml"
WriteAttributeValue("", 1891, types, 1891, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1900, 2028, true);
            WriteLiteral(@"id=""types"" />
            <button class=""layui-btn"" lay-submit lay-filter=""logform"">立即提交</button>
        </div>
    </div>
</form>
<script type=""text/javascript"">
        var layer
        layui.use(['layer', 'form','layedit'], function () {
            layer = layui.layer;
            var form = layui.form;
            var layedit = layui.layedit;
            // 创建一个编辑器
            layedit.set({
                uploadImage: {
                    url: '/UploadApi/uploadImage' //接口url
                    , type: 'post' //默认post
                }
            });

            var editIndex = layedit.build('Rem', {
                height: 370 //设置编辑器高度
            });
            form.on('submit(logform)', function (data) {
                layedit.sync(editIndex)
                data.field.Rem = layedit.getContent(editIndex);
                
                $.post(""/EnterCustom/SaveEnterCustPhaseLog"", data.field, function (res) {
                    if (res.code == 1) {
             ");
            WriteLiteral(@"           layer.msg('保存成功', { icon: 6 });
                        var types = Number($(""#types"").val());
                        if (types === 0) {
                            console.log(""关闭所有弹窗"");
                            var index = parent.layer.getFrameIndex(window.name); //先得到当前iframe层的索引
                            parent.layer.close(index); //再执行关闭        
                        } else {
                            window.location = '/EnterCustom/Index';
                        }
                    } else {
                        layer.msg('保存失败', { icon: 5 });
                    }
                })
                return false;
            });

            form.verify({
                Rem: function (value, item) { //value：表单的值、item：表单的DOM对象
                    layedit.sync(editIndex);
                    if (value.length < 30) {
                        return '说明至少要50个字';
                    }
                }
            });
        })
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lsc.Model.EnterCustomer> Html { get; private set; }
    }
}
#pragma warning restore 1591