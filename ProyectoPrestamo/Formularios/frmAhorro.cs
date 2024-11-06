using ProyectoPrestamo.Herramientas;
using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modales;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamo.Formularios
{
    public partial class frmAhorro : Form
    {
        public frmAhorro()
        {
            InitializeComponent();
            rbdocumentocliente.Checked = true;
        }

        private void limpiar(bool aplica = true)
        {
            if (aplica)
            {
                txtnrodocumento.Text = "";
            }


            txtidprestamo.Text = "0";


            txtclientenombre.Text = "";
            txtclientetipodocumento.Text = "";
            txtclientedocumento.Text = "";
            txtclientedireccion.Text = "";
            txtclienteciudad.Text = "";
            txtclientecorreo.Text = "";
            txtclientetelefono.Text = "";

            txtmontoprestamo.Text = "";


            txtcuotapagar.Text = "";
            txtfechalimite.Text = "";
            txtimportepagar.Text = "";

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            limpiar(true);
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            string numerooperacion = string.Empty;
            string documentocliente = string.Empty;

            if (txtnrodocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            documentocliente = txtnrodocumento.Text;

            Clientes obj = AhorroLogica.Instancia.BuscarClientePorNumeroDocumento(documentocliente);

            if (obj != null)
            {
                txtidprestamo.Text = obj.IdCliente.ToString();
                txtclientenombre.Text = obj.NombreCompleto;
                txtclientetipodocumento.Text = obj.TipoDocumento;
                txtclientedocumento.Text = obj.NumeroDocumento;
                txtclientedireccion.Text = obj.Direccion;
                txtclienteciudad.Text = obj.Ciudad;
                txtclientecorreo.Text = obj.Correo;
                txtclientetelefono.Text = obj.NumeroTelefono;
            }
            else
            {
                limpiar(false);
                MessageBox.Show("No se encontraron resultados con los datos de búsqueda solicitados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAhorrar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtidprestamo.Text) == 0  || string.IsNullOrWhiteSpace(txtmontoprestamo.Text))
            {
                MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal totalAhorrado = AhorroLogica.Instancia.ObtenerUltimoAhorroPorCliente(Convert.ToInt32(txtidprestamo.Text));




            var selectedOption = (OpcionCombo)cbotipomoneda.SelectedItem;

            string mensaje;

            // Asignar el valor de IdTipoMoneda de forma condicional antes de crear el objeto Ahorro
            TipoMoneda tipoMoneda = null;
            if (selectedOption != null)
            {
                tipoMoneda = new TipoMoneda() { IdTipoMoneda = Convert.ToInt32(selectedOption.Valor) };
            }

            int nrooperaciones = AhorroLogica.Instancia.RegistrarAhorro(new Ahorro()
            {
                IdCliente = Convert.ToInt32(txtidprestamo.Text),
                Monto = Convert.ToDecimal(txtmontoprestamo.Text),
                Fecha = txtfechainicio.Text,
                Multa = 0,
                TotalAhorrado = totalAhorrado + Convert.ToDecimal(txtmontoprestamo.Text),
                Firma = "FIRMA",
                IdTipoMoneda = tipoMoneda .IdTipoMoneda
            }, out mensaje);

            if (nrooperaciones > 0)
            {
                MessageBox.Show("Ahorro registrado con éxito.");
            }
            else
            {
                MessageBox.Show("Error: " + mensaje);
            }




            limpiar(true);
            MessageBox.Show("Se registro el pago correctamente\nPuedes descargar el recibo en \"Historial Ahorro\"", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmAhorro_Load(object sender, EventArgs e)
        {
            String mensaje = string.Empty;
            var listamoneda = TipoMonedaLogica.Instancia.Listar(out mensaje);
            foreach (TipoMoneda item in listamoneda)
            {
                cbotipomoneda.Items.Add(new OpcionCombo() { Valor = item.IdTipoMoneda, Texto = item.Abreviatura });
            }
            cbotipomoneda.DisplayMember = "Texto";
            cbotipomoneda.ValueMember = "Valor";
            cbotipomoneda.SelectedIndex = 0;
        }

        private void btnborrar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
