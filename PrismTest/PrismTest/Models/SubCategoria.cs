using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismTest.Models
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }
        public string NomeSubCategoria { get; set; }
        public int IdCategoria { get; set; }
        public int Ordem { get; set; }
    }
}
