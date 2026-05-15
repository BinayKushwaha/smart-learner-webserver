using smart_learner.Application.DTO;
using smart_learner.Application.Repository;
using Smart_learner.Domain;
using System.Xml.Xsl;

namespace smart_learner.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentProfileDto> CreateStudentProfile(StudentProfileDto studentProfileDto)
        {
            var studentProfile = await _studentRepository.CreateStudentProfile(new StudentProfile
            {
                Id = studentProfileDto.Id,
                StudentFavourite = studentProfileDto.StudentFavourite
            });
            return studentProfileDto;
        }

        public async Task<List<StudentProfileDto>> GetStudentProfile()
        {
            var studentProfiles = await _studentRepository.GetStudentProfile();
            return studentProfiles.Select(sp => new StudentProfileDto
            {
                Id = sp.Id,
                StudentFavourite = sp.StudentFavourite
            }).ToList();
        }

        public async Task<List<StudentDto>> GetStudents()
        {
            var students = await _studentRepository.GetStudents();
            return students.Select(s => new StudentDto
            {
                Id = s.Id,
                FullName = s.FullName
            }).ToList();
        }
    }
}
