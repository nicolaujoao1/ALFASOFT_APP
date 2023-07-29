using ALFASOFT.Domain.Entities;
using System.Linq.Expressions;

namespace ALFASOFT.Domain.Interfaces
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllAsync(Expression<Func<Contact, bool>> filter = null);
        Task<Contact> GetByIdAsync(Guid Id);
        Task<bool> CreateAsync(Contact entity);
        Task<bool> UpdateAsync(Contact entity);
        Task<bool> DeleteAsync(Contact entity);
    }
}
