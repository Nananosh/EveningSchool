using System.Collections.Generic;

namespace EveningSchool.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}