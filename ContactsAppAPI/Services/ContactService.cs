

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
        private readonly ICategoryRepository _categoryRepo;

        public ContactService(IContactRepository contactRepo, ICategoryRepository categoryRepo)
        {
            _contactRepo = contactRepo;
            _categoryRepo = categoryRepo;
        }

        public void Create(Contact entity)
        {
            var category = _categoryRepo.GetCategoryById(entity.Category.Id);
            entity.Category = category;
            _contactRepo.CreateContact(entity);
        }

        public void CreateContact(ContactData data)
        {
            Contact contact = new Contact
            {
                Name = data.Name,
                Email = data.Email,
                Password = data.Password,
                Phone = data.Phone,
                DateOfBirth = data.DateOfBirth,
                Category = _categoryRepo.GetCategoryById(data.CategoryId)
            };
            Create(contact);
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
            var contact = await _contactRepo.GetContactWithDetailsByIdAsync(entityId);
            return contact;
        }

        public void Update(Contact entity)
        {
            _contactRepo.UpdateContact(entity);
        }

       
    }
}
