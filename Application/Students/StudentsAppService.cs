using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DemoLoginAPI.Students
{
    public class StudentsAppService: IStudentAppService
    {
        private readonly DataContext _context;
        public StudentsAppService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<StudentsEntity>> GetStudents()
        {
            List<StudentsEntity> Students = await _context.Students.ToListAsync();

            return Students;
        }
        public async Task<StudentsEntity> PostStudent(StudentsEntity Student)
        {
            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
            return Student;
        }
        public async Task<StudentsEntity> UpdateStudent(StudentsEntity Student)
        {
            StudentsEntity StudentUpdate = await _context.Students.FindAsync(Student.Id);
            if(StudentUpdate is null)
            return StudentUpdate;
            StudentUpdate.FirstName = Student.FirstName;
            StudentUpdate.MiddelName = Student.MiddelName;
            StudentUpdate.LastName = Student.LastName;
            StudentUpdate.Age = Student.Age;
            StudentUpdate.Gender = Student.Gender;
            StudentUpdate.IsLocal = Student.IsLocal;
            await _context.SaveChangesAsync();
            return StudentUpdate;
        }

        public async Task<StudentsEntity> DeleteStudent(StudentsEntity Student)
        {
            StudentsEntity StudentDelete = await _context.Students.FindAsync(Student.Id);
            if(StudentDelete is null)
            return StudentDelete;
            _context.Students.Remove(StudentDelete);  
            await _context.SaveChangesAsync();
            return StudentDelete;   
            }
    }
}