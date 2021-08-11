using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Lanches : BaseModel
    {
        public string Tipo { get; set; }
        public int QtdItens { get; set; }
        public decimal Valor { get; set; }
    }
}
