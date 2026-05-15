using Smart_learner.Domain.Enums;

namespace Smart_learner.Domain
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ExpertiseLevel Level { get; set; }
        public float Price { get; set; }
    }
}

