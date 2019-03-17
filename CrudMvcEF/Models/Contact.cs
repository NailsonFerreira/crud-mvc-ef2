using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Client Client { get; set; }

        public Contact()
        {

        }

        public Contact(int id, string phoneNumber, string email, Client client)
        {
            Id = id;
            PhoneNumber = phoneNumber;
            Email = email;
            Client = client;
        }
    }
}
