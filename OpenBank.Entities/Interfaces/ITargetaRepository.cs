using OpenBank.Entities.POCOs;

namespace OpenBank.Entities.Interfaces
{
    public interface ITargetaRepository
    {
        Task CreateTargeta();
        //Tarjeta GetById(int id);
        Tarjeta? GetByNumeroTarjeta(int numeroTarjeta);
        Tarjeta? GetNumeroPin(int pin);
        void UpdateBloquearTarjeta(int numeroTarjeta);

    }
}
