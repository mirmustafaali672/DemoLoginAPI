using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DemoLoginAPI.Students
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("MyCorsPolicy")]
    public class StudentsController: ControllerBase
    {
        private readonly IStudentAppService _iStudentAppService;
        public StudentsController(IStudentAppService iStudentAppService)
        {
            _iStudentAppService = iStudentAppService;
        }
        [HttpGet]
        [Route("GetStudents"), Authorize]
        public async Task<ActionResult<List<StudentsEntity>>> GetStudents()
        {
            var Students = await _iStudentAppService.GetStudents();
             return Ok(Students);
        }
        [HttpPost]
        [Route("PostStudent")]
        public async Task<ActionResult<StudentsEntity>> PostStudent(StudentsEntity Student)
        {
            await _iStudentAppService.PostStudent(Student);
            return Ok(Student);
        }
        [HttpPut]
        [Route("UpdateStudent")]
         public async Task<ActionResult<StudentsEntity>> UpdateStudent(StudentsEntity Student)
         {
            StudentsEntity StudentUpdate = await _iStudentAppService.UpdateStudent(Student);
            if(StudentUpdate is null)
            return NotFound("Student not found.");
            return Ok(Student);
         }
         [HttpDelete]
         [Route("DeleteStudent")]
         public async Task<ActionResult<StudentsEntity>> DeleteStudent(StudentsEntity Student)
         {
            StudentsEntity StudentDelete = await _iStudentAppService.DeleteStudent(Student);
            if(StudentDelete is null)
            return NotFound("Student not found.");
            return Ok(StudentDelete);
         }
    }
}