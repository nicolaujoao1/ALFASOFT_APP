﻿using ALFASOFT.Data.Data;
using ALFASOFT.Domain.Entities;
using ALFASOFT.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ALFASOFT.Data.Repositories
{
    public class ContactRepository:IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context) => _context = context;

        public async Task<bool> CreateAsync(Contact entity)
        {
            _context.Add(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Guid Id)
        {
            _context.Contacts.Remove(_context.Contacts.First(c=>c.Id==Id));
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Contact>> GetAllAsync(Expression<Func<Contact, bool>> filter = null)
        {
            var query = _context.Contacts.AsQueryable();

            if (filter != null)
                query = query.Where(filter).AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<Contact> GetByIdAsync(Guid Id) => await _context.Contacts.FirstOrDefaultAsync(u => u.Id == Id);


        public async Task<bool> UpdateAsync(Contact entity)
        {
            _context.Contacts.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
