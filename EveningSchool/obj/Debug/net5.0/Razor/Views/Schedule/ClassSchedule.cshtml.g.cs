#pragma checksum "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\ClassSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8809cec626e2099fc103755e870f43d36bcace3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_ClassSchedule), @"mvc.1.0.view", @"/Views/Schedule/ClassSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8809cec626e2099fc103755e870f43d36bcace3", @"/Views/Schedule/ClassSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5eb01ca052e0f68de0fa3e1ab9ca0e68b895e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_ClassSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""example"">
    <div id=""scheduler""></div>
</div>
<script id=""event-template"" type=""text/x-kendo-template"">
    <div class=""movie-template"">
      <p>#: title #</p>
      </div>
    </script>
<script>
$(function() {
    $(""#scheduler"").kendoScheduler({
        footer: false,
        date: new Date(""");
#nullable restore
#line 13 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\ClassSchedule.cshtml"
                   Write(DateTime.Now.ToString("yyyy-M-d 07:00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"),\r\n        startTime: new Date(\"");
#nullable restore
#line 14 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\ClassSchedule.cshtml"
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
                    url: """);
#nullable restore
#line 35 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\ClassSchedule.cshtml"
                     Write(Url.Action("GetLessonsByClassId", "Schedule", new {id = ViewBag.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    dataType: ""json""
                },
            },
            schema: {
                model: {
                    id: ""id"",
                    fields: {
                        id: {
                            from: ""id"",
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
                        lesso");
            WriteLiteral(@"nNumber: {
                            from: ""lessonNumber"",
                        },
                        teacherId: {
                            type: ""number"",
                            from: ""teacherId"",
                            defaultValue: ");
#nullable restore
#line 70 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\ClassSchedule.cshtml"
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
                    text: ""Урок 2"",
                    value: 2
                },
                {
             ");
            WriteLiteral(@"       text: ""Урок 3"",
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
</style>
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
