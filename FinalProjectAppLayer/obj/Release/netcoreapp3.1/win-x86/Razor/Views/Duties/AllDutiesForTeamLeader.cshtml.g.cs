#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f539be1e4430e10564cfa29550bc61315803059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Duties_AllDutiesForTeamLeader), @"mvc.1.0.view", @"/Views/Duties/AllDutiesForTeamLeader.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f539be1e4430e10564cfa29550bc61315803059", @"/Views/Duties/AllDutiesForTeamLeader.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Duties_AllDutiesForTeamLeader : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusniessLayer.Entity.Duty>>
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
            WriteLiteral(@"
<div class=""page-header"">
    <div class=""page-block"">
        <div class=""row align-items-center"">
            <div class=""col-md-12"">
                <div class=""page-header-title"">
                </div>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f539be1e4430e10564cfa29550bc613158030594167", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f539be1e4430e10564cfa29550bc613158030595406", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f539be1e4430e10564cfa29550bc613158030596621", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f539be1e4430e10564cfa29550bc613158030597839", async() => {
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
            WriteLiteral(@"</li>
                </ul>
            </div>
        </div>
    </div>
</div>
<div id=""Alert""></div>


<div id=""PlaceHolderHere""></div>
<!-- Modal -->

<div class=""row"">
    <!-- [ horizontal-layout ] start -->
    <div class=""col-sm-12"">
        <div class=""card"">

            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Descrption
                                </th>
                                <th>
                                    Member
                                </th>
                                <th>
                                    State
                                </th>
                                <th>
                    ");
            WriteLiteral("                Action\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                              foreach (var item in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("id", " id=\"", 2062, "\"", 2083, 2);
            WriteAttributeValue("", 2067, "row_", 2067, 4, true);
#nullable restore
#line 56 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 2071, item.DutyId, 2071, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2084, "\"", 2104, 1);
#nullable restore
#line 56 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 2092, item.DutyId, 2092, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 58 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                           Write(item.DutyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 61 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                           Write(item.DutyDescrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                       <td>");
#nullable restore
#line 63 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                      Write(item.TeamMember.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td>\r\n");
#nullable restore
#line 66 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                                 if (item.Sprint.StateId == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-success\">Completed</span>\r\n");
#nullable restore
#line 69 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                                }
                                                else if (item.Sprint.StateId == 3)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"badge badge-warning\">Pending</span>\r\n");
#nullable restore
#line 73 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n");
#nullable restore
#line 76 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                             if (item.Sprint.StateId != 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>\r\n                                                    <button class=\"btn-danger btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3457, "\"", 3493, 3);
            WriteAttributeValue("", 3467, "DeleteDuty(\'", 3467, 12, true);
#nullable restore
#line 79 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 3479, item.DutyId, 3479, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3491, "\')", 3491, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        Delete\r\n                                                    </button>\r\n\r\n                                                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3699, "\"", 3752, 6);
            WriteAttributeValue("", 3709, "EditModal(\'", 3709, 11, true);
#nullable restore
#line 83 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 3720, item.DutyId, 3720, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3732, "\',", 3732, 2, true);
            WriteAttributeValue(" ", 3734, "\'", 3735, 2, true);
#nullable restore
#line 83 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 3736, item.SprintId, 3736, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3750, "\')", 3750, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success ViewToShow\">\r\n                                                        Edit\r\n                                                    </button>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3970, "\"", 4017, 2);
            WriteAttributeValue("", 3977, "/Teamleader/WorkView?DutyId=", 3977, 28, true);
#nullable restore
#line 86 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
WriteAttributeValue("", 4005, item.DutyId, 4005, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Work</a>\r\n                                                </td>\r\n");
#nullable restore
#line 88 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td>Done</td>\r\n");
#nullable restore
#line 92 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            \r\n                                        </tr>\r\n");
#nullable restore
#line 95 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"

                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                        <tfoot>
                            <tr id=""footerz""></tr>
                        </tfoot>
                    </table>

                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        EditModal = function (Did, Sid) {
            var ul = '/TeamLeader/EditDuty?DutyId=' + Did + '&&SprintId=' + Sid + '';

            $(""#PlaceHolderHere"").load(ul, function () {
                $(""#ModalToShow"").modal(""show"");
            })
        }
    })
</script>
<script>
    function DeleteDuty(Did) {
        var ul = '/TeamLeader/PartialDeleteDuty?DutyId=' + Did;
        $(""#PlaceHolderHere"").load(ul, function () {
            $(""#ModalDelete"").modal(""show"");

        })
    }
</script>
<script>
    function DeleteDutyConfirm(Did) {
        $.ajax({
            method: 'POST',
            url: '/TeamLeader/DeleteDuty',
            data: { DutyId: Did },
       ");
            WriteLiteral(@"     success: function () {
                debugger;
                $(""#row_"" + Did).remove();

            }

        })

    }
</script>

<div class=""modal fade"" id=""ModelDone"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-notify modal-info"" role=""document"">
        Content
        <div class=""modal-content text-center"">

            <div class=""modal-header d-flex justify-content-center"">
                <p class=""heading"">Be always up to date</p>
            </div>

            <div class=""modal-body"">
                <i class=""fas fa-bell fa-4x animated rotateIn mb-4""></i>
                <p>Are you sure to submite all duties?</p>
            </div>

            <div class=""modal-footer flex-center"">
                <a class=""btn btn-outline-warning"" data-dismiss=""modal"">close</a>
                <a id=""DutyDone"" class=""btn btn-warning"" data-dismiss=""modal"">Yes</a>
            </div>
        </di");
            WriteLiteral("v>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(\"#DutyDone\").click(function () {\r\n        var Sprint =");
#nullable restore
#line 171 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Duties\AllDutiesForTeamLeader.cshtml"
               Write(ViewBag.SprintId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        $.ajax({
            method: 'GET',
            url: '/TeamLeader/DutyDone',
             data: { SprintId:Sprint },
            success: function () {
                $(""#Alert"").append('<div class=""alert alert-success"" role=""alert"">Duties Submited Succssesfuly</div >')
            }
        })
    })
</script>

<script>
    $('#Serachajax').on('keyup', function () {
        var url_string = window.location;
        var url = new URL(url_string);
        var Sid = url.searchParams.get(""SprintId"");


        var search = $(this).val();
        $.ajax({
            method: 'GET',
            url: '/Duties/SearchDutiesBySprintId',
            data: {
                Search: search,
                SprintId: Sid
            },
            success: function (data) {

                $('tbody tr').each(function () {
                    $('#footerz').empty();
                    $(this).prop('hidden', true)
                })

                $.each(data, function (ind, v");
            WriteLiteral(@"ls) {
                    $('tbody tr').each(function () {
                        if ('row_' + vls.dutyId == $(this).attr('id')) {
                            debugger
                            var x = $(this).attr('id');
                            $('#' + x).prop('hidden', false)
                        }
                    })
                })
                if (data.length == 0) {

                    $('#footerz').empty();
                    $('#footerz').append('<div style=""color:red"" role=""alert"">No result are found</div >')
                }

                if ($('#Serachajax').val() == 0) {
                    $('#footerz').empty();
                    $('tbody tr').each(function () {
                        $(this).prop('hidden', false)
                    })

                }
            }

        })

    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusniessLayer.Entity.Duty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
