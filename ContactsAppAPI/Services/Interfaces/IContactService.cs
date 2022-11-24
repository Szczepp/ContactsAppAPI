using ContactsAppAPI.Abstracts;
using ContactsAppAPI.Models;
using Microsoft.Net.Http.Headers;

namespace ContactsAppAPI.Services.Interfaces
{
    public interface IContactService : IServiceBase<Contact>
    {
        public void CreateContact(ContactData data);
    }
}
