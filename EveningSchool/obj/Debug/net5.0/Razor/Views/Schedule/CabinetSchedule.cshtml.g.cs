#pragma checksum "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8d0adb56cbd79357fe2387d9fe0f1a45751e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_CabinetSchedule), @"mvc.1.0.view", @"/Views/Schedule/CabinetSchedule.cshtml")]
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
#line 1 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\_ViewImports.cshtml"
using EveningSchool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\_ViewImports.cshtml"
using EveningSchool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8d0adb56cbd79357fe2387d9fe0f1a45751e9d", @"/Views/Schedule/CabinetSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5eb01ca052e0f68de0fa3e1ab9ca0e68b895e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_CabinetSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<intput type=""button"" class=""btn"" onclick=""ReplaceURL()"" style=""background-color: #2FB807;"">Показать замены</intput>
<intput type=""button"" class=""btn"" onclick=""NotReplaceURL()"" style=""background-color: #0D9CEE;"">Скрыть замены</intput>
<div id=""example"">
    <div id=""scheduler""></div>
</div>
<script id=""event-template"" type=""text/x-kendo-template"">
    <div class=""movie-template"" style=""background-color: #=colorVal#"">
      <p>#: title #</p>
      </div>
    </script>
<script>
var URL = """);
#nullable restore
#line 12 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
      Write(Url.Action("GetLessonsByTeacherId", "Schedule", new {id = ViewBag.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
$(function() {
    $(""#scheduler"").kendoScheduler({
        toolbar: [""pdf""],
        pdf: {
            fileName: ""Расписание.pdf"",
            proxyURL: ""https://demos.telerik.com/kendo-ui/service/export""
        },
        footer: false,
        date: new Date(""");
#nullable restore
#line 21 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
                   Write(DateTime.Now.ToString("yyyy-M-d 07:00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"),\r\n        startTime: new Date(\"");
#nullable restore
#line 22 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
                        Write(DateTime.Now.ToString("yyyy-M-d 07:00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""),
        allDaySlot: false,
        majorTimeHeaderTemplate: """",
        timeSlot: false,
        ShowTimeRuler: false,
        majorTick: 1440, //set major tick to full day and leave the default startTime/endTime
        minorTickCount: 3,
        views: [
            {
                type: ""day"",
                selected: true,
            },
            { type: ""workWeek""},
        ],
        editable: false,
        eventTemplate: $(""#event-template"").html(),
        timezone: ""Europe/Minsk"",
        dataSource: {
            batch: true,
            transport: {
                read: {
                    url: function(options) {
                                                          return URL;
                                                        },
                    dataType: ""json""
                },
            },
            schema: {
                model: {
                    id: ""id"",
                    fields: {
                        id: {
        ");
            WriteLiteral(@"                    from: ""id"",
                            type: ""number""
                        },
                        title: {
                            defaultValue: ""No title"",
                            validation: {
                                required: true
                            }
                        },
                        start: {
                            type: ""date"",
                            from: ""dateStart""
                        },
                        end: {
                            type: ""date"",
                            from: ""dateEnd""
                        },
                        recurrenceRule: {
                            from: ""recurrenceRule""
                        },
                        lessonNumber: {
                            from: ""lessonNumber"",
                        },
                        teacherId: {
                            type: ""number"",
                            from: ""teacherId"",
      ");
            WriteLiteral("                      defaultValue: ");
#nullable restore
#line 80 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
                                     Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        },
                        classId: {
                            type: ""number"",
                            from: ""classId""
                        },
                        subjectId: {
                            type: ""number"",
                            from: ""subjectId""
                        },
                        cabinetId: {
                            type: ""number"",
                            from: ""cabinetId""
                        },
                        colorVal: {
                            from: ""colorVal"",
                        }
                    }
                }
            }
        },
        group: {
            resources: [""LessonNumber""],
            orientation: ""vertical""
        },
        resources: [{
            field: ""lessonNumber"",
            name: ""LessonNumber"",
            dataSource: [{
                    text: ""Урок 1"",
                    value: 1
                },
                {
       ");
            WriteLiteral(@"             text: ""Урок 2"",
                    value: 2
                },
                {
                    text: ""Урок 3"",
                    value: 3
                },
                {
                    text: ""Урок 4"",
                    value: 4
                },
                {
                    text: ""Урок 5"",
                    value: 5
                },
                {
                    text: ""Урок 6"",
                    value: 6
                },
                {
                    text: ""Урок 7"",
                    value: 7
                },
                {
                    text: ""Урок 8"",
                    value: 8
                }
            ],
            title: ""LessonNumber""
        }]
    });
});
</script>
<style>
    .k-icon.k-i-arrow-60-down{
        display: none;
        }
    .k-icon.k-i-arrow-60-up{
        display: none;
        }
    .k-current-time{
        display: none;
    }
</style>

<style>
      ");
            WriteLiteral(@"  /*
            Use the DejaVu Sans font for display and embedding in the PDF file.
            The standard PDF fonts have no support for Unicode characters.
        */
        .k-scheduler {
            font-family: ""DejaVu Sans"", ""Arial"", sans-serif;
            font-size: .9em;
        }

        /* Hide toolbar, navigation and footer during export */
        .k-pdf-export .k-scheduler-toolbar,
        .k-pdf-export .k-scheduler-navigation .k-nav-today,
        .k-pdf-export .k-scheduler-navigation .k-nav-prev,
        .k-pdf-export .k-scheduler-navigation .k-nav-next,
        .k-pdf-export .k-scheduler-footer
        {
            display: none;
        }
        .k-event{
              		background: none;
                  	border: none;
              	}
           .kendo-scheduler .k-event .k-event-actions, .k-event .k-event-actions {
           margin-right: 10px;
           }    
    </style>

<script>
        // Import DejaVu Sans font for embedding

        // NOTE: O");
            WriteLiteral(@"nly required if the Kendo UI stylesheets are loaded
        // from a different origin, e.g. cdn.kendostatic.com
        kendo.pdf.defineFont({
            ""DejaVu Sans""             : ""https://kendo.cdn.telerik.com/2016.2.607/styles/fonts/DejaVu/DejaVuSans.ttf"",
            ""DejaVu Sans|Bold""        : ""https://kendo.cdn.telerik.com/2016.2.607/styles/fonts/DejaVu/DejaVuSans-Bold.ttf"",
            ""DejaVu Sans|Bold|Italic"" : ""https://kendo.cdn.telerik.com/2016.2.607/styles/fonts/DejaVu/DejaVuSans-Oblique.ttf"",
            ""DejaVu Sans|Italic""      : ""https://kendo.cdn.telerik.com/2016.2.607/styles/fonts/DejaVu/DejaVuSans-Oblique.ttf"",
            ""WebComponentsIcons""      : ""https://kendo.cdn.telerik.com/2017.1.223/styles/fonts/glyphs/WebComponentsIcons.ttf""
        });
</script>
<script>
function NotReplaceURL(){
    URL = """);
#nullable restore
#line 201 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
      Write(Url.Action("GetLessonsByClassId", "Schedule", new {id = ViewBag.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    var scheduler = $(\"#scheduler\").data(\"kendoScheduler\");\r\n    scheduler.dataSource.read();\r\n}\r\nfunction ReplaceURL(){\r\n    URL = \"");
#nullable restore
#line 206 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\CabinetSchedule.cshtml"
      Write(Url.Action("GetLessonsByClassIdReplaced", "Schedule", new {id = ViewBag.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    var scheduler = $(\"#scheduler\").data(\"kendoScheduler\");\r\n    scheduler.dataSource.read();\r\n}\r\n</script>");
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
