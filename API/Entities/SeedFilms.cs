namespace API.Entities
{
    public class SeedFilms
    {
          public static Film[] Load() => new Film[] {
            new Film { Id = 1, Title = "A New Hope", EpisodeId = 4 },
            new Film { Id = 2, Title = "The Empire Strikes Back", EpisodeId = 5 },
            new Film { Id = 3, Title = "Return of the Jedi", EpisodeId = 6 },
            new Film { Id = 4, Title = "The Phantom Menace", EpisodeId = 1 },
            new Film { Id = 5, Title = "Attack of the Clones", EpisodeId = 2 },
            new Film { Id = 6, Title = "Revenge of the Sith", EpisodeId = 3 }            
          };
    }
}