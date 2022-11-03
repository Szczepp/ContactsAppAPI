

using ContactsAppAPI.Repositories.Interfaces;
using ContactsAppAPI.Services.Interfaces;
using ContactsAppAPI.Interfaces;
using ContactsAppAPI.Models;
using System.Collections.Generic;

namespace ContactsAppAPI.Services
{

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepo;

        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }

        public void AddContact(Contact contact)
        {
            _contactRepo.AddContact(contact);
        }

        public Contact GetContact(long contactId)
        {
            return _contactRepo.GetContact(contactId);
        }

        public List<Contact> GetContacts()
        {
            return _contactRepo.GetContacts();
        }

        public void RemoveContact(long contactId)
        {
            _contactRepo.RemoveContact(contactId);
        }

        public void UpdateContact(Contact contact)
        {
            _contactRepo.UpdateContact(contact);
        }
    }
}
