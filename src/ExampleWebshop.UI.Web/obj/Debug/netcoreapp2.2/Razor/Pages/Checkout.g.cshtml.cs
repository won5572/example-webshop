#pragma checksum "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "602fd103671731b0e791d3523211b9f1ab691c04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ExampleWebshop.UI.Web.Pages.Pages_Checkout), @"mvc.1.0.razor-page", @"/Pages/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Checkout.cshtml", typeof(ExampleWebshop.UI.Web.Pages.Pages_Checkout), null)]
namespace ExampleWebshop.UI.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\_ViewImports.cshtml"
using ExampleWebshop.UI.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"602fd103671731b0e791d3523211b9f1ab691c04", @"/Pages/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0447e0a416887b53d592686b35f015964925356", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(101, 314, true);
            WriteLiteral(@"
<h1>Checkout</h1>

<p>Please validate your order and address details below.</p>

<h2>Address details</h2>
<table class=""table table-bordered"">
    <thead></thead>
    <tbody>
        <tr>
            <td>
                <strong>Full name</strong>
            </td>
            <td>
                ");
            EndContext();
            BeginContext(416, 22, false);
#line 20 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
           Write(Model.Person.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(438, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(440, 21, false);
#line 20 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                                   Write(Model.Person.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(461, 156, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <b>Address</b>\r\n            </td>\r\n            <td>\r\n                <p>");
            EndContext();
            BeginContext(618, 25, false);
#line 28 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
              Write(Model.Person.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(643, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(669, 25, false);
#line 29 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
              Write(Model.Person.AddressLine2);

#line default
#line hidden
            EndContext();
            BeginContext(694, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(720, 25, false);
#line 30 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
              Write(Model.Person.AddressLine3);

#line default
#line hidden
            EndContext();
            BeginContext(745, 345, true);
            WriteLiteral(@"</p>
            </td>
        </tr>
    </tbody>
</table>

<hr/>

<h2>Order details</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th></th>
            <th>Name</th>
            <th>Quantity</th>
            <th>Price</th>
            <th>Total</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 51 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
         foreach (var item in Model.Cart.Items())
        {

#line default
#line hidden
            BeginContext(1152, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1216, "\"", 1263, 2);
            WriteAttributeValue("", 1222, "https://picsum.photos/64?__", 1222, 27, true);
#line 55 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
WriteAttributeValue("", 1249, item.Key.Name, 1249, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1264, "\"", 1285, 2);
#line 55 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
WriteAttributeValue("", 1270, item.Key.Name, 1270, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1284, ".", 1284, 1, true);
            EndWriteAttribute();
            BeginContext(1286, 97, true);
            WriteLiteral(">\r\n                </td>\r\n                <td>\r\n                    <p>\r\n                        ");
            EndContext();
            BeginContext(1384, 13, false);
#line 59 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                   Write(item.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1397, 169, true);
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n                <td>\r\n                    <div class=\"row\">\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(1567, 10, false);
#line 65 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                       Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1577, 174, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    <p>\r\n                        $");
            EndContext();
            BeginContext(1752, 14, false);
#line 71 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                    Write(item.Key.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1766, 142, true);
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    <p>\r\n                        $");
            EndContext();
            BeginContext(1910, 27, false);
#line 76 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                     Write(item.Key.Price * item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(1938, 70, true);
            WriteLiteral("\r\n                    </p>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
        }

#line default
#line hidden
            BeginContext(2019, 126, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"5\" class=\"text-right\">\r\n                <h4>Total: <strong>$");
            EndContext();
            BeginContext(2146, 27, false);
#line 85 "C:\Users\Isomorphism\source\repos\ExampleWebshop\src\ExampleWebshop.UI.Web\Pages\Checkout.cshtml"
                               Write(Model.Cart.CalculateTotal());

#line default
#line hidden
            EndContext();
            BeginContext(2173, 880, true);
            WriteLiteral(@"</strong></h4>
            </td>
        </tr>
    </tfoot>
</table>

<hr/>

<h2>Payment</h2>

<div class=""d-block my-3"">
    <div class=""custom-control custom-radio"">
        <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" checked="""" required="""">
        <label class=""custom-control-label"" for=""credit"">Credit card</label>
    </div>
    <div class=""custom-control custom-radio"">
        <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required="""">
        <label class=""custom-control-label"" for=""debit"">Debit card</label>
    </div>
    <div class=""custom-control custom-radio"">
        <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required="""">
        <label class=""custom-control-label"" for=""paypal"">Paypal</label>
    </div>
</div>

<hr/>


");
            EndContext();
            BeginContext(3053, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "602fd103671731b0e791d3523211b9f1ab691c0411545", async() => {
                BeginContext(3073, 77, true);
                WriteLiteral("\r\n    <input type=\"submit\" class=\"btn btn-primary\" value=\"Confirm order\" />\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3157, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExampleWebshop.UI.Web.Pages.CheckoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExampleWebshop.UI.Web.Pages.CheckoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExampleWebshop.UI.Web.Pages.CheckoutModel>)PageContext?.ViewData;
        public ExampleWebshop.UI.Web.Pages.CheckoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
