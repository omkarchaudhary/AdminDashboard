#pragma checksum "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0434cbb0cd308835fbabbe2af860a8164b86b1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Update), @"mvc.1.0.view", @"/Views/Employee/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Update.cshtml", typeof(AspNetCore.Views_Employee_Update))]
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
#line 1 "E:\ProductManagement\ProductManagement\Views\_ViewImports.cshtml"
using ProductManagement.ViewModels;

#line default
#line hidden
#line 2 "E:\ProductManagement\ProductManagement\Views\_ViewImports.cshtml"
using ProductManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0434cbb0cd308835fbabbe2af860a8164b86b1c", @"/Views/Employee/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10827a39c2752d4279605801b45cbfceda10631b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
  
    ViewBag.Title = "Employees List";

#line default
#line hidden
            BeginContext(79, 142, true);
            WriteLiteral("\r\n<!--PAGE CONTENT -->\r\n\r\n\r\n<div class=\"inner\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1 class=\"page-header\"> ");
            EndContext();
            BeginContext(222, 15, false);
#line 12 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
                                Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(237, 407, true);
            WriteLiteral(@"</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    Employee Information
                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            ");
            EndContext();
            BeginContext(644, 1613, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0434cbb0cd308835fbabbe2af860a8164b86b1c6162", async() => {
                BeginContext(706, 211, true);
                WriteLiteral("\r\n                                <div class=\"form-group col-lg-4\">\r\n                                    <label>Name</label>\r\n                                    <input class=\"form-control\" name=\"name\" id=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 917, "\"", 945, 1);
#line 27 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
WriteAttributeValue("", 925, Model.Employee.Name, 925, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(946, 98, true);
                WriteLiteral(">\r\n                                    <input class=\"form-control\" type=\"hidden\" name=\"Id\" id=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1044, "\"", 1070, 1);
#line 28 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
WriteAttributeValue("", 1052, Model.Employee.Id, 1052, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1071, 280, true);
                WriteLiteral(@">
                                </div>
                                <div class=""form-group col-lg-4"">
                                    <label>Email</label>
                                    <input class=""form-control"" placeholder=""Enter text"" name=""Email"" id=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1351, "\"", 1380, 1);
#line 32 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
WriteAttributeValue("", 1359, Model.Employee.Email, 1359, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1381, 295, true);
                WriteLiteral(@">
                                </div>
                                <div class=""form-group col-lg-4"">
                                    <label>Department</label>
                                    <input class=""form-control"" placeholder=""Enter text"" name=""Department"" id=""Department""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1676, "\"", 1710, 1);
#line 36 "E:\ProductManagement\ProductManagement\Views\Employee\Update.cshtml"
WriteAttributeValue("", 1684, Model.Employee.Department, 1684, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1711, 348, true);
                WriteLiteral(@">
                                </div>


                                <div class=""form-group col-lg-4"">
                                    <button type=""submit"" class=""btn btn-primary"">Submit </button>
                                    <button type=""reset"" class=""btn btn-warning"">Reset </button>
                                    ");
                EndContext();
                BeginContext(2059, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0434cbb0cd308835fbabbe2af860a8164b86b1c9487", async() => {
                    BeginContext(2170, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2180, 70, true);
                WriteLiteral("\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2257, 180, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<!--END PAGE CONTENT -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
