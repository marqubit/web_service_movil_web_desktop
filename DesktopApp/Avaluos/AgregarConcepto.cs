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
    public partial class AgregarConcepto : MetroForm
    {
        public AgregarConcepto()
        {
            InitializeComponent();
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
        private void AgregarConcepto_Load(object sender, EventArgs e)
        {
            cargarListaAvaluos(cbAvaluo);
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

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pAddConcepto parametros = new pAddConcepto();
            parametros.motivo = txtMotivo.Text;
            parametros.ubicacion_predio = txtUbicacionPredio.Text;
            parametros.localidad = txtLocalidad.Text;
            parametros.adquiriente = txtAdquiriente.Text;
            parametros.ubicacion = txtUbicacionConcepto.Text;
            parametros.domicilio_notificar = txtDomNot.Text;
            parametros.localidad_notificar = txtLolNot.Text;
            parametros.no_cuenta = int.Parse(txtNoCuenta.Text);
            parametros.enajenante = txtEnajenante.Text;
            string fechita = string.Format("{0}-{1}-{2} ", dtFecha.Value.Year, dtFecha.Value.Day, dtFecha.Value.Month);
            parametros.fecha = fechita;
            string id = cbAvaluo.Text.Split(')')[0];
            parametros.id_Avaluo = int.Parse(id);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            //MessageBox.Show(body);
            string strResSucio = miServicio.llamarServicio(body);
            string resultados = limpiar(strResSucio);
            MessageBox.Show(resultados);

            //MessageBox.Show(String.Format("tp: {0}\n pC: {1}\n f: {2}\n cto: {3}\n st: {4}\n tt: {5}\n cte: {6}\n pC: {7}\n f: {8}\n cto: {9}\n ",
                     //txtUbiPredio.Text, txtLocalidad.Text, fechita, txtAdquiriente.Text, txtDom.Text, txtDomNot.Text,
              //       txtLolNot.Text, txtNoCuenta.Text, txtEnajenante.Text, txtMotivo.Text
//          ));
        }

        private void txtAdquiriente_Click(object sender, EventArgs e)
        {

        }
    }
}
