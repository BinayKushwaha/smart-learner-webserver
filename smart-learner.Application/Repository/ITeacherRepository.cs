using Smart_learner.Domain;

namespace smart_learner.Application.Repository
{
    public interface ITeacherRepository
    {
            Task<List<Teacher>> GetTeachers();
    }
}
