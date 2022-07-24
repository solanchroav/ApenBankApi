using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenBank.DTOs;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        readonly IRegistroInputPort InputPort;
        readonly IRegistroOutputPort OutputPort;

        public RegistroController(IRegistroInputPort inputPort, IRegistroOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CrearRegistro(RegistroDTO registro)
        {
            try
            {
                await InputPort.Handle(registro);
                return Ok(((IPresenter<RegistroDTO>)OutputPort).Content);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
