using ASP.Net_Core_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Core_Project.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
    }
}
