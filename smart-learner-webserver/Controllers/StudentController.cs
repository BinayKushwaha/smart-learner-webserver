using Microsoft.AspNetCore.Mvc;
using smart_learner.Application.DTO;
using smart_learner.Application.Services;
using System.Threading.Tasks;

namespace smart_learner_webserver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentService _studentService;

        public StudentController(ILogger<StudentController> logger,
            IStudentService studentService)
        {
            _logger = logger;
            _studentService = studentService;
        }

        [HttpGet("students")]
        public async Task<IEnumerable<StudentDto>> Get()
        {
            return await _studentService.GetStudents();
        }

        [HttpGet("profiles")]
        public async Task<IEnumerable<StudentProfileDto>> GetProfile()
        {
            return await _studentService.GetStudentProfile();
        }

        [HttpPost("CreateStudentProfile")]
        public async Task<StudentProfileDto> CreateProfile(StudentProfileDto studentProfileDto)
        {
            return await _studentService.CreateStudentProfile(studentProfileDto);
        }
    }
}
