public interface ICineFlexDbContext
{
    DbSet<Movie> Movies { get; set; }
    DbSet<Cinema> Cinemas { get; set; }
    int SaveChanges();
}