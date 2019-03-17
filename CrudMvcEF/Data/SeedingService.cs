using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMvcEF.Models;


namespace CrudMvcEF.Data
{
    public class SeedingService
    {
        private CrudMvcEFContext _context;

        public SeedingService(CrudMvcEFContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //Verifica se ha dados em
            if (_context.Client.Any() || _context.Contact.Any() || _context.Address.Any())
            {
                return;
            }

            Client c1 = new Client(1, "Joan", "123.456.789-00", "12345678");

            Contact co1 = new Contact(1, "88787795", "Joan@naoJ", c1);

            Address ad1 = new Address(1, "Rua A", "Big City", "Pomadora", c1);

            _context.Client.AddRange(c1);
            _context.Contact.AddRange(co1);
            _context.Address.AddRange(ad1);

            _context.SaveChanges();
        }
    }
}
