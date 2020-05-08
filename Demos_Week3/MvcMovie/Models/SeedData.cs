using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Red Dawn",
                        ReleaseDate = DateTime.Parse("1984-1-1"),
                        Genre = "Adventure",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Terminator",
                        ReleaseDate = DateTime.Parse("1983-2-2"),
                        Genre = "Thriller",
                        Rating = "G",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Princess Bride",
                        ReleaseDate = DateTime.Parse("1986-3-3"),
                        Genre = "Romantic Adventure",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Goonies",
                        ReleaseDate = DateTime.Parse("1987-4-4"),
                        Genre = "Adventure",
                        Rating = "G",
                        Price = 9.99M
                    },
                    
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-1-11"),
                        Genre = "Romantic Comedy",
                        Rating = "PG-13",
                        Price = 7.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
