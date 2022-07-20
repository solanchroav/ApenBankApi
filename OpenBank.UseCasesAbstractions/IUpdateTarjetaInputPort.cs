using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IUpdateTarjetaInputPort
    {
        Task HandleBloquearTarjeta(int numeroTargeta);
    }
}
