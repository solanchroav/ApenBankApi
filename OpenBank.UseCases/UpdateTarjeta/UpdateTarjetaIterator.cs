using OpenBank.DTOs;
using OpenBank.Entities.Interfaces;
using OpenBank.Entities.POCOs;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.UseCases.CreateTargeta
{
    public class UpdateTarjetaIterator : IUpdateTarjetaInputPort
    {
        readonly ITargetaRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly IUpdateTarjetaOutputPort OutputPort;

        public UpdateTarjetaIterator(ITargetaRepository repository, IUnitOfWork unitOfWork, IUpdateTarjetaOutputPort outputPort) => (Repository, UnitOfWork, OutputPort) = (repository, unitOfWork, outputPort);
        //{
        //    Repository = repository;
        //    UnitOfWork = unitOfWork;
        //    OutputPort = outputPort;
        //}

        public async Task<bool> HandleBloquearTarjeta(decimal numeroTarjeta)
        {
            bool response = Repository.UpdateBloquearTarjeta(numeroTarjeta);
            await UnitOfWork.SaveChanges();
            await OutputPort.HandleBloquearTarjeta(numeroTarjeta);
            return response;
        }
    }
}
