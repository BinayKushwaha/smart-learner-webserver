using Microsoft.EntityFrameworkCore;
using smart_learner.Application.Repository;
using Smart_learner.Domain;

namespace smart_learner.infrastructure.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public TeacherRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Task<List<Teacher>> GetTeachers()
        {
            return _applicationDbContext.Teachers.ToListAsync();
        }
    }
}
