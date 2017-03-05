using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ForgingAheadWithASP.NETCore.Models
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<Character> Characters { get; set; }
    }
}
