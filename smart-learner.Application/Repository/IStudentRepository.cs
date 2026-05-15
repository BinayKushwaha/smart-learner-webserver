using Smart_learner.Domain;

namespace smart_learner.Application.Repository
{
    public interface IStudentRepository
    {
        Task<Student> CreateStudent(Student student);
        Task<List<Student>> GetStudents();
        Task<StudentProfile> CreateStudentProfile(StudentProfile studentProfile);
        Task<List<StudentProfile>> GetStudentProfile();
    }
}
