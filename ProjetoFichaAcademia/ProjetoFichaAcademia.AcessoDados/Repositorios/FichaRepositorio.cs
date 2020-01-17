using Microsoft.EntityFrameworkCore;
using ProjetoFichaAcademia.AcessoDados.Interfaces;
using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Repositorios
{
    public class FichaRepositorio : RepositorioGenerico<Ficha>, IFichaRepositorio
    {
        public readonly Contexto _contexto;

        public FichaRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> FichaExiste(string Nome)
        {
            return await _contexto.Fichas.AnyAsync(f => f.Nome == Nome);
        }

        public async Task<bool> FichaExiste(string Nome, int FichaId)
        {
            return await _contexto.Fichas.AnyAsync(f => f.Nome == Nome && f.FichaId != FichaId);
        }

        public async Task<Ficha> PegarFichaAlunoPeloId(int id)
        {
            return await _contexto.Fichas.Include(f => f.Aluno).FirstOrDefaultAsync(f => f.FichaId == id);
        }

        public async Task<IEnumerable<Ficha>> PegarTodasFichasPeloAlunoId(int id)
        {
            return await _contexto.Fichas.Include(f => f.Aluno).ThenInclude(f => f.Objetivo).Where(f => f.AlunoId == id).ToListAsync();
        }
    }
}