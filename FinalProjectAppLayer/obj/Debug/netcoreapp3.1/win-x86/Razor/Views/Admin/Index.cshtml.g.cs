#pragma checksum "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbdda8fd347e89830872a97d5b74624d47c100ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
using BusniessLayer.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
using BusniessLayer.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbdda8fd347e89830872a97d5b74624d47c100ac", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f19c9938f9566f77b1b2dd31ba359b858e9d0b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- [ Header ] end -->
<!-- [ Main Content ] start -->
<div class=""page-header"">
    <div class=""page-block"">
        <div class=""row align-items-center"">
            <div class=""col-md-12"">
                <div class=""page-header-title"">
                    <h5 class=""m-b-10"">Dashboard </h5>
                </div>
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html""><i class=""feather icon-home""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- [ breadcrumb ] end -->
<!-- [ Main Content ] start -->
<div class=""row"">
    <div class=""col-lg-7 col-md-12"">
        <!-- support-section start -->
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""card support-bar overflow-hidden"">
                    <div class=""card-body pb-0"">
                        <h2 class=""m-0"">");
#nullable restore
#line 28 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                   Write(ViewBag.AllMember);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span class=""text-c-blue""> Member</span>
                        <p class=""mb-3 mt-3"">Total number of Member of the system.</p>
                    </div>

                    <div class=""card-footer text-white"" style=""background-color:cadetblue;"">
                        <div class=""row text-center"">
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                        </div>
                    </div>
                </div>
            ");
            WriteLiteral("</div><div class=\"col-sm-6\">\r\n                <div class=\"card support-bar overflow-hidden\">\r\n                    <div class=\"card-body pb-0\">\r\n                        <h2 class=\"m-0\">");
#nullable restore
#line 53 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                   Write(ViewBag.AllProjectManger);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                        <span class=""text-c-blue"">Project Manger</span>
                        <p class=""mb-3 mt-3"">Total number of Project Manger.</p>
                    </div>

                    <div class=""card-footer text-white"" style=""background-color:dodgerblue;"">
                        <div class=""row text-center"">
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                        </div>
                    </div>
                </div>
         ");
            WriteLiteral("   </div>\r\n            <div class=\"col-sm-6\">\r\n                <div class=\"card support-bar overflow-hidden\">\r\n                    <div class=\"card-body pb-0\">\r\n                        <h2 class=\"m-0\">");
#nullable restore
#line 79 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                   Write(ViewBag.AllTeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span class=""text-c-green"">Team Leader</span>
                        <p class=""mb-3 mt-3"">Total number of Team Leader.</p>
                    </div>
                    <div class=""card-footer bg-success text-white"">
                        <div class=""row text-center"">
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div> <div class=""col-sm-6"">
");
            WriteLiteral("                <div class=\"card support-bar overflow-hidden\">\r\n                    <div class=\"card-body pb-0\">\r\n                        <h2 class=\"m-0\">");
