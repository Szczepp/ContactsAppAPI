

using ContactsAppAPI.Repositories.Interfaces;
using ContactsAppAPI.Services.Interfaces;
using ContactsAppAPI.Abstracts;
using ContactsAppAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace ContactsAppAPI.Services
{

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepo;

        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public void Create(Contact entity)
        {
            _contactRepo.CreateContact(entity);
        }

        public async void Delete(long entityId)
        {
            var contact = await this.GetByIdAsync(entityId);
            _contactRepo.Delete(contact);
        }

        public async Task<List<Contact>> GetAllAsync()
        {
            var contacts = await _contactRepo.GetAllContactsAsync();
            return contacts.ToList();
        }

        public IEnumerable<Contact> GetByCondition(Expression<Func<Contact, bool>> expression)
        {
            var contacts =  _contactRepo.GetByCondition(expression).ToList();
            return contacts;
        }

        public async Task<Contact> GetByIdAsync(long entityId)
        {
            var contact = await _contactRepo.GetContactByIdAsync(entityId);
            return contact;
        }

        public void Update(Contact entity)
        {
            _contactRepo.UpdateContact(entity);
        }

       
    }
}
