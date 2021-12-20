namespace EveningSchool.ViewModels.Admin
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Telephone { get; set; }

        public string FullName => $"{Surname} {Name} {Lastname}";
    }
}