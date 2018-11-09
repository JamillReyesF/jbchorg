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
			modelBuilder.Entity<TAsociado>().HasData
			(new TAsociado{
					Id=1,
					Nombre="Principal",
				},
				new TAsociado{
					Id=2,
					Nombre="Adjunto",
				},
				new TAsociado{
					Id=3,
					Nombre="Invitado",
				}
			);		
		}
	
        public DbSet<Mensaje> Mensaje { get; set; }
		public DbSet<Asociado> Asociados { get; set; }
		public DbSet<TAsociado> TAsociados { get; set; }
		public DbSet<Proyecto> Proyecto { get; set; }
		public DbSet<Donacion> Donacion { get; set; }
		public DbSet<Servicio> Servicio { get; set; }
	}
}