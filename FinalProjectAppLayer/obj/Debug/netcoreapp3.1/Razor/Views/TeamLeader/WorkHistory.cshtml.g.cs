#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da375742a72144f57ec776b538f48d47a73c5828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamLeader_WorkHistory), @"mvc.1.0.view", @"/Views/TeamLeader/WorkHistory.cshtml")]
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
#nullable restore
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da375742a72144f57ec776b538f48d47a73c5828", @"/Views/TeamLeader/WorkHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamLeader_WorkHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllTeamLeaderProjects", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SprintList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""page-header"">
    <div class=""page-block"">
        <div class=""row align-items-center"">
            <div class=""col-md-12"">
                <div class=""page-header-title"">
                </div>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c58284306", async() => {
                WriteLiteral("<i class=\"feather icon-home\"></i>");
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
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c58285545", async() => {
                WriteLiteral("All Project");
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
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c58286760", async() => {
                WriteLiteral("Prject Sprints");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c58287978", async() => {
                WriteLiteral("Project Duties");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c58289196", async() => {
                WriteLiteral("All Work");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da375742a72144f57ec776b538f48d47a73c582810408", async() => {
                WriteLiteral("Work History");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <!-- [ sample-page ] start -->
    <div class=""col-sm-12 col-sm-12"">
        <div class=""card"">
            <div class=""card-body"">

                <div class=""table-responsive"">

                    <table class=""table"">
                            <tr class=""thead-light"">

                                <th>
                                    Name
                                </th>
                                <th>
                                    Update Date
                                </th>
                                <th>
                                    Note
                                </th>
                                <th>
                                    Attachment
                                </th>

                                <th>
                                    state
                                </th>

");
#nullable restore
#line 48 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                   foreach (var item in (List<WorkHistory>)ViewBag.WorkHistory)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 52 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                       Write(item.Work.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                       Write(item.UpdateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 57 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                          
                                            foreach (var R in (List<Reject>)ViewBag.RejectHistory)
                                            {
                                                if (item.Id == R.WorkHistoryId)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        ");
#nullable restore
#line 63 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                                   Write(R.RejectedNote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n");
#nullable restore
#line 65 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                                }
                                                else if (item.WorkId == R.WorkId)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>No Note</td>\r\n");
#nullable restore
#line 69 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                                }


                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                         if (((List<Reject>)ViewBag.RejectHistory).Count() == 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>No Note</td>\r\n");
#nullable restore
#line 76 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3619, "\"", 3699, 2);
            WriteAttributeValue("", 3626, "/TeamLeader/WorkAttachmentHistory?WorkAttachmentId=", 3626, 51, true);
#nullable restore
#line 80 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
WriteAttributeValue("", 3677, item.WorkAttachmentId, 3677, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 80 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                                                                                                                           Write(item.WorkAttachments.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </td>\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 87 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                         if (item.StateId == 1 || item.StateId == 2)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td style=\"color:green\">\r\n                                                Approved\r\n                                            </td>\r\n");
#nullable restore
#line 92 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                        }
                                        else if (item.StateId == 3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td style=\"color:orange\">\r\n                                                Pendeing\r\n                                            </td>\r\n");
#nullable restore
#line 98 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td style=\"color:red\">\r\n                                                Rejected\r\n                                            </td>\r\n");
#nullable restore
#line 104 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 108 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\WorkHistory.cshtml"
                                }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n");
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
