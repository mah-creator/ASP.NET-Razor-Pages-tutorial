using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

DbContextOptionsBuilder<StudentDbContext> optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
optionsBuilder.UseSqlite("Data source=test2.db");

StudentDbContext dbContext = new StudentDbContext(optionsBuilder.Options);

Student student = new Student();
student.Id = 1;
student.Name = "Sam";
student.Major = "Physics";
dbContext.Students.Add(student);

dbContext.SaveChanges();