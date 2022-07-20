using OpenBank.DTOs;
using OpenBank.Entities.Interfaces;
using OpenBank.Entities.POCOs;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.UseCases.CreateRegistro
{
    public class RegistroIterator : IRegistroInputPort
    {

        readonly IRegistroRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly IRegistroOutputPort OutputPort;

        public RegistroIterator(IRegistroRepository repository, IUnitOfWork unitOfWork, IRegistroOutputPort outputPort) => (Repository, UnitOfWork, OutputPort) = (repository, unitOfWork, outputPort);
        public async Task Handle(RegistroDTO registro)
        {
            Registro newRegistro = new Registro
            {
                TarjetaId = registro.TarjetaId,
                Fecha = DateTime.Now,
                CantRetirada = registro.CantRetirada,
                OperacionCodigo = registro.OperacionCodigo
            };
            Repository.PostRegistro(newRegistro);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new RegistroDTO
            {
                Id = newRegistro.Id,
                TarjetaId = newRegistro.TarjetaId,
                Fecha = newRegistro.Fecha.ToString(),
                CantRetirada = newRegistro.CantRetirada,
                OperacionCodigo = newRegistro.OperacionCodigo
            });
        }
    }
}
