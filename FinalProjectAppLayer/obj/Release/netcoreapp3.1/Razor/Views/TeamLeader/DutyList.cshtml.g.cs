#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "405ae93698a9e319362863c91942439893b399e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamLeader_DutyList), @"mvc.1.0.view", @"/Views/TeamLeader/DutyList.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405ae93698a9e319362863c91942439893b399e6", @"/Views/TeamLeader/DutyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamLeader_DutyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Duty>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405ae93698a9e319362863c91942439893b399e64285", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405ae93698a9e319362863c91942439893b399e65524", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405ae93698a9e319362863c91942439893b399e66739", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "405ae93698a9e319362863c91942439893b399e67957", async() => {
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
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div id=\"Alert\"></div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
           if (ViewBag.SprintState != 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-9 \">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1002, "\"", 1060, 2);
            WriteAttributeValue("", 1009, "/TeamLeader/CreatNewDuty?SprintId=", 1009, 34, true);
#nullable restore
#line 25 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 1043, ViewBag.SprintId, 1043, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\"> Create New Duty</a>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                if (((List<Duty>)ViewBag.Duties).Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-2\" id=\"a\">\r\n                        <button id=\"State\" class=\"btn btn-warning\" disabled>Done</button>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                }
                else if (ViewBag.Count == ((List<Duty>)ViewBag.Duties).Count())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-2\" id=\"a\">\r\n                        <button data-toggle=\"modal\" data-target=\"#ModelDone\" id=\"State\" class=\"btn btn-warning\">Done</button>\r\n                    </div>\r\n");
#nullable restore
#line 38 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-2\" id=\"a\">\r\n                        <button id=\"State\" class=\"btn btn-warning\" disabled>Done</button>\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                }
            }
            else
            {

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
#nullable restore
#line 53 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
  
    if (ViewBag.SprintState == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            This Duties is Completed\r\n        </div>\r\n");
#nullable restore
#line 59 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
                                    Action
                                </th>
                            </tr>
              ");
            WriteLiteral("          </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 93 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                              foreach (var item in (List<Duty>)ViewBag.Duties)
                                {
                                    if (item.SprintId == ViewBag.SprintId)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("id", " id=\"", 3559, "\"", 3580, 2);
            WriteAttributeValue("", 3564, "row_", 3564, 4, true);
#nullable restore
#line 97 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 3568, item.DutyId, 3568, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3581, "\"", 3601, 1);
#nullable restore
#line 97 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 3589, item.DutyId, 3589, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 99 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                           Write(item.DutyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 102 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                           Write(item.DutyDescrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n");
#nullable restore
#line 105 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                 foreach (var M in ViewBag.Member)
                                                {

                                                    if (item.TeamMemberId == M.Id)
                                                    {

                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                   Write(M.UserName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                                   

                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n\r\n");
#nullable restore
#line 117 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                              foreach (var State in (List<State>)ViewBag.States)
                                                {
                                                    if (item.StateId == State.StateId)
                                                    {
                                                        if (State.StateId == 1 || State.StateId == 2)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"color:green\">\r\n                                                                ");
#nullable restore
#line 124 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n");
#nullable restore
#line 126 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                        }
                                                        else if (State.StateId == 3)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"color:orange\">\r\n                                                                ");
#nullable restore
#line 130 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n");
#nullable restore
#line 132 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td style=\"color:red\">\r\n                                                                ");
#nullable restore
#line 136 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                           Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n");
#nullable restore
#line 138 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                        }
                                                    }
                                                }
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                              
                                                if (ViewBag.SprintState != 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        <button class=\"btn-danger btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6575, "\"", 6611, 3);
            WriteAttributeValue("", 6585, "DeleteDuty(\'", 6585, 12, true);
#nullable restore
#line 146 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 6597, item.DutyId, 6597, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6609, "\')", 6609, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            Delete\r\n                                                        </button>\r\n\r\n                                                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6829, "\"", 6882, 6);
            WriteAttributeValue("", 6839, "EditModal(\'", 6839, 11, true);
#nullable restore
#line 150 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 6850, item.DutyId, 6850, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6862, "\',", 6862, 2, true);
            WriteAttributeValue(" ", 6864, "\'", 6865, 2, true);
#nullable restore
#line 150 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 6866, item.SprintId, 6866, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6880, "\')", 6880, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success ViewToShow\">\r\n                                                            Edit\r\n                                                        </button>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7112, "\"", 7159, 2);
            WriteAttributeValue("", 7119, "/Teamleader/WorkView?DutyId=", 7119, 28, true);
#nullable restore
#line 153 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 7147, item.DutyId, 7147, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Work</a>\r\n                                                    </td>\r\n");
#nullable restore
#line 155 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7507, "\"", 7554, 2);
            WriteAttributeValue("", 7514, "/Teamleader/WorkView?DutyId=", 7514, 28, true);
#nullable restore
#line 159 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
WriteAttributeValue("", 7542, item.DutyId, 7542, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Work</a>\r\n                                        </td>\r\n");
#nullable restore
#line 161 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tr>\r\n");
#nullable restore
#line 164 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                    }
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
        var url_search = window.location
        var url =new URL(url_search)
        let Sid = url.searchParams.get('SprintId')
      ");
            WriteLiteral(@"  debugger;
        $.ajax({
            method: 'POST',
            url: '/TeamLeader/DeleteDuty',
            data: { DutyId: Did },
            success: function () {
                debugger;
                window.location.href = '/TeamLeader/DutyList?SprintId=' + Sid
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
                <a cla");
            WriteLiteral(@"ss=""btn btn-outline-warning"" data-dismiss=""modal"">close</a>
                <a id=""DutyDone"" class=""btn btn-warning"" data-dismiss=""modal"">Yes</a>
            </div>
        </div>
    </div>
</div>
<script>
    $(""#DutyDone"").click(function () {
        var Sprint =");
#nullable restore
#line 242 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
               Write(ViewBag.SprintId);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        $.ajax({\r\n            method: \'GET\',\r\n            url: \'/TeamLeader/DutyDone\',\r\n             data: { SprintId:Sprint },\r\n            success: function () {\r\n                window.location.href = \'");
#nullable restore
#line 248 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
                                   Write(Url.Action("DutyList","TeamLeader",new {SprintId= @ViewBag.SprintId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
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

                $.each(data, function (ind, vls) {
                    $('tbody tr').each(function () {
                        if ('row_' + vls.dutyId == $(this).attr('id')) {
                            debugger
                            var x = $(this).attr('id');
                            $('#' + x).prop('hidden', fals");
            WriteLiteral(@"e)
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
</script>

");
#nullable restore
#line 304 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
 if (TempData["success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            SuccsesMessage(\"Duty\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 312 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
    TempData["success"] = null;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 314 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
 if (TempData["Remove"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n\r\n        $(document).ready(function () {\r\n            RemoveFunction(\"Duty\");\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 322 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 324 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
 if (TempData["Edit"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            EditMessage(\"Duty\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 332 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamLeader\DutyList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Duty> Html { get; private set; }
    }
}
#pragma warning restore 1591
