using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Web.Script.Serialization;

namespace Avaluos
{
    public partial class EditarCliente : MetroForm
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            cargarListaCliente(cbEditarIdCliente);
        }
        private void cargarListaCliente(ComboBox cbCombo)
        {
            MiServicio miServicio = new MiServicio();

            pMCliente parametros = new pMCliente();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string listaGe = miServicio.llamarServicio(body);
            string resultados = limpiar(listaGe);

            var canciones = ser.Deserialize<List<resultClientes>>(resultados);

            cbCombo.Items.Clear();
            int x = 0;
            string auxGenero = "";
            foreach (resultClientes genero in canciones)
            {
                if (x == 0)
                    auxGenero = genero.ToString();
                cbCombo.Items.Add(genero.ToString());
                x++;
            }
            cbCombo.Text = auxGenero;
        }
        private void metroButton7_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pUpdateCliente parametrosUp = new pUpdateCliente();
            string id = cbEditarIdCliente.Text.Split(')')[0];
            parametrosUp.id_Cliente = int.Parse(id);
            parametrosUp.nombre = txtEdNombreC.Text;
            parametrosUp.apellido = txtEdApellCl.Text;
            parametrosUp.colonia = txtEditColCli.Text;
            parametrosUp.tenencia = txtEdTenCli.Text;
            parametrosUp.manzana = txtEdManzCli.Text;
            parametrosUp.reg = txtEdRegCli.Text;
            parametrosUp.RFC = txtEdRFCL.Text;
            parametrosUp.lote = txtEdLoteCli.Text;
            parametrosUp.cPostal = int.Parse(txtEdcPCli.Text);
            parametrosUp.municipio = txtMunTenCli.Text;
            parametrosUp.telefono = txtEdTelCli.Text;
            parametrosUp.celular = txtEdCelCli.Text;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }
        private void cbEditarIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = cbEditarIdCliente.Text.Split(')')[0];
            //MessageBox.Show(id);

            MiServicio miServicio = new MiServicio();
            pMClienteId parametros = new pMClienteId();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            parametros.id_Cliente = int.Parse(id);
            string body = ser.Serialize(parametros);
            string listaGe = miServicio.llamarServicio(body);
            string resultados = limpiar(listaGe);
            var canciones = ser.Deserialize<List<resultClientes>>(resultados);
            foreach (resultClientes cliente in canciones)
            {
                txtEdNombreC.Text = cliente.Nombre;
                txtEdApellCl.Text = cliente.Apellido;
                txtEditColCli.Text = cliente.Colonia;
                txtEdTenCli.Text = cliente.Tenencia;
                txtEdManzCli.Text = cliente.Manzana;
                txtEdRegCli.Text = cliente.Reg;
                txtEdRFCL.Text = cliente.RFC;
                txtEdLoteCli.Text = cliente.Lote;
                txtEdcPCli.Text = cliente.cPostal.ToString();
                txtMunTenCli.Text = cliente.Municipio;
                txtEdTelCli.Text = cliente.Telefono;
                txtEdCelCli.Text = cliente.Celular;
            }


        }
        private string limpiar(string strResSucio)
        {
            bool leer = false;
            string result = "";
            foreach (char letra in strResSucio)
            {
                if (letra == '[')
                    leer = true;
                if (leer)
                    result += letra;
            }
            return result;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
