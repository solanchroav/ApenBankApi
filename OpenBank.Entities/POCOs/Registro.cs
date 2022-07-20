using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBank.Entities.POCOs
{
    public class Registro
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Tarjeta")]
        public int TarjetaId { get; set; }
        public DateTime Fecha { get; set; }
        public bool OperacionCodigo { get; set; }
        [Required]
        [Column(TypeName = "decimal(19,4)")]
        public decimal CantRetirada { get; set; }
    }
}
