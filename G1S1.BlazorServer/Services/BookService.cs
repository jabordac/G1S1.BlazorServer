using G1S1.BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Services
{
    public class BookService : IBookService
    {
        public async Task<List<Book>> GetAll()
        {
            return new List<Book>
            {
                new Book { BookId = 1, Name = "Libro 1", AuthorId  = 1, Pages = 100, Price = 100.25, PublishDate = DateTime.Parse("01-05-2005"), State = true },
                new Book { BookId = 2, Name = "Libro 2", AuthorId  = 1, Pages = 200, Price = 75, PublishDate = DateTime.Parse("01-05-2005"), State = true },
                new Book { BookId = 3, Name = "Libro 3", AuthorId  = 1, Pages = 50, Price = 25, PublishDate = DateTime.Parse("01-05-2005"), State = false },
            };
        }
    }
}
