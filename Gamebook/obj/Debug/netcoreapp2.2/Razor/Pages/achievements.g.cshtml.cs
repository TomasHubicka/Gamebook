#pragma checksum "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1285dc9fc9b194fe6bfb6e0530dc5e73f996bb3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1285dc9fc9b194fe6bfb6e0530dc5e73f996bb3", @"/Pages/achievements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801d5cb70facbdf580d936bd96e9a62a681e465b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_achievements : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
  
    ViewData["Title"] = "achievements";

#line default
#line hidden
            BeginContext(96, 25, true);
            WriteLiteral("\r\n<h1>achievements</h1>\r\n");
            EndContext();
#line 8 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
 if (Model.achievements.win) 
{

#line default
#line hidden
            BeginContext(155, 22, true);
            WriteLiteral("    <p>Win: True</p>\r\n");
            EndContext();
#line 11 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(189, 23, true);
            WriteLiteral("    <p>Win: False</p>\r\n");
            EndContext();
#line 15 "C:\Users\Tomáš\source\repos\Gamebook\Gamebook\Pages\achievements.cshtml"
}

#line default
#line hidden
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