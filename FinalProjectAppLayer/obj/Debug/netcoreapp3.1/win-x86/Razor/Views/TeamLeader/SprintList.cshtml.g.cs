#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b09ff5ff79f5c3d94daf481a0101143ed9a505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamLeader_SprintList), @"mvc.1.0.view", @"/Views/TeamLeader/SprintList.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b09ff5ff79f5c3d94daf481a0101143ed9a505", @"/Views/TeamLeader/SprintList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamLeader_SprintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sprint>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b09ff5ff79f5c3d94daf481a0101143ed9a5054299", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b09ff5ff79f5c3d94daf481a0101143ed9a5055538", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26b09ff5ff79f5c3d94daf481a0101143ed9a5056753", async() => {
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
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div id=\"Alert\"></div>\r\n<div id=\"Edit\"> </div>\r\n<div id=\"DeleteDiv\"> </div>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
   if (ViewBag.ProjectState != 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-9\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 961, "\"", 1023, 2);
            WriteAttributeValue("", 968, "/TeamLeader/CreatNewSprint?ProjectId=", 968, 37, true);
#nullable restore
#line 28 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 1005, ViewBag.ProjectId, 1005, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Create New Sprint</a>\r\n                </div>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                 if (ViewBag.ProjectSprintState == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3\">\r\n                        <button class=\"btn btn-warning\" data-toggle=\"modal\" data-target=\"#ModelDone\">Done</button>\r\n                    </div>\r\n");
#nullable restore
#line 36 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                }
                else if (ViewBag.ProjectSprintState == 0 || ViewBag.ProjectSprintState == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-3\">\r\n                        <button class=\"btn btn-warning\" disabled>Done</button>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n\r\n    <!-- [ horizontal-layout ] start -->\r\n    <div class=\"col-sm-12\">\r\n\r\n        <div class=\"card\">\r\n\r\n");
#nullable restore
#line 56 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
             if (ViewBag.ProjectState == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\" role=\"alert\">\r\n                    This Sprint Is Submited Succssesfulty..\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>

                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Start Date
                                </th>
                                <th>
                                    End Date
                                </th>
                                <th>
                                    State
                                </th>

                                <th>
                                    Action
                                </th>
                            </tr>
                        </thead>
                      ");
            WriteLiteral("  <tbody>\r\n");
#nullable restore
#line 90 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                              foreach (var item in (List<Sprint>)ViewBag.AllSprint)
                                {
                                    if (ViewBag.ProjectId == item.ProjectId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr");
            BeginWriteAttribute("id", " id=\"", 3383, "\"", 3402, 1);
#nullable restore
#line 94 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 3388, item.SprintId, 3388, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 96 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                           Write(item.SprintName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 99 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                           Write(item.sprintDescrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 102 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                           Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 105 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                           Write(item.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n\r\n");
#nullable restore
#line 108 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                               foreach (var State in (List<State>)ViewBag.States)
                                                                {
                                                                    if (item.StateId == State.StateId)
                                                                    {
                                                                        if (State.StateId == 1 || State.StateId == 2)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <td style=\"color:green\">\r\n                                                                                ");
#nullable restore
#line 115 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n");
#nullable restore
#line 117 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                        }
                                                                        else if (State.StateId == 3)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <td style=\"color:orange\">\r\n                                                                                ");
#nullable restore
#line 121 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n");
#nullable restore
#line 123 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                        }
                                                                        else
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                            <td style=\"color:red\">\r\n                                                                                ");
#nullable restore
#line 127 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                            </td>\r\n");
#nullable restore
#line 129 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"

                                                                        }
                                                                    }
                                                                }

                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                             if (ViewBag.ProjectState != 1)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    <button class=\"btn btn-danger btndelete\"");
            BeginWriteAttribute("value", " value=\"", 6763, "\"", 6785, 1);
#nullable restore
#line 138 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 6771, item.SprintId, 6771, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                                                                    <button class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6903, "\"", 6941, 3);
            WriteAttributeValue("", 6913, "EditSprint(\'", 6913, 12, true);
#nullable restore
#line 139 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 6925, item.SprintId, 6925, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6939, "\')", 6939, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7028, "\"", 7079, 2);
            WriteAttributeValue("", 7035, "/TeamLeader/DutyList?SprintId=", 7035, 30, true);
#nullable restore
#line 140 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 7065, item.SprintId, 7065, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Duties</a>\r\n                                                                </td>\r\n");
#nullable restore
#line 142 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <td>\r\n                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 7525, "\"", 7576, 2);
            WriteAttributeValue("", 7532, "/TeamLeader/DutyList?SprintId=", 7532, 30, true);
#nullable restore
#line 146 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
WriteAttributeValue("", 7562, item.SprintId, 7562, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Duties</a>\r\n                                                                </td>\r\n");
#nullable restore
#line 148 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </tr>\r\n");
#nullable restore
#line 150 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
                                    }
                                    else continue;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr id=""footerz""></tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
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
         ");
            WriteLiteral(@"       <a id=""DutyDone"" class=""btn btn-warning"" data-dismiss=""modal"">Yes</a>
            </div>
        </div>
    </div>
</div>
<div id=""RemoveMoadl"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalCenterTitle"">Remove</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                Are you sure you want to delete this sprint..?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn  btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn  btn-danger"" id=""removeSend"">Save changes</button>
  ");
            WriteLiteral(@"          </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {

        $("".btndelete"").click(function () {
            var x = $(this).val();
            debugger;
            $('#RemoveMoadl').modal(""show"");
            $(""#RemoveMoadl"").appendTo('#DeleteDiv');

            $('#removeSend').click(function () {
                $.ajax({
                    method: 'POST',
                    url: '/TeamLeader/DeleteSprint?SprintId=' + x,
                    success: function () {
                        debugger;
                        window.location.reload();
                    }
                })
            })
        })

    })


</script>
<script>
    $(""#DutyDone"").click(function () {
        var Pid =");
#nullable restore
#line 230 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
            Write(ViewBag.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        $.ajax({
            method: 'GET',
            url: '/TeamLeader/SprintDone',
            data: { ProjectId: Pid },
            success: function () {
                $(""#Alert"").append('<div class=""alert alert-warning"" role=""alert"" style=""color:black"">Sprint Submited Succssesfuly</div >')
            }
        })
    })
</script>
<script>
    EditSprint = function (sprintId) {
        var url = '/TeamLeader/SprintEdit?SprintId=' + sprintId;
        $('#Edit').load(url, function () {
            $('#EditModal').modal('show')
        })
    }
</script>
");
#nullable restore
#line 249 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
 if (TempData["success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            SuccsesMessage(\"Sprint\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 257 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 258 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
 if (TempData["Remove"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n\r\n        $(document).ready(function () {\r\n            RemoveFunction(\"Sprint\");\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 266 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 268 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
 if (TempData["Edit"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            EditMessage(\"Sprint\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 276 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(\'#Serachajax\').on(\'keyup\', function () {\r\n        var search = $(this).val();\r\n        var pid= ");
#nullable restore
#line 280 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\SprintList.cshtml"
            Write(ViewBag.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        $.ajax({
            method: 'GET',
            url: '/Sprint/SprintSearchByProjectId',
            data: {
                Search: search,
                ProjectId:pid
            },
            success: function (data) {
                $('tbody tr').each(function () {
                    $('#footerz').empty();
                    $(this).prop('hidden', true)
                })

                $.each(data, function (ind, vls) {
                    $('tbody tr').each(function () {
                        if (vls.sprintId == $(this).attr('id')) {
                            $('#' + $(this).attr('id') ).prop('hidden', false)
                        }
                    })
                })
                if (data.length == 0) {
                    debugger
                    $('#footerz').empty();
                    $('#footerz').append('<div style=""color:red"" role=""alert"">No result are found</div >')
                }

                if ($('#Serachajax').val() == 0)");
            WriteLiteral(" {\r\n                    $(\'#footerz\').empty();\r\n                    $(\'tbody tr\').each(function () {\r\n                        $(this).prop(\'hidden\', false)\r\n                    })\r\n\r\n                }\r\n            }\r\n\r\n        })\r\n\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sprint> Html { get; private set; }
    }
}
#pragma warning restore 1591
