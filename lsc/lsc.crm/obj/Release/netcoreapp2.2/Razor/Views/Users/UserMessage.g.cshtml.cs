#pragma checksum "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104442f1c16800d99f2a4304e441e79d61af43af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_UserMessage), @"mvc.1.0.view", @"/Views/Users/UserMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/UserMessage.cshtml", typeof(AspNetCore.Views_Users_UserMessage))]
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
#line 1 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
using lsc.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"104442f1c16800d99f2a4304e441e79d61af43af", @"/Views/Users/UserMessage.cshtml")]
    public class Views_Users_UserMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
  
    ViewData["Title"] = "用户信息";
    Layout = "~/Pages/_LayoutNone.cshtml";
    UserRole userRole = ViewBag.userRole;

#line default
#line hidden
            BeginContext(162, 44, true);
            WriteLiteral("<div style=\"text-align:center\">\r\n    <p>用户名：");
            EndContext();
            BeginContext(207, 14, false);
#line 9 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
      Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 17, true);
            WriteLiteral("</p>\r\n    <p>姓名： ");
            EndContext();
            BeginContext(239, 10, false);
#line 10 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(249, 18, true);
            WriteLiteral("</p>\r\n    <p>手机号： ");
            EndContext();
            BeginContext(268, 14, false);
#line 11 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
       Write(Model.TelPhone);

#line default
#line hidden
            EndContext();
            BeginContext(282, 17, true);
            WriteLiteral("</p>\r\n    <p>角色： ");
            EndContext();
            BeginContext(300, 17, false);
#line 12 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
      Write(userRole.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(317, 19, true);
            WriteLiteral("</p>\r\n    <p>注册时间： ");
            EndContext();
            BeginContext(337, 39, false);
#line 13 "D:\gitCode\crm\lsc\lsc.crm\Views\Users\UserMessage.cshtml"
        Write(Model.CreateTime.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(376, 16, true);
            WriteLiteral("</p>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591