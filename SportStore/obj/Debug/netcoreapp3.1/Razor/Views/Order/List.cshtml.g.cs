#pragma checksum "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e3081bb5738bf2c87294ee46965a34153e023f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_List), @"mvc.1.0.view", @"/Views/Order/List.cshtml")]
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
#line 1 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\_ViewImports.cshtml"
using SportStore.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e3081bb5738bf2c87294ee46965a34153e023f", @"/Views/Order/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c6b16f3eb77d8b7fe9af19497745e29d07597a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkShipped", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
  
    ViewBag.Title = "Orders";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-striped\">\r\n        <tr><th>Name</th><th>Zip</th><th colspan=\"2\">Details</th><th></th></tr>\r\n");
#nullable restore
#line 12 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
         foreach (Order o in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 15 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
               Write(o.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
               Write(o.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <th>Product</th>\r\n                <th>Quantity</th>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e3081bb5738bf2c87294ee46965a34153e023f5667", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 614, "\"", 632, 1);
#nullable restore
#line 21 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
WriteAttributeValue("", 622, o.OrderId, 622, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                            Ship\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
             foreach (CartLine line in o.Lines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"2\"></td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
                   Write(line.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 36 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 39 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">No Unshipped Orders</div>\r\n");
#nullable restore
#line 43 "C:\Users\vlddr\source\repos\SportStore\SportStore\Views\Order\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
