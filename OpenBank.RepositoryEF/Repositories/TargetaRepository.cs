
using OpenBank.Entities.Interfaces;
using OpenBank.Entities.POCOs;
using OpenBank.RepositoryEF.DataContext;

namespace OpenBank.RepositoryEF.Repositories
{
    public class TargetaRepository : ITargetaRepository
    {
        readonly OpenBankContext OpenBankContext;

        public TargetaRepository(OpenBankContext openBankContext) => OpenBankContext = openBankContext;
       
        public Task CreateTargeta()
        {
            throw new NotImplementedException();
        }

        public Tarjeta? GetByNumeroTarjeta(decimal numeroTarjeta)
        {
            var tarjeta = OpenBankContext.Tarjetas.Where(t => t.NumeroTarjeta == numeroTarjeta).FirstOrDefault();
            return tarjeta;
        }

        public Tarjeta? GetNumeroPin(int pin)
        {
            var tarjeta = OpenBankContext.Tarjetas.Where(t => t.Pin == pin).FirstOrDefault();
            return tarjeta;
        }

        public bool UpdateBloquearTarjeta(decimal numeroTarjeta)
        {
            var tarjeta = OpenBankContext.Tarjetas.Where(t => t.NumeroTarjeta == numeroTarjeta).FirstOrDefault();

            if (tarjeta != null) 
            {
                tarjeta.Bloqueada = true;
                OpenBankContext.Tarjetas.Update(tarjeta);
                return true;
            } else
            {
                return false;
            }

        }
    }
}
