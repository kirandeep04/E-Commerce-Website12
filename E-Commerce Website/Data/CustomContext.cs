using E_Commerce_Website.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Website.Data
{
    public class CustomContext:DbContext
    {
        public CustomContext(DbContextOptions<CustomContext> option) : base(option) { }
        public DbSet<AdminLogin> AdminLogins { get; set; }
    }
}
