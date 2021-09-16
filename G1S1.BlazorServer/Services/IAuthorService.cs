using G1S1.BlazorServer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Services
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAll();
    }
}
