using Microsoft.EntityFrameworkCore;

public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { set; get; } = default!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=test.db");   
    }
}