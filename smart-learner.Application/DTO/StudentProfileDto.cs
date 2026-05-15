using Smart_learner.Domain;

namespace smart_learner.Application.DTO
{
    public class StudentProfileDto
    {
        public int Id { get; set; }
        public StudentFavourite StudentFavourite { get; set; }
    }
}
