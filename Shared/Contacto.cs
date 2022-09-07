using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Contacto
    {
        public int ID { get; set; }

        public tipocontacto Tipo { get; set; }

        public string Email { get; set; }

        public string TelefonoLinea { get; set; }

        public string Mobil { get; set; }
    }
}
