using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pAddCliente
    {
        public string action { get; set; }
        public string RFC { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string tenencia { get; set; }
        public string reg { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public int cPostal { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }

        public pAddCliente()
        {
            action = "agregar_cliente";
        }
    };

}

