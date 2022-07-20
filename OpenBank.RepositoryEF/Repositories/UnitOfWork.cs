using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenBank.Entities.Interfaces;
using OpenBank.RepositoryEF.DataContext;

namespace OpenBank.RepositoryEF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly OpenBankContext OpenBankContext;
        public UnitOfWork(OpenBankContext openBankContext) => OpenBankContext = openBankContext;

        public async Task<int> SaveChanges()
        {
            try
            {
                return await OpenBankContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
