using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactsAppAPI.Models;
using ContactsAppAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System;
using System.Net;

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
        public async Task<List<Contact>> Get()
        {
            var result = await _contactService.GetAllAsync();
            return result.ToList();
        }

        //[Authorize]
        [HttpGet]
        [Route("{contactId}")]
        public async Task<Contact> Get(long contactId)
        {
            var contact = await _contactService.GetByIdAsync(contactId);
            return contact;
        }

        //[Authorize]
        [HttpPost]
        [Route("add")]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            try {
                if (contact == null)
                    return BadRequest();
                
                _contactService.Create(contact);

            } catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured while creating new contact");
            }

            return Ok();
        }

        [Authorize]
        [HttpDelete]
        [Route("remove/{contactId}")]
        public IActionResult RemoveContact(long contactId)
        {
            _contactService.Delete(contactId);

            return Ok();
        }

        [Authorize]
        [HttpPut]
        [Route("update")]
        public IActionResult UpdateContact([FromBody] Contact contact)
        {
            try
            {
                if (contact == null)
                    return BadRequest();

                _contactService.Create(contact);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occured while updating the contact");
            }

            return Ok();
        }
    }
}
