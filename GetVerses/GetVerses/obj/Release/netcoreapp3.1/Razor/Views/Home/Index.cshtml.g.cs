#pragma checksum "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b602f3e17a30fea23dafe03508c0ca1d7b4d38ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\_ViewImports.cshtml"
using GetVerses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\_ViewImports.cshtml"
using GetVerses.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b602f3e17a30fea23dafe03508c0ca1d7b4d38ac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5d05042be275991c833c4fb3ed161576ff7e53a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VerseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    \r\n    <style>\r\n        img {\r\n            width:300px;\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Verse of The Day";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 17 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
Write(Html.ActionLink("My Favorites", "MyFavorites"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 19 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
 using(Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 22 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"form-group\">\r\n            <div class=\"col-sm-12\">\r\n                <label>");
#nullable restore
#line 25 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                  Write(Html.DisplayNameFor(Model => Model.startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-sm-12\">\r\n                ");
#nullable restore
#line 28 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
           Write(Html.EditorFor(model => model.startdate, new { htmlAttributes = new { @type = "text", @id = "datepicker", @class = "form-control datepicker", @placeholder = "MM/DD/YYYY" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.startdate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <div class=\"form-group col-sm-12\">\r\n                <div class=\"col-sm-12\">\r\n                    <label>");
#nullable restore
#line 35 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                      Write(Html.DisplayNameFor(Model => Model.PageSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"col-sm-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b602f3e17a30fea23dafe03508c0ca1d7b4d38ac6475", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
#nullable restore
#line 39 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
               Write(Html.ValidationMessageFor(model => model.PageSize, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
         if(Model.verses != null && Model.verses.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table>\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                        ");
#nullable restore
#line 52 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.verses[0].verseText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                        ");
#nullable restore
#line 55 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.verses[0].verseImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                     for(int row = 0; row < Model.verses.Count; ++row)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <label");
            BeginWriteAttribute("id", " id=\"", 2250, "\"", 2265, 2);
            WriteAttributeValue("", 2255, "verse_", 2255, 6, true);
#nullable restore
#line 64 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2261, row, 2261, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2266, "\"", 2302, 1);
#nullable restore
#line 64 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2274, Model.verses[row].verseText, 2274, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                                                                                       Write(Model.verses[row].verseText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </td>\r\n                            <td>\r\n                                <img");
            BeginWriteAttribute("id", " id=\"", 2447, "\"", 2462, 2);
            WriteAttributeValue("", 2452, "image_", 2452, 6, true);
#nullable restore
#line 67 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2458, row, 2458, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 2463, "\"", 2498, 1);
#nullable restore
#line 67 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2469, Model.verses[row].verseImage, 2469, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  />\r\n                            </td>\r\n                            <td>\r\n                                <button");
            BeginWriteAttribute("id", " id=\"", 2613, "\"", 2631, 2);
            WriteAttributeValue("", 2618, "favorite_", 2618, 9, true);
#nullable restore
#line 70 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2627, row, 2627, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"is-favorite btn btn-primary\"");
            BeginWriteAttribute("row", " row=\"", 2668, "\"", 2678, 1);
#nullable restore
#line 70 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2674, row, 2674, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 2679, "\"", 2708, 1);
#nullable restore
#line 70 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
WriteAttributeValue("", 2687, Model.verses[row].id, 2687, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Favorite</button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 73 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 76 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 78 "C:\Users\blittle\source\repos\nwnltr\GetVerses\GetVerses\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
    <script src=""https://code.jquery.com/jquery-1.12.4.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script>
        $(function () {
            $(""#datepicker"").datepicker();
        });

        $("".is-favorite"").click(function (e) {

            e.preventDefault();
            let row = $(this).attr('row');
            let id = $(this).val();
            let verse = $(""#verse_"" + row).attr(""value"");
            let imageLink = $(""#image_"" + row).attr(""src"");

            alert(""favorite clicked\n"" +
                ""row = "" + row + ""\n"" + 
                ""id = "" + $(this).val() + ""\n"" + 
                ""verse = "" + $(""#verse_"" + row).attr(""value"") + ""\n"" +
                ""image link = "" + $(""#image_"" + row).attr(""src"")
            );

            $.ajax({
                url: ""/AddFavorite"",
                data: { id: id, verse: verse,");
                WriteLiteral(@" imageLink: imageLink },
                type: ""post"",
                dataType: ""text"",
                success: function(result) {

                },
                cache: false,
                error: function (xhr, status, errorThrown) { },
                complete: function (xhr, status) { }
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VerseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591