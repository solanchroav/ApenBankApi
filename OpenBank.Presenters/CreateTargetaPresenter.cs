using OpenBank.DTOs;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Presenters
{
    public class CreateTargetaPresenter : IGetTargetaOutputPort, IPresenter<TargetaDTO>
    {
        public TargetaDTO Content { get; private set; }

        public Task Handle(TargetaDTO targeta)
        {
            Content = targeta;
            return Task.CompletedTask;
        }
    }
}