#pragma checksum "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cc3c0809651db3b8ec624d94580dbbb760de81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Friends), @"mvc.1.0.view", @"/Views/Home/Friends.cshtml")]
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
#nullable restore
#line 1 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
using probnik.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
using probnik.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cc3c0809651db3b8ec624d94580dbbb760de81", @"/Views/Home/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<probnik.Data.Friends>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFriends", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "reject_addition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
  
    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
    var user = ViewBag.User as List<User>;
    var friends = ViewBag.Friends as List<Friends>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<center>\r\n    <h2>Заявки в друзья</h2>\r\n");
#nullable restore
#line 12 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
     if (friends != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0cc3c0809651db3b8ec624d94580dbbb760de816592", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
         foreach (var j in user.Where(x => x.Id == friends.Last().Sender))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>");
#nullable restore
#line 16 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
          Write(j.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input hidden name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 576, "\"", 602, 1);
#nullable restore
#line 18 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 584, friends.Last().Id, 584, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"sender\"");
                BeginWriteAttribute("value", " value=\"", 643, "\"", 673, 1);
#nullable restore
#line 19 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 651, friends.Last().Sender, 651, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"recipient\"");
                BeginWriteAttribute("value", " value=\"", 717, "\"", 729, 1);
#nullable restore
#line 20 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 725, idd, 725, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"confirmation\" value=\"true\" />\r\n        <div>\r\n            <input type=\"submit\" value=\"Добавить в друзья\" class=\"btn btn-default\" />\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0cc3c0809651db3b8ec624d94580dbbb760de8110411", async() => {
                WriteLiteral("\r\n        <input hidden name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1039, "\"", 1065, 1);
#nullable restore
#line 28 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 1047, friends.Last().Id, 1047, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"sender\"");
                BeginWriteAttribute("value", " value=\"", 1106, "\"", 1136, 1);
#nullable restore
#line 29 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 1114, friends.Last().Sender, 1114, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"recipient\"");
                BeginWriteAttribute("value", " value=\"", 1180, "\"", 1192, 1);
#nullable restore
#line 30 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 1188, idd, 1188, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input hidden name=\"confirmation\" value=\"true\" />\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Отклонить добавление\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Друзья</h2>\r\n    <table width=\"60%\">\r\n");
#nullable restore
#line 39 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
         foreach (var i in Model)
        {
            foreach (var j in user.Where(x => x.Id == i.Sender))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 45 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                         if (j.Photo != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\'width:50px; height:50px; border-radius:35px;\'");
            BeginWriteAttribute("src", " src=\"", 1797, "\"", 1860, 2);
            WriteAttributeValue("", 1803, "data:image/jpeg;base64,", 1803, 23, true);
#nullable restore
#line 47 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
WriteAttributeValue("", 1826, Convert.ToBase64String(j.Photo), 1826, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 48 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\'width:50px; height:50px; border-radius:35px;\' src=\"https://tib.tomsk.ru/upload/iblock/9bb/9bba32393645786f73bbc55c98aa138e.jpg\" />\r\n");
#nullable restore
#line 52 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td align=\"center\" width=\"100%\">");
#nullable restore
#line 55 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                                               Write(j.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0cc3c0809651db3b8ec624d94580dbbb760de8116168", async() => {
                WriteLiteral("Написать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                                                                            WriteLiteral(j.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                                                                                                   WriteLiteral(j.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                                                                                                                             WriteLiteral(j.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
                                                                                                                                                        WriteLiteral(j.Photo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["photo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-photo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["photo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Home\Friends.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>\r\n</center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<probnik.Data.Friends>> Html { get; private set; }
    }
}
#pragma warning restore 1591
