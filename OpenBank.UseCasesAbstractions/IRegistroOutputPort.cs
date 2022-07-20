using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IRegistroOutputPort 
    {
        Task Handle(RegistroDTO registro);
    }
}
