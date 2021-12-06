using System;

namespace EveningSchool.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Cabinet Cabinet { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime Date { get; set; }
    }
}