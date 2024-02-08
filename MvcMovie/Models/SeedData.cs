using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "golmal",
                    ReleaseDate = DateTime.Parse("2001-22-12"),
                    Genre = "Comedy",
                    Rating = "RAT 1",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "baghbaan",
                    ReleaseDate = DateTime.Parse("2001-22-12"),
                    Genre = "Comedy",
                    Rating = "RAT 2",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "singham",
                    ReleaseDate = DateTime.Parse("2001-22-12"),
                    Genre = "Comedy",
                    Rating = "RAT 3",
                    Price = 3.99M
                },
             
                new Movie
                {
                    Title = "baby",
                    ReleaseDate = DateTime.Parse("2001-22-12"),
                    Genre = "Action",
                    Rating = "RAT 4",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "KGF",
                    ReleaseDate = DateTime.Parse("2001-22-12"),
                    Genre = "Action",
                    Rating = "RAT 5",
                    Price = 3.99M
                }

            );
            context.SaveChanges();
        }
    }
}