using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FN.Store.UI.Models
{
    [Table(nameof(Usuario))]
    public class Usuario : Entity
    {
        [Column(TypeName ="varchar")]
        [Required]
        [StringLength(100)]
        public string Nome{ get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(80)]
        public string Email{ get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [StringLength(50)]
        public string Senha{ get; set; }




    }
}
