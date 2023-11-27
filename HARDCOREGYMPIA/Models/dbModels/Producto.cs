using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HARDCOREGYMPIA.Models.dbModels
{
    [Table("Producto")]
    public partial class Producto
    {
        public Producto()
        {
            Carritos = new HashSet<Carrito>();
            CompraDetalles = new HashSet<CompraDetalle>();
        }

        [Key]
        [Column("IDProducto")]
        public int Idproducto { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        public double Precio { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; } = null!;
        public string? Image { get; set; }

        [InverseProperty("IdproductoNavigation")]
        public virtual ICollection<Carrito> Carritos { get; set; }
        [InverseProperty("IdproductoNavigation")]
        public virtual ICollection<CompraDetalle> CompraDetalles { get; set; }
    }
}
