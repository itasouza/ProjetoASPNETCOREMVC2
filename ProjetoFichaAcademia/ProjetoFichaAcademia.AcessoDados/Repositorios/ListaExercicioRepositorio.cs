using Microsoft.EntityFrameworkCore;
using ProjetoFichaAcademia.AcessoDados.Interfaces;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Repositorios
{
    public class ListaExercicioRepositorio : RepositorioGenerico<ListaExercicio>, IListaExercicioRepositorio
    {
        private readonly Contexto _contexto;

        public ListaExercicioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> ExercicioExisteNaFicha(int exercicioId, int fichaId)
        {
            return await _contexto.ListasExercicios.AnyAsync(e => e.ExercicioId == exercicioId && e.FichaId == fichaId);
        }
    }
}