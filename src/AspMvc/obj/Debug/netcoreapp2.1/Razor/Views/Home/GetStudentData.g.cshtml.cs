#pragma checksum "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e613a16f1abf12e313fc763e98fe60755ae91fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetStudentData), @"mvc.1.0.view", @"/Views/Home/GetStudentData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetStudentData.cshtml", typeof(AspNetCore.Views_Home_GetStudentData))]
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
#line 1 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\_ViewImports.cshtml"
using AspMvc;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\_ViewImports.cshtml"
using AspMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e613a16f1abf12e313fc763e98fe60755ae91fc", @"/Views/Home/GetStudentData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"890ab49ac151ff00f5f2136a3c0822f5f59e057e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetStudentData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspMvc.Models.Student_Info>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
  
    ViewData["Title"] = "GetStudentData";

#line default
#line hidden
            BeginContext(98, 193, true);
            WriteLiteral("\r\n<h2>StudentData</h2>\r\n<table class=\"table table-bordered table-responsive table-hover\">\r\n    <tr>\r\n        <th> Student_ID </th>\r\n        <th> Name </th>\r\n        <th>Branch</th>\r\n    </tr>\r\n");
            EndContext();
#line 13 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
            BeginContext(329, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(352, 12, false);
#line 16 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
       Write(d.Student_ID);

#line default
#line hidden
            EndContext();
            BeginContext(364, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(384, 6, false);
#line 17 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
       Write(d.Name);

#line default
#line hidden
            EndContext();
            BeginContext(390, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(410, 8, false);
#line 18 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
       Write(d.Branch);

#line default
#line hidden
            EndContext();
            BeginContext(418, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Users\Lenovo\source\repos\AspMvc\AspMvc\Views\Home\GetStudentData.cshtml"
    }

#line default
#line hidden
            BeginContext(443, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspMvc.Models.Student_Info>> Html { get; private set; }
    }
}
#pragma warning restore 1591
