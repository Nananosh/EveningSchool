using System.Collections.Generic;

namespace EveningSchool.Models
{
    public class Cabinet
    {
        public int Id { get; set; }
        public string CabinetNumber { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}