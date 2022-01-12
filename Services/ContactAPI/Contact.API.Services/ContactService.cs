using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactServices
    {
        public ContactDTO GetContactByID(int id)
        {
            return new ContactDTO
            {
                Firstname = "Esat",
                Lastname = "Özdağ",
                id = id
            };
        }
    }
}
