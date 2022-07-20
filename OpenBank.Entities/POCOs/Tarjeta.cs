using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Entities.POCOs
{
    public class Tarjeta
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(16,0)")]
        public decimal NumeroTarjeta { get; set; }
        [Required]
        public bool Bloqueada { get; set; }
        [Required]
        public int Pin { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        [Required]
        [Column(TypeName = "decimal(19,4)")]
        public decimal BalanceTotal { get; set; }
        IEnumerable<Registro> RegistroList { get; set; }
    }
}
