#pragma checksum "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20c6e701a001365afc5622758a125ba7768afbbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayData), @"mvc.1.0.view", @"/Views/Home/DisplayData.cshtml")]
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
#line 1 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\_ViewImports.cshtml"
using FormSubmission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\_ViewImports.cshtml"
using FormSubmission.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c6e701a001365afc5622758a125ba7768afbbd", @"/Views/Home/DisplayData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eee8ebcfc15afbef5ef7fe8ba1aeeb298d01b049", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <h2>Full Name: ");
#nullable restore
#line 5 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <br>\r\n    <h2>Age: ");
#nullable restore
#line 7 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
        Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <br>\r\n    <h2>Email: ");
#nullable restore
#line 9 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
          Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <br>\r\n    <h2>Password:");
#nullable restore
#line 11 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
            Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <br>\r\n    <h2>FavDate: ");
#nullable restore
#line 13 "C:\Users\todda\OneDrive\Documents\CodingDojo\C#\ASP.NETCore\FormSubmission\Views\Home\DisplayData.cshtml"
            Write(Model.FavDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <br>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
