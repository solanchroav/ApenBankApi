using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IUpdateTarjetaInputPort
    {
        Task HandleBloquearTarjeta(decimal numeroTargeta);
    }
}
