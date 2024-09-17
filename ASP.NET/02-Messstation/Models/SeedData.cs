using _02_Messstation.Data;
using Microsoft.EntityFrameworkCore;

namespace _02_Messstation.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MessstationContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<MessstationContext>>()))
        {
            if (context == null || context.Messstation == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Messstation.Any())
            {
                return; // DB has been seeded
            }
            
            context.Messstation.AddRange(
                new Messstation
                {
                    Id = 1,
                    Name = "Station Alpha",
                    Betriebsdauer = 12
                },
                new Messstation
                {
                    Id = 2,
                    Name = "Station Beta",
                    Betriebsdauer = 8
                },
                new Messstation
                {
                    Id = 3,
                    Name = "Station Gamma",
                    Betriebsdauer = 15
                }
            );
            
            context.Messwert.AddRange(
                new Messwert
                {
                    Id = 1,
                    Wert = 100,
                    Einheit = "Celsius",
                    MessstationId = 1
                },
                new Messwert
                {
                    Id = 2,
                    Wert = 200,
                    Einheit = "Celsius",
                    MessstationId = 2
                },
                new Messwert
                {
                    Id = 3,
                    Wert = 300,
                    Einheit = "Kelvin",
                    MessstationId = 3
                },
                new Messwert
                {
                    Id = 4,
                    Wert = 400,
                    Einheit = "Kelvin",
                    MessstationId = 1
                }
            );

            context.SaveChanges();
        }
    }
}