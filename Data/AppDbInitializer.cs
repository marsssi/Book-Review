using Book_Review.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Book_Review.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                //Checking if our DB is empty and adding 2 books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "Koha qe do te doja",
                        Author = "Fabio Volo",
                        Description = "Lorem ipsum....",
                        Genre = "Roman",
                        Rate = 4,
                        DateCreated = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "Hamlet",
                        Author = "William Shakespeare",
                        Description = "Lorem ipsum dolores....",
                        Genre = "Tragedy",
                        Rate = 5,
                        DateCreated = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
