namespace StudentApi.Models
{
    public class Student
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public required int Age{get; set;}

        public string ? Department {get; set;}

    }
}