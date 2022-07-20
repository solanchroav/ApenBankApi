using OpenBank.DTOs;

namespace OpenBank.UseCasesAbstractions
{
    public interface IRegistroInputPort
    {
        Task Handle(RegistroDTO registro);
    }
}
