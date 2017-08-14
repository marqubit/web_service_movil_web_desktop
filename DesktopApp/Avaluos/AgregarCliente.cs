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
    public partial class AgregarCliente : MetroForm
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            MiServicio miServicio = new MiServicio();

            pAddCliente parametros = new pAddCliente();
            //string id = cbEditarIdCliente.Text.Split(')')[0];
            //parametros.id = int.Parse(id);
            parametros.nombre = txtNombreAddCliente.Text;
            parametros.apellido = txtApellidoAddCliente.Text;
            parametros.colonia = txtColoniaAddCliente.Text;
            parametros.tenencia = txtTenenciaAddCliente.Text;
            parametros.manzana = txtManzanaAddCliente.Text;
            parametros.reg = txtRegAddCliente.Text;
            parametros.RFC = txtRFCAddCliente.Text;
            parametros.lote = txtLoteAddCliente.Text;
            parametros.cPostal = int.Parse(txtCPAddCliente.Text);
            parametros.municipio = txtMunicipioAddCliente.Text;
            parametros.telefono = txtTelefonoAddCliente.Text;
            parametros.celular = txtCelularAddCliente.Text;
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string body = ser.Serialize(parametros);

            //MessageBox.Show(body);
            string resultados = miServicio.llamarServicio(body);
            MessageBox.Show(resultados);
        }
    }
}
