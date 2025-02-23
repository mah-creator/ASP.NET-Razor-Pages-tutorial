using Microsoft.EntityFrameworkCore;

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students;
}