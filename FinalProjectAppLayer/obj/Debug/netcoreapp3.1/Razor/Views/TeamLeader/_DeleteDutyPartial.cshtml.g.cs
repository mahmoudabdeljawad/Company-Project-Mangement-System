#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\_DeleteDutyPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20883e98441a4c1907342d067f24b57ea7e5fff0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamLeader__DeleteDutyPartial), @"mvc.1.0.view", @"/Views/TeamLeader/_DeleteDutyPartial.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\_ViewImports.cshtml"
using FinalProjectAppLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\_ViewImports.cshtml"
using FinalProjectAppLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20883e98441a4c1907342d067f24b57ea7e5fff0", @"/Views/TeamLeader/_DeleteDutyPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamLeader__DeleteDutyPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div id=""ModalDelete"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLiveLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLiveLabel"">Delete Duty</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"" id=""ModalBodyDelete"">
                <p class=""mb-0"">Are you sure you to delete this duty...?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn  btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn  btn-danger"" id=""DeleteDuty""");
            BeginWriteAttribute("onclick", " onclick=\"", 882, "\"", 928, 3);
            WriteAttributeValue("", 892, "DeleteDutyConfirm(\'", 892, 19, true);
#nullable restore
#line 15 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\_DeleteDutyPartial.cshtml"
WriteAttributeValue("", 911, ViewBag.DutyId, 911, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 926, "\')", 926, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-dismiss=\"modal\">Save changes</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591