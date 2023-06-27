using API.Entities;
using API.Entities.SeedData;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions DbContextOptions) : base(DbContextOptions) { }

    public DbSet<Starship> Starships { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Starship[] starships = SeedStarships.Load();
        modelBuilder.Entity<Starship>().Ignore(s => s.Url).HasData(starships);

        Film[] films = SeedFilms.Load();
        modelBuilder.Entity<Film>().Ignore(s => s.Url).HasData(films);

        Person[] people = SeedPeople.Load();
        modelBuilder.Entity<Person>().HasData(people);
    }
}