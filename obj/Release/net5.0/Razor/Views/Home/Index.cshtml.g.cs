#pragma checksum "/home/kun/Mng/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d0ffdda0809a716fd120ef01fa386a3ef8bc2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/kun/Mng/Views/_ViewImports.cshtml"
using Mng;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kun/Mng/Views/_ViewImports.cshtml"
using Mng.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d0ffdda0809a716fd120ef01fa386a3ef8bc2a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e889aa6237966944742c5c533c98dfbf6737e28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mng.Models.Part>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/kun/Mng/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "/home/kun/Mng/Views/Home/Index.cshtml"
 foreach(var v in Model) {


#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n<br>\r\n    <p> ");
#nullable restore
#line 16 "/home/kun/Mng/Views/Home/Index.cshtml"
   Write(v.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 17 "/home/kun/Mng/Views/Home/Index.cshtml"
    

    foreach(var t in v.Images) {
        if (t != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img style=\'width:200px; height:200px;\'");
            BeginWriteAttribute("src", " src=\"", 494, "\"", 561, 2);
            WriteAttributeValue("", 500, "data:image/jpeg;base64,", 500, 23, true);
#nullable restore
#line 22 "/home/kun/Mng/Views/Home/Index.cshtml"
WriteAttributeValue("", 523, Convert.ToBase64String(t.ImageData), 523, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 23 "/home/kun/Mng/Views/Home/Index.cshtml"
                    }
    }
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mng.Models.Part>> Html { get; private set; }
    }
}
#pragma warning restore 1591
