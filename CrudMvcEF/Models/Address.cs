using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Client Client { get; set; }

        public Address()
        {

        }

        public Address(int id, string streetAddress, string city, string state, Client client)
        {
            Id = id;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Client = client;
        }
    }
}
