using System;

namespace ContactsAppAPI.Models
{
    public class ContactData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long CategoryId { get; set; }
    }
}
