using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HARDCOREGYMPIA.Models.dbModels
{
    [Table("Plan")]
    public partial class Plan
    {
        public Plan()
        {
            Usuarios = new HashSet<ApplicationUser>();
        }

        [Key]
        [Column("IDPlan")]
        public int Idplan { get; set; }
        [StringLength(20)]
        public string NombrePlan { get; set; } = null!;
        public int Precio { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; } = null!;

        [InverseProperty("IdplanNavigation")]
        public virtual ICollection<ApplicationUser> Usuarios { get; set; }
    }
}
