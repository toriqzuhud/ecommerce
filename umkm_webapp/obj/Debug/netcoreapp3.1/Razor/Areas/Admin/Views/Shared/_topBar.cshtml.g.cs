#pragma checksum "D:\MSIB 3\Github\FinalProject\ecommerce\umkm_webapp\Areas\Admin\Views\Shared\_topBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d973203416f6304d82c6ed06fb1663c8afe3e290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__topBar), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_topBar.cshtml")]
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
#line 1 "D:\MSIB 3\Github\FinalProject\ecommerce\umkm_webapp\Areas\Admin\Views\_ViewImports.cshtml"
using umkm_webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MSIB 3\Github\FinalProject\ecommerce\umkm_webapp\Areas\Admin\Views\_ViewImports.cshtml"
using umkm_webapp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MSIB 3\Github\FinalProject\ecommerce\umkm_webapp\Areas\Admin\Views\_ViewImports.cshtml"
using umkm_webapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d973203416f6304d82c6ed06fb1663c8afe3e290", @"/Areas/Admin/Views/Shared/_topBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b25e33c9ab078f69963bbacad25489b84c4caea4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__topBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-sm-inline-block form-inline mr-auto ml-md-3 my-2 my-md-0 mw-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/undraw_profile_1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <!-- Topbar -->
<nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

    <!-- Sidebar Toggle (Topbar) -->
    <button id=""sidebarToggleTop"" class=""btn btn-link d-md-none rounded-circle mr-3"">
        <i class=""fa fa-bars""></i>
    </button>

    <!-- Topbar Search -->
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d973203416f6304d82c6ed06fb1663c8afe3e2905870", async() => {
                WriteLiteral(@"
        <div class=""input-group"">
            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for...""
                   aria-label=""Search"" aria-describedby=""basic-addon2"">
            <div class=""input-group-append"">
                <button class=""btn btn-primary"" type=""button"">
                    <i class=""fas fa-search fa-sm""></i>
                </button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <!-- Topbar Navbar -->
    <ul class=""navbar-nav ml-auto"">

        <!-- Nav Item - Search Dropdown (Visible Only XS) -->
        <li class=""nav-item dropdown no-arrow d-sm-none"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-search fa-fw""></i>
            </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in""
                 aria-labelledby=""searchDropdown"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d973203416f6304d82c6ed06fb1663c8afe3e2908309", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <input type=""text"" class=""form-control bg-light border-0 small""
                               placeholder=""Search for..."" aria-label=""Search""
                               aria-describedby=""basic-addon2"">
                        <div class=""input-group-append"">
                            <button class=""btn btn-primary"" type=""button"">
                                <i class=""fas fa-search fa-sm""></i>
                            </button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </li>

        <!-- Nav Item - Alerts -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-fw""></i>
                <!-- Counter - Alerts -->
                <span class=""badge badge-danger badge-counter"">3+</span>
            </a>
            <!-- Dropdown - Alerts -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                 aria-labelledby=""alertsDropdown"">
                <h6 class=""dropdown-header"">
                    Alerts Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-primary"">
                            <i class=""fas fa-file-alt text-");
            WriteLiteral(@"white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 12, 2019</div>
                        <span class=""font-weight-bold"">A new monthly report is ready to download!</span>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div class=""icon-circle bg-success"">
                            <i class=""fas fa-donate text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 7, 2019</div>
                        $290.29 has been deposited into your account!
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""mr-3"">
                        <div ");
            WriteLiteral(@"class=""icon-circle bg-warning"">
                            <i class=""fas fa-exclamation-triangle text-white""></i>
                        </div>
                    </div>
                    <div>
                        <div class=""small text-gray-500"">December 2, 2019</div>
                        Spending Alert: We've noticed unusually high spending for your account.
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Show All Alerts</a>
            </div>
        </li>

        <!-- Nav Item - Messages -->
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""messagesDropdown"" role=""button""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-envelope fa-fw""></i>
                <!-- Counter - Messages -->
                <span class=""badge badge-danger badge-counter"">7</span>
          ");
            WriteLiteral(@"  </a>
            <!-- Dropdown - Messages -->
            <div class=""dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in""
                 aria-labelledby=""messagesDropdown"">
                <h6 class=""dropdown-header"">
                    Message Center
                </h6>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d973203416f6304d82c6ed06fb1663c8afe3e29013976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div class=""font-weight-bold"">
                        <div class=""text-truncate"">
                            Hi there! I am wondering if you can help me with a
                            problem I've been having.
                        </div>
                        <div class=""small text-gray-500"">Emily Fowler · 58m</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""img/undraw_profile_2.svg""
                             alt=""..."">
                        <div class=""status-indicator""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">
                            I have the photos that you ordered last month, how
   ");
            WriteLiteral(@"                         would you like them sent to you?
                        </div>
                        <div class=""small text-gray-500"">Jae Chun · 1d</div>
                    </div>
                </a>
                <a class=""dropdown-item d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""img/undraw_profile_3.svg""
                             alt=""..."">
                        <div class=""status-indicator bg-warning""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">
                            Last month's report looks great, I am very happy with
                            the progress so far, keep up the good work!
                        </div>
                        <div class=""small text-gray-500"">Morgan Alvarez · 2d</div>
                    </div>
                </a>
                <a class=""dropdown-item");
            WriteLiteral(@" d-flex align-items-center"" href=""#"">
                    <div class=""dropdown-list-image mr-3"">
                        <img class=""rounded-circle"" src=""https://source.unsplash.com/Mv9hjnEUHR4/60x60""
                             alt=""..."">
                        <div class=""status-indicator bg-success""></div>
                    </div>
                    <div>
                        <div class=""text-truncate"">
                            Am I a good boy? The reason I ask is because someone
                            told me that people say this to all dogs, even if they aren't good...
                        </div>
                        <div class=""small text-gray-500"">Chicken the Dog · 2w</div>
                    </div>
                </a>
                <a class=""dropdown-item text-center small text-gray-500"" href=""#"">Read More Messages</a>
            </div>
        </li>

        <div class=""topbar-divider d-none d-sm-block""></div>

        <!-- Nav Item - User Information --");
            WriteLiteral(@">
        <li class=""nav-item dropdown no-arrow"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button""
               data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Douglas McGee</span>
                <img class=""img-profile rounded-circle""
                     src=""img/undraw_profile.svg"">
            </a>
            <!-- Dropdown - User Information -->
            <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in""
                 aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                    Profile
                </a>
                <a class=""dropdown-item"" href=""#"">
                    <i class=""fas fa-cogs fa-sm fa-fw mr-2 text-gray-400""></i>
                    Settings
                </a>
                <a class");
            WriteLiteral(@"=""dropdown-item"" href=""#"">
                    <i class=""fas fa-list fa-sm fa-fw mr-2 text-gray-400""></i>
                    Activity Log
                </a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                    <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                    Logout
                </a>
            </div>
        </li>

    </ul>

</nav>
<!-- End of Topbar -->");
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
