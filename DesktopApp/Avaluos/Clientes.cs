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
    public partial class Clientes : MetroForm
    {
        public Clientes()
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
        private void Clientes_Load(object sender, EventArgs e)
        {
            panelMostrarClientes.Show();

           
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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            panelMostrarClientes.Show();
           
        
            MiServicio miServicio = new MiServicio();

            pMCliente parametros = new pMCliente();
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);
            cargarListaCliente(comboBox1);
            //MessageBox.Show(body);
            string res = miServicio.llamarServicio(body);
            string resultados = limpiar(res);

            var canciones = ser.Deserialize<List<resultClientes>>(resultados);


            dgvClientes.DataSource = null;
            dgvClientes.DataSource = canciones;


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AgregarCliente s = new AgregarCliente();
            s.Show();
            

            
        }


        private void metroButton3_Click(object sender, EventArgs e)
        {
            //panelMostrarClientes.Hide();
            EditarCliente s = new EditarCliente();
            s.Show();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio c = new Inicio();
            c.Show();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();
            pDelCliente parametrosUp = new pDelCliente();
            string id = comboBox1.Text.Split(')')[0];
            parametrosUp.id_Cliente = int.Parse(id);
            
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametrosUp);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }
    }
}
