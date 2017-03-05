using System.Data.Entity;

namespace ForgingAheadWithASP.NETCore.Models
{
	public class ApplicationDbContext : DbContext
    {
		public DbSet<Character> Characters { get; set; }
    }
}
