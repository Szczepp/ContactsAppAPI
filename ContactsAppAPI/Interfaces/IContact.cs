using ContactsAppAPI.Models;
using System.Collections.Generic;

namespace ContactsAppAPI.Interfaces
{
    public interface IContact
    {
        public List<Contact> GetContacts();
        public Contact GetContact(long contactId);
        public void AddContact(Contact contact);
        public void UpdateContact(Contact contact);
        public void RemoveContact(long contactId);
    }
}
