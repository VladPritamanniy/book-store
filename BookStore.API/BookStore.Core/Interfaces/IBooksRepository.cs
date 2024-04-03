using BookStore.Core.Models;

namespace BookStore.Core.Interfaces
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAll();
        Task<Guid> Create(Book book);
        Task<Guid> Update(Guid id, string title, string description, decimal price);
        Task<Guid> Delete(Guid id);
    }
}
