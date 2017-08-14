using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pMConcepto
    {
        public string action { get; set; }
        //public int gender { get; set; }
        public int id_Concepto { get; set; }
        public string motivo { get; set; }
        public string ubicacion_predio { get; set; }
        public string localidad { get; set; }
        public string adquiriente { get; set; }
        public string ubicacion { get; set; }
        public string domicilio_notificar { get; set; }
        public string localidad_notificar { get; set; }
        public int no_cuenta { get; set; }
        public string enajenante { get; set; }
        public string fecha { get; set; }
        public int id_Avaluo { get; set; }

        public pMConcepto()
        {
            action = "consultar_conceptos";
        }
    };

    class resultConcepto
    {
        public int id_Concepto { get; set; }
        public string motivo { get; set; }
        public string ubicacion_predio { get; set; }
        public string localidad { get; set; }
        public string adquiriente { get; set; }
        public string ubicacion { get; set; }
        public string domicilio_notificar { get; set; }
        public string localidad_notificar { get; set; }
        public int no_cuenta { get; set; }
        public string enajenante { get; set; }
        public string fecha { get; set; }
        public int id_Avaluo { get; set; }
    }
}
