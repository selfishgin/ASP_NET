#pragma checksum "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f88d04d74b76028f46027f321001b7821ec748107de0d6051ca881b6893e541b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee2), @"mvc.1.0.view", @"/Views/Home/Employee2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f88d04d74b76028f46027f321001b7821ec748107de0d6051ca881b6893e541b", @"/Views/Home/Employee2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"385b2a4e67f04428fd59cec96bccbb89b1a625ea35f61d3eeeec5a82a03805c3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Employee2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCPracticeLesson1.Models.EmployeeViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88d04d74b76028f46027f321001b7821ec748107de0d6051ca881b6893e541b3159", async() => {
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88d04d74b76028f46027f321001b7821ec748107de0d6051ca881b6893e541b4149", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
     foreach (var item in Model.Employees)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <h1>Firstname: ");
#nullable restore
#line 30 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
                      Write(item.Firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            <h1>Lastname: ");
#nullable restore
#line 31 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
                     Write(item.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            <div>\r\n                <span>User ID: ");
#nullable restore
#line 33 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
                          Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 36 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
     foreach(var item in Model.Cities)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h2>");
#nullable restore
#line 39 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 40 "C:\Users\Husey_ij91\source\repos\MVCPracticeLesson1\MVCPracticeLesson1\Views\Home\Employee2.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCPracticeLesson1.Models.EmployeeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
