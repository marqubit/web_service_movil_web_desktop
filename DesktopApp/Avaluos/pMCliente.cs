using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class pMCliente
    {
        public string action { get; set; }
        //public int gender { get; set; }

        public pMCliente()
        {
            action = "consultar_clientes";
        }
    };

    class resultClientes
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
        public override string ToString()
        {
            return String.Format("{0}): {1} {2} ", id_Cliente, Nombre, Apellido);
        }
    }

}

