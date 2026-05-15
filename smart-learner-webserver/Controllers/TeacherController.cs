using Microsoft.AspNetCore.Mvc;
using smart_learner.Application.DTO;
using smart_learner.Application.Services;
using System.Threading.Tasks;

namespace smart_learner_webserver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;
        private readonly ITeacherService _teacherService;

        public TeacherController(ILogger<TeacherController> logger,
            ITeacherService teacherService)
        {
            _logger = logger;
            _teacherService = teacherService;
        }

        [HttpGet(Name = "GetTeachers")]
        public async Task<IEnumerable<TeacherDto>> Get() 
        {
            return await _teacherService.GetTeachers();
        }
    }
}
