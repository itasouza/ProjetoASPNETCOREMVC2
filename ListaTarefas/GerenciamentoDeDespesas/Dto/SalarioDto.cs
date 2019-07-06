using GerenciamentoDeDespesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Dto
{
    public class SalarioDto
    {
        [Key]
        [Required]
        public int SalarioId { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }

        public double Valor { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        public string ValorString { get; set; }
    }
}
