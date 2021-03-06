#pragma checksum "D:\Projects\time-sheet-HRMS\TimeSheet\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e7418c385422579fe60a49e23744c52276ddbf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\time-sheet-HRMS\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\time-sheet-HRMS\TimeSheet\Views\_ViewImports.cshtml"
using TimeSheet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7418c385422579fe60a49e23744c52276ddbf6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7036a8495e566242915d53879884387daf7875", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<link href=\"https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i\" rel=\"stylesheet\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf63290", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.7/css/bootstrap.min.css""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.3/js/select2.full.min.js""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.3/css/select2.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.2.7/components/accordion.min.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.2.7/components/accordion.min.js""></script>

    <script src=""D:\Projects\time-sheet-HRMS\TimeSheet\Contents\JS\timesheet.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div>
    <p class=""maintitle"">Monthly Timesheet</p>
</div>

<section class=""timesheet-navigation"">
    <div class=""nav"">
        <div class=""container-fluid nopaddingmail"">
            <div class=""tabbable"">
                <ul class=""nav nav-tabs"" data-tabs=""tabs"" id=""myTab"">
                    <li class=""active""><a data-toggle=""tab"" href=""#incoming"">Current</a></li>
                    <li><a data-toggle=""tab"" href=""#sentmsg"">Previous</a></li>
                    <li><a data-toggle=""tab"" href=""#sentmsg"">Not Sent</a></li>
                    <li><a data-toggle=""tab"" href=""#sentmsg"">Wait for Accept</a></li>
                    <li><a data-toggle=""tab"" href=""#sentmsg"">Accepted</a></li>
                    <li><a data-toggle=""tab"" href=""#sentmsg"">Rejected</a></li>
                </ul>
                <div class=""tab-content"">
                    <div class=""tab-pane active"" id=""incoming"">

</section>


<section class=""timesheet-buttons"">

    <input type=""date"" id=""theDate"">

");
            WriteLiteral(@"    <div class=""today-timesheet"">
        <button type=""button"" class=""newmsgb"">Today</button>
        <button type=""button"" class=""add-task-timesheet"" data-toggle=""modal"" data-target=""#addtask"">Add New Task</button>
    </div>
</section>

<section style=""margin-top: -40px"">

    <p class=""picked-day"">2016-12-30</p>




</section>

<section>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12 tab-title"">
                <div class=""row"">
                    <div class=""col-md-2 col-sm-2 col-xs-1"">
                        <div class=""statustitle"">Project</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""projectnametitle"">Task</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""completiontitle"">Date</div>
                    </div>
                    <div class=""col");
            WriteLiteral(@"-md-2 col-sm-2 col-xs-2"">
                        <div class=""detailstitle"">Start Date/End Date</div>
                    </div>
                    <div class=""col-md-1 col-sm-1 col-xs-1"">
                        <div class=""detailstitle"">Duration</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""detailstitle"">Description</div>
                    </div>
                    <div class=""col-md-1 col-sm-1 col-xs-1"">
                        <div class=""tsdelete-row""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<section>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
                <div class=""row timesheet-task-row"">
                    <div class=""col-md-2 col-sm-2 col-xs-1"">
                        <div class=""statustitle"">Project 1</div>
                    </div>
 ");
            WriteLiteral(@"                   <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""projectnametitle"">Task 1</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""completiontitle"">2016-12-12</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""detailstitle"">12:00/13:00</div>
                    </div>
                    <div class=""col-md-1 col-sm-1 col-xs-1"">
                        <div class=""detailstitle"">1 Hr.</div>
                    </div>
                    <div class=""col-md-2 col-sm-2 col-xs-2"">
                        <div class=""detailstitle"">Really hard work.</div>
                    </div>
                    <div class=""col-md-1 col-sm-1 col-xs-1"">
                        <div class=""tsdelete-row"">x</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</sectio");
            WriteLiteral(@"n>


<!-- Modal -->
<div id=""addtask"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content timesheet"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Add Task</h4>
            </div>
            <div class=""modal-body"">

                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <p>Project</p>
                                </div>
                                <div class=""col-md-9"">

                                    <select class=""js-example-basic-single"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf610570", async() => {
                WriteLiteral("Project1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf611571", async() => {
                WriteLiteral("Project2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf612572", async() => {
                WriteLiteral("Project3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf613573", async() => {
                WriteLiteral("Project4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf614574", async() => {
                WriteLiteral("Project5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>

                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <p>Task</p>
                                </div>
                                <div class=""col-md-9"">

                                    <select class=""js-example-basic-single"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf616035", async() => {
                WriteLiteral("Task1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf617033", async() => {
                WriteLiteral("Task2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf618031", async() => {
                WriteLiteral("Task3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf619029", async() => {
                WriteLiteral("Task4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7418c385422579fe60a49e23744c52276ddbf620027", async() => {
                WriteLiteral("Task5");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>

                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <p>Date</p>
                                </div>
                                <div class=""col-md-9"">
                                    <input type=""date"">
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <p>Start Time</p>
                                </div>
                                <div class=""col-md-9"">
                                    <input type=""time"" />
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                        ");
            WriteLiteral(@"            <p>End Time</p>
                                </div>
                                <div class=""col-md-9"">
                                    <input type=""time"" />
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <p>Description</p>
                                </div>
                                <div class=""col-md-9"">
                                    <input type=""text"" class=""timesheet-description"" />
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-3"">
                                </div>
                                <div class=""col-md-9"">

                                    <div clas=""actionbutton"">
                                        <p class=""button-container""><button clas");
            WriteLiteral(@"s=""user-aciton"">Add Task</button></p>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>







        </div>
    </div>

</div>
</div>
");
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
