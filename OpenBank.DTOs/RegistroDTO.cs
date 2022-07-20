using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.DTOs
{
    public class RegistroDTO
    {
        public int? Id { get; set; }
        public int TarjetaId { get; init; }
        public string? Fecha { get; init; }
        public bool OperacionCodigo { get; init; }
        public decimal CantRetirada { get; init; }

    }
}
