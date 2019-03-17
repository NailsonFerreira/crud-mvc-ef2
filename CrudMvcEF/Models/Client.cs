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
    }
}
