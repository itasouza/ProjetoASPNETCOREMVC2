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

        [Required(ErrorMessage = "Mês e obrigatório")]
        public int MesId { get; set; }

        public Mes Mes { get; set; }

        [Required(ErrorMessage = "Tipo de despesa é obrigatório")]
        public int TipoDeDespesaId { get; set; }
        public TipoDeDespesa TipoDeDespesa { get; set; }

        public double Valor { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor Inválido")]
        public string ValorString { get; set; }
    }
}
