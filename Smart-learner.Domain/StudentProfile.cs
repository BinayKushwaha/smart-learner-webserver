namespace Smart_learner.Domain
{
    public class StudentProfile
    {
        public int Id { get; set; }
        public StudentFavourite StudentFavourite { get; set; }
}

    public class StudentFavourite
    {
        public int StudentId { get; set; }
            public  int TeacherId { get; set; }
    }
}
