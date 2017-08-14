using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pAddAvaluo
    {
        public string action { get; set; }
        public string tipo { get; set; }
        public int pago_catastro { get; set; }
        public string fecha { get; set; }
        public int cto_Avaluo { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public int id_Cliente { get; set; }

        public pAddAvaluo()
        {
            action = "agregar_avaluo";
        }
    };

}

