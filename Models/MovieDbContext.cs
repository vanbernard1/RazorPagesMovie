using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext (DbContextOptions<MovieDbContext> options)
			: base(options)
		{
		}
		public DbSet<RazorPagesMovie.Models.Movie> Movie {get; set;}
	}
}
