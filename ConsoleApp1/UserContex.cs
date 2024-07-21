using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ConsoleApp1;

public class UserContex:DbContext
{
    DbSet<User> Users { get; set; }
    DbSet<Tags> Tags { get; set; }

    DbSet<Posts> Posts { get; set; }

    public UserContex()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=USERS;Integrated Security=SSPI;");
    }
}
