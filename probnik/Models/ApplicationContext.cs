using probnik.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace probnik.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Messages> Messages{ get; set; }
        public DbSet<GroupChat> GroupChat{ get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           //Database.EnsureDeleted();   // удаляем бд со старой схемой
           //Database.EnsureCreated();   // создаем бд с новой схемой
        }
    }
}