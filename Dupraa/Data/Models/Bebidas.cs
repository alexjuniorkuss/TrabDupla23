using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Bebidas : BaseModel
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public decimal TeorAlcoolico { get; set; }
    }
}
