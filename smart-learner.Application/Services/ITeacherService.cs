using smart_learner.Application.DTO;

namespace smart_learner.Application.Services
{
    public interface ITeacherService
    {
        Task<List<TeacherDto>> GetTeachers();
    }
}
