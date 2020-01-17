using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjetoFichaAcademia.Dominio.Models
{
    public class CategoriaExercicio
    {
        public int CategoriaExercicioId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório") ]
        public string Nome { get; set; }

        public ICollection<Exercicio> Exercicios { get; set; }
    }
}
