using Microsoft.EntityFrameworkCore;
using OpenBank.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.RepositoryEF.DataContext
{
    public class OpenBankContext : DbContext
    {
        public OpenBankContext(DbContextOptions<OpenBankContext> options) : base (options) { }

        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Registro> Registros { get; set; }

    }
}
