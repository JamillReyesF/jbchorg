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
<<<<<<< HEAD
=======

>>>>>>> 33f2b9b8763546f7569a406dc2f6454be14c0d8d
   
	}
}