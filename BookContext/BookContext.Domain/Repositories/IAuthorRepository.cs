using System.Threading.Tasks;
using BookContext.Domain.Entities;

namespace BookContext.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> CreateAuthorAsync(Author author);
        Task<Author> UpdateAuthorAsync(Author author);
        Task<Author> DeleteAuthorAsync(Author author);       
    }
}