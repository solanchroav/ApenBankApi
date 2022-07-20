using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.DTOs
{
    public class TargetaDTO
    {
        public decimal NumeroTarjeta { get; init; }
        public bool Bloqueada { get; init; }
        public int Pin { get; init; }
        public string? FechaNacimiento { get; init; }
        public decimal BalanceTotal { get; init; }
    }
}
