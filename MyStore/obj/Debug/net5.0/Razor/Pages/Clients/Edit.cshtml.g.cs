#pragma checksum "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18a65a6eb12caa65aa3a5f7c153c4fad7c744415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyStore.Pages.Clients.Pages_Clients_Edit), @"mvc.1.0.razor-page", @"/Pages/Clients/Edit.cshtml")]
namespace MyStore.Pages.Clients
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
#line 1 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\_ViewImports.cshtml"
using MyStore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a65a6eb12caa65aa3a5f7c153c4fad7c744415", @"/Pages/Clients/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f20bcdfab133b6ecc62fd859baf09c01713465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<h2>Edit Client</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n        <strong>");
#nullable restore
#line 12 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"btn-close\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18a65a6eb12caa65aa3a5f7c153c4fad7c7444154185", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 405, "\"", 433, 1);
#nullable restore
#line 18 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 413, Model.clientInfo.id, 413, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></input>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Name</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 627, "\"", 657, 1);
#nullable restore
#line 23 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 635, Model.clientInfo.name, 635, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Email</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 875, "\"", 906, 1);
#nullable restore
#line 30 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 883, Model.clientInfo.email, 883, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Phone</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1124, "\"", 1155, 1);
#nullable restore
#line 37 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1132, Model.clientInfo.phone, 1132, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Address</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1377, "\"", 1410, 1);
#nullable restore
#line 44 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1385, Model.clientInfo.address, 1385, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
     if (Model.succcessMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
#nullable restore
#line 53 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
                       Write(Model.succcessMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <button type=\"button\" class=\"btn-close\" aria-label=\"Close\"></button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>

    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStore.Pages.Clients.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.EditModel>)PageContext?.ViewData;
        public MyStore.Pages.Clients.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
