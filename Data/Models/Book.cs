using System;


namespace Book_Review.Data.Models
{

    //Creating Book Model
    public class Book
    {
           public int Id { get; set; }
           public string Title { get; set; }
           public string Author { get; set; }
           public string Description { get; set; }
           public string Genre { get; set; }
           public  int Rate { get; set; }
           public DateTime DateCreated { get; set; }
    }
}
