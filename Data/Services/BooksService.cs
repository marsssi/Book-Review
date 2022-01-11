using Book_Review.Controllers;
using Book_Review.Data.Models;
using Book_Review.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Review.Data.Services
{
    public class BooksService
    {
        //Inject AppDbContext file
        private AppDbContext _context;

        //The Constructor
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //Creating a method for adding books
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                Genre = book.Genre,
                Rate = book.Rate
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
    }

        //Creating a method for listing all books
        public List<Book> GetAllBooks() =>  _context.Books.ToList();


        //Creating a method for listing a book by Id
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(n =>n.Id ==bookId);


        //Creating a method for updating an existing book 
        public Book UpdateBookById(int bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n =>n.Id == bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Author = book.Author;
                _book.Description = book.Description;
                _book.Genre = book.Genre;
                _book.Rate = book.Rate;

                _context.SaveChanges();
            }

            return _book;
            
        }


        //Creating a method for updating an existing book 
        public void DeleteBookById(int bookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.Id == bookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }
    }
}
