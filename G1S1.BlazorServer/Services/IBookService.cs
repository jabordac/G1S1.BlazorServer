using G1S1.BlazorServer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAll();
    }
}
