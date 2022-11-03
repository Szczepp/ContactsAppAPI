using System;

namespace ContactsAppAPI.Models
{
    public class Contact
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Category { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
