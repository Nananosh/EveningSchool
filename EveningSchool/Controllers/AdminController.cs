using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationContext db;
        private readonly IMapper mapper;
        private readonly IAdminService adminService;
        
        public AdminController(ApplicationContext db, IMapper mapper, IAdminService adminService)
        {
            this.db = db;
            this.mapper = mapper;
            this.adminService = adminService;
        }
        
        public IActionResult AddClass()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddClass(ClassViewModel model)
        {
            adminService.AddClass(db,mapper.Map<Class>(model));
            return RedirectToAction();
        }

        public IActionResult AddSubject()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddSubject(SubjectViewModel model)
        {
            adminService.AddSubject(db,mapper.Map<Subject>(model));
            return RedirectToAction();
        }
        
        public IActionResult AddCabinet()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddCabinet(CabinetViewModel model)
        {
            adminService.AddCabinet(db,mapper.Map<Cabinet>(model));
            return RedirectToAction();
        }
        
        public IActionResult GetAllTeachers()
        {
            var teachers = adminService.GetAllTeachers(db);
            return Json(mapper.Map<IEnumerable<TeacherViewModel>>(teachers));
        }
        
        public IActionResult GetAllClasses()
        {
            var classes = adminService.GetAllClasses(db);
            return Json(mapper.Map<IEnumerable<ClassViewModel>>(classes));
        }
    
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(StudentViewModel model)
        {
            adminService.AddStudent(db,mapper.Map<Student>(model));
            return RedirectToAction();
        }
    }
}