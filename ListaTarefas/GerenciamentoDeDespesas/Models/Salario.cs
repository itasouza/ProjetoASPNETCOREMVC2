using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Models
{
    public class Salario
    {
        public  int SalarioId  { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public double Valor { get; set; }
    }

}
