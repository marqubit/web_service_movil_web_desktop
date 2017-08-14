using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pUpdateAvaluo
    {
        public string action { get; set; }
        public string tipo { get; set; }
        public int pago_catastro { get; set; }
        public string fecha { get; set; }
        public int cto_Avaluo { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public int id_Cliente { get; set; }
        public int id_Avaluo { get; set; }

        //public int gender { get; set; }

        public pUpdateAvaluo()
        {
            action = "editar_avaluo";
        }
    };

    class resultUplAvaluo
    {
        public int id_Avaluo { get; set; }
        public string Tipo { get; set; }
        public int PagoCatastro { get; set; }
        public int Fecha { get; set; }
        public int cto_Avaluo { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public int id_Cliente { get; set; }


    }
}

