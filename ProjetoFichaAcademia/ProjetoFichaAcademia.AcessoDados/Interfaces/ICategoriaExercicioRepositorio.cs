using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Interfaces
{
    public interface ICategoriaExercicioRepositorio : IRepositorioGenerico<CategoriaExercicio>
    {
        Task<bool> CategoriaExiste(string categoria);
        Task<bool> CategoriaExiste(string categoria, int CategoriaExercicioId);
    }
}