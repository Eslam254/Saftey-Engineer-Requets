#pragma checksum "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bc6805b1c4103040bbb13e3b438fe6e0f4ab69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_Index), @"mvc.1.0.view", @"/Views/Requests/Index.cshtml")]
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
#line 1 "E:\SafetyRequests\SafetyRequests\Views\_ViewImports.cshtml"
using SafetyRequests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SafetyRequests\SafetyRequests\Views\_ViewImports.cshtml"
using SafetyRequests.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bc6805b1c4103040bbb13e3b438fe6e0f4ab69", @"/Views/Requests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6e9844383323c50fc575f1b97f483865cd3631", @"/Views/_ViewImports.cshtml")]
    public class Views_Requests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SafetyRequests.Models.DB.Request>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
   ViewData["Title"] = "Requests"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>\n    <i class=\"bi bi-film\"></i>\n    Requests\n</h2>\n\n<hr />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92bc6805b1c4103040bbb13e3b438fe6e0f4ab695331", async() => {
                WriteLiteral("\n    <i class=\"bi bi-plus\"></i>Add Request\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"mt-4\">\n");
#nullable restore
#line 17 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
     if (!Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-warning\" role=\"alert\">\n    <i class=\"bi bi-exclamation-triangle\"></i>\n    No Requests found!\n</div> ");
#nullable restore
#line 22 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
       }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 26 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
     foreach (var req in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-12"">
    <div class=""card mb-3"">
        <div class=""row no-gutters"">
            <div class=""col-md-10"">
                <div class=""card-body d-flex flex-column justify-content-between h-100"">
                    <div>
                        <h5 class=""card-title""> Employee Name : ");
#nullable restore
#line 34 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                           Write(req.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text text-justify\"> Equipment : ");
#nullable restore
#line 35 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                   Write(req.Equipments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-justify\">Planned Activity : ");
#nullable restore
#line 36 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                         Write(req.PlannedActivity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-justify\">Request Start Date : ");
#nullable restore
#line 37 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                           Write(req.WorkingStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-justify\">Request End Date : ");
#nullable restore
#line 38 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                         Write(req.WorkingEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text text-justify\">Department name : ");
#nullable restore
#line 39 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                        Write(req.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""d-flex justify-content-between"">
                        <p class=""card-text mb-0 mt-2"">
                            <i class=""bi bi-star-fill text-warning""></i>
                            <small class=""text-muted"">Request Status : ");
#nullable restore
#line 44 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                  Write(req.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                        </p>\n\n                        <div>\n                            <a href=\"javascript:;\" class=\"btn btn-info js-approve\" data-id=\"");
#nullable restore
#line 48 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                                       Write(req.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                <i class=\"bi bi-trash\"></i>\n                                Approve\n                            </a>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92bc6805b1c4103040bbb13e3b438fe6e0f4ab6910938", async() => {
                WriteLiteral("\n                                <i class=\"bi bi-pencil\"></i>\n                                Edit\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                   WriteLiteral(req.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <a href=\"javascript:;\" class=\"btn btn-danger js-delete\" data-id=\"");
#nullable restore
#line 56 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                                        Write(req.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                <i class=\"bi bi-trash\"></i>\n                                Delete\n                            </a>\n                            <a href=\"javascript:;\" class=\"btn btn-danger js-reject\" data-id=\"");
#nullable restore
#line 60 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                                                        Write(req.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                <i class=\"bi bi-trash\"></i>\n                                Reject\n                            </a>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92bc6805b1c4103040bbb13e3b438fe6e0f4ab6914349", async() => {
                WriteLiteral("\n                                <i class=\"bi bi-camera-reels\"></i>\n                                Details\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
                                                      WriteLiteral(req.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
#nullable restore
#line 74 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
#nullable restore
#line 75 "E:\SafetyRequests\SafetyRequests\Views\Requests\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.js-delete').on('click', function () {
                var btn = $(this);

                bootbox.confirm({
                    message: ""Are you sure that you need to delete this Request?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/Requests/delete/' + btn.data('id'),
                                success: function () {
                                    var reqContainer = btn.parents('.col-12');
                                    reqContainer.addCla");
                WriteLiteral(@"ss('animate__animated animate__zoomOut');

                                    setTimeout(function () {
                                        reqContainer.remove();
                                    }, 1000);

                                    toastr.success('Request deleted');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                        }
                    }
                });
            });

            $('.js-reject').on('click', function () {
                var btn = $(this);
                bootbox.confirm({
                    message: ""Are you sure that you need to Reject this Request?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-danger'
                        },
                        cancel: ");
                WriteLiteral(@"{
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
             
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/Requests/Reject/' + btn.data('id'),
                                success: function () {
                                    var reqContainer = btn.parents('.col-12');
                                    reqContainer.addClass('animate__animated animate__zoomOut');
                                    setTimeout(function () {
                                        location.reload();
                                    }, 1000);

                                    toastr.success('Request Rejected');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                      ");
                WriteLiteral(@"          }
                            });
                        }
                    }
                });
            });

            $('.js-approve').on('click', function () {
                var btn = $(this);
                bootbox.confirm({
                    message: ""Are you sure that you need to approve this Request?"",
                    buttons: {
                        confirm: {
                            label: 'Yes',
                            className: 'btn-info'
                        },
                        cancel: {
                            label: 'No',
                            className: 'btn-outline-secondary'
                        }
                    },
                    callback: function (result) {
                        if (result) {
                            $.ajax({
                                url: '/Requests/Approve/' + btn.data('id'),
                                success: function () {
                                    var reqContainer = btn.");
                WriteLiteral(@"parents('.col-12');
                                    reqContainer.addClass('animate__animated animate__zoomOut');
                                    setTimeout(function () {
                                        location.reload();
                                    }, 1000);
                                    toastr.success('Request Approved');
                                },
                                error: function () {
                                    toastr.error('Something went wrong!');
                                }
                            });
                        }
                    }
                });
            });
        });</script>
");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SafetyRequests.Models.DB.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591