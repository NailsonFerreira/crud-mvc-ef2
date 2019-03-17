using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudMvcEF.Models
{
    public class CrudMvcEFContext : DbContext
    {
        public CrudMvcEFContext (DbContextOptions<CrudMvcEFContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
