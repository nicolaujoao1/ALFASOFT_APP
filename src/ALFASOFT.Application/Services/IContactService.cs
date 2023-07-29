using ALFASOFT.Application.DTOs;

namespace ALFASOFT.Application.Services;

public interface IContactService
{
    Task<IEnumerable<ContactDTO>> GetAllAsync();
    Task<ContactDTO> GetByIdAsync(Guid Id);
    Task<bool> CreateAsync(ContactDTO entity);
    Task<bool> UpdateAsync(ContactDTO entity);
    Task<bool> DeleteAsync(Guid Id);
}
