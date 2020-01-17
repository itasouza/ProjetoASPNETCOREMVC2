using ProjetoFichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFichaAcademia.AcessoDados.Interfaces
{
    public interface IObjetivoRepositorio : IRepositorioGenerico<Objetivo>
    {
        Task<bool> ObjetivoExiste(string Nome);
        Task<bool> ObjetivoExiste(string Nome, int ObjetivoId);
    }
}