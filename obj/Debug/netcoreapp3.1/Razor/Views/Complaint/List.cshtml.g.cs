#pragma checksum "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69c2d4f27dca5c0bc3c28f98f34792593994c9a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Complaint_List), @"mvc.1.0.view", @"/Views/Complaint/List.cshtml")]
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
#line 1 "E:\Core Apps\DemoApp\DemoApp\Views\_ViewImports.cshtml"
using DemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Core Apps\DemoApp\DemoApp\Views\_ViewImports.cshtml"
using DemoApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Core Apps\DemoApp\DemoApp\Views\_ViewImports.cshtml"
using DemoApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69c2d4f27dca5c0bc3c28f98f34792593994c9a8", @"/Views/Complaint/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959b8aabb0230514dd81682de5448e5a5c9781cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Complaint_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Complaint>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Complaints</h1>\r\n");
#nullable restore
#line 9 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
 if (ViewBag.Success != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success\" role=\"alert\">\r\n    ");
#nullable restore
#line 11 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
Write(ViewBag.Success);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 13 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
 if (ViewBag.Failure != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-danger\" role=\"alert\">\r\n    ");
#nullable restore
#line 16 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
Write(ViewBag.Failure);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 18 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69c2d4f27dca5c0bc3c28f98f34792593994c9a85015", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ComplaintId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ComplaintTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ComplaineeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.StatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.IsResolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 59 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplaintId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplaintType.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplaineeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ContactDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 84 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplaintStatus.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 87 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsResolved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 93 "E:\Core Apps\DemoApp\DemoApp\Views\Complaint\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Complaint>> Html { get; private set; }
    }
}
#pragma warning restore 1591
