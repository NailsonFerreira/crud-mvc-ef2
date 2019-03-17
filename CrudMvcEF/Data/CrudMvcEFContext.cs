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

        public DbSet<CrudMvcEF.Models.Client> Client { get; set; }
    }
}
