using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions DbContextOptions) : base(DbContextOptions) { }

    public DbSet<Starship> Starships { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.Entity<Starship>()
        //     .Property(e => e.Films)
        //     .HasConversion(
        //         v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
        //         v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
        //         new ValueComparer<ICollection<string>>(
        //             (c1, c2) => c1.SequenceEqual(c2),
        //             c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
        //             c => (ICollection<string>)c.ToList()));
        // modelBuilder.Entity<Starship>()
        //     .Property(e => e.Pilots)
        //     .HasConversion(
        //         v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
        //         v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null),
        //         new ValueComparer<ICollection<string>>(
        //             (c1, c2) => c1.SequenceEqual(c2),
        //             c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
        //             c => (ICollection<string>)c.ToList()));

        Starship[] starships = SeedStarships.Load();
        modelBuilder.Entity<Starship>().Ignore(s => s.Url).HasData(starships);
    }
}