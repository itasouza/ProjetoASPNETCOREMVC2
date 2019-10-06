using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Models;

namespace ViewModel.ViewModels
{
    public class TodosViewModels
    {
        public IEnumerable<Aluno> Alunos { get; set; }
        public IEnumerable<Materia> Materias { get; set; }
    }
}
