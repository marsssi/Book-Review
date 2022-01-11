using System;
using Book_Review.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Review.Data
{
    public class AppDbContext:DbContext
    {
        //Config constructor
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }


        //Config Table Authors
        public DbSet<Author> Authors { get; set; }


        //Config Table Books
        public DbSet<Book> Books { get; set; }

    }



}
