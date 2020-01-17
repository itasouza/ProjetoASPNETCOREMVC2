using Microsoft.EntityFrameworkCore;
using ProjetoFichaAcademia.AcessoDados.Interfaces;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Repositorios
{
    public class CategoriaExercicioRepositorio : RepositorioGenerico<CategoriaExercicio>, ICategoriaExercicioRepositorio
    {
        private readonly Contexto _contexto;

        public CategoriaExercicioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> CategoriaExiste(string categoria)
        {
            return await _contexto.CategoriasExercicios.AnyAsync(ce => ce.Nome == categoria);
        }

        public async Task<bool> CategoriaExiste(string categoria, int CategoriaExercicioId)
        {
            return await _contexto.CategoriasExercicios.AnyAsync(ce => ce.Nome == categoria && ce.CategoriaExercicioId != CategoriaExercicioId);
        }
    }
}