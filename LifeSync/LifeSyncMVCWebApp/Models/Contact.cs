using System;

using System.ComponentModel.DataAnnotations;

namespace LifeSync.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }

    }
}
