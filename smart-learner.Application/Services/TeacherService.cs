using smart_learner.Application.DTO;
using smart_learner.Application.Repository;

namespace smart_learner.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public async Task<List<TeacherDto>> GetTeachers()
        {
            var teachers = await _teacherRepository.GetTeachers();
            return teachers.Select(teacher => new TeacherDto
            {
                FullName = teacher.FullName,
                Id = teacher.Id,
                Level = teacher.Level,
                Price = teacher.Price
            }).ToList();
        }
    }
}
