using ClubDeportivoG3.Datos;
using ClubDeportivoG3.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net;
using Font = iTextSharp.text.Font;
using System.Drawing;

namespace ClubDeportivoG3
{
    public partial class FormAgregarSocios : Form
    {



        public FormAgregarSocios()
        {
            InitializeComponent();

            // Poblar el ComboBox de estado de pago
            cmbEstadoPago.Items.Clear(); // Limpiamos el cmb porque hice modificaciones que no se actualizan
            // Nos aseguramos de que solo aparezcan estas dos opciones
            cmbEstadoPago.Items.Add("Pagado");
            cmbEstadoPago.Items.Add("Pendiente");
            cmbEstadoPago.SelectedItem = "Pendiente";
        }


        private void FormAgregarSocios_Load(object sender, EventArgs e)
        {

        }
        private bool EsEmailValido(string email)
        {
            // Expresión regular para validar el formato de un correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(patronEmail);
            return regex.IsMatch(email);
        }

        private static int idContador = 1;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos antes de continuar
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si hay campos vacíos
            }
            
            // Validamos que el socio presente el aptoFisico para poder registrarse
            if (!chkAptoFisico.Checked)
            {
                MessageBox.Show("El cliente no puede ser registrado porque no presenta apto físico.", "Apto físico requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el apto físico no es válido
            }

            // Validar el formato del correo electrónico
            if (!EsEmailValido(txtMail.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el formato no es válido
            }

            // Comprobamos si el DNI ya existe
            if (Socio.ExisteEnBaseDeDatos(txtDNI.Text))
            {
                MessageBox.Show("El cliente con este DNI ya existe en la base de datos.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No continuamos si el DNI ya está registrado, el formulario no se cierra
            }

            // Convertir el valor seleccionado del ComboBox en un booleano
            bool estadoPago = cmbEstadoPago.SelectedItem.ToString() == "Pagado";

            // Crea un nuevo socio con los datos del formulario
            Socio nuevoSocio = new Socio(
                                     txtNombre.Text,
                                     txtApellido.Text,
                                     txtDNI.Text,
                                     txtMail.Text,
                                     txtTelefono.Text,
                                     chkAptoFisico.Checked,
                                     0,
                                     chkCarnetEntrega.Checked,
                                     nudCuotaMensual.Value,
                                     estadoPago // Aquí se asigna el valor del estado de pago
                                          );

            // Llama al método para guardar el socio en la base de datos
            nuevoSocio.DarAlta();

            // Si el socio se guardó correctamente, muestra el mensaje de éxito
            // Nota: DarAlta ya maneja el mensaje si el socio no se pudo guardar por duplicado.
            MessageBox.Show("El socio ha sido guardado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario después de guardar y confirma el resultado
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cierra el formulario
        }

        private void btnEntregarCarnet_Click_1(object sender, EventArgs e)
        {
            // Validar que el socio tenga apto físico y haya pagado
            bool aptoFisico = chkAptoFisico.Checked;
            bool estadoPago = cmbEstadoPago.SelectedItem.ToString() == "Pagado";

            if (!aptoFisico)
            {
                MessageBox.Show("El socio no tiene apto físico para recibir el carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!estadoPago)
            {
                MessageBox.Show("El socio no ha abonado la cuota mensual. No puede recibir el carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear la instancia del socio con los datos del formulario
            Socio socio = new Socio(
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                txtMail.Text,
                txtTelefono.Text,
                aptoFisico,
                0,
                true, // CarnetEntrega marcado como true debido a que se entregará el carnet
                nudCuotaMensual.Value,
                estadoPago);

            // Guardar el socio en la base de datos
            socio.DarAlta();  // Puedes integrar esto si es necesario

            // Generar y guardar el carnet en formato PNG
            try
            {
                Socio.GenerarCarnetImagen(socio); // Llamamos al método estático para generar el carnet en formato PNG
                MessageBox.Show("El socio ha sido guardado exitosamente y el carnet ha sido generado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el carnet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cierra el formulario después de guardar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}

