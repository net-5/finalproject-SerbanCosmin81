#pragma checksum "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1397d3fd8973fae4e283a858aebc0672aae0d16e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/SponsorTypes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SponsorTypes/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_SponsorTypes_Delete))]
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
#line 1 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1397d3fd8973fae4e283a858aebc0672aae0d16e", @"/Areas/Admin/Views/SponsorTypes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69431662de017e0e5062ca4c3938ac9070d8796", @"/Areas/Admin/Views/SponsorTypes/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SponsorTypes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Conference.Areas.Admin.Models.SponsorTypesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(104, 161, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(266, 38, false);
#line 15 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(304, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(368, 34, false);
#line 18 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(402, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(465, 40, false);
#line 21 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(505, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(569, 36, false);
#line 24 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(605, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(668, 41, false);
#line 27 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(709, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(773, 37, false);
#line 30 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order));

#line default
#line hidden
            EndContext();
            BeginContext(810, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(873, 43, false);
#line 33 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(916, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(980, 39, false);
#line 36 "d:\SerCOS Final\finalproject-SerbanCosmin81\Conference\Areas\Admin\Views\SponsorTypes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1057, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1397d3fd8973fae4e283a858aebc0672aae0d16e8275", async() => {
                BeginContext(1083, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1166, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1397d3fd8973fae4e283a858aebc0672aae0d16e8748", async() => {
                    BeginContext(1188, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1204, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1217, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Conference.Areas.Admin.Models.SponsorTypesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
