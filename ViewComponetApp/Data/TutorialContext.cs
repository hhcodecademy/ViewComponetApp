using Microsoft.EntityFrameworkCore;
using ViewComponetApp.Models;

namespace ViewComponetApp.Data
{
    public class TutorialContext:DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options):base(options) { }

        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
