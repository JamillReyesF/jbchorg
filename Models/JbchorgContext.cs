using Microsoft.EntityFrameworkCore;
namespace jbchorg.Models
{
    
	public class JbchorgContext : DbContext
    {
        
	public JbchorgContext(DbContextOptions<JbchorgContext> options) : base(options) {

}

        	public DbSet<Mensaje> Mensajes { get; set; }
        
   
}
}