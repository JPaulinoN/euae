#pragma checksum "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3b4230f2ccb38693c97e4685bc3f3334f2a166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Greeting), @"mvc.1.0.razor-page", @"/Pages/Greeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Greeting.cshtml", typeof(AspNetCore.Pages_Greeting), @"{name}")]
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
#line 1 "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Models;

#line default
#line hidden
#line 2 "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.ViewModels;

#line default
#line hidden
#line 3 "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Pages;

#line default
#line hidden
#line 4 "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{name}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c3b4230f2ccb38693c97e4685bc3f3334f2a166", @"/Pages/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049668f3ff472e3c13f080721e10f773e99c64d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Greeting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(52, 21, false);
#line 5 "D:\Treinamento\ASP.NET\OdeToFood\OdeToFood\Pages\Greeting.cshtml"
Write(Model.CurrentGreeting);

#line default
#line hidden
            EndContext();
            BeginContext(73, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreetingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingModel>)PageContext?.ViewData;
        public GreetingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
