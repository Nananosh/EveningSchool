#pragma checksum "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee0e131aa9ec6b2bd823211fa0704e5a616a03b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminStudent), @"mvc.1.0.view", @"/Views/Admin/AdminStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee0e131aa9ec6b2bd823211fa0704e5a616a03b7", @"/Views/Admin/AdminStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a5eb01ca052e0f68de0fa3e1ab9ca0e68b895e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0e131aa9ec6b2bd823211fa0704e5a616a03b73089", async() => {
                WriteLiteral("\r\n<br/><br/><br/>\r\n<div id=\"example\">\r\n    <div id=\"grid\"></div>\r\n    <script>\r\n        $(document).ready(function() {\r\n            $(\"#grid\").kendoGrid({\r\n                dataSource: {\r\n                    transport: {\r\n                        read: \"");
#nullable restore
#line 10 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml"
                          Write(Url.Action("GetAllStudents", "Schedule"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                        update: {\r\n                            url: \"");
#nullable restore
#line 12 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml"
                             Write(Url.Action("EditStudent","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                            dataType: \"json\",\r\n                            type: \"POST\"\r\n                        },\r\n                        create:{\r\n                            url: \"");
#nullable restore
#line 17 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml"
                             Write(Url.Action("AddStudent","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                            dataType: \"json\",\r\n                            type: \"POST\"  \r\n                        },\r\n                        destroy: {\r\n                            url: \"");
#nullable restore
#line 22 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml"
                             Write(Url.Action("DeleteStudent","Admin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                            dataType: ""json"",
                            type: ""DELETE""
                        }
                    },
                    group: {
                        field: ""Class.className"",
                        dir: ""sort""                  
                    },
                    schema: {
                        model: {
                            id: ""Id"",
                            fields: {
                                Id: { editable: false, from: ""id"", type: ""number"" },
                                Class: { from: ""class"", validation: {required: true} }, 
                                ClassId: {from: ""classId"", validation: {required: true} },
                                Name: { from: ""name"", type: ""string"", validation: {required: true }},
                                Surname: { from: ""surname"", type: ""string"", validation: {required: true }},
                                Lastname: { from: ""lastname"", type: ""string"", validation: {requ");
                WriteLiteral(@"ired: true }},
                                Telephone: { from: ""telephone"", type: ""string"", validation: {required: true }},
                                Address: { from: ""address"", type: ""string"", validation: {required: true }}
                            }
                        }
                    },
                    pageSize: 20,
                    serverPaging: false,
                    serverFiltering: false,
                    serverSorting: false
                },
                height: 550,
                editable: ""popup"",
                filterable: true,
                sortable: true,
                pageable: true,
                toolbar: [
                    {name: ""create""},
                    {name : ""search""}
                ],
                search: {
                    fields: [{
                            name: ""Class.className"",
                            operator: ""contains""
                        },
                        {
          ");
                WriteLiteral(@"                  name: ""Name"",
                            operator: ""contains""
                        },
                        {
                            name: ""Surname"",
                            operator: ""contains""
                        },
                        {
                            name: ""Lastname"",
                            operator: ""contains""
                        },
                        {
                            name: ""Telephone"",
                            operator: ""contains""
                        },
                        {
                            name: ""Address"",
                            operator: ""contains""
                        },
                    ]
                },
                columns: [
                    {
                        field:""Id"",
                        filterable: false
                    },
                    {
                        field: ""Name"",
                        title: ""Имя""
       ");
                WriteLiteral(@"             }, 
                    {
                        field: ""Surname"",
                        title: ""Фамилия""
                    }, 
                    {
                        field: ""Lastname"",
                        title: ""Отчество""
                    },
                    {
                        field: ""Class.className"",
                        title: ""Класс"",
                        editor: classEditor
                    },
                    {
                        field: ""Telephone"",
                        title: ""Телефон""
                    },
                    {
                        field: ""Address"",
                        title: ""Адрес""
                    },
                    {
                        command: ""edit"", 
                    },
                    {
                        command: ""destroy""
                    }
                ]
            });
        });
        
        function classEditor(container, options) {
");
                WriteLiteral(@"            $('<input required name=""ClassId"">')
                .appendTo(container)
                .kendoDropDownList({
                    dataTextField: ""className"",
                    dataValueField: ""id"",
                    height: 500,
                    dataSource: {
                        transport: {
                            read: {
                                url: """);
#nullable restore
#line 137 "C:\Users\nanan\RiderProjects\EveningSchool\EveningSchool\Views\Admin\AdminStudent.cshtml"
                                 Write(Url.Action("GetAllClasses", "Schedule"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                                dataType: \"json\",\r\n                                cache: false\r\n                            }\r\n                        }\r\n                    }\r\n                });\r\n        }\r\n    </script>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
