#pragma checksum "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e31e70238b53d024ffd55b43e0130804081f51c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Category_Index), @"mvc.1.0.view", @"/Views/Shared/Components/Category/Index.cshtml")]
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
#line 1 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\_ViewImports.cshtml"
using umkm_webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\_ViewImports.cshtml"
using umkm_webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e31e70238b53d024ffd55b43e0130804081f51c1", @"/Views/Shared/Components/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec9ce0c68a1f0929dcbef48fc3a257d716a3261", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
   
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"navbar-nav\" id=\"accordionSidebar\">\r\n");
#nullable restore
#line 6 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
      int number = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\" style=\"list-style:none;\">\r\n        <a class=\"nav-link collapsed\" href=\"#\" data-toggle=\"collapse\" data-target=\"#num_");
#nullable restore
#line 10 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                                                                                   Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n           aria-expanded=\"true\" aria-controls=\"num1\">\r\n            <span>");
#nullable restore
#line 12 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
             Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n");
#nullable restore
#line 14 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
         if (category.InverseParents != null && category.InverseParents.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 518, "\"", 534, 2);
            WriteAttributeValue("", 523, "num_", 523, 4, true);
#nullable restore
#line 16 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
WriteAttributeValue("", 527, number, 527, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\" aria-labelledby=\"headingTwo\" data-parent=\"#accordionSidebar\">\r\n                \r\n                <div class=\"bg-white py-2 collapse-inner rounded\">\r\n");
#nullable restore
#line 19 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                     foreach (var subCategory in category.InverseParents)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                         if (subCategory.Status)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"collapse-item\" href=\"#\">");
#nullable restore
#line 23 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                                                         Write(subCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 24 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                \r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n");
#nullable restore
#line 32 "C:\Users\asus\source\repos\umkm_webapp\umkm_webapp\Views\Shared\Components\Category\Index.cshtml"
        { number++; }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
