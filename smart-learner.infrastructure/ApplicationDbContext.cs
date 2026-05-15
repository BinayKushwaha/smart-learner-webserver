using Microsoft.EntityFrameworkCore;
using Smart_learner.Domain;
using Smart_learner.Domain.Enums;

namespace smart_learner.infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProfile> studentProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Teacher entity
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Level).IsRequired();
                entity.Property(e => e.Price).IsRequired();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(100);
            });


            modelBuilder.Entity<StudentProfile>()
                .OwnsOne(s => s.StudentFavourite, builder =>
                {
                    builder.Property(f => f.StudentId).IsRequired();
                    builder.Property(f => f.TeacherId).IsRequired();
                });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    FullName = "John Doe",
                    Level = ExpertiseLevel.Beginner,
                    Price = 50.0f
                },
                new Teacher
                {
                    Id = 2,
                    FullName = "Jane Smith",
                    Level = ExpertiseLevel.Advanced,
                    Price = 100.0f
                },
                new Teacher
                {
                    Id = 3,
                    FullName = "Alice Johnson",
                    Level = ExpertiseLevel.Beginner,
                    Price = 75.0f
                },
                new Teacher
                {
                    Id = 4,
                    FullName = "Bob Brown",
                    Level = ExpertiseLevel.Advanced,
                    Price = 120.0f
                },
                new Teacher
                {
                    Id = 5,
                    FullName = "Charlie Davis",
                    Level = ExpertiseLevel.Beginner,
                    Price = 60.0f
                },
                new Teacher
                {
                    Id = 6,
                    FullName = "Emily Wilson",
                    Level = ExpertiseLevel.Advanced,
                    Price = 110.0f
                },
                new Teacher
                {
                    Id = 7,
                    FullName = "David Lee",
                    Level = ExpertiseLevel.Beginner,
                    Price = 80.0f
                });

            modelBuilder.Entity<Student>().HasData(new Student
            {
                Id = 1,
                FullName = "Mark William"
            },
            new Student
            {
                Id = 2,
                FullName = "Json Smith"
            },
            new Student
            {
                Id = 3,
                FullName = "John Cena"
            });
        }
    }
}
