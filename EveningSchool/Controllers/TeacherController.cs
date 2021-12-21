using AutoMapper;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationContext db;
        private readonly ITeacherService teacherService;
        private readonly IMapper mapper;
        
        public TeacherController(ITeacherService teacherService, ApplicationContext context, IMapper mapper)
        {
            this.teacherService = teacherService;
            this.db = context;
            this.mapper = mapper;
        }
        
        public IActionResult AllTeachers()
        {
            var teachers = teacherService.GetAllTeachers();
            return View(teachers);
        }
    }
}