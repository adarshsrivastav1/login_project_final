
using Microsoft.EntityFrameworkCore;
using login.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace login.Data
{
    public class loginDbContext : IdentityDbContext
    {
        public loginDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserData> UserData { get; set; }
    }

}

