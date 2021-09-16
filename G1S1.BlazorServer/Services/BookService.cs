using G1S1.BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Services
{
    public class BookService : IBookService
    {
        private List<Book> _books { get; set; }

        public BookService()
        {
            _books = new List<Book>
            {
                new Book { BookId = Guid.NewGuid(), Name = "Libro 1", AuthorId  = Guid.NewGuid(), Pages = 100, Price = 100.25, PublishDate = DateTime.Parse("01-05-2005"), State = true },
                new Book { BookId = Guid.NewGuid(), Name = "Libro 2", AuthorId  = Guid.NewGuid(), Pages = 200, Price = 75, PublishDate = DateTime.Parse("01-05-2005"), State = true },
                new Book { BookId = Guid.NewGuid(), Name = "Libro 3", AuthorId  = Guid.NewGuid(), Pages = 50, Price = 25, PublishDate = DateTime.Parse("01-05-2005"), State = false },
            };
        }

        public async Task<List<Book>> GetAll()
        {
            return _books;
        }

        public async Task<Book> GetById(Guid bookId)
        {
            return _books.First(x => x.BookId == bookId);
        }

        public async Task<Guid> Set(Book book)
        {
            if(book.BookId == null)
            {
                book.BookId = Guid.NewGuid();
                _books.Add(book);
            }
            else
            {
                var bookToUpdate = _books.First(x => x.BookId == book.BookId);
                bookToUpdate = book;
            }

            return book.BookId.GetValueOrDefault();
        }

    }
}
