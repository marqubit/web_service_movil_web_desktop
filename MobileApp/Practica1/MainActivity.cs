using Android.App;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Practica1
{
    [Activity(Label = "MTZ Ingenieros", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button mostrarClientes;
        TextView lvClientes;
        Button agregarClientes;
        Button aceptar;
        Button cancelar;
        AutoCompleteTextView acRFC, acNombre, acApellido, acColonia, acMunicipio, acTenencia, acReg, acManzana, acLote, acPostal, acTelefono, acCelular;
        List<string> listaClientes;
        LinearLayout layout2, layout4, layout6, layout8;
        ListView listClientes;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            acRFC = FindViewById<AutoCompleteTextView>(Resource.Id.txtRFC);
            acNombre = FindViewById<AutoCompleteTextView>(Resource.Id.txtNombre);
            acApellido = FindViewById<AutoCompleteTextView>(Resource.Id.txtApellido);
            acColonia = FindViewById<AutoCompleteTextView>(Resource.Id.txtColonia);

            acMunicipio = FindViewById<AutoCompleteTextView>(Resource.Id.txtMunicipio);
            acTenencia = FindViewById<AutoCompleteTextView>(Resource.Id.txtTenencia);
            acReg = FindViewById<AutoCompleteTextView>(Resource.Id.txtReg);
            acManzana = FindViewById<AutoCompleteTextView>(Resource.Id.txtManzana);

            acLote = FindViewById<AutoCompleteTextView>(Resource.Id.txtLote);
            acPostal = FindViewById<AutoCompleteTextView>(Resource.Id.txtCPostal);
            acTelefono = FindViewById<AutoCompleteTextView>(Resource.Id.txtTelefono);
            acCelular = FindViewById<AutoCompleteTextView>(Resource.Id.txtCelular);

            listaClientes = new List<string>();
            mostrarClientes = FindViewById <Button>(Resource.Id.btnMostrarCanciones);
            lvClientes = FindViewById<TextView>(Resource.Id.tvText);
            agregarClientes = FindViewById<Button>(Resource.Id.btnAgregar);
            listClientes = FindViewById<ListView>(Resource.Id.lvArtistas);
            aceptar = FindViewById<Button>(Resource.Id.btnAceptar);
            cancelar = FindViewById<Button>(Resource.Id.btnCancelar);
            layout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            layout4 = FindViewById<LinearLayout>(Resource.Id.linearLayout4);
            layout6 = FindViewById<LinearLayout>(Resource.Id.linearLayout6);
            layout8 = FindViewById<LinearLayout>(Resource.Id.linearLayout8);
            lvClientes.Text = "Bienvenido a la App MTZ ingenieros";
            mostrarClientes.Click += MostrarCanciones_Click;
            agregarClientes.Click += AgregarClientes_Click;
            aceptar.Click += Aceptar_Click;
            cancelar.Click += Cancelar_Click;
        }

        private void Aceptar_Click(object sender, System.EventArgs e)
        {
            servicios miServicio = new servicios();
            pAgregarCliente parametros = new pAgregarCliente(
                    acRFC.Text,
                    acNombre.Text,
                    acApellido.Text,
                    acColonia.Text,

                    acMunicipio.Text,
                    acTenencia.Text,
                    acReg.Text,
                    acManzana.Text,

                    acLote.Text,
                    int.Parse(acPostal.Text),
                    acTelefono.Text,
                    acCelular.Text
                );
            string body = JsonConvert.SerializeObject(parametros);
            string resultadoSucio = miServicio.llamarServicio(body);
            string resultados = sanitizarResultado(resultadoSucio);
            lvClientes.Text = resultados;
            layout2.Alpha = 0;
            layout4.Alpha = 0;
            layout6.Alpha = 0;
            layout8.Alpha = 0;
            mostrarClientes.Alpha = 100;
            agregarClientes.Alpha = 100;
        }

        private void Cancelar_Click(object sender, System.EventArgs e)
        {
            layout2.Alpha = 0;
            layout4.Alpha = 0;
            layout6.Alpha = 0;
            layout8.Alpha = 0;
            mostrarClientes.Alpha = 100;
            agregarClientes.Alpha = 100;
            lvClientes.Text = "Cancelado";
        }

        private void AgregarClientes_Click(object sender, System.EventArgs e)
        {
            layout2.Alpha = 100;
            layout4.Alpha = 100;
            layout6.Alpha = 100;
            layout8.Alpha = 100;
            lvClientes.Text = "Rellena los siguientes datos: ";
            mostrarClientes.Alpha = 0;
            agregarClientes.Alpha = 0;
            listaClientes.Clear();
            listClientes.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemActivated1, listaClientes);

        }

        private void MostrarCanciones_Click(object sender, System.EventArgs e)
        {
            servicios miServicio = new servicios();
            pMostrarClientes parametros = new pMostrarClientes();
            string body = JsonConvert.SerializeObject(parametros);
            string resultadoSucio = miServicio.llamarServicio(body);
            string resultados = sanitizarResultado(resultadoSucio);
            var listResultados = JsonConvert.DeserializeObject<List<resultMostrarClientes>>(resultados);

            //lvClientes.Text = "";
            //int contador = 1;
            foreach (resultMostrarClientes cliente in listResultados)
            {
                //lvClientes.Text += + cliente.id_Cliente + ": " + cliente.nombre + " " + cliente.apellido + "\n";
                string clienteNuevo = string.Format("{0}) {1} {2}", cliente.id_Cliente, cliente. nombre, cliente.apellido);
                listaClientes.Add(clienteNuevo);
                //contador++;
            }
            lvClientes.Text = "Clientes mostrados: ";
            listClientes.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemActivated1, listaClientes);


        }

        private string sanitizarResultado(string strResSucio)
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
    }
}

