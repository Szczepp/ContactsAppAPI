using ContactsAppAPI.Abstracts;
using ContactsAppAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsAppAPI.Repositories.Interfaces
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
        Task<IEnumerable<Contact>> GetAllContactsAsync();
        Task<Contact> GetContactByIdAsync(long id);
        Task<Contact> GetContactWithDetailsByIdAsync(long id);
        void CreateContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
    }
}
