#pragma checksum "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4091d315e33f709c2cbb25792ace41861a3d555d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pick), @"mvc.1.0.view", @"/Views/Home/Pick.cshtml")]
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
#line 2 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4091d315e33f709c2cbb25792ace41861a3d555d", @"/Views/Home/Pick.cshtml")]
    public class Views_Home_Pick : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Parcel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
 using (Html.BeginForm("Pick", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4091d315e33f709c2cbb25792ace41861a3d555d3350", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
        <title>Outpost</title>
        <link rel=""stylesheet"" href=""/css/site.css"">
        <script src=""/js/site.js""></script>
        <script src=""https://kit.fontawesome.com/ad31369bc9.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4091d315e33f709c2cbb25792ace41861a3d555d4722", async() => {
                WriteLiteral(@"
        <span class=""slide"">
            <a href=""#"" onclick=""openSlideMenu()"" id=""bars"">

                <i class=""fas fa-bars""></i>
            </a>
        </span>


        <div id=""menu"" class=""nav"">
            <a href=""#"" class=""close"" onclick=""closeSlideMenu()"">
                <i class=""fas fa-times""></i>
            </a>
            <a href=""/home/Index"" id=""button"" runat=""server"">
                <i class=""fas fa-home""></i>
            </a>
            <a href=""/home/Package"" id=""button2"" runat=""server"">
                <i class=""fas fa-box-open""></i>
            </a>
            <a href=""/Home/Pick"" id=""button3"" runat=""server"">
                <i class=""fas fa-user-friends""></i>
            </a>
            <a href=""/Home/CreateAccount"" id=""button4"">
                <i class=""fas fa-times""></i>
            </a>
            <a href=""#"" id=""button5"">
                <i class=""fas fa-times""></i>
            </a>

        </div>

        <div class=""pimg1"">
          ");
                WriteLiteral(@"  <div class=""ptext"">
                <span class=""border"">
                    Outpost
                </span>
            </div>
        </div>

        <section class=""section section-light"">
            <h2>Pick up parcel</h2>
            <div id=""create-account"">
                <label class=""input"">
                    ");
#nullable restore
#line 60 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
               Write(Html.LabelFor(model => model.Code, htmlAttributes: new { @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 61 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
               Write(Html.EditorFor(model => model.Code));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </label>\r\n                <label class=\"input\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
               Write(Html.LabelFor(model => model.PickUpCode, htmlAttributes: new { @class = "input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 65 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
               Write(Html.EditorFor(model => model.PickUpCode));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </label>
            </div>
            <span class=""user"">
                <div class=""form-group"">
                    <input type=""submit"" value=""Odbierz"" class=""btn btn-succes"" />
                </div>
            </span>

        </section>

        <div class=""pimg3"">
            <div class=""ptext"">
                <span class=""border trans"">
                    Image Three Text
                </span>
            </div>
        </div>

        <section class=""section section-dark"">
            <h2>Outpost</h2>
        </section>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
#nullable restore
#line 89 "C:\Users\Bartek\Documents\GitHub\outpost\Strona test\Test\Test\Views\Home\Pick.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Parcel> Html { get; private set; }
    }
}
#pragma warning restore 1591
