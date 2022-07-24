using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateTarjetaController : ControllerBase
    {
        readonly IUpdateTarjetaInputPort InputPort;
        readonly IUpdateTarjetaOutputPort OutputPort;

        public UpdateTarjetaController(IUpdateTarjetaInputPort inputPort, IUpdateTarjetaOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateBloquearTarjeta(decimal numeroTarjeta)
        {
            try
            {
                bool response = await InputPort.HandleBloquearTarjeta(numeroTarjeta);

                if (!response)
                {
                    return NotFound();
                }
                return Ok(((IPresenter<decimal>)OutputPort).Content);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
