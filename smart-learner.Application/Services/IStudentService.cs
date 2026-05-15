using smart_learner.Application.DTO;

namespace smart_learner.Application.Services
{
    public interface IStudentService
    {
        Task<List<StudentDto>> GetStudents();
        Task<StudentProfileDto> CreateStudentProfile(StudentProfileDto studentProfileDto);
        Task<List<StudentProfileDto>> GetStudentProfile();
    }
}
