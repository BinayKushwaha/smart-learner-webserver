using Microsoft.EntityFrameworkCore;
using smart_learner.Application.Repository;
using Smart_learner.Domain;

namespace smart_learner.infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Student> CreateStudent(Student student)
        {
            _applicationDbContext.Students.Add(student);
            await _applicationDbContext.SaveChangesAsync();
            return student;

        }

        public async Task<StudentProfile> CreateStudentProfile(StudentProfile studentProfile)
        {
            _applicationDbContext.studentProfiles.Add(studentProfile);
            await _applicationDbContext.SaveChangesAsync();
            return studentProfile;
        }

        public async Task<List<StudentProfile>> GetStudentProfile()
        {
            return await _applicationDbContext.studentProfiles.ToListAsync();
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _applicationDbContext.Students.ToListAsync();
        }
    }
}
