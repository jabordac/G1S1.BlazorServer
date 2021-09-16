using G1S1.BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Services
{
    public class AuthorService : IAuthorService
    {
        private List<Author> _authors { get; set; }

        public AuthorService()
        {
            _authors = new List<Author>
            {
                new Author { AuthorId = Guid.NewGuid(), Name = "Chris Sainty" },
                new Author { AuthorId = Guid.NewGuid(), Name = "Gabriel García Márquez" },
                new Author { AuthorId = Guid.NewGuid(), Name = "Paul Deitel" },
                new Author { AuthorId = Guid.NewGuid(), Name = "Julio Verne" },
                new Author { AuthorId = Guid.NewGuid(), Name = "Paul Bradbury" },
            };
        }

        public async Task<List<Author>> GetAll()
        {
            return _authors;
        }
    }
}
