using ALFASOFT.Application.DTOs;
using ALFASOFT.Domain.Entities;
using ALFASOFT.Domain.Interfaces;
using AutoMapper;

namespace ALFASOFT.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactService;
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<bool> CreateAsync(ContactDTO entity)
        {
            var contact = _mapper.Map<Contact>(entity);

            return await _contactService.CreateAsync(contact);
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {

            return await _contactService.DeleteAsync(Id);
        }

        public async Task<IEnumerable<ContactDTO>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<ContactDTO>>(await _contactService.GetAllAsync());
        }

        public async Task<ContactDTO> GetByIdAsync(Guid Id)
        {
            return _mapper.Map<ContactDTO>(await _contactService.GetByIdAsync(Id));
        }

        public async Task<bool> UpdateAsync(ContactDTO entity)
        {
            var contact = _mapper.Map<Contact>(entity);

            return await _contactService.CreateAsync(contact);
        }
    }
}
