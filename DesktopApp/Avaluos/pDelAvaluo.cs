using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pDelAvaluo
    {
        public string action { get; set; }
        //public int gender { get; set; }
        public int id_Avaluo { get; set; }

        public pDelAvaluo()
        {
            action = "eliminar_avaluo";
        }
    };

    class resultDelAvaluo
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

