﻿using System;
using EveningSchool.Models;

namespace EveningSchool.ViewModels.Schedule
{
    public class LessonViewModel
    {
        public int Id { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public Cabinet Cabinet { get; set; }
        public int CabinetId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int LessonNumber { get; set; }
        public string RecurrenceRule { get; set; }
        public bool Replacement { get; set; }

        public string Title
        {
            get => @$"Класс - {Class.ClassName}, 
                      Предмет - {Subject.SubjectName}, 
                      Кабинет - {Cabinet.CabinetNumber},
                      Преподаватель - {Teacher.Name}";
        }
    }
}