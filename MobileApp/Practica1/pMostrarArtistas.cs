using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Practica1
{
    public class pMostrarClientesPorId
    {
        public string action { get; set; }
        public int id_Cliente { get; set; }

        public pMostrarClientesPorId(int id_Cliente)
        {
            action = "consultar_clientes_por_id";
            this.id_Cliente = id_Cliente;
        }
    }

    public class resultMostrarClientesPorId
    {
        public int id_Cliente { get; set; }
        public string RFC { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string tenencia { get; set; }
        public string reg { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public int cPostal { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
    }

    public class pMostrarClientes
    {
        public string action { get; set; }

        public pMostrarClientes()
        {
            action = "consultar_clientes";
        }
    }

    public class resultMostrarClientes
    {
        public int id_Cliente { get; set; }
        public string RFC { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string tenencia { get; set; }
        public string reg { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public int cPostal { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
    }

    public class pAgregarCliente
    {
        public string action { get; set; }
        public string RFC { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string tenencia { get; set; }
        public string reg { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public int cPostal { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }


        public pAgregarCliente(
            string RFC,
            string nombre,
            string apellido,
            string colonia,
            string municipio,
            string tenencia,
            string reg,
            string manzana,
            string lote,
            int cPostal,
            string telefono,
            string celular
            )
        {
            action = "agregar_cliente";
            this.RFC = RFC;
            this.nombre = nombre;
            this.apellido = apellido;
            this.colonia = colonia;
            this.municipio = municipio;
            this.tenencia = tenencia;
            this.reg = reg;
            this.manzana = manzana;
            this.lote = lote;
            this.cPostal = cPostal;
            this.telefono = telefono;
            this.celular = celular;
        }
    }
    public class pEditarClientes
    {
        public string action { get; set; }
        public int id_Cliente { get; set; }
        public string RFC { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string tenencia { get; set; }
        public string reg { get; set; }
        public string manzana { get; set; }
        public string lote { get; set; }
        public int cPostal { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }


        public pEditarClientes(
            int id_Cliente,
            string RFC,
            string nombre,
            string apellido,
            string colonia,
            string municipio,
            string tenencia,
            string reg,
            string manzana,
            string lote,
            int cPostal,
            string telefono,
            string celular
            )
        {
            action = "editar_cliente";
            this.id_Cliente = id_Cliente;
            this.RFC = RFC;
            this.nombre = nombre;
            this.apellido = apellido;
            this.colonia = colonia;
            this.municipio = municipio;
            this.tenencia = tenencia;
            this.reg = reg;
            this.manzana = manzana;
            this.lote = lote;
            this.cPostal = cPostal;
            this.telefono = telefono;
            this.celular = celular;
        }
    }
}