StudentDbContext dbContext = new StudentDbContext();

Student student = new Student();
student.Id = 1;
student.Name = "Sam";
student.Major = "Phy";
dbContext.Students.Add(student);

dbContext.SaveChanges();