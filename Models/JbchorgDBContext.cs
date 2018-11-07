using Microsoft.EntityFrameworkCore;
using jbchorg.Models;
namespace jbchorg.Models
{
    
	public class JbchorgDBContext : DbContext
    {
        
		public JbchorgDBContext(DbContextOptions<JbchorgDBContext> options) : base(options) {
		}
	
        public DbSet<Mensaje> Mensaje { get; set; }
		public DbSet<Asociado> Asociado { get; set; }
		public DbSet<Proyecto> Proyecto { get; set; }
		
		public DbSet<Donacion> Donacion { get; set; }
	}
}