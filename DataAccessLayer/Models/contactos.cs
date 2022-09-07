using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class contactos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id_Contactos { get; set; }

        [MaxLength(128), MinLength(0), Required]
        public string Email { get; set; }

        [MaxLength(128), MinLength(0), Required]
        public string TelefonoLinea { get; set; }

        [MaxLength(128), MinLength(0), Required]
        public string Mobil { get; set; }

        [ForeignKey("TiposdeContactos")]

        public virtual int id{ get; set; }

        public TiposdeContactos Tipo { get; set; }


    }
}
