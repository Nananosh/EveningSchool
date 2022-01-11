using System.Collections.Generic;
using Newtonsoft.Json;

namespace EveningSchool.Models
{
    public class Cabinet
    {
        public int Id { get; set; }
        public int CabinetNumber { get; set; }
        [JsonIgnore]
        public List<Lesson> Lessons { get; set; }
    }
}