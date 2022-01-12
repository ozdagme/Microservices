using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Infrastructure
{
    public interface IContactServices
    {
        public ContactDTO GetContactByID(int id);
    }
}
