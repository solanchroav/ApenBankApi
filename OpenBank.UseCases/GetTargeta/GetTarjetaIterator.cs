using OpenBank.DTOs;
using OpenBank.Entities.Interfaces;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.UseCases.GetTargeta
{
    public class GetTarjetaIterator : IGetTargetaInputPort
    {
        readonly ITargetaRepository Repository;
        readonly IGetTargetaOutputPort OutputPort;

        public GetTarjetaIterator(ITargetaRepository repository, IUnitOfWork unitOfWork, IGetTargetaOutputPort outputPort) => (Repository, OutputPort) = (repository, outputPort);

        public async Task<TargetaDTO?> HandleNumeroPin(int targeta)
        {
            var newTarjeta = Repository.GetNumeroPin(targeta);
            TargetaDTO newTarjetaDTO = null;

            if (newTarjeta != null)
            {
                newTarjetaDTO = new TargetaDTO
                {
                    NumeroTarjeta = newTarjeta.NumeroTarjeta,
                    Bloqueada = newTarjeta.Bloqueada,
                    FechaNacimiento = newTarjeta.FechaNacimiento.ToString(),
                    Pin = newTarjeta.Pin,
                    BalanceTotal = newTarjeta.BalanceTotal
                };

                await OutputPort.HandleNumeroPin(newTarjetaDTO);
            }

            return newTarjetaDTO;
        }

        public async Task<TargetaDTO?> HandleNumeroTarjeta(decimal targeta)
        {
            var newTarjeta = Repository.GetByNumeroTarjeta(targeta);
            TargetaDTO newTarjetaDTO = null;

            if (newTarjeta != null)
            {
                newTarjetaDTO = new TargetaDTO
                {
                    NumeroTarjeta = newTarjeta.NumeroTarjeta,
                    Bloqueada = newTarjeta.Bloqueada,
                    FechaNacimiento = newTarjeta.FechaNacimiento.ToString(),
                    Pin = newTarjeta.Pin,
                    BalanceTotal = newTarjeta.BalanceTotal
                };

                await OutputPort.HandleNumeroPin(newTarjetaDTO);
            }
            return newTarjetaDTO;
        }
    }
}
