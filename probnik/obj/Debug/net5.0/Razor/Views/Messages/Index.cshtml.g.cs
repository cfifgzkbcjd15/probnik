#pragma checksum "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c2c55fe3c41e07996c97fd7ff3ef257da0be0c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Index), @"mvc.1.0.view", @"/Views/Messages/Index.cshtml")]
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
#line 1 "D:\Desktop\интенсив\probnik\probnik\Views\_ViewImports.cshtml"
using probnik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\интенсив\probnik\probnik\Views\_ViewImports.cshtml"
using probnik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
using probnik.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
using probnik.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c2c55fe3c41e07996c97fd7ff3ef257da0be0c7", @"/Views/Messages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessegaseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddGroupChat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GroupMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
  
    ViewBag.Title = "Сообщения";
    var groupChat = ViewBag.AddGroupChat as List<AddGroupChat>;
    var message = ViewBag.Messages as List<Messages>;
    var only = User.Identity.Name;
    var photo = ViewBag.Photo as List<byte[]>;
    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c2c55fe3c41e07996c97fd7ff3ef257da0be0c75177", async() => {
                WriteLiteral("Групповой чат");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 16 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
     if (Model.AddGroupChats != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
         foreach (var j in groupChat)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
             foreach (var i in Model.AddGroupChats.Where(x => x.GroupId == j.GroupId && x.Name != null))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 24 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                         if (i.Photo != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\'width:50px; height:50px; border-radius:35px;\'");
            BeginWriteAttribute("src", " src=\"", 937, "\"", 1000, 2);
            WriteAttributeValue("", 943, "data:image/jpeg;base64,", 943, 23, true);
#nullable restore
#line 26 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
WriteAttributeValue("", 966, Convert.ToBase64String(i.Photo), 966, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 27 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img style=\'width:50px; height:50px; border-radius:35px;\' src=\"https://tib.tomsk.ru/upload/iblock/9bb/9bba32393645786f73bbc55c98aa138e.jpg\" />\r\n");
#nullable restore
#line 31 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>");
#nullable restore
#line 34 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td align=\"right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c2c55fe3c41e07996c97fd7ff3ef257da0be0c79082", async() => {
                WriteLiteral("Написать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-groupId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                    WriteLiteral(i.GroupId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-groupId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                                                WriteLiteral(i.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td colspan=\"2\" align=\"center\">Сообщения</td></tr>\r\n");
#nullable restore
#line 41 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
         if (message.Count != 0)
        {
            //.LastOrDefault(x => x.id == idd || x.Fromm == only).Message
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
             foreach (var j in message.Where(x => x.Fromm == only || x.id == idd))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                 foreach (var i in Model.User)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td>");
#nullable restore
#line 48 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                       Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td align=\"right\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c2c55fe3c41e07996c97fd7ff3ef257da0be0c713958", async() => {
                WriteLiteral("Написать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                              WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                                                     WriteLiteral(i.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                                                                               WriteLiteral(i.Email);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                                                                                                                                                                                          WriteLiteral(i.Photo);

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
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 49 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\r\n    ");
#nullable restore
#line 51 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
Write(message.LastOrDefault(x => x.id == idd || x.Fromm == only).Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</td>\r\n");
#nullable restore
#line 53 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Desktop\интенсив\probnik\probnik\Views\Messages\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessegaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
