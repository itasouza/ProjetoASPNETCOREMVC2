﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFichaAcademia.AcessoDados
{
    public class Contexto :DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}
