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
    public partial class EditarAvaluo : MetroForm
    {
        public EditarAvaluo()
        {
            InitializeComponent();
        }

        private void EditarAvaluo_Load(object sender, EventArgs e)
        {
            cargarListaAvaluos(cbAvaluoEd);
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
        private void cargarListaAvaluos(ComboBox cbCombo)
        {
            MiServicio miServicio = new MiServicio();

            pMAvaluo parametros = new pMAvaluo();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            string listaGe = miServicio.llamarServicio(body);
            string resultados = limpiar(listaGe);

            var canciones = ser.Deserialize<List<resultAvaluo>>(resultados);

            cbCombo.Items.Clear();
            int x = 0;
            string auxGenero = "";
            foreach (resultAvaluo genero in canciones)
            {
                if (x == 0)
                    auxGenero = genero.ToString();
                cbCombo.Items.Add(genero.ToString());
                x++;
            }
            cbCombo.Text = auxGenero;
        }
        private void cbAvaluo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarListaCliente(cbClienteEd);
            string id = cbAvaluoEd.Text.Split(')')[0];
            

            MiServicio miServicio = new MiServicio();
            pMAvaluoId parametros = new pMAvaluoId();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            parametros.id_Avaluo = int.Parse(id);
            string body = ser.Serialize(parametros);
            string listaGe = miServicio.llamarServicio(body);
            string resultados = limpiar(listaGe);
            var ava = ser.Deserialize<List<resultAvaluoId>>(resultados);
            MessageBox.Show(resultados);
            foreach (resultAvaluoId avaluo in ava)
            {
                //////////////////////////////////
                cbClienteEd.Text = "Avaluo Sin Cliente";
                foreach (string cliente in cbClienteEd.Items)
                {
                    int idActual = int.Parse(cliente.Split(')')[0]);
                    if (idActual == avaluo.id_Cliente)
                        cbClienteEd.Text = cliente;
                }
                
                cbTipoAvaluoEd.Text = avaluo.Tipo;
                txtPagoCatastroEd.Text = avaluo.PagoCatastro.ToString();
                int year = int.Parse(avaluo.Fecha.Split('-')[0]);
                int month = int.Parse(avaluo.Fecha.Split('-')[2]);
                int day = int.Parse(avaluo.Fecha.Split('-')[1]);
                DateTime dt = new DateTime(year, month, day);
                dtFechaEd.Value = dt;
                txtctoAvaluoEd.Text = avaluo.cto_Avaluo.ToString();
                txtSubAvaluoEd.Text = avaluo.Subtotal.ToString();
                txtTotalAvaluoEd.Text = avaluo.Total.ToString();
            }
        }
        //Boton de Actualizar clickeado
        private void metroButton6_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pUpdateAvaluo parametrosUp = new pUpdateAvaluo();
            string id = cbAvaluoEd.Text.Split(')')[0];
            parametrosUp.id_Avaluo = int.Parse(id);
            parametrosUp.id_Cliente = int.Parse(cbClienteEd.Text.Split(')')[0]);
            parametrosUp.tipo = cbTipoAvaluoEd.Text;
            parametrosUp.pago_catastro = int.Parse(txtPagoCatastroEd.Text);
            parametrosUp.subtotal = int.Parse(txtSubAvaluoEd.Text);
            parametrosUp.total = int.Parse(txtTotalAvaluoEd.Text);
            parametrosUp.cto_Avaluo = int.Parse(txtctoAvaluoEd.Text);
            parametrosUp.fecha = String.Format("{0}-{1}-{2}", dtFechaEd.Value.Year, 
                dtFechaEd.Value.Day, dtFechaEd.Value.Month);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }

        private void cbClienteEd_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("soy el cbCliente y tambien cambie");
        }

        private void dtFechaEd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
