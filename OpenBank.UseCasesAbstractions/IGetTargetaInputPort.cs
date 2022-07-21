using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IGetTargetaInputPort
    {
        Task HandleNumeroTarjeta(decimal targeta);
        Task HandleNumeroPin(int targeta);
    }
}
