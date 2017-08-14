using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pUpdateCliente
    {
        public string action { get; set; }
        public int id_Cliente { get; set; }
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
        //public int gender { get; set; }

        public pUpdateCliente()
        {
            action = "editar_cliente";
        }
    };

    class resultUpClientes
    {
        public int id_Cliente { get; set; }
        public string RFC { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Tenencia { get; set; }
        public string Reg { get; set; }
        public string Manzana { get; set; }
        public string Lote { get; set; }
        public int cPostal { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
    }

}

