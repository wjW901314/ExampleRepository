#pragma checksum "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9160d8fa3e2f5bc504ddc12b97a7695c3c94c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EmrSee), @"mvc.1.0.view", @"/Views/Home/EmrSee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EmrSee.cshtml", typeof(AspNetCore.Views_Home_EmrSee))]
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
#line 1 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\_ViewImports.cshtml"
using EMRWebCore;

#line default
#line hidden
#line 2 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\_ViewImports.cshtml"
using EMRWebCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9160d8fa3e2f5bc504ddc12b97a7695c3c94c60", @"/Views/Home/EmrSee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a55987a28da7e4b6d21180ada74373fca7788d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EmrSee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("init()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
  
    ViewData["Title"] = "EMR调阅页面";

#line default
#line hidden
            BeginContext(43, 103, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    function init() {\r\n        var objParam = {\r\n            \"zyId\": \'");
            EndContext();
            BeginContext(147, 12, false);
#line 7 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                Write(ViewBag.zyId);

#line default
#line hidden
            EndContext();
            BeginContext(159, 29, true);
            WriteLiteral("\',\r\n            \"doctorId\": \'");
            EndContext();
            BeginContext(189, 16, false);
#line 8 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                    Write(ViewBag.doctorId);

#line default
#line hidden
            EndContext();
            BeginContext(205, 31, true);
            WriteLiteral("\',\r\n            \"doctorName\": \'");
            EndContext();
            BeginContext(237, 18, false);
#line 9 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                      Write(ViewBag.doctorName);

#line default
#line hidden
            EndContext();
            BeginContext(255, 33, true);
            WriteLiteral("\',\r\n            \"departmentId\": \'");
            EndContext();
            BeginContext(289, 18, false);
#line 10 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                        Write(ViewBag.doctorName);

#line default
#line hidden
            EndContext();
            BeginContext(307, 35, true);
            WriteLiteral("\',\r\n            \"departmentName\": \'");
            EndContext();
            BeginContext(343, 22, false);
#line 11 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                          Write(ViewBag.departmentName);

#line default
#line hidden
            EndContext();
            BeginContext(365, 26, true);
            WriteLiteral("\',\r\n            \"orgId\": \'");
            EndContext();
            BeginContext(392, 13, false);
#line 12 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                 Write(ViewBag.orgId);

#line default
#line hidden
            EndContext();
            BeginContext(405, 28, true);
            WriteLiteral("\',\r\n            \"orgName\": \'");
            EndContext();
            BeginContext(434, 15, false);
#line 13 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                   Write(ViewBag.orgName);

#line default
#line hidden
            EndContext();
            BeginContext(449, 31, true);
            WriteLiteral("\',\r\n            \"serviceUrl\": \'");
            EndContext();
            BeginContext(481, 18, false);
#line 14 "E:\Repository\C#\EMRWebCore\EMRWebCore\Views\Home\EmrSee.cshtml"
                      Write(ViewBag.serviceUrl);

#line default
#line hidden
            EndContext();
            BeginContext(499, 91, true);
            WriteLiteral("\'\r\n        };\r\n        emrEditor.SetBaseInfo(JSON.stringify(objParam));\r\n    }\r\n</script>\r\n");
            EndContext();
            BeginContext(590, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9160d8fa3e2f5bc504ddc12b97a7695c3c94c606691", async() => {
                BeginContext(612, 120, true);
                WriteLiteral("\r\n<div class=\"row\">\r\n    <object id=\"emrEditor\" classid=\"CLSID:F8D25819-93E2-4A55-9910-B4664F008609\"></object>\r\n</div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
