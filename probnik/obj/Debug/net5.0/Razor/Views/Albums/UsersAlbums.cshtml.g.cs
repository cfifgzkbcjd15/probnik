#pragma checksum "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9241d2968e89d37c019e2638e3ec26bcc11269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_UsersAlbums), @"mvc.1.0.view", @"/Views/Albums/UsersAlbums.cshtml")]
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
#line 1 "D:\Desktop\моя прелесть\probnik\Views\_ViewImports.cshtml"
using probnik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\моя прелесть\probnik\Views\_ViewImports.cshtml"
using probnik.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
using probnik.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b9241d2968e89d37c019e2638e3ec26bcc11269", @"/Views/Albums/UsersAlbums.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_UsersAlbums : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<probnik.Data.Albums>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Albums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAlbums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
  
    ViewBag.Title = "Галерея";
    var count = ViewBag.Count as List<Photos>;
    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
    var users = ViewBag.Users as List<User>;
    var mid = ViewBag.Mid;
    var usersId = ViewBag.UserId;
    var albums=ViewBag.Albums as List<Albums>;
    var photos=ViewBag.Photos as List<Photos>;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .vcenter {
        display: inline-block;
        float: none;
        vertical-align: middle;
        text-align: center;
        margin: 20px 0px 10px 0px;
    }

    #bg {
        width: 400px;
        height: 250px;
        background-image: url(https://sun9-29.userapi.com/impg/Gm9zXtygE3R7FAYBxUiD3Do0gMGKZ1wlQtndbw/qSZ4wkQnpr8.jpg?size=1080x1080&quality=96&sign=2b515bdfd042facdad103c5fde584955&type=album);
    }
</style>
<script src=""/js/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""https://github.com/cfifgzkbcjd15/ramka/img.css"">
<script>
    $(document).ready(function () {
        $(""figcaption"").each(function () {
            if ($(this).prop(""innerHTML"").length > 15) {
                let val = $(this).prop(""innerHTML"");
                $(this).attr(""title"", val);
                $(this).prop(""innerHTML"", val.substr(0, 15) + ""..."")
            }
        });
    });");
            WriteLiteral("\n\r\n</script>\r\n<div id=\"text\">\r\n");
#nullable restore
#line 45 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
         foreach (var item in albums)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"vcenter\">\r\n\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1611, "\"", 1632, 2);
            WriteAttributeValue("", 1616, "example_", 1616, 8, true);
#nullable restore
#line 49 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
WriteAttributeValue("", 1624, item.Id, 1624, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" display:block;\">\r\n                    <figure>\r\n\r\n                        <figcaption> ");
#nullable restore
#line 52 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </figcaption>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9241d2968e89d37c019e2638e3ec26bcc112696979", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 54 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                             if (item?.Photos != null)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\"");
                BeginWriteAttribute("src", " src=\"", 2043, "\"", 2138, 2);
                WriteAttributeValue("", 2049, "data:image/jpeg;base64,", 2049, 23, true);
#nullable restore
#line 57 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
WriteAttributeValue("", 2072, Convert.ToBase64String(count.Last(x=>x.albumId==item.Id).Photo), 2072, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 58 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\" src=\"https://4x4sever.ru/image/cache/no_image-1200x900.png\" />\r\n");
#nullable restore
#line 63 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                         if (User.IsInRole("admin") || User.IsInRole("editor"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b9241d2968e89d37c019e2638e3ec26bcc1126911244", async() => {
                WriteLiteral("Удалить");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 68 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                         if (count != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <figcaption>Количество:");
#nullable restore
#line 71 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
                                              Write(count.Where(x => x.albumId == item.Id).Distinct().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n");
#nullable restore
#line 72 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </figure>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "D:\Desktop\моя прелесть\probnik\Views\Albums\UsersAlbums.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<probnik.Data.Albums>> Html { get; private set; }
    }
}
#pragma warning restore 1591
