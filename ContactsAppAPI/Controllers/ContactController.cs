using ContactsAppAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsAppAPI.Models;
using ContactsAppAPI.Services.Interfaces;

namespace ContactsAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("")]
        public List<Contact> Get()
        {
            var result =  _contactService.GetContacts();
            return result;
        }

        [HttpGet]
        [Route("{contactId}")]
        public Contact Get(long contactId)
        {
            return _contactService.GetContact(contactId);
        }
        [HttpPost]
        [Route("add")]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            _contactService.AddContact(contact);

            return Ok();
        }

        [HttpDelete]
        [Route("remove/{contactId}")]
        public IActionResult RemoveContact(long contactId)
        {
            _contactService.RemoveContact(contactId);

            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateContact([FromBody] Contact contact)
        {
            _contactService.UpdateContact(contact);

            return Ok();
        }
    }
}
