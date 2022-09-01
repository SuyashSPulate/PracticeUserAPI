using Microsoft.EntityFrameworkCore;
using PracticeUser.Models;

namespace PracticeUser.Data
{
    public class PracticeUserDbContext : DbContext
    {
        public PracticeUserDbContext(DbContextOptions<PracticeUserDbContext> options) : base(options)
        {

        }
        public DbSet<UserDetails> UserDetails { get; set; }
      
    }
}
