using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEF.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>();

        public Client()
        {

        }

        public Client(int id, string name, string cpf, string rg)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Rg = rg;
        }

        public void AddAddress(Address address)
        {
            Addresses.Add(address);
        }

        public void RemoveAddress(Address address)
        {
            Addresses.Remove(address);
        }
    }
}
