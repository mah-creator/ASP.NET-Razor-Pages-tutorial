using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { set; get; } = default!;
    
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
    }
}

class StudentDbContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
{
    public StudentDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<StudentDbContext> optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
        optionsBuilder.UseSqlite("Data source=test2.db");
        return new StudentDbContext(optionsBuilder.Options);
    }
}