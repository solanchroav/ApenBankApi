using OpenBank.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Entities.Interfaces
{
    public interface IRegistroRepository
    {
        void PostRegistro(Registro registro);

    }
}
