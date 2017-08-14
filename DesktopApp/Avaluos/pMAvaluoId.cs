using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pMAvaluoId
    {
        public int id_Avaluo { get; set; }
        public string action { get; set; }
        //public int gender { get; set; }

        public pMAvaluoId()
        {
            action = "consultar_avaluos_por_id";
        }
    };
    class resultAvaluoId
    {
        //public int id_Avaluo { get; set; }
        public int id_Avaluo { get; set; }
        public string Tipo { get; set; }
        public int PagoCatastro { get; set; }
        public string Fecha { get; set; }
        public int cto_Avaluo { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public int id_Cliente { get; set; }

        public override string ToString()
        {
            return String.Format("{0}): {1} {2} ", id_Avaluo, Tipo, Fecha);
        }

    }
}
