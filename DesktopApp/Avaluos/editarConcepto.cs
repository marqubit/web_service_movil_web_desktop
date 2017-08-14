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
    public partial class editarConcepto : MetroForm
    {
        public editarConcepto()
        {
            InitializeComponent();
        }

        private void editarConcepto_Load(object sender, EventArgs e)
        {
            cargarListaConcepto(cbConcepto);
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
        private void cbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarListaAvaluos(cbAvaluo);
            string id = cbConcepto.Text.Split(')')[0];


            MiServicio miServicio = new MiServicio();
            pMConceptoId parametros = new pMConceptoId();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            parametros.id_Concepto = int.Parse(id);
            string body = ser.Serialize(parametros);
            string listaGe = miServicio.llamarServicio(body);
            string resultados = limpiar(listaGe);
            var conceptos = ser.Deserialize<List<resultConceptoId>>(resultados);
            MessageBox.Show(resultados);
            foreach (resultConceptoId concepto in conceptos)
            {
                //////////////////////////////////
                cbAvaluo.Text = "Concepto Sin Avaluo";
                foreach (string con in cbAvaluo.Items)
                {
                    int idActual = int.Parse(con.Split(')')[0]);
                    if (idActual == concepto.id_Avaluo)
                        cbAvaluo.Text = con;
                }
                txtMotivo.Text = concepto.motivo;
                txtUbiPredio.Text = concepto.ubicacion_predio;
                txtAdquiriente.Text = concepto.adquiriente;
                txtDomNot.Text = concepto.domicilio_notificar;
                txtLocalidad.Text = concepto.localidad_notificar;
                txtNoCuenta.Text = concepto.no_cuenta.ToString();
                int year = int.Parse(concepto.fecha.Split('-')[0]);
                int day = int.Parse(concepto.fecha.Split('-')[2]);
                int month = int.Parse(concepto.fecha.Split('-')[1]);
                DateTime dt = new DateTime(year, month, day);
                dtFecha.Value = dt;
                txtEnajenante.Text = concepto.enajenante;
                txtDom.Text = concepto.ubicacion;



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
        private void cargarListaConcepto(ComboBox cbCombo)
        {
            MiServicio miServicio = new MiServicio();

            pMConcepto parametros = new pMConcepto();
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

        private void metroButton6_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pUpdateConcetp parametrosUp = new pUpdateConcetp();
            string id = cbConcepto.Text.Split(')')[0];
            parametrosUp.motivo = txtMotivo.Text;
            parametrosUp.ubicacion_predio = txtUbiPredio.Text;
            parametrosUp.adquiriente = txtAdquiriente.Text;
            parametrosUp.domicilio_notificar = txtDomNot.Text;
            parametrosUp.localidad_notificar = txtLolNot.Text;
            parametrosUp.no_cuenta = int.Parse(txtNoCuenta.Text);
            parametrosUp.fecha = String.Format("{0}-{1}-{2}", dtFecha.Value.Year,
                dtFecha.Value.Day, dtFecha.Value.Month);
            parametrosUp.enajenante = txtEnajenante.Text;
            parametrosUp.ubicacion = txtDom.Text;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }
    }
}
