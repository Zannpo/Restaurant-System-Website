#pragma checksum "D:\Projekty\takie tam\RestaurantSystem\RestaurantSystem\Pages\SpecialOffers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80edf2e32f115e6c32fb25f8f59500703418ac5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantSystem.Pages.Pages_SpecialOffers), @"mvc.1.0.razor-page", @"/Pages/SpecialOffers.cshtml")]
namespace RestaurantSystem.Pages
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
#line 1 "D:\Projekty\takie tam\RestaurantSystem\RestaurantSystem\Pages\_ViewImports.cshtml"
using RestaurantSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80edf2e32f115e6c32fb25f8f59500703418ac5e", @"/Pages/SpecialOffers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d5ffe3a4611e6ab139f5a57e87caf9d154c25b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SpecialOffers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projekty\takie tam\RestaurantSystem\RestaurantSystem\Pages\SpecialOffers.cshtml"
  
    ViewData["Title"] = "Promocje";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 8 "D:\Projekty\takie tam\RestaurantSystem\RestaurantSystem\Pages\SpecialOffers.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>Nasze aktualne promocje: </p>\r\n</div>\r\n");
#nullable restore
#line 12 "D:\Projekty\takie tam\RestaurantSystem\RestaurantSystem\Pages\SpecialOffers.cshtml"
Write(Model.Id);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantSystem.Pages.SpecialOffersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantSystem.Pages.SpecialOffersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantSystem.Pages.SpecialOffersModel>)PageContext?.ViewData;
        public RestaurantSystem.Pages.SpecialOffersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591