#pragma checksum "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c18bccfc954f6d3f3a43e8fd818458b581d3dfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_AddGroupChat), @"mvc.1.0.view", @"/Views/Messages/AddGroupChat.cshtml")]
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
#line 1 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\_ViewImports.cshtml"
using probnik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\_ViewImports.cshtml"
using probnik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c18bccfc954f6d3f3a43e8fd818458b581d3dfd", @"/Views/Messages/AddGroupChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_AddGroupChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<probnik.Data.AddGroupChat>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGroupChat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
  
    ViewBag.Title = "Создание беседы";
    var users = ViewBag.Users;
    var only = User.Identity.Name;
    var j = 0;
    var groupId = ViewBag.Chat;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c18bccfc954f6d3f3a43e8fd818458b581d3dfd4233", async() => {
                WriteLiteral("\r\n\r\n    <label class=\"control-label\">Название беседы</label>\r\n    <input name=\"NameGroup\" class=\"form-control\" />\r\n");
#nullable restore
#line 87 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
     for (int i = 0; i < users.Count; i++)
    {


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <div class=\"form-group\">\r\n");
                WriteLiteral("                <label class=\"control-label\">");
#nullable restore
#line 94 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
                                        Write(users[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                <input type=\"checkbox\"");
                BeginWriteAttribute("name", " name=\"", 3178, "\"", 3207, 3);
                WriteAttributeValue("", 3185, "groupModels[", 3185, 12, true);
#nullable restore
#line 95 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3197, i, 3197, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3199, "].userId", 3199, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3208, "\"", 3228, 1);
#nullable restore
#line 95 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3216, users[i].Id, 3216, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                <input hidden");
                BeginWriteAttribute("name", " name=\"", 3284, "\"", 3314, 3);
                WriteAttributeValue("", 3291, "groupModels[", 3291, 12, true);
#nullable restore
#line 96 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3303, i, 3303, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3305, "].Creator", 3305, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3315, "\"", 3328, 1);
#nullable restore
#line 96 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3323, only, 3323, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n                <input hidden");
                BeginWriteAttribute("name", " name=\"", 3384, "\"", 3414, 3);
                WriteAttributeValue("", 3391, "groupModels[", 3391, 12, true);
#nullable restore
#line 97 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3403, i, 3403, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3405, "].GroupId", 3405, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3415, "\"", 3435, 1);
#nullable restore
#line 97 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
WriteAttributeValue("", 3423, groupId+1, 3423, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 100 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Messages\AddGroupChat.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Отправить\" class=\"btn btn-default\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<probnik.Data.AddGroupChat> Html { get; private set; }
    }
}
#pragma warning restore 1591
