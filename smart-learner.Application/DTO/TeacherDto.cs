using Smart_learner.Domain.Enums;

namespace smart_learner.Application.DTO
{
    public class TeacherDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ExpertiseLevel Level { get; set; }
        public float Price { get; set; }
    }
}
