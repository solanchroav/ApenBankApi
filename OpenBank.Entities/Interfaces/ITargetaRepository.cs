using OpenBank.Entities.POCOs;

namespace OpenBank.Entities.Interfaces
{
    public interface ITargetaRepository
    {
        Task CreateTargeta();
        //Tarjeta GetById(int id);
        Tarjeta? GetByNumeroTarjeta(decimal numeroTarjeta);
        Tarjeta? GetNumeroPin(int pin);
        bool UpdateBloquearTarjeta(decimal numeroTarjeta);

    }
}
