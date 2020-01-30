using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AluguelCarro.Models
{
    public class Context : IdentityDbContext
    {


        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
}
