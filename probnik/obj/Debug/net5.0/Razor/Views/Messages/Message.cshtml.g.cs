#pragma checksum "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7b0e728f39194ec739944a18fcf5766c60ab8e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Message), @"mvc.1.0.view", @"/Views/Messages/Message.cshtml")]
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
#line 1 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
using probnik.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b0e728f39194ec739944a18fcf5766c60ab8e6", @"/Views/Messages/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539e55a807092e16e792d5580a8cc116f7a7c750", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<probnik.Data.Messages>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/photo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-unobtrusive-ajax/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
  
    ViewBag.Title = "Сообщение";
    var message = ViewBag.Message as List<Messages>;
    var users = ViewBag.Users as List<User>;
    //var idd = User.FindFirstValue(ClaimTypes.NameIdentifier);
    var only = User.Identity.Name;
    var name = ViewBag.Name;
    var Email = ViewBag.Email;
    var mId = ViewBag.Mid;
    //Правильные сообщения
    //@foreach (var i in message.Where(x => (x.id == mId && x.Fromm == only) || (x.Fromm == email && x.id == idd)).OrderBy(x => x.Date))

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    body {\r\n        overflow: hidden;\r\n    }\r\n\r\n    .alignleft {\r\n        float: left;\r\n    }\r\n\r\n    .alignright {\r\n        float: right;\r\n    }\r\n\r\n    .scroll_div::-webkit-scrollbar {\r\n        width: 0;\r\n    }\r\n    \r\n</style>\r\n\r\n");
#nullable restore
#line 35 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
 foreach (var i in users)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
     if (i.Photo != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p align=\"center\"><img style=\'width: 60px; height: 60px; border-radius: 35px;\'");
            BeginWriteAttribute("src", " src=\"", 971, "\"", 1034, 2);
            WriteAttributeValue("", 977, "data:image/jpeg;base64,", 977, 23, true);
#nullable restore
#line 39 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
WriteAttributeValue("", 1000, Convert.ToBase64String(i.Photo), 1000, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> ");
#nullable restore
#line 39 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
                                                                                                                                                     Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p align=\"center\"><img style=\'width: 60px; height: 60px; border-radius: 35px;\' src=\"https://cdn.pixabay.com/photo/2012/04/26/19/43/profile-42914_1280.png\" /> ");
#nullable restore
#line 43 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
                                                                                                                                                                 Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 align=\"center\">Сообщения</h2>\r\n        <div class=\"scroll_div\" id=\"mydiv\" style=\" overflow: scroll;overflow-x:hidden; height: 332px;background:white;\">\r\n            <table height: 332px; width=\"100%\" id=\"tblMessages\"");
            BeginWriteAttribute("class", " class=\"", 1485, "\"", 1493, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <tbody></tbody>\r\n            </table>\r\n        </div>\r\n</br>\r\n    <div class=\"form-group col-md-5\">\r\n        <input hidden type=\"text\" id=\"addId\"");
            BeginWriteAttribute("value", " value=\"", 1658, "\"", 1670, 1);
#nullable restore
#line 54 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
WriteAttributeValue("", 1666, mId, 1666, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("required", " required=\"", 1692, "\"", 1703, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"form-group col-md-5\">\r\n        <input hidden type=\"text\" id=\"addFromm\"");
            BeginWriteAttribute("value", " value=\"", 1809, "\"", 1822, 1);
#nullable restore
#line 58 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
WriteAttributeValue("", 1817, only, 1817, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("required", " required=\"", 1844, "\"", 1855, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group col-md-5\">\r\n        <input hidden id=\"addDate\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1967, "\"", 1988, 1);
#nullable restore
#line 61 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
WriteAttributeValue("", 1975, DateTime.Now, 1975, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("required", " required=\"", 1989, "\"", 2000, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n<input hidden id=\"Email\"");
            BeginWriteAttribute("value", " value=\"", 2042, "\"", 2056, 1);
#nullable restore
#line 63 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
WriteAttributeValue("", 2050, Email, 2050, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("<div style=\"width: 100%; height: 70px;\">\r\n    <input type=\"text\" style=\"width: 80%; border-radius: 5px;\" id=\"addMessage\" class=\"alignleft\" placeholder=\"Введите сообщение\"");
            BeginWriteAttribute("required", " required=\"", 2386, "\"", 2397, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("    <input  class=\"alignright\" id=\"btnSave\" value=\"Отправить\" type=\"button\">\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7b0e728f39194ec739944a18fcf5766c60ab8e611291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n       //setInterval(function () {\r\n       //     $(\'#time\').load(\'Message.cshtml #time\');\r\n       // }, 3000);\r\n        //Добавление\r\n");
                WriteLiteral("        $(function () {\r\n            LoadData(id = $(\"#addId\").val(),Email = $(\"#Email\").val());\r\n            $(\"#btnSave\").click(function () {\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \'");
#nullable restore
#line 108 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
                     Write(Url.Action("sendMessages"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    data: {
                        Email: Email,
                        id: $(""#addId"").val(),
                        message: $(""#addMessage"").val(),
                        fromm: $(""#addFromm"").val(),
                        date: $(""#addDate"").val()
                        
                        //photo: $(""#addPhoto"").val()
                    },

                    success: function (data) {
                        LoadData();

                    }
                });
                return false;
            });
        });
        setInterval(LoadData, 7500);

        //Вывод
        function LoadData(id = $(""#addId"").val(), Email = $(""#Email"").val()) {

        $(""#tblMessages tbody tr"").remove();
        $.ajax({
            type: 'POST',
            url: '");
#nullable restore
#line 135 "D:\Desktop\моя прелесть\probnik\Views\Messages\Message.cshtml"
             Write(Url.Action("getMessages"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
            dataType: 'json',
            //data: { idd: '', },
            data: { id: id, Email: Email },
            success: function (data) {
                //var items = '';
                $.each(data, function (i, item) {
                    var rows =
                            ""<tr>""
                            + ""<td style='border: 2px solid white;'>""
                        + ""<div style='background-color: rgba(128, 128, 255,0.3);'>""
                            + ""<p class='alignleft' >"" + item.fromm + ""</p>""
                            + ""<p class='alignright' >"" + item.date + ""</p>"" + ""</br>""
                            + ""</div>""
                            + ""<p align='left' style='margin:20px;' >"" + item.message + ""</p>""
                            + ""</td>""
                            + ""</tr>"";
                    $('#tblMessages tbody').append(rows);
                    $(""#mydiv"").scrollTop($(""#mydiv"")[0].scrollHeight);


                });
            }
     ");
                WriteLiteral(@"   });
        return false;
        }

        /*setTimeout(, 5000);*/
        //setTimeout(function () {
        //document.getElementById(""time"").location.reload(1);
        //}, 5000);
       //
        //setTimeout(function () {
        //    window.location.reload(1);
        //}, 3000);

        //$('#time').click(function () {
        //    location.reload();
        //});

        ////вывод с конца
        //var scrollDiv = document.getElementById(""scroll_div"");
        //scrollDiv.scrollTo(0, scrollDiv.scrollHeight);
        ////
    </script>
");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7b0e728f39194ec739944a18fcf5766c60ab8e616031", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7b0e728f39194ec739944a18fcf5766c60ab8e617071", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<probnik.Data.Messages> Html { get; private set; }
    }
}
#pragma warning restore 1591
