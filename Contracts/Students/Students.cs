namespace DemoLoginAPI.Students
{
    public class StudentsEntity
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string MiddelName { get; set; } = string.Empty;
        public string LastName { get; set; } =  string.Empty;
        public required int Age { get; set; }
        public string Gender { get; set; } = "undefined";
        public bool IsLocal { get; set; }
    }
}