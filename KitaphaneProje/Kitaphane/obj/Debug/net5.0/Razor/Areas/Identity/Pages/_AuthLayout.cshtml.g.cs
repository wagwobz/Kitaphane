#pragma checksum "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fcff5cd1f6a460c88c9a1ebeaffc47258f8388"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_ViewImports.cshtml"
using Kitaphane.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_ViewImports.cshtml"
using Kitaphane.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_ViewImports.cshtml"
using Kitaphane.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fcff5cd1f6a460c88c9a1ebeaffc47258f8388", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d763f457ad063846595deb62454f9a33e620cab6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .button {
        border: none;
        color: #FAFDD6;
        padding: 12px 24px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 14px;
        margin: 4px 2px;
        transition-duration: 0.4s;
        cursor: pointer;
    }

    .button1 {
        background-color: #FAFDD6;
        color: black;
        border: 2px solid #A2B38B;
    }

        .button1:hover {
            background-color: #A2B38B;
            color: black;
        }
</style>

<div class=""row"" >
    <div class=""com-md-6 offset-md-3"" style=""background-color: #FAFDD6""  >
        <div class=""card login-logout-tab"" style=""width:600px;"">
            <div class=""card-header"" style=""background-color: #FAFDD6"" >
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>Sign In</a>
                    </li>
                 ");
            WriteLiteral(@"   <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'>Sign Up</a>
                    </li>
                </ul>
            </div>
            <div class=""card-content"" style=""background-color: #FAFDD6"" >
                <div class=""row"">
                    <div class=""col-md-10"">
                        ");
#nullable restore
#line 46 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_AuthLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 55 "C:\Users\behza\Desktop\KitaphaneRepo\Kitaphane\KitaphaneProje\Kitaphane\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

<script>
    $(function () {
        var current = location.pathname;
        $('.nav-tabs li a').each(function (){
            var $this = $(this);
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
