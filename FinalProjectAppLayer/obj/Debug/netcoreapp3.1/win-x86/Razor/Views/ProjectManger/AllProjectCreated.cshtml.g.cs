#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414e3dc4e465938878277ecb4ff00e86126ef713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectManger_AllProjectCreated), @"mvc.1.0.view", @"/Views/ProjectManger/AllProjectCreated.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414e3dc4e465938878277ecb4ff00e86126ef713", @"/Views/ProjectManger/AllProjectCreated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectManger_AllProjectCreated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllProjectCreated", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertNewProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "x.Id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
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
                    <li class=""breadcrumb-item""><a href=""index.html""><i class=""feather icon-home""></i></a></li>
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e3dc4e465938878277ecb4ff00e86126ef7135560", async() => {
                WriteLiteral("Home");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e3dc4e465938878277ecb4ff00e86126ef7136768", async() => {
                WriteLiteral("AllProject");
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
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e3dc4e465938878277ecb4ff00e86126ef7138032", async() => {
                WriteLiteral("Create New Project");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<div class=""row"">
    <!-- [ horizontal-layout ] start -->
    <div class=""col-sm-12"">
        <div class=""card"">
            <div id=""Edit""></div>
            <div class=""table-responsive"">
                <div class=""card-body"">

                    <table class=""table "">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Description
                                </th>
                                <th>
                                    Deadline
                                </th>
                                <th>
                                    Project Members
                                </th>
                                <th>
                                    State
                                </th>
                                <th>
         ");
            WriteLiteral("                           Action\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                             foreach (var item in (List<ProjectMembers>)ViewBag.AllProject)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("id", " id=\"", 2167, "\"", 2187, 1);
#nullable restore
#line 57 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
WriteAttributeValue("", 2172, item.ProjectId, 2172, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 59 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                   Write(item.Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 62 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                   Write(item.Project.ProjectDescrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                   Write(item.Project.DeadLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <select class=\"js-example-basic-multiple form-control\">\r\n\r\n");
#nullable restore
#line 70 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                               foreach (var x in ViewBag.ProjectMemberLeader)
                                                {
                                                    if (item.Project.ProjectId == x.ProjectId)
                                                    {
                                                        if (x.RoleName == "Teamleader")
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e3dc4e465938878277ecb4ff00e86126ef71313490", async() => {
                WriteLiteral("TeamLeader ");
#nullable restore
#line 76 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                                                                       Write(x.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 77 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                                        }
                                                        else if (x.RoleName == "ProjectManger") { continue; }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414e3dc4e465938878277ecb4ff00e86126ef71315520", async() => {
#nullable restore
#line 81 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                                                            Write(x.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                                        }
                                                    }
                                                }

                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </select>\r\n                                    </td>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                     if (item.Project.StateId == 1)
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-success\">Completed</span>\r\n                                        </td>\r\n");
#nullable restore
#line 96 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                    }
                                    else if (item.Project.StateId == 3)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <span class=\"badge badge-warning\">Pending</span>\r\n                                        </td>\r\n");
#nullable restore
#line 102 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <td>\r\n                                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4835, "\"", 4875, 3);
            WriteAttributeValue("", 4845, "EditProject(\'", 4845, 13, true);
#nullable restore
#line 105 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
WriteAttributeValue("", 4858, item.ProjectId, 4858, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4873, "\')", 4873, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-success\">Edit</button>\r\n\r\n                                        <button data-toggle=\"modal\" data-target=\"#exampleModalLive\" type=\"button\" class=\"btn  btn-danger Deleted\"");
            BeginWriteAttribute("onclick", "\r\n                                                onclick=\"", 5064, "\"", 5184, 6);
            WriteAttributeValue("", 5123, "ReomvePorject(\'", 5123, 15, true);
#nullable restore
#line 108 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
WriteAttributeValue("", 5138, item.ProjectId, 5138, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5153, "\',", 5153, 2, true);
            WriteAttributeValue(" ", 5155, "\'", 5156, 2, true);
#nullable restore
#line 108 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
WriteAttributeValue("", 5157, item.Project.ProjectName, 5157, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5182, "\')", 5182, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            Delete\r\n                                        </button>\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 114 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                        <tfoot>
                            <tr id=""footerz"">
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 126 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
 if (TempData["success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            SuccsesMessage(\"Project\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 134 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
 if (TempData["Remove"] !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n      \r\n        $(document).ready(function () {\r\n            RemoveFunction(\"Project\");\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 143 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
 if (TempData["Edit"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n            EditMessage(\"Project\")\r\n\r\n        })\r\n    </script>\r\n");
#nullable restore
#line 153 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""exampleModalLive"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLiveLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLiveLabel"">Remove Project</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                <p class=""mb-0"">Are you sure you want to delete this project..!</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn  btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn  btn-danger"" id=""ProjectId"">Save changes</button>
            </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {

        ReomvePorject = ");
            WriteLiteral(@"function (ProjectId,PName) {

            $(""#ProjectId"").click(function () {
             
                $.ajax({
                    method: 'POST',
                    url: '/ProjectManger/DeleteProject',
                    data: { Id: ProjectId, ProjectName: PName }
                    , success: function () {

                        window.location.href = '");
#nullable restore
#line 184 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\ProjectManger\AllProjectCreated.cshtml"
                                           Write(Url.Action("AllProjectCreated","ProjectManger"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                    }
                })
            })
        }
  });
</script>
<script>
    EditProject = function (id) {
        var ul = '/ProjectManger/ProjectEdit?ProjectId=' + id;
        $('#Edit').load(ul, function () {
            $('#EditModal').modal('show');
        })
    }
</script>

<script>
    $('#Serachajax').on('keyup', function () {
        var search = $(this).val();
        $.ajax({
            method: 'GET',
            url: '/ProjectManger/SearchProject',
            data: { Search: search },
            success: function (data) {
                $('tbody tr').each(function () {
                    $('#footerz').empty();
                    $(this).prop('hidden', true)
                })

                $.each(data, function (ind, vls) {
                    $('tbody tr').each(function () {
                        if (vls.projectId == $(this).attr('id')) {
                            $('#' + vls.projectId).prop('hidden', false)
                     ");
            WriteLiteral(@"   }
                    })
                })
                if (data.length == 0) {
                    debugger
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Member> Html { get; private set; }
    }
}
#pragma warning restore 1591