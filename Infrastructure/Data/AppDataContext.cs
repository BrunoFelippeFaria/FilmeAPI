using Microsoft.EntityFrameworkCore;

public class AppDataContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=data.db");
    }
}