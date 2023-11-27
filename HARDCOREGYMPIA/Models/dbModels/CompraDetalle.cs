using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HARDCOREGYMPIA.Models.dbModels
{
    [Table("CompraDetalle")]
    public partial class CompraDetalle
    {
        [Key]
        [Column("IDCompra")]
        public int Idcompra { get; set; }
        [Key]
        [Column("IDProducto")]
        public int Idproducto { get; set; }
        public int CantidadProducto { get; set; }
        public double PrecioUnitario { get; set; }

        [ForeignKey("Idcompra")]
        [InverseProperty("CompraDetalles")]
        public virtual Compra IdcompraNavigation { get; set; } = null!;
        [ForeignKey("Idproducto")]
        [InverseProperty("CompraDetalles")]
        public virtual Producto IdproductoNavigation { get; set; } = null!;
    }
}
