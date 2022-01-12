using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Models
{
    public class ContactDTO
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname => $"{Firstname} {Lastname}";
    }
}
