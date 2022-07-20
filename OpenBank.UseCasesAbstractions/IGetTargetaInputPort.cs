using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IGetTargetaInputPort
    {
        Task HandleNumeroTarjeta(int targeta);
        Task HandleNumeroPin(int targeta);
    }
}
