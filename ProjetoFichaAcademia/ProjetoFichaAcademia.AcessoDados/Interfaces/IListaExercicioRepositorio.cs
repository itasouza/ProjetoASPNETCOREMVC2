using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Interfaces
{
    public interface IListaExercicioRepositorio : IRepositorioGenerico<ListaExercicio>
    {
        Task<bool> ExercicioExisteNaFicha(int exercicioId, int fichaId);
    }
}