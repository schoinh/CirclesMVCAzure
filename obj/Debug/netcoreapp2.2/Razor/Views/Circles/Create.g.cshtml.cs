#pragma checksum "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e5ab71437573df8ee6635b504a0da587d0786a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Circles_Create), @"mvc.1.0.view", @"/Views/Circles/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Circles/Create.cshtml", typeof(AspNetCore.Views_Circles_Create))]
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
#line 1 "/Users/Guest/Desktop/CIRCLES_MVC/Views/_ViewImports.cshtml"
using Circles_MVC;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/CIRCLES_MVC/Views/_ViewImports.cshtml"
using Circles_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e5ab71437573df8ee6635b504a0da587d0786a6", @"/Views/Circles/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d864beb897ca847bc7b874ccfd52d6af1fe42f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Circles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Create.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 32, true);
            WriteLiteral("\n<h1>Add a New Circle</h1>\n<hr>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(90, 149, true);
            WriteLiteral("    <div class=\"form-group\">\n        <label for=\"Name\">Name</label>\n        <input name=\"Name\" type=\"text\" class=\"form-control\" required>\n    </div>\n");
            EndContext();
            BeginContext(241, 78, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add Circle\" class=\"btn btn-primary\"/><br><br>\n");
            EndContext();
            BeginContext(324, 34, false);
#line 17 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Create.cshtml"
Write(Html.ActionLink("Cancel", "Index"));

#line default
#line hidden
            EndContext();
#line 17 "/Users/Guest/Desktop/CIRCLES_MVC/Views/Circles/Create.cshtml"
                                       
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