#nullable restore
#line 103 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                   Write(ViewBag.AllTeamMember);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <span class=""text-c-green"">Team Member</span>
                        <p class=""mb-3 mt-3"">Total number of Team Member.</p>
                    </div>
                    <div class=""card-footer bg-c-yellow text-white"">
                        <div class=""row text-center"">
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                            <div class=""col"">
                                <h4 class=""m-0 text-white""></h4>
                                <span></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    ");
            WriteLiteral(@"    <!-- support-section end -->
    </div>
    <div class=""col-lg-5 col-md-12"">
        <!-- page statustic card start -->
        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row align-items-center"">
                            <div class=""col-8"">
                                <h4 class=""text-c-blue"">");
#nullable restore
#line 137 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(ViewBag.AllWork);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                                <h6 class=""text-muted m-b-0"">Total Work</h6>
                            </div>
                            <div class=""col-4 text-right"">
                                <i class=""feather icon-calendar f-28""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer bg-c-blue"">
                        <div class=""row align-items-center"">
                            <div class=""col-9"">
                                <p class=""text-white m-b-0""></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row align-items-center"">
                            <div class=""col-8"">
                                <h4 class=""text-c-yellow"">");
#nullable restore
#line 159 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                     Write(ViewBag.AllWorkPending);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                                <h6 class=""text-muted m-b-0"">Pending Work</h6>
                            </div>
                            <div class=""col-4 text-right"">
                                <i class=""feather icon-bar-chart-2 f-28""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer bg-c-yellow"">
                        <div class=""row align-items-center"">
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row align-items-center"">
                            <div class=""col-8"">
                                <h4 class=""text-c-green"">");
#nullable restore
#line 178 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                    Write(ViewBag.AllWorkApprove);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                                <h6 class=""text-muted m-b-0"">Approve Work</h6>
                            </div>
                            <div class=""col-4 text-right"">
                                <i class=""feather icon-file-text f-28""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer bg-c-green"">
                        <div class=""row align-items-center"">
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row align-items-center"">
                            <div class=""col-8"">
                                <h4 class=""text-c-red"">");
#nullable restore
#line 197 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                  Write(ViewBag.AllWorkReject);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                                <h6 class=""text-muted m-b-0"">Rejected</h6>
                            </div>
                            <div class=""col-4 text-right"">
                                <i class=""feather icon-thumbs-down f-28""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer bg-c-red"">
                        <div class=""row align-items-center"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- page statustic card end -->
    </div>

    <div class=""col-xl-3 col-md-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        <h3>");
#nullable restore
#line 220 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                       Write(ViewBag.AllProject);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h6 class=""text-muted m-b-0"">Total Project</h6>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        <h3>");
#nullable restore
#line 232 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                       Write(ViewBag.AllSprint);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h6 class=""text-muted m-b-0"">Total Sprint</h6>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        <h3>");
#nullable restore
#line 244 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                       Write(ViewBag.AllDuties);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h6 class=""text-muted m-b-0"">Total Duties</h6>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row align-items-center"">
                    <div class=""col-6"">
                        <h3>");
#nullable restore
#line 256 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                       Write(ViewBag.AllWorkAttachment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <h6 class=""text-muted m-b-0"">Work Attachment</h6>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-7 col-md-12 "">
        <div class=""card table-card"">
            <div class=""card-header"">
                <h5>Projects</h5>
                <div class=""card-header-right"">
                    <div class=""btn-group card-option"">
                        <button type=""button"" class=""btn dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""feather icon-more-horizontal""></i>
                        </button>
                        <ul class=""list-unstyled card-option dropdown-menu dropdown-menu-right"">
                            <li class=""dropdown-item full-card""><a href=""#!""><span><i class=""feather icon-maximize""></i> maximize</span><span style=""display:none""><i class=""feather icon-minimize""></i> Restore</span></a></li>
         ");
            WriteLiteral(@"                   <li class=""dropdown-item minimize-card""><a href=""#!""><span><i class=""feather icon-minus""></i> collapse</span><span style=""display:none""><i class=""feather icon-plus""></i> expand</span></a></li>
                            <li class=""dropdown-item reload-card""><a href=""#!""><i class=""feather icon-refresh-cw""></i> reload</a></li>
                            <li class=""dropdown-item close-card""><a href=""#!""><i class=""feather icon-trash""></i> remove</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""card-body p-0"" style="" height: 388px; overflow-y: scroll"">
                <div class=""table-responsive"">
                    <table class=""table table-hover mb-0"">
                        <thead>
                            <tr>
                                <th>
                                    Manger
                                </th>
                                <th>Project Name</th>
       ");
            WriteLiteral("                         <th>Dead Line</th>\r\n                                <th>State</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 295 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                              

                                foreach (var item in (List<ProjectMangerStateDto>)ViewBag.ProjectMangerState)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n");
            WriteLiteral("                                            <div class=\"d-inline-block align-middle\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 14355, "\"", 14376, 2);
            WriteAttributeValue("", 14361, "/", 14361, 1, true);
#nullable restore
#line 308 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
WriteAttributeValue("", 14362, item.ImageUrl, 14362, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"user image\" class=\"img-radius wid-40 align-top m-r-15\">\r\n                                                <div class=\"d-inline-block\">\r\n                                                    <h6>");
#nullable restore
#line 310 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(item.MangerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 316 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                       Write(item.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>");
#nullable restore
#line 319 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                       Write(item.DeadLine.ToString("dd/MMM/yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 320 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                         if (item.StateId == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-right\"><label class=\"badge badge-light-success\">Completed</label></td>\r\n");
#nullable restore
#line 323 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                        }
                                        else if (item.StateId == 3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"text-right\"><label class=\"badge badge-light-warning\">Pending</label></td>\r\n");
#nullable restore
#line 327 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tr>\r\n");
#nullable restore
#line 331 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-5 col-md-12 "" >
        <div class=""card latest-update-card"">
            <div class=""card-header"">
                <h5>Latest Updates</h5>
                <div class=""card-header-right"">
                    <div class=""btn-group card-option"">
                        <button type=""button"" class=""btn dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""feather icon-more-horizontal""></i>
                        </button>
                        <ul class=""list-unstyled card-option dropdown-menu dropdown-menu-right"">
                            <li class=""dropdown-item full-card""><a href=""#!""><span><i class=""feather icon-maximize""></i> maximize</span><span style=""display:none""><i class=""feather icon-minimize""></i> Restore</span></a></li>
                            <li class=""d");
            WriteLiteral(@"ropdown-item minimize-card""><a href=""#!""><span><i class=""feather icon-minus""></i> collapse</span><span style=""display:none""><i class=""feather icon-plus""></i> expand</span></a></li>
                            <li class=""dropdown-item reload-card""><a href=""#!""><i class=""feather icon-refresh-cw""></i> reload</a></li>
                            <li class=""dropdown-item close-card""><a href=""#!""><i class=""feather icon-trash""></i> remove</a></li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class=""card-body"" style="" height: 388px; overflow-y: scroll"">
                <div class=""latest-update-box"">
");
#nullable restore
#line 360 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                     foreach (var item in (List<LastUpdateDto>)ViewBag.LastUpdate)
                    {
                        if (item.StateId == 6)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row p-t-30 p-b-30\">\r\n                        <div class=\"col-auto text-right update-meta\" style=\"padding-right: 20px;\">\r\n                            <p class=\"text-muted m-b-0 d-inline-flex\" style=\"padding-right:20px\">");
#nullable restore
#line 366 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                                            Write(item.UpdateDate.ToString("dd/M  hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            <div class="" text-danger ""  role=""status""style=""display: inline;"">
                                <i class=""fa fa-trash"" ></i>
                            </div>
                        </div>

                        <div class=""col"">
                            <a href=""#!"">
                                <h6>");
#nullable restore
#line 374 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                               Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 374 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                            </a>\r\n                            <p class=\"text-muted m-b-0\">");
#nullable restore
#line 376 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 376 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Has been Removed</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 379 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                }
                       else if (item.StateId == 7)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row p-t-30 p-b-30\">\r\n                        <div class=\"col-auto text-right update-meta\" style=\"padding-right: 20px;\">\r\n                            <p class=\"text-muted m-b-0 d-inline-flex\" style=\"padding-right:20px\">");
#nullable restore
#line 384 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                                            Write(item.UpdateDate.ToString("dd/M  hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            <div class="" text-success ""  role=""status""style=""display: inline;"">
                                <i class=""fa fa-plus-circle"" ></i>
                            </div>
                        </div>

                        <div class=""col"">
                            <a href=""#!"">
                                <h6>");
#nullable restore
#line 392 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                               Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 392 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                            </a>\r\n                            <p class=\"text-muted m-b-0\">");
#nullable restore
#line 394 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 394 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Has been Add</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 397 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                }else if (item.StateId == 8)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row p-t-30 p-b-30\">\r\n                        <div class=\"col-auto text-right update-meta\" style=\"padding-right: 20px;\">\r\n                            <p class=\"text-muted m-b-0 d-inline-flex\" style=\"padding-right:20px\">");
#nullable restore
#line 401 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                                            Write(item.UpdateDate.ToString("dd/M  hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                            <div class="" text-success ""  role=""status""style=""display: inline;"">
                                <i class=""fa fa-edit"" ></i>
                            </div>
                        </div>

                        <div class=""col"">
                            <a href=""#!"">
                                <h6>");
#nullable restore
#line 409 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                               Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 409 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                            </a>\r\n                            <p class=\"text-muted m-b-0\">");
#nullable restore
#line 411 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 411 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Has been Update</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 414 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                }
                else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row p-t-30 p-b-30\">\r\n                        <div class=\"col-auto text-right update-meta\">\r\n                            <p class=\"text-muted m-b-0 d-inline-flex\">");
#nullable restore
#line 418 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                 Write(item.UpdateDate.ToString("dd/M  hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 419 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                             if (item.StateId == 1 )
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"spinner-grow text-success\" role=\"status\">\r\n                                    <span class=\"sr-only\"></span>\r\n                                </div>\r\n");
#nullable restore
#line 424 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"

                            }
                            else if (item.StateId == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"spinner-grow text-warning\" role=\"status\">\r\n                                    <span class=\"sr-only\"></span>\r\n                                </div>\r\n");
#nullable restore
#line 431 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                            }
                            else if (item.StateId == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"spinner-grow text-warning\" role=\"status\">\r\n                                    <span class=\"sr-only\"></span>\r\n                                </div>\r\n");
#nullable restore
#line 437 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                            }
                            else if (item.StateId == 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"spinner-grow text-danger\" role=\"status\">\r\n                                    <span class=\"sr-only\"></span>\r\n                                </div>\r\n");
#nullable restore
#line 443 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <a href=\"#!\">\r\n                                <h6>");
#nullable restore
#line 448 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                               Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 448 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                            </a>\r\n                            <p class=\"text-muted m-b-0\">");
#nullable restore
#line 450 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                   Write(item.FieldName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 450 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" State has been update to ");
#nullable restore
#line 450 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                                                                                                       Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 453 "C:\Users\MAHMO\source\repos\FinalProject\FinalProjectAppLayer\Views\Admin\Index.cshtml"
                }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                    </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n   \r\n\r\n    <!-- Latest Customers end -->\r\n</div>\r\n<!-- [ Main Content ] end -->");
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
