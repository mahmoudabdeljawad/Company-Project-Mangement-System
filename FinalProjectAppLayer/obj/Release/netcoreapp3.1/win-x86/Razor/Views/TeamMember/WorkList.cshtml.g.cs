#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918a48e2d0b7fc4118a6cef321eb77745015bff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TeamMember_WorkList), @"mvc.1.0.view", @"/Views/TeamMember/WorkList.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918a48e2d0b7fc4118a6cef321eb77745015bff3", @"/Views/TeamMember/WorkList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_TeamMember_WorkList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918a48e2d0b7fc4118a6cef321eb77745015bff34288", async() => {
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
            WriteLiteral("</li>\r\n\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918a48e2d0b7fc4118a6cef321eb77745015bff35531", async() => {
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
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-9\">\r\n");
#nullable restore
#line 19 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
          

            if (ViewBag.Dutystate.StateId == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\" role=\"alert\">\r\n                    The Work Of this Duty Is submit Successfully And The Duties State Is Completed..!\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 1016, 2);
            WriteAttributeValue("", 974, "/TeamMember/NewWork?DutyId=", 974, 27, true);
#nullable restore
#line 29 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 1001, ViewBag.DutyId, 1001, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">New Work</a>\r\n");
#nullable restore
#line 30 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 33 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
      
        if (ViewBag.Dutystate.StateId == 1)
        {
        }
        //var Count = ((List<Work>)ViewBag.WorkList).Count();
        else if (((List<Work>)ViewBag.WorkList).Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2 \">\r\n                <button disabled class=\"btn btn-warning\">Done</button>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
        }
        else if (ViewBag.WorkCount == ((List<Work>)ViewBag.WorkList).Count())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1581, "\"", 1631, 2);
            WriteAttributeValue("", 1588, "/TeamMember/WorkDone?DutyId=", 1588, 28, true);
#nullable restore
#line 47 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 1616, ViewBag.DutyId, 1616, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled class=\"btn btn-warning\" id=\"Jdone\">Done</a>\r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2\">\r\n                <button href=\"#\" class=\"btn btn-warning\" disabled>Done</button>\r\n            </div>\r\n");
#nullable restore
#line 55 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div id=""DivToShow""></div>
<div class=""row"">
    <!-- [ sample-page ] start -->
    <div class=""col-sm-12 col-sm-12"">
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
                                    Description
                                </th>
                                <th>
                                    State
                                </th>
                                <th>
                                    Action
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 86 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                               foreach (var item in (List<Work>)ViewBag.WorkList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr");
            BeginWriteAttribute("id", " id=\"", 2999, "\"", 3016, 1);
#nullable restore
#line 88 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 3004, item.WorkId, 3004, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 90 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                       Write(item.WorkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 93 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                       Write(item.WorkDescrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 95 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                          foreach (var State in (List<State>)ViewBag.State)
                                            {
                                                if (item.StateId == State.StateId)
                                                {
                                                    if (State.StateId == 1 || State.StateId == 2)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"color:green\">\r\n                                                            ");
#nullable restore
#line 102 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                       Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n");
#nullable restore
#line 104 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                    }
                                                    else if (State.StateId == 3)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"color:orange\">\r\n                                                            ");
#nullable restore
#line 108 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                       Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n");
#nullable restore
#line 110 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"color:red\">\r\n                                                            ");
#nullable restore
#line 114 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                       Write(State.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n");
#nullable restore
#line 116 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                                    }
                                                }
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n");
#nullable restore
#line 121 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                             if (@ViewBag.Dutystate.StateId == 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 5216, "\"", 5250, 3);
            WriteAttributeValue("", 5226, "WorkView(\'", 5226, 10, true);
#nullable restore
#line 123 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 5236, item.WorkId, 5236, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5248, "\')", 5248, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">View</button>\r\n");
#nullable restore
#line 124 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                            }
                                            else if (item.StateId == 4 || item.StateId == 3)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 5539, "\"", 5573, 3);
            WriteAttributeValue("", 5549, "EditWork(\'", 5549, 10, true);
#nullable restore
#line 127 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 5559, item.WorkId, 5559, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5571, "\')", 5571, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Edit</button>\r\n                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 5669, "\"", 5703, 3);
            WriteAttributeValue("", 5679, "WorkView(\'", 5679, 10, true);
#nullable restore
#line 128 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 5689, item.WorkId, 5689, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5701, "\')", 5701, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">View</button>\r\n");
#nullable restore
#line 129 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                            }

                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 5950, "\"", 5984, 3);
            WriteAttributeValue("", 5960, "WorkView(\'", 5960, 10, true);
#nullable restore
#line 133 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
WriteAttributeValue("", 5970, item.WorkId, 5970, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5982, "\')", 5982, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">View</button>\r\n");
#nullable restore
#line 134 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 137 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                        <tfoot></tfoot>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 147 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
 if (TempData["insert"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            SuccsesMessage(\"Work\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 155 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"
 if (TempData["update"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n\r\n        $(document).ready(function () {\r\n            EditMessage(\"Work\");\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 164 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\TeamMember\WorkList.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $.urlParam = function (name) {
            var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(window.location.href);
            if (results == null) {
                return null;
            }
            return decodeURI(results[1]) || 0;
        }

        $(""#Serachajax"").on('keyup', function () {

            var search = $(this).val();
            var duty = $.urlParam('DutyId');
            $.ajax({
                method: 'POST',
                url: '/Work/SearchForDutyWork',
                data: { Search: search, DutyId: duty },
                success: function (data) {
                    $(""#footer"").remove();
                    $('tbody tr').each(function () {
                        $(this).prop('hidden', true)
                    });
                    if (data.length == 0) {
                        debugger;
                        $(""#footer"").remove();
                        $('tfoot').append('<tr");
            WriteLiteral(@" id=""footer""><td><div style=""color:red""> No result found </div></td></td>')
                    }

                    $.each(data, function (ind, vls) {
                        $('tbody tr').each(function () {
                            $(""#footer"").remove();
                            var x = $(this).attr('id');
                            if (x == vls.workId) {
                                $(""#"" + x).prop('hidden', false)
                            }
                        })
                    })
                    if ($(""#Serachajax"").val() == 0) {
                        $(""tfoot"").empty();
                        $('tbody tr').each(function () {
                            $(this).prop('hidden', false);

                        });
                    }

                }

            })
        })
    })
</script>
<script>
    WorkView = function (workId) {
        var url = '/TeamMember/ViewWork?WorkId=' + workId
        $('#DivToShow').load(url, function () {
 ");
            WriteLiteral(@"           $('#EditModal').modal('show');
        })
    }
</script>
<script>
    EditWork = function (workId) {
        var url = '/TeamMember/WrokEditpartial?WorkId=' + workId
        $('#DivToShow').load(url, function () {
            $('#EditModal').modal('show');
        })
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
