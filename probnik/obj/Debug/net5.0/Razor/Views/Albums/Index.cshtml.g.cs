#pragma checksum "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e8758659af5bba493c4a2e28ed03d93c94096d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
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
#line 1 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
using probnik.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e8758659af5bba493c4a2e28ed03d93c94096d", @"/Views/Albums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<probnik.Data.Albums>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAlbums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePhotos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Albums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAlbums", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
  
    ViewBag.Title = "Галерея";
    var count = ViewBag.Count as List<Photos>;
    var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
    var users = ViewBag.Users as List<User>;

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
    function chpok(id) {
        elem = document.getElementById(id); //находим блок div по его id, который передали в функцию
        state = elem.style.display; //смотрим, включен ли сейчас элемент
        if (state == '') elem.style.display = 'none'; //если включен, то выключаем
        else elem.style.display = ''; //иначе - включаем
");
            WriteLiteral(@"    }
    $(document).ready(function () {
        $(""figcaption"").each(function () {
            if ($(this).prop(""innerHTML"").length > 15) {
                let val = $(this).prop(""innerHTML"");
                $(this).attr(""title"", val);
                $(this).prop(""innerHTML"", val.substr(0, 15) + ""..."")
            }
        });
    });

</script>
");
#nullable restore
#line 46 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
 foreach (var i in users)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e8758659af5bba493c4a2e28ed03d93c94096d6958", async() => {
                WriteLiteral("Добавить Альбом");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e8758659af5bba493c4a2e28ed03d93c94096d8126", async() => {
                WriteLiteral("Добавить Фото");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<button onclick=\"chpok(\'text\')\">Скрыть/Показать</button>\r\n\r\n<div id=\"text\">\r\n\r\n\r\n");
#nullable restore
#line 57 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"vcenter\">\r\n\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 1991, "\"", 2012, 2);
            WriteAttributeValue("", 1996, "example_", 1996, 8, true);
#nullable restore
#line 61 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 2004, item.Id, 2004, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" display:block;\">\r\n                <figure>\r\n\r\n                    <figcaption> ");
#nullable restore
#line 64 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </figcaption>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e8758659af5bba493c4a2e28ed03d93c94096d10632", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                         if (item?.Photos != null)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\"");
                BeginWriteAttribute("src", " src=\"", 2399, "\"", 2494, 2);
                WriteAttributeValue("", 2405, "data:image/jpeg;base64,", 2405, 23, true);
#nullable restore
#line 69 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 2428, Convert.ToBase64String(count.Last(x=>x.albumId==item.Id).Photo), 2428, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 70 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\" src=\"https://4x4sever.ru/image/cache/no_image-1200x900.png\" />\r\n");
#nullable restore
#line 75 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
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
#line 77 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                     if (User.IsInRole("admin") || User.IsInRole("editor"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e8758659af5bba493c4a2e28ed03d93c94096d14900", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
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
#line 80 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                     if (count != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <figcaption>Количество:");
#nullable restore
#line 83 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                                          Write(count.Where(x => x.albumId == item.Id).Distinct().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n");
#nullable restore
#line 84 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </figure>\r\n            </div>\r\n            <button");
            BeginWriteAttribute("id", " id=\"", 3331, "\"", 3356, 3);
            WriteAttributeValue("", 3336, "example_", 3336, 8, true);
#nullable restore
#line 90 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3344, item.Id, 3344, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3354, "_1", 3354, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3357, "\"", 3574, 9);
            WriteAttributeValue("", 3367, "document.getElementById(\'example_", 3367, 33, true);
#nullable restore
#line 90 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3400, item.Id, 3400, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3408, "\').style.display=\'block\';", 3408, 25, true);
            WriteAttributeValue(" ", 3433, "document.getElementById(\'example_", 3434, 34, true);
#nullable restore
#line 90 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3467, item.Id, 3467, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3477, "_1\').style.display=\'none\';", 3477, 26, true);
            WriteAttributeValue(" ", 3503, "document.getElementById(\'example_", 3504, 34, true);
#nullable restore
#line 90 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3537, item.Id, 3537, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3547, "_2\').style.display=\'block\';", 3547, 27, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none;\">Показать</button>\r\n\r\n            <button");
            BeginWriteAttribute("id", " id=\"", 3638, "\"", 3663, 3);
            WriteAttributeValue("", 3643, "example_", 3643, 8, true);
#nullable restore
#line 92 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3651, item.Id, 3651, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3661, "_2", 3661, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3664, "\"", 3881, 9);
            WriteAttributeValue(" ", 3674, "document.getElementById(\'example_", 3675, 34, true);
#nullable restore
#line 92 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3708, item.Id, 3708, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3716, "\').style.display=\'none\';", 3716, 24, true);
            WriteAttributeValue(" ", 3740, "document.getElementById(\'example_", 3741, 34, true);
#nullable restore
#line 92 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3774, item.Id, 3774, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3784, "_2\').style.display=\'none\';", 3784, 26, true);
            WriteAttributeValue(" ", 3810, "document.getElementById(\'example_", 3811, 34, true);
#nullable restore
#line 92 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3844, item.Id, 3844, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3854, "_1\').style.display=\'block\';", 3854, 27, true);
            EndWriteAttribute();
            WriteLiteral(">Скрыть</button>\r\n\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
