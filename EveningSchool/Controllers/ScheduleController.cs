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

        public IActionResult EditTeacherSchedule(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult AllSchedule()
        {
            ViewBag.Cabinets = scheduleService.GetAllCabinets();
            ViewBag.Classes = scheduleService.GetAllClasses();
            ViewBag.Subjects = scheduleService.GetAllSubjects();
            ViewBag.Teachers = scheduleService.GetAllTeachers();
            return View();
        }

        public IActionResult TeacherSchedule(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        
        public IActionResult ClassSchedule(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        
        public IActionResult CabinetSchedule(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        
        public IActionResult SubjectSchedule(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult GetLessonsByTeacherId(int id)
        {
            var lessons = scheduleService.GetLessonsByTeacherId(id);
            return Json(mapper.Map<IEnumerable<LessonViewModel>>(lessons));
        }
        
        public IActionResult GetLessonsByClassId(int id)
        {
            var lessons = scheduleService.GetLessonsByClassId(id);
            return Json(mapper.Map<IEnumerable<LessonViewModel>>(lessons));
        }
        
        public IActionResult GetLessonsByCabinetId(int id)
        {
            var lessons = scheduleService.GetLessonsByCabinetId(id);
            return Json(mapper.Map<IEnumerable<LessonViewModel>>(lessons));
        }
        
        public IActionResult GetLessonsBySubjectId(int id)
        {
            var lessons = scheduleService.GetLessonsBySubjectId(id);
            return Json(mapper.Map<IEnumerable<LessonViewModel>>(lessons));
        }

        [HttpPost]
        public IActionResult AddTeacherLessons(LessonViewModel models)
        {
            var addedLesson = scheduleService.AddTeacherLesson(mapper.Map<Lesson>(models));
            return Json(mapper.Map<LessonViewModel>(addedLesson));
        }

        [HttpPost]
        public IActionResult EditTeacherLessons(LessonViewModel models)
        {
            var editedLesson = scheduleService.EditTeacherLesson(mapper.Map<Lesson>(models));
            return Json(mapper.Map<LessonViewModel>(editedLesson));
        }

        [HttpDelete]
        public IActionResult DeleteTeacherLessons(LessonViewModel models)
        {
            scheduleService.DeleteLesson(mapper.Map<Lesson>(models));
            return Ok();
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

        public IActionResult GetAllTeachers()
        {
            var teachers = scheduleService.GetAllTeachers();
            return Json(mapper.Map<IEnumerable<TeacherViewModel>>(teachers));
        }

        public IActionResult GetAllStudents()
        {
            var students = scheduleService.GetAllStudents();
            return Json(mapper.Map<IEnumerable<StudentViewModel>>(students));
        }
    }
}