#pragma checksum "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6552e438e284231277bfa10b87edaff11d3c85d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantSystem.Pages.Pages_Appetizer), @"mvc.1.0.razor-page", @"/Pages/Appetizer.cshtml")]
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
#line 1 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\_ViewImports.cshtml"
using RestaurantSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6552e438e284231277bfa10b87edaff11d3c85d9", @"/Pages/Appetizer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d5ffe3a4611e6ab139f5a57e87caf9d154c25b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Appetizer : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
  
    ViewData["Title"] = "Przystawki";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>Nasze rameny</p>\r\n    <div class=\"card-columns\">\r\n");
#nullable restore
#line 12 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
         foreach (var dish in Model.AllPositions)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 351, "\"", 412, 4);
            WriteAttributeValue("", 359, "background-image:", 359, 17, true);
            WriteAttributeValue(" ", 376, "url(", 377, 5, true);
#nullable restore
#line 15 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
WriteAttributeValue("", 381, Url.Content(dish.CourseImage), 381, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 411, ")", 411, 1, true);
            EndWriteAttribute();
            WriteLiteral(" );>\r\n                    <div class=\"embed-responsive embed-responsive-16by9\">\r\n                        <div class=\"card-body\">\r\n                            ");
#nullable restore
#line 18 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
                       Write(dish.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Żaneta\Desktop\ramenik\Restaurant-System-Website\RestaurantSystem\Pages\Appetizer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantSystem.Pages.AppetizerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantSystem.Pages.AppetizerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantSystem.Pages.AppetizerModel>)PageContext?.ViewData;
        public RestaurantSystem.Pages.AppetizerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
