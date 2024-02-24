using Microsoft.AspNetCore.Mvc;

namespace DemoLoginAPI.Students
{
    public interface IStudentAppService
    {
        public Task<List<StudentsEntity>> GetStudents();
        public Task<StudentsEntity> PostStudent(StudentsEntity Student);
        public Task<StudentsEntity> UpdateStudent(StudentsEntity Student);
        public Task<StudentsEntity> DeleteStudent(StudentsEntity Student);
    }
}