using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using AutoMapper;
using EveningSchool.Business.Interfaces;
using EveningSchool.Models;
using EveningSchool.ViewModels.Admin;
using EveningSchool.ViewModels.Schedule;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleService scheduleService;
        private readonly IMapper mapper;

        public ScheduleController(IScheduleService scheduleService, IMapper mapper)
        {
            this.scheduleService = scheduleService;
            this.mapper = mapper;
        }
        
        public IActionResult TeacherLessons(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult GetLessonsByTeacherId(int id)
        {
            var lessons = scheduleService.GetLessonsByTeacherId(id); 
            return Json(mapper.Map<IEnumerable<LessonViewModel>>(lessons));
        }

        [HttpPost]
        public IActionResult AddTeacherLessons([FromBody] LessonViewModel models)
        {
            var lesson = scheduleService.AddTeacherLessons(mapper.Map<Lesson>(models));
            return Json(mapper.Map<LessonViewModel>(lesson));
        }

        public IActionResult GetAllClasses()
        {
            var classes = scheduleService.GetAllClasses();
            return Json(mapper.Map<IEnumerable<ClassViewModel>>(classes));
        }
        
        public IActionResult GetAllSubjects()
        {
            var subjects = scheduleService.GetAllSubjects();
            return Json(mapper.Map<IEnumerable<SubjectViewModel>>(subjects));
        }
        
        public IActionResult GetAllCabinets()
        {
            var cabinets = scheduleService.GetAllCabinets();
            return Json(mapper.Map<IEnumerable<CabinetViewModel>>(cabinets));
        }
    }
}