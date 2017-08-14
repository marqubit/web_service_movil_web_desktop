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
using MetroFramework.Fonts;
using System.Web.Script.Serialization;
namespace Avaluos
{
    public partial class AgregarAvaluo : MetroForm
    {
        public AgregarAvaluo()
        {
            InitializeComponent();
        }

        private void AgregarAvaluo_Load(object sender, EventArgs e)
        {
            cargarListaCliente(cbCliente);
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

        private void metroButton6_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pAddAvaluo parametros = new pAddAvaluo();
            parametros.tipo = cbTipoAvaluo.Text;
            parametros.pago_catastro = int.Parse(txtPagoCatastro.Text);
            string fechita = string.Format("{0}-{1}-{2} ", dtFecha.Value.Year, dtFecha.Value.Day, dtFecha.Value.Month);
            parametros.fecha = fechita;
            parametros.cto_Avaluo = int.Parse(txtctoAvaluo.Text);
            parametros.subtotal = double.Parse(txtSubAvaluo.Text);
            parametros.total = double.Parse(txtTotalAvaluo.Text);
            string id = cbCliente.Text.Split(')')[0];
            parametros.id_Cliente = int.Parse(id);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            //MessageBox.Show(body);
            string strResSucio = miServicio.llamarServicio(body);
            string resultados = limpiar(strResSucio);

            MessageBox.Show(String.Format("tp: {0}\n pC: {1}\n f: {2}\n cto: {3}\n st: {4}\n tt: {5}\n cte: {6}\n",
                cbTipoAvaluo.Text,
                txtPagoCatastro.Text,
                fechita,
                txtctoAvaluo.Text,
                txtSubAvaluo.Text,
                txtTotalAvaluo.Text,
                id));
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AgregarCliente p = new AgregarCliente();
            p.Show();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
