using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class direcciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [MaxLength(128), MinLength(0), Required]
        public string calle { get; set; }

        [MaxLength(128), MinLength(0), Required]
        public string observasiones { get; set; }

        public long numero { get; set; }

        [ForeignKey("Personas")]

        public virtual int id_Persona { get; set; }

        public Personas personas { get; set; }

    }
}
