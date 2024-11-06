using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using ProyectoPrestamo.Logica;
using ProyectoPrestamo.Modales;
using ProyectoPrestamo.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrestamo.Formularios
{
    public partial class frmHistorialAhorro : Form
    {
        public frmHistorialAhorro()
        {
            InitializeComponent();
            rbdocumentocliente.Checked = true;
        }

        private void limpiar(bool aplica = true)
        {


            txtidprestamo.Text = "0";


            txtclientenombre.Text = "";
            txtclientetipodocumento.Text = "";
            txtclientedocumento.Text = "";
            txtclientedireccion.Text = "";
            txtclienteciudad.Text = "";
            txtclientecorreo.Text = "";
            txtclientetelefono.Text = "";


            AhorroTotal.Text = "";
            dgvahorro.Rows.Clear();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string numerooperacion = string.Empty;
            string documentocliente = string.Empty;

            if (txtdocumentocliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            documentocliente = txtdocumentocliente.Text;

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

                var dtAhorros = AhorroLogica.Instancia.ObtenerAhorrosPorCliente(obj.IdCliente);
                int ahorro_total = AhorroLogica.Instancia.ObtenerUltimoAhorroPorCliente(obj.IdCliente);
                dgvahorro.Rows.Clear();
                foreach (Ahorro item in dtAhorros)
                {

                    dgvahorro.Rows.Add(new object[] {
                        "",
                        item.Monto.ToString(),
                        item.Fecha.ToString(),
                        item.TotalAhorrado.ToString()
                    });
                }
                dgvahorro.ClearSelection();


                AhorroTotal.Text = ahorro_total.ToString();
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btndescargarresumen_Click(object sender, EventArgs e)
        {
            if (txtidprestamo.Text == "0")
            {
                MessageBox.Show("No se encontraron datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaInformacion.ToString();

            Datos da = DatoLogica.Instancia.Obtener();

            Texto_Html = Texto_Html.Replace("@nrooperacion", lblnrooperacion.Text);
            Texto_Html = Texto_Html.Replace("@nombrerazonsocial", da.RazonSocial);
            Texto_Html = Texto_Html.Replace("@correo", da.Correo);
            Texto_Html = Texto_Html.Replace("@ruc", da.RUC);
            Texto_Html = Texto_Html.Replace("@telefono", da.Telefono);
            Texto_Html = Texto_Html.Replace("@representante", da.Representante);

            Texto_Html = Texto_Html.Replace("@nombrecompleto", txtclientenombre.Text);
            Texto_Html = Texto_Html.Replace("@tipodoc", txtclientetipodocumento.Text);
            Texto_Html = Texto_Html.Replace("@nrodoc", txtclientedocumento.Text);
            Texto_Html = Texto_Html.Replace("@direccion", txtclientedireccion.Text);
            Texto_Html = Texto_Html.Replace("@ciudad", txtclienteciudad.Text);
            Texto_Html = Texto_Html.Replace("@correoc", txtclientecorreo.Text);
            Texto_Html = Texto_Html.Replace("@telefonoc", txtclientetelefono.Text);

            string filasHistorial = string.Empty;
            if (dgvahorro.Rows.Count > 0)
            {
                string filasCuotas = string.Empty;
                String documentocliente = txtdocumentocliente.Text;
                Clientes obj = AhorroLogica.Instancia.BuscarClientePorNumeroDocumento(documentocliente);
                var dtAhorros = AhorroLogica.Instancia.ObtenerAhorrosPorCliente(obj.IdCliente);
                foreach (var cuota in dtAhorros)
                {
                    filasCuotas += "<tr>";
                    filasCuotas += $"<td>{cuota.Monto}</td>";
                    filasCuotas += $"<td>{cuota.Fecha}</td>";
                    filasCuotas += $"<td>{cuota.TotalAhorrado.ToString()}</td>";
                    filasCuotas += "</tr>";
                }
                Texto_Html = Texto_Html.Replace("@filas", filasCuotas);
            }
            else
            {
                Texto_Html = Texto_Html.Replace("@filasHistorialAhorro", "<tr><td colspan='3'>No hay registros</td></tr>");
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Informacion_{0}.pdf", lblnrooperacion.Text);
            savefile.Filter = "Pdf Files|*.pdf";


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteimage = DatoLogica.Instancia.ObtenerLogo(out obtenido);
                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.GetRight(60), pdfDoc.GetTop(60) - 21);
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
