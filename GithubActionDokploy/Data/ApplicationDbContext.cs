using GithubActionDokploy.Models;
using Microsoft.EntityFrameworkCore;

namespace GithubActionDokploy.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
