using Microsoft.EntityFrameworkCore;
using jbchorg.Models;
namespace jbchorg.Models
{
    
	public class JbchorgDBContext : DbContext
    {
        
	public JbchorgDBContext(DbContextOptions<JbchorgDBContext> options) : base(options) {
}
        	public DbSet<Mensaje> Mensajes { get; set; }
			public DbSet<Asociado> Asociados { get; set; }
			public DbSet<TAsociado> TAsociados {get;set;}

        
   
}
}