#pragma checksum "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94a1609bc32a10d6ac44d3d184214ecc64d3ee4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Songs_Details), @"mvc.1.0.view", @"/Views/Songs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Songs/Details.cshtml", typeof(AspNetCore.Views_Songs_Details))]
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
#line 1 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\_ViewImports.cshtml"
using MusicWebDemo;

#line default
#line hidden
#line 2 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\_ViewImports.cshtml"
using MusicWebDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94a1609bc32a10d6ac44d3d184214ecc64d3ee4b", @"/Views/Songs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b01d6d9613825d10ef70d822ae5a0e073a989c", @"/Views/_ViewImports.cshtml")]
    public class Views_Songs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MusicWebDemo.Models.Song>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Song</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(197, 40, false);
#line 14 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 36, false);
#line 17 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(317, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(361, 42, false);
#line 20 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Singer));

#line default
#line hidden
            EndContext();
            BeginContext(403, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(447, 38, false);
#line 23 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Singer));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(529, 42, false);
#line 26 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(571, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(615, 38, false);
#line 29 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(653, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(697, 45, false);
#line 32 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Thumbnail));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(786, 41, false);
#line 35 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Thumbnail));

#line default
#line hidden
            EndContext();
            BeginContext(827, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(871, 40, false);
#line 38 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(911, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(955, 36, false);
#line 41 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Link));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1035, 45, false);
#line 44 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1124, 41, false);
#line 47 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1209, 45, false);
#line 50 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1298, 41, false);
#line 53 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1383, 42, false);
#line 56 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1469, 38, false);
#line 59 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1554, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a97a8e8720644779a291fb5c3075047", async() => {
                BeginContext(1600, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\NguyenCongJP\source\repos\HOC KY 3\WEB .NET CORE\MusicWebDemo\MusicWebDemo\Views\Songs\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1608, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1616, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daef817acc37485d9f52ef8cc7c7a768", async() => {
                BeginContext(1638, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1654, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicWebDemo.Models.Song> Html { get; private set; }
    }
}
#pragma warning restore 1591
