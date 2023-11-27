using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HARDCOREGYM.Models.dbModels
{
    [Table("Compra")]
    public partial class Compra
    {
        public Compra()
        {
            CompraDetalles = new HashSet<CompraDetalle>();
        }

        [Key]
        [Column("IDCompra")]
        public int Idcompra { get; set; }
        [Column("IDUsuario")]
        public int Idusuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaCompra { get; set; }
        public double Total { get; set; }

        [InverseProperty("IdcompraNavigation")]
        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }
    }
}
