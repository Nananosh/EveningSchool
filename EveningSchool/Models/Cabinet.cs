using System.Collections.Generic;

namespace EveningSchool.Models
{
    public class Cabinet
    {
        public int Id { get; set; }
        public int CabinetNumber { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}