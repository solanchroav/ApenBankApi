using OpenBank.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.UseCasesAbstractions
{
    public interface IGetTargetaOutputPort
    {
        Task HandleNumeroTarjeta(TargetaDTO targeta);
        Task HandleNumeroPin(TargetaDTO targeta);
    }
}
