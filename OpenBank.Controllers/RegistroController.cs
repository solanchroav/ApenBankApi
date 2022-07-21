using Microsoft.AspNetCore.Mvc;
using OpenBank.DTOs;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController
    {
        readonly IRegistroInputPort InputPort;
        readonly IRegistroOutputPort OutputPort;

        public RegistroController(IRegistroInputPort inputPort, IRegistroOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<RegistroDTO> CrearRegistro(RegistroDTO registro)
        {
            await InputPort.Handle(registro);
            return ((IPresenter<RegistroDTO>)OutputPort).Content;
        }
    }
}
