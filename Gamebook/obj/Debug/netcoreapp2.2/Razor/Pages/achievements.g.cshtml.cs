#pragma checksum "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f8bc503726ddeb9354596eab0b2aa5ba8acbe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Gamebook.Pages.Pages_achievements), @"mvc.1.0.razor-page", @"/Pages/achievements.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/achievements.cshtml", typeof(Gamebook.Pages.Pages_achievements), null)]
namespace Gamebook.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\_ViewImports.cshtml"
using Gamebook;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f8bc503726ddeb9354596eab0b2aa5ba8acbe4", @"/Pages/achievements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801d5cb70facbdf580d936bd96e9a62a681e465b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_achievements : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
  
    ViewData["Title"] = "achievements";

#line default
#line hidden
            BeginContext(96, 190, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1>achievements</h1>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Win:</p>\r\n            </div>\r\n");
            EndContext();
#line 13 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.win)
            {

#line default
#line hidden
            BeginContext(343, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 18 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(493, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 24 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(614, 152, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Turn Around:</p>\r\n            </div>\r\n");
            EndContext();
#line 31 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.TurnAround)
            {

#line default
#line hidden
            BeginContext(830, 103, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed </p>\r\n                </div>\r\n");
            EndContext();
#line 36 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(981, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 42 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(1102, 159, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Bedroom Adventure: </p>\r\n            </div>\r\n");
            EndContext();
#line 49 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.BedroomAdventure)
            {

#line default
#line hidden
            BeginContext(1331, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 54 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1481, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 60 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(1602, 149, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>FallOut: </p>\r\n            </div>\r\n");
            EndContext();
#line 67 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.FallOut)
            {

#line default
#line hidden
            BeginContext(1812, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 72 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1962, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 78 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(2083, 160, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Crowbars Are Heavy: </p>\r\n            </div>\r\n");
            EndContext();
#line 85 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.CrowbarsAreHeavy)
            {

#line default
#line hidden
            BeginContext(2313, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 90 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2463, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 96 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(2584, 161, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Pushing Never Works: </p>\r\n            </div>\r\n");
            EndContext();
#line 103 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.PushingNeverWorks)
            {

#line default
#line hidden
            BeginContext(2816, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 108 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(2966, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 114 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(3087, 153, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Knife Fight: </p>\r\n            </div>\r\n");
            EndContext();
#line 121 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.KnifeFight)
            {

#line default
#line hidden
            BeginContext(3304, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 126 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3454, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 132 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(3575, 155, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Kung-Fu Fight: </p>\r\n            </div>\r\n");
            EndContext();
#line 139 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.KungFuFight)
            {

#line default
#line hidden
            BeginContext(3795, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 144 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3945, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 150 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(4066, 151, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>It\'s Dark: </p>\r\n            </div>\r\n");
            EndContext();
#line 157 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.ItsDark)
            {

#line default
#line hidden
            BeginContext(4278, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 162 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4428, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 168 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(4549, 162, true);
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-6\">\r\n                <p>Do Nothing And Die: </p>\r\n            </div>\r\n");
            EndContext();
#line 176 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
             if (Model.achievements.DoNothingAndDie)
            {

#line default
#line hidden
            BeginContext(4780, 102, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 181 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(4930, 106, true);
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <p>Not Completed</p>\r\n                </div>\r\n");
            EndContext();
#line 187 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
            }

#line default
#line hidden
            BeginContext(5051, 54, true);
            WriteLiteral("        </div>\r\n        <hr />\r\n    </div>\r\n\r\n        ");
            EndContext();
            BeginContext(5105, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4f8bc503726ddeb9354596eab0b2aa5ba8acbe415711", async() => {
                BeginContext(5148, 4, true);
                WriteLiteral("Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5156, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gamebook.Pages.achievementsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gamebook.Pages.achievementsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gamebook.Pages.achievementsModel>)PageContext?.ViewData;
        public Gamebook.Pages.achievementsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
