using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.RepositoryEF.DataContext
{
    class OpenBankContextFactory : IDesignTimeDbContextFactory<OpenBankContext>
    {
        public OpenBankContext CreateDbContext(string[] args)
        {
            var OptionsBuilder = new DbContextOptionsBuilder<OpenBankContext>();
            OptionsBuilder.UseSqlServer("Data Source=DESKTOP-NFM67UE\\MSSQLSERVER1;Initial Catalog=Bank;Integrated Security=true");
            return new OpenBankContext(OptionsBuilder.Options); 
        }
    }
}
