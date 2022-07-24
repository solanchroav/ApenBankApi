using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IUpdateTarjetaInputPort
    {
        Task<bool> HandleBloquearTarjeta(decimal numeroTargeta);
    }
}
