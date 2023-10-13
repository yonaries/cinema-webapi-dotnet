using Microsoft.EntityFrameworkCore;

public class CineFlexDbContext : DbContext, ICineFlexDbContext              
{                                                                               
    public MovieStoreDbContext(DbContextOptions<CineFlexDbContext> options) : base(options)                                                                       
    { }                                                                         
    public DbSet<Movie> Movies { get; set; }                                    
    public DbSet<Cinema> Cinemas { get; set; }                                                      
                                                                                
    public override int SaveChanges()                                           
    {                                                                           
        return base.SaveChanges();                                              
    }                                                                      
}