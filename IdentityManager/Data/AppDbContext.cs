using IdentityManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

    }
}
