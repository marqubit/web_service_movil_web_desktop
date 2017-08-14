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
    public partial class Avaluos : MetroForm
    {
        public Avaluos()
        {
            InitializeComponent();
        }

        private void Avaluos_Load(object sender, EventArgs e)
        {
            panelMostrarAvaluos.Show();
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
            panelMostrarAvaluos.Show();
            cargarListaAvaluos(comboBox1);
            MiServicio miServicio = new MiServicio();
            pMAvaluo parametros = new pMAvaluo();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);
            //MessageBox.Show(body);
            string res = miServicio.llamarServicio(body);
            string resultados = limpiar(res);
            var canciones = ser.Deserialize<List<resultAvaluo>>(resultados);
            dgvAvaluos.DataSource = null;
            dgvAvaluos.DataSource = canciones;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            AgregarAvaluo n = new AgregarAvaluo();
            n.Show();

        }


        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio c = new Inicio();
            c.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            EditarAvaluo n = new EditarAvaluo();
            n.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pDelAvaluo parametrosUp = new pDelAvaluo();
            string id = comboBox1.Text.Split(')')[0];
            parametrosUp.id_Avaluo = int.Parse(id);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
            
        }
    }
}
