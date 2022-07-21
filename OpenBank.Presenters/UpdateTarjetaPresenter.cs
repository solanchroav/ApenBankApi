using OpenBank.DTOs;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Presenters
{
    public class UpdateTarjetaPresenter : IUpdateTarjetaOutputPort, IPresenter<decimal>
    {
        public decimal Content { get; private set; }

        public Task HandleBloquearTarjeta(decimal numeroTargeta)
        {
            Content = numeroTargeta;
            return Task.CompletedTask;
        }
    }
}