using System;

namespace Book_Review.Data.Models
{

    //Creating Author Model
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }

    }
}


