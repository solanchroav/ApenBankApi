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
    public class UpdateTarjetaController
    {
        readonly IUpdateTarjetaInputPort InputPort;
        readonly IUpdateTarjetaOutputPort OutputPort;

        public UpdateTarjetaController(IUpdateTarjetaInputPort inputPort, IUpdateTarjetaOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPut]
        public async Task<decimal> GetPinTarjeta(decimal numeroTarjeta)
        {
            await InputPort.HandleBloquearTarjeta(numeroTarjeta);
            return ((IPresenter<decimal>)OutputPort).Content;
        }
    }
}
