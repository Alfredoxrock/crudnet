#pragma checksum "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55eb48295c6e0a022a067173540c18598f28527c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyStore.Pages.Clients.Pages_Clients_Create), @"mvc.1.0.razor-page", @"/Pages/Clients/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55eb48295c6e0a022a067173540c18598f28527c", @"/Pages/Clients/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f20bcdfab133b6ecc62fd859baf09c01713465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("\r\n<br />\r\n<h2>New Client</h2>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
 if (Model.errorMessage.Length > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
#nullable restore
#line 12 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
                       Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                </div>\r\n");
#nullable restore
#line 15 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55eb48295c6e0a022a067173540c18598f28527c4344", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Name</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 680, "\"", 710, 1);
#nullable restore
#line 21 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 688, Model.clientInfo.name, 688, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Email</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 928, "\"", 959, 1);
#nullable restore
#line 28 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 936, Model.clientInfo.email, 936, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Phone</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1177, "\"", 1208, 1);
#nullable restore
#line 35 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1185, Model.clientInfo.phone, 1185, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-sm-3 col-form-label\">Address</div>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1430, "\"", 1463, 1);
#nullable restore
#line 42 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
WriteAttributeValue("", 1438, Model.clientInfo.address, 1438, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
     if (Model.successMessage.Length > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row mb-3\">\r\n                    <div class=\"col-sm-9\">\r\n                        <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n                            <strong>");
#nullable restore
#line 51 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
                               Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Users\alf_b\Desktop\MyStore\MyStore\Pages\Clients\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStore.Pages.Clients.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.CreateModel>)PageContext?.ViewData;
        public MyStore.Pages.Clients.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591