#pragma checksum "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1a9755aa38a6b964c0fe2f45c3963fed973eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Schedule_EditTeacherSchedule), @"mvc.1.0.view", @"/Views/Schedule/EditTeacherSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1a9755aa38a6b964c0fe2f45c3963fed973eb8", @"/Views/Schedule/EditTeacherSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5eb01ca052e0f68de0fa3e1ab9ca0e68b895e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Schedule_EditTeacherSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""example"">
    <div id=""scheduler""></div>
</div>
<script id=""event-template"" type=""text/x-kendo-template"">
    <div class=""movie-template"" style=""background-color: #=colorVal#"">
      <p>#: title #</p>
      </div>
    </script>
<script id=""customEditorTemplate"" type=""text/x-kendo-template"">
    <div class=""k-edit-label""><label for=""recurrenceRule"">Повторение</label></div>
    <div data-container-for=""recurrenceRule"" class=""k-edit-field"">
        <div data-bind=""value:recurrenceRule"" name=""recurrenceRule"" data-role=""recurrenceeditor""></div>
      </div>
    <div class=""k-edit-label""><label for=""classId"">Класс</label></div>
    <div class=""k-edit-field"">
              <input id=""class"" style=""width: 60%;"" data-bind=""value:classId""/>
          </div>
    <div class=""k-edit-label""><label for=""classId"">Предмет</label></div>
    <div class=""k-edit-field"">
                        <input id=""subject"" style=""width: 60%;"" data-bind=""value:subjectId""/>
                    </div>
    <div cl");
            WriteLiteral(@"ass=""k-edit-label""><label for=""classId"">Кабинет</label></div>
    <div class=""k-edit-field"">
    <input id=""cabinet"" style=""width: 60%;"" data-bind=""value:cabinetId""/>
    </div>
    <div class=""k-edit-label""><label for=""replacement"">Замена</label></div>
    <div data-container-for=""Replacement"" class=""k-edit-field"">
    <input data-bind=""checked: replacement"" data-type=""number"" type=""checkbox"" />
    </div>
    </script>

<script>
$(function() {
    $(""#scheduler"").kendoScheduler({
        footer: false,
        date: new Date(""");
#nullable restore
#line 36 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                   Write(DateTime.Now.ToString("yyyy-M-d 07:00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"),\r\n        startTime: new Date(\"");
#nullable restore
#line 37 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
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
        minorTickCount: 1,
        views: [
            {
                type: ""day"",
                selected: true,
            },
            
        ],
        editable: {
            editRecurringMode: ""series"",
            template: $(""#customEditorTemplate"").html(),
        },
        edit: function(e) {
            $(""#class"").kendoDropDownList({
                dataTextField: ""className"",
                dataValueField: ""id"",
                optionLabel: ""Выберите класс..."",
                height: 500,
                dataSource: {
                    transport: {
                        read: {
                            url: """);
#nullable restore
#line 64 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                             Write(Url.Action("GetAllClassesByParameter","Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + `/?lessonNumber=${e.event.lessonNumber}&dateStart=${kendo.toString(e.event.start, ""MM/dd/yyyy 7:00:00"")}`,
                            dataType: ""json"",
                            cache: false
                        }
                    }
                }
            });

            $(""#subject"").kendoDropDownList({
                dataTextField: ""subjectName"",
                dataValueField: ""id"",
                optionLabel: ""Выберите предмет..."",
                height: 500,
                dataSource: {
                    transport: {
                        read: {
                            url: """);
#nullable restore
#line 80 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                             Write(Url.Action("GetAllSubjects", "Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                            dataType: ""json"",
                            cache: false
                        }
                    }
                }
            })
            $(""#cabinet"").kendoDropDownList({
                dataTextField: ""cabinetNumber"",
                dataValueField: ""id"",
                optionLabel: ""Выберите кабинет..."",
                height: 500,
                dataSource: {
                    transport: {
                        read: {
                            url: """);
#nullable restore
#line 95 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                             Write(Url.Action("GetAllCabinetsByParameter", "Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + `/?lessonNumber=${e.event.lessonNumber}&dateStart=${kendo.toString(e.event.start, ""MM/dd/yyyy 7:00:00"")}`,
                            dataType: ""json"",
                            cache: false
                        }
                    }
                }
            })
        },
        eventTemplate: $(""#event-template"").html(),
        timezone: ""Europe/Minsk"",
        dataSource: {
            batch: true,
            transport: {
                read: {
                    url: """);
#nullable restore
#line 109 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                     Write(Url.Action("GetLessonsByTeacherId", "Schedule", new {id = ViewBag.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    dataType: \"json\"\r\n                },\r\n                create: {\r\n                    url: \"");
#nullable restore
#line 113 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                     Write(Url.Action("AddTeacherLessons", "Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    datatype: \"json\",\r\n                    type: \"POST\"\r\n                },\r\n                update: {\r\n                    url: \"");
#nullable restore
#line 118 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                     Write(Url.Action("EditTeacherLessons", "Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    dataType: \"json\",\r\n                    type: \"POST\"\r\n                },\r\n                destroy: {\r\n                    url: \"");
#nullable restore
#line 123 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
                     Write(Url.Action("DeleteTeacherLessons", "Schedule"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                    dataType: ""json"",
                    type: ""DELETE""
                },
                parameterMap: function(options, operation) {
                    if (operation !== ""read"" && options.models) {
                        console.log(options.models[0])
                        options.models[0].dateStart = kendo.toString(options.models[0].dateStart, ""dd/MM/yyyy 7:00"");
                        options.models[0].dateEnd = kendo.toString(options.models[0].dateEnd, ""dd/MM/yyyy 7:00"");
                        return options.models[0];
                    }
                }
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
          ");
            WriteLiteral(@"                      required: true
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
                            defaultValue: ");
#nullable restore
#line 167 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Schedule\EditTeacherSchedule.cshtml"
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
    .k-event{
    ");
            WriteLiteral("  \t\tbackground: none;\r\n          \tborder: none;\r\n      \t}\r\n   .kendo-scheduler .k-event .k-event-actions, .k-event .k-event-actions {\r\n   margin-right: 10px;\r\n   }    \r\n</style>\r\n");
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
