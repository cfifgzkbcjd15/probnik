#pragma checksum "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59366119b5152c92ec866bd4b67e76d8d4840183"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59366119b5152c92ec866bd4b67e76d8d4840183", @"/Views/Albums/Index.cshtml")]
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
#line 3 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
  
    ViewBag.Title = "Галерея";
    var count = ViewBag.Count as List<Photos>;

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
#line 43 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
 if (User.IsInRole("Admin") || User.IsInRole("editor"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59366119b5152c92ec866bd4b67e76d8d48401836695", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59366119b5152c92ec866bd4b67e76d8d48401837863", async() => {
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
#line 47 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
    
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button onclick=\"chpok(\'text\')\">Скрыть/Показать</button>\r\n\r\n        <div id=\"text\">\r\n\r\n\r\n");
#nullable restore
#line 54 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
             foreach (var item in Model.OrderByDescending(x => x.Id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"vcenter\">\r\n\r\n                    <div");
            BeginWriteAttribute("id", " id=\"", 1969, "\"", 1990, 2);
            WriteAttributeValue("", 1974, "example_", 1974, 8, true);
#nullable restore
#line 58 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 1982, item.Id, 1982, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" display:block;\">\r\n                        <figure>\r\n\r\n                            <figcaption> ");
#nullable restore
#line 61 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </figcaption>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59366119b5152c92ec866bd4b67e76d8d484018310490", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                                 if (item?.Photos != null)
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\"");
                BeginWriteAttribute("src", " src=\"", 2425, "\"", 2478, 1);
#nullable restore
#line 66 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 2431, count.Last(x=>x.albumId==item.Id).ThumbnailUrl, 2431, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 67 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"

                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img style=\"margin: 10px; height: 150px; width: 150px; border-radius: 10px;\" src=\"https://4x4sever.ru/image/cache/no_image-1200x900.png\" />\r\n");
#nullable restore
#line 72 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
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
#line 62 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
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
#line 74 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                             if (User.IsInRole("Admin") || User.IsInRole("editor"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59366119b5152c92ec866bd4b67e76d8d484018314754", async() => {
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
#line 76 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
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
#line 77 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                             if (count != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <figcaption>Количество:");
#nullable restore
#line 80 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
                                                  Write(count.Where(x => x.albumId == item.Id).Distinct().Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</figcaption>\r\n");
#nullable restore
#line 81 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </figure>\r\n                    </div>\r\n                    <button");
            BeginWriteAttribute("id", " id=\"", 3451, "\"", 3476, 3);
            WriteAttributeValue("", 3456, "example_", 3456, 8, true);
#nullable restore
#line 87 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3464, item.Id, 3464, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3474, "_1", 3474, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3477, "\"", 3694, 9);
            WriteAttributeValue("", 3487, "document.getElementById(\'example_", 3487, 33, true);
#nullable restore
#line 87 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3520, item.Id, 3520, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3528, "\').style.display=\'block\';", 3528, 25, true);
            WriteAttributeValue(" ", 3553, "document.getElementById(\'example_", 3554, 34, true);
#nullable restore
#line 87 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3587, item.Id, 3587, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3597, "_1\').style.display=\'none\';", 3597, 26, true);
            WriteAttributeValue(" ", 3623, "document.getElementById(\'example_", 3624, 34, true);
#nullable restore
#line 87 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3657, item.Id, 3657, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3667, "_2\').style.display=\'block\';", 3667, 27, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none;\">Показать</button>\r\n\r\n                    <button");
            BeginWriteAttribute("id", " id=\"", 3766, "\"", 3791, 3);
            WriteAttributeValue("", 3771, "example_", 3771, 8, true);
#nullable restore
#line 89 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3779, item.Id, 3779, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3789, "_2", 3789, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3792, "\"", 4009, 9);
            WriteAttributeValue(" ", 3802, "document.getElementById(\'example_", 3803, 34, true);
#nullable restore
#line 89 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3836, item.Id, 3836, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3844, "\').style.display=\'none\';", 3844, 24, true);
            WriteAttributeValue(" ", 3868, "document.getElementById(\'example_", 3869, 34, true);
#nullable restore
#line 89 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3902, item.Id, 3902, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3912, "_2\').style.display=\'none\';", 3912, 26, true);
            WriteAttributeValue(" ", 3938, "document.getElementById(\'example_", 3939, 34, true);
#nullable restore
#line 89 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
WriteAttributeValue("", 3972, item.Id, 3972, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3982, "_1\').style.display=\'block\';", 3982, 27, true);
            EndWriteAttribute();
            WriteLiteral(">Скрыть</button>\r\n\r\n                </div>\r\n");
#nullable restore
#line 92 "C:\Users\саша\Desktop\интенсив\probnik\probnik\Views\Albums\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n");
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
