using OpenBank.Entities.Interfaces;
using OpenBank.Entities.POCOs;
using OpenBank.RepositoryEF.DataContext;

namespace OpenBank.RepositoryEF.Repositories
{
    public class RegistroRepository : IRegistroRepository
    {
        readonly OpenBankContext OpenBankContext;

        public RegistroRepository(OpenBankContext openBankContext) => OpenBankContext = openBankContext;

        public void PostRegistro(Registro registro)
        {
            OpenBankContext.Registros.Add(registro);
            if (registro.OperacionCodigo)
            {
                var tarjeta = OpenBankContext.Tarjetas.Find(registro.TarjetaId);
                if(tarjeta != null)
                {
                    tarjeta.BalanceTotal = tarjeta.BalanceTotal - registro.CantRetirada;
                    OpenBankContext.Tarjetas.Update(tarjeta);
                }
            }
        }
    }
}
