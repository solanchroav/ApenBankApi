using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenBank.DTOs;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTargetaController : ControllerBase
    {
        readonly IGetTargetaInputPort InputPort;
        readonly IGetTargetaOutputPort OutputPort;

        public GetTargetaController(IGetTargetaInputPort inputPort, IGetTargetaOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpGet("pin/{pin}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetPinTarjeta (int pin)
        {
            try
            {
               
                var result = await InputPort.HandleNumeroPin(pin);
               
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(((IPresenter<TargetaDTO>)OutputPort).Content);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpGet("numeroTarjeta/{numeroTarjeta}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetNumeroTarjeta(decimal numeroTarjeta)
        {
            try
            {
                
                var result = await InputPort.HandleNumeroTarjeta(numeroTarjeta);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(((IPresenter<TargetaDTO>)OutputPort).Content);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}