using OpenBank.DTOs;
using OpenBank.UseCasesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Presenters
{
    public class RegistroPresenter : IRegistroOutputPort, IPresenter<RegistroDTO>
    {
        public RegistroDTO Content { get; private set; }

        public Task Handle(RegistroDTO registro)
        {
            Content = registro;
            return Task.CompletedTask;
        }
    }
}
