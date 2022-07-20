using Microsoft.AspNetCore.Mvc;
using OpenBank.DTOs;
using OpenBank.Presenters;
using OpenBank.UseCasesAbstractions;

namespace OpenBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateTargetaController
    {
        readonly IGetTargetaInputPort InputPort;
        readonly IGetTargetaOutputPort OutputPort;

        public CreateTargetaController(IGetTargetaInputPort inputPort, IGetTargetaOutputPort outputPort) => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<TargetaDTO> CreateTargeta (CreateTargetaDTO product)
        {
            await InputPort.Handle(product);
            return ((IPresenter<TargetaDTO>)OutputPort).Content;
        }
    }
}