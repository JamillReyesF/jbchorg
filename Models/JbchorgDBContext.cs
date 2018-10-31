using Microsoft.EntityFrameworkCore;
using jbchorg.Models;
namespace jbchorg.Models
{
    
	public class JbchorgDBContext : DbContext
    {
        
	public JbchorgDBContext(DbContextOptions<JbchorgDBContext> options) : base(options) {
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<TAsociado>().HasData(
			new TAsociado{
				Id=1,
				Nombre="Asociado Vitalicio"
			},
			new TAsociado{
				Id=2,
				Nombre="Asociado Permanente"
			}
		
		);
	}
        	public DbSet<Mensaje> Mensajes { get; set; }
			public DbSet<Asociado> Asociados { get; set; }
			public DbSet<TAsociado> TAsociados {get;set;}

        
   
}
}