using GerenciamentoDeDespesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Dto
{
    public class DespesaDto
    {
        [Key]
        [Required]
        public int DespesaId { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public int TipoDeDespesaId { get; set; }
        public TipoDeDespesa TipoDeDespesa { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor inválido")]
        public double Valor { get; set; }
    }
}
