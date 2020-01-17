using Microsoft.EntityFrameworkCore;
using ProjetoFichaAcademia.AcessoDados.Interfaces;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Repositorios
{
    public class ProfessorRepositorio : RepositorioGenerico<Professor>, IProfessorRepositorio
    {
        private readonly Contexto _contexto;

        public ProfessorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> ProfessorExiste(string Nome)
        {
            return await _contexto.Professores.AnyAsync(p => p.Nome == Nome);
        }

        public async Task<bool> ProfessorExiste(string Nome, int ProfessorId)
        {
            return await _contexto.Professores.AnyAsync(p => p.Nome == Nome && p.ProfessorId != ProfessorId);
        }
    }
}