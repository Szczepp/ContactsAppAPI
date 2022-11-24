using ContactsAppAPI.Data;
using ContactsAppAPI.Models;
using System.Collections.Generic;
using System.Linq;
using ContactsAppAPI.Repositories.Interfaces;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;
using ContactsAppAPI.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace ContactsAppAPI.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<Contact> GetContactByIdAsync(long id)
        {
            return await GetByCondition(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Contact> GetContactWithDetailsByIdAsync(long id)
        {
            return await GetByCondition(c => c.Id == id)
                .Include(c => c.Category) 
                .FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            return await GetAll()
                .OrderBy(c => c.Id)
                .ToListAsync();
        }
        public void CreateContact(Contact contact)
        {
            Create(contact);
        }

        public void DeleteContact(Contact contact)
        {
            Delete(contact);
        }

        public void UpdateContact(Contact contact)
        {
            Update(contact);
        }
    }
}
