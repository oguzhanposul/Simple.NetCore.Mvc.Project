#pragma checksum "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f047d0ee4c68da3c1a909ed53d4c16d9b25bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_List), @"mvc.1.0.view", @"/Views/Course/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/List.cshtml", typeof(AspNetCore.Views_Course_List))]
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
#line 1 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\_ViewImports.cshtml"
using MiniProjectCourseApp2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f047d0ee4c68da3c1a909ed53d4c16d9b25bae", @"/Views/Course/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9acd29271d0a9574d418f622349cfe24b490e4d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Student>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(30, 40, true);
            WriteLiteral("\r\n <!doctype html>\r\n\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(70, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f047d0ee4c68da3c1a909ed53d4c16d9b25bae3382", async() => {
                BeginContext(76, 181, true);
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n  <title>Home</title>\r\n  <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\">  \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(264, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(268, 464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f047d0ee4c68da3c1a909ed53d4c16d9b25bae4765", async() => {
                BeginContext(274, 185, true);
                WriteLiteral("\r\n\r\n    <table>\r\n        <thead>\r\n          <tr>\r\n            <td>Name</td>\r\n            <td>Email</td>\r\n            <td>Phone</td>\r\n          </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 24 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml"
           foreach (var student in Model)
          {

#line default
#line hidden
                BeginContext(515, 40, true);
                WriteLiteral("              <tr>\r\n                <td>");
                EndContext();
                BeginContext(556, 12, false);
#line 27 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml"
               Write(student.Name);

#line default
#line hidden
                EndContext();
                BeginContext(568, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(596, 13, false);
#line 28 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml"
               Write(student.Email);

#line default
#line hidden
                EndContext();
                BeginContext(609, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(637, 13, false);
#line 29 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml"
               Write(student.Phone);

#line default
#line hidden
                EndContext();
                BeginContext(650, 28, true);
                WriteLiteral("</td>\r\n              </tr>\r\n");
                EndContext();
#line 31 "C:\Users\oguz-\Desktop\Genel\Udemy.ASP.NET.CORE\MiniProjectCourseApp2\Views\Course\List.cshtml"
          }

#line default
#line hidden
                BeginContext(691, 34, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(732, 46, true);
            WriteLiteral("\r\n</html>                                     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591