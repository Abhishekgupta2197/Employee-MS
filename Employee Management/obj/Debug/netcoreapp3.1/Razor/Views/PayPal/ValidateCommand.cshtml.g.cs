#pragma checksum "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9d83dbb9349219ccda0d980480f7b131b700d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayPal_ValidateCommand), @"mvc.1.0.view", @"/Views/PayPal/ValidateCommand.cshtml")]
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
#line 1 "E:\Capstone\Employee-MS\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Capstone\Employee-MS\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Capstone\Employee-MS\Employee Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9d83dbb9349219ccda0d980480f7b131b700d41", @"/Views/PayPal/ValidateCommand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c190d19520ea44a4df6e823ec2ec466f984b4978", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PayPal_ValidateCommand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee_Management.Models.PayPalModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hiddenform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9d83dbb9349219ccda0d980480f7b131b700d414021", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9d83dbb9349219ccda0d980480f7b131b700d414283", async() => {
                    WriteLiteral("\r\n    ");
#nullable restore
#line 5 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.cmd));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 6 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.business));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 7 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.no_shipping));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 8 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.@return));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 9 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.cancel_return));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 10 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.notify_url));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 11 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.currency_code));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 12 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.item_name));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
#nullable restore
#line 13 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
Write(Html.HiddenFor(model => model.amount));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "E:\Capstone\Employee-MS\Employee Management\Views\PayPal\ValidateCommand.cshtml"
AddHtmlAttributeValue("", 90, Model.actionURL, 90, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <p style=\"text-align: center\">\r\n        <h3>\r\n            Connecting to Paypal , please wait ...\r\n\r\n        </h3>\r\n    </p>\r\n");
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<script type=\"text/javascript\" language=\"javascript\">\r\n    $(this.document).ready(function () {\r\n        var form = $(\"form\");\r\n        form.submit();\r\n    });   \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee_Management.Models.PayPalModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591