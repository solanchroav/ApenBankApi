using Microsoft.AspNetCore.Mvc;
using OpenBank.DTOs;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTargetaController
    {
        readonly IGetTargetaInputPort InputPort;
        readonly IGetTargetaOutputPort OutputPort;

        public GetTargetaController(IGetTargetaInputPort inputPort, IGetTargetaOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpGet("pin/{pin}")]
        public async Task<TargetaDTO> GetPinTarjeta (int pin)
        {
            await InputPort.HandleNumeroPin(pin);
            return ((IPresenter<TargetaDTO>)OutputPort).Content;
        }

        [HttpGet("numeroTarjeta/{numeroTarjeta}")]
        public async Task<TargetaDTO> GetNumeroTarjeta(decimal numeroTarjeta)
        {
            await InputPort.HandleNumeroTarjeta(numeroTarjeta);
            return ((IPresenter<TargetaDTO>)OutputPort).Content;
        }
    }
}