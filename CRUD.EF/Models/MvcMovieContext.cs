
using Microsoft.EntityFrameworkCore;
namespace CRUD.EF.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
                  : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
