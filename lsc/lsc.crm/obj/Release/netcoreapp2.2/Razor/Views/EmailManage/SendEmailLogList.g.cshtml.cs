#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "866bbd352aabe88849eca1ab76e0061887a26b04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmailManage_SendEmailLogList), @"mvc.1.0.view", @"/Views/EmailManage/SendEmailLogList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmailManage/SendEmailLogList.cshtml", typeof(AspNetCore.Views_EmailManage_SendEmailLogList))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"866bbd352aabe88849eca1ab76e0061887a26b04", @"/Views/EmailManage/SendEmailLogList.cshtml")]
    public class Views_EmailManage_SendEmailLogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<lsc.Model.SendEmailLog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
  
    ViewData["Title"] = "邮件发送日志";
    Layout = "~/Pages/_Layout.cshtml";
    SendEmailTask taskinfo = ViewBag.taskinfo;

#line default
#line hidden
            BeginContext(185, 533, true);
            WriteLiteral(@"<fieldset class=""layui-elem-field layui-field-title"" style=""margin-top: 20px;"">
    <legend>邮件发送日志</legend>
</fieldset>
<div class=""layui-fluid"">
    <div class=""layui-row"">
        <table class=""layui-table"">
            <thead>
            <tr>
                <th>任务名称</th>
                <th>邮箱</th>
                <th>姓名</th>
                <th>是否已发送</th>
                <th>是否发送成功</th>
                <th>是否已读</th>
                <th>操作</th>

            </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 27 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
             if (Model != null)
            {
                foreach (var log in Model)
                {
                    string isokstr = string.Empty;
                    string IsReadstr = string.Empty;
                    if (!log.IsSend)
                    {
                        isokstr = "未发送";
                        IsReadstr = "未发送";
                    }
                    else
                    {
                        if(log.IsSendOk)
                        {
                            isokstr = "发送成功";
                        }
                        else
                        {
                            isokstr = "发送失败";
                        }
                        if (log.IsRead)
                        {
                            IsReadstr = "已读";
                        }
                        else
                        {
                            IsReadstr = "未读";
                        }
                    }

#line default
#line hidden
            BeginContext(1724, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1780, 18, false);
#line 58 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(taskinfo?.TaskName);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1836, 9, false);
#line 59 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(log.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1846, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1883, 8, false);
#line 60 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(log.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1892, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1929, 26, false);
#line 61 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(log.IsSend ? "已发送" : "未发送");

#line default
#line hidden
            EndContext();
            BeginContext(1956, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1993, 7, false);
#line 62 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(isokstr);

#line default
#line hidden
            EndContext();
            BeginContext(2001, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2038, 9, false);
#line 63 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                        Write(IsReadstr);

#line default
#line hidden
            EndContext();
            BeginContext(2048, 91, true);
            WriteLiteral("</td>\r\n                        <td><a href=\"javascript:;\" class=\"layui-btn layui-btn-small\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2139, "\"", 2171, 3);
            WriteAttributeValue("", 2149, "sendemail(\'", 2149, 11, true);
#line 64 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
WriteAttributeValue("", 2160, log.Id, 2160, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2169, "\')", 2169, 2, true);
            EndWriteAttribute();
            BeginContext(2172, 41, true);
            WriteLiteral(">发送</a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2247, 93, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div id=\"page\"></div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2357, 451, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        var layer, laypage;
        layui.use(['element', 'layer', 'table','laypage'],
            function() {
                var element = layui.element;
                layer = layui.layer;
                var table = layui.table;
                laypage = layui.laypage;
                //分页
                laypage.render({
                    elem: 'page' //分页容器的id
                    , count: ");
                EndContext();
                BeginContext(2810, 13, false);
#line 86 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                         Write(ViewBag.count);

#line default
#line hidden
                EndContext();
                BeginContext(2824, 35, true);
                WriteLiteral(" //总页数\r\n                    ,limit:");
                EndContext();
                BeginContext(2861, 16, false);
#line 87 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                       Write(ViewBag.pageSize);

#line default
#line hidden
                EndContext();
                BeginContext(2878, 120, true);
                WriteLiteral("\r\n                    , skin: \'#1E9FFF\' //自定义选中色值\r\n                    //,skip: true //开启跳页\r\n                    ,curr: ");
                EndContext();
                BeginContext(3000, 17, false);
#line 90 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                       Write(ViewBag.pageIndex);

#line default
#line hidden
                EndContext();
                BeginContext(3018, 228, true);
                WriteLiteral(" //获取起始页\r\n                    , jump: function (obj, first) {\r\n                        if (!first) {\r\n                            window.location =\r\n                                \'/EmailManage/SendEmailLogList?sendEmailTaskId=");
                EndContext();
                BeginContext(3248, 23, false);
#line 94 "D:\gitCode\crm\lsc\lsc.crm\Views\EmailManage\SendEmailLogList.cshtml"
                                                                           Write(ViewBag.sendEmailTaskId);

#line default
#line hidden
                EndContext();
                BeginContext(3272, 807, true);
                WriteLiteral(@"&pageIndex=' +
                                obj.curr;
                        }
                    }
                    , hash: 'fenye' //自定义hash值
                });
            });
        sendemail = function (id) {
            layer.confirm('是否发送邮件？', { icon: 3, title: '邮件发送提示' }, function (index) {
                $.get('/EmailManage/SendEmail?logId=' + id,
                    function (res) {
                        if (res.code == 1) {
                            layer.msg('已经发送', { icon: 6 });
                            window.location.reload();
                        } else {
                            layer.msg('发送失败', { icon: 5 });
                        }
                    });
                layer.close(index);
            });
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<lsc.Model.SendEmailLog>> Html { get; private set; }
    }
}
#pragma warning restore 1591