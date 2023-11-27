using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace HARDCOREGYM.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Carritos = new HashSet<Carrito>();
        }

        public string Nombre { get; set; }
        [StringLength(50)]
        public string Apellido { get; set; } = null!;
        [StringLength(50)]
        public int? Idplan { get; set; }

        [ForeignKey("Idplan")]
        [InverseProperty("Usuarios")]
        public virtual Plan? IdplanNavigation { get; set; }
        
        [InverseProperty("IdusuarioNavigation")]
        public virtual ICollection<Carrito> Carritos { get; set; }
    }
}
