#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0aa7313b4659e906d73ee737774159411c2a78c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Work_AllWork), @"mvc.1.0.view", @"/Views/Work/AllWork.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0aa7313b4659e906d73ee737774159411c2a78c", @"/Views/Work/AllWork.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Work_AllWork : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusniessLayer.Entity.Work>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllTeamLeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                    <h5 class=""m-b-10"">Work </h5>
                </div>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aa7313b4659e906d73ee737774159411c2a78c4124", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0aa7313b4659e906d73ee737774159411c2a78c5363", async() => {
                WriteLiteral("All Work Created");
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
    <div class=""col-sm-12 col-lg-8"">
        <div class=""card"">
            <div class=""card-body"">


                <table class=""table"">
                    <thead>
                        <tr>
                         
                            <th>
name                            </th>
                            <th>
description                            </th>    
                            <th>
                                Team Member
                            </th>
                            <th>
                                Duty 
                            </th>
                            <th>
                                State
                            </th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody id=""AjaxAppend""></tbody>
         ");
            WriteLiteral("           <tbody id=\"AjaxHide\">\r\n");
#nullable restore
#line 49 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                              \r\n                                <td>\r\n                                    ");
#nullable restore
#line 54 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                               Write(Html.DisplayFor(modelItem => item.WorkName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 57 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                               Write(Html.DisplayFor(modelItem => item.WorkDescrption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 60 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Duty.TeamMember.FitstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 63 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Duty.DutyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 66 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                                     if (item.StateId == 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-success\">Approved</span>\r\n");
#nullable restore
#line 69 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                                    }
                                    else if (item.StateId == 3)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-warning\">Pending</span>\r\n");
#nullable restore
#line 73 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"

                                    }
                                    else if (item.StateId == 4)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"badge badge-danger\">Rejected</span>\r\n");
#nullable restore
#line 78 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            \r\n                            </tr>\r\n");
#nullable restore
#line 83 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Work\AllWork.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<script>
    $(""#Serachajax"").keyup(function () {
        var search = $(""#Serachajax"").val();
        $.ajax({
            method: 'POST',
            url: '/Work/WrokSearch',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: { Search: search },
            success: function (data) {
                $(""#AjaxHide"").hide();
                $(""#AjaxAppend"").empty();

                $.each(data, function (index, value) {
                    $(""#AjaxAppend"").append('<tr><td>' + value.workId + '</td><td>' + value.workName + '</td><td>' + value.workDescrption
                        + '</td><td>' + value.userName + '</td><td>' + value.dutiesName + '</td>'
                        + '<td><span id=""id' + value.workId +'"">' +''+ '</span></td>'
                        +
                        '</tr>');
                    if (value.stateId == 2) ");
            WriteLiteral(@"{
                      
                        $(""#id"" + value.workId).addClass(""badge badge-success"");
                        $(""#id"" + value.workId).append(""Approve"");
                    } else if (value.stateId == 3){
                        $(""#id"" + value.workId).addClass(""badge badge-warning"");
                        $(""#id"" + value.workId).append(""Pending"");

                    } else if (value.stateId == 4){
                        $(""#id"" + value.workId).addClass(""badge badge-danger"");
                        $(""#id"" + value.workId).append(""Reject"")

                    }
                })
             
                if ($(""#Serachajax"").val() == 0) {
                    $(""#AjaxAppend"").empty();
                    $(""#AjaxHide"").show();
                }
              
            },
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusniessLayer.Entity.Work>> Html { get; private set; }
    }
}
#pragma warning restore 1591
