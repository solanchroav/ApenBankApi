using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IGetTargetaInputPort
    {
        Task<TargetaDTO?> HandleNumeroTarjeta(decimal targeta);
        Task<TargetaDTO?> HandleNumeroPin(int targeta);
    }
}
