using ContactsAppAPI.Data;
using ContactsAppAPI.Interfaces;
using ContactsAppAPI.Models;
using System.Collections.Generic;
using System.Linq;
using ContactsAppAPI.Repositories.Interfaces;

namespace ContactsAppAPI.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _db;

        public ContactRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddContact(Contact contact)
        {
            _db.Contacts.Add(contact);
            _db.SaveChanges();
        }

        public Contact GetContact(long contactId)
        {
            return _db.Contacts.Find(contactId);
        }

        public List<Contact> GetContacts()
        {
            return _db.Contacts.ToList();
        }

        public void RemoveContact(long contactId)
        {
            var contact = GetContact(contactId);
            _db.Contacts.Remove(contact);
            _db.SaveChanges();
        }

        public void UpdateContact(Contact contact)
        {
            _db.Contacts.Update(contact);
            _db.SaveChanges();
        }
    }
}
