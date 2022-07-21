using OpenBank.DTOs;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Presenters
{
    public class GetTarjetaPresenter : IGetTargetaOutputPort, IPresenter<TargetaDTO>
    {
        public TargetaDTO Content { get; private set; }

        public Task HandleNumeroPin(TargetaDTO targeta)
        {
            Content = targeta;
            return Task.CompletedTask;
        }

        public Task HandleNumeroTarjeta(TargetaDTO targeta)
        {
            Content = targeta;
            return Task.CompletedTask;
        }
    }
}
