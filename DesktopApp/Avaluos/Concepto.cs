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
    public partial class Concepto : MetroForm
    {
        public Concepto()
        {
            InitializeComponent();
        }

        private void Concepto_Load(object sender, EventArgs e)
        {
            panelMostrarConcepto.Show();
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
            panelMostrarConcepto.Show();
            MiServicio miServicio = new MiServicio();
            cargarListaConcepto(comboBox1);

            pMConcepto parametros = new pMConcepto();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            //MessageBox.Show(body);
            string res = miServicio.llamarServicio(body);
            string resultados = limpiar(res);

            var canciones = ser.Deserialize<List<resultConcepto>>(resultados);


            dgvConcepto.DataSource = null;
            dgvConcepto.DataSource = canciones;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio c = new Inicio();
            c.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AgregarConcepto n = new AgregarConcepto();
            n.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            editarConcepto n = new editarConcepto();
            n.Show();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void metroButton4_Click(object sender, EventArgs e)
        {

            MiServicio miServicio = new MiServicio();
            pDelCOncepto parametrosUp = new pDelCOncepto();
            string id = comboBox1.Text.Split(')')[0];
            parametrosUp.id_Concepto = int.Parse(id);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }
    }
}
