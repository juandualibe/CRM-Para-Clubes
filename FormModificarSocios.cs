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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace ClubDeportivoG3
{
    public partial class FormModificarSocios : Form
    {
        private int idCliente;

        public FormModificarSocios(int idCliente)
        {
            InitializeComponent();

            this.idCliente = idCliente;

            // Poblar el ComboBox de estado de pago
            cmbEstadoPago.Items.Clear(); // Limpiamos el cmb porque hice modificaciones que no se actualizan
            // Nos aseguramos de que solo aparezcan estas dos opciones
            cmbEstadoPago.Items.Add("Pagado");
            cmbEstadoPago.Items.Add("Pendiente");
        }

        private void FormModificarSocios_Load(object sender, EventArgs e)
        {
            CargarSocio(this.idCliente);
        }

        private void CargarSocio(int idCliente)
        {
            Socio socio = Socio.BuscarSocio(idCliente);

            if (socio != null)
            {
                // Asignar los datos del socio a los TextBox
                txtId.Text = socio.Id.ToString();
                txtNombre.Text = socio.Nombre;
                txtApellido.Text = socio.Apellido;
                txtDNI.Text = socio.DNI;
                txtMail.Text = socio.Mail;
                txtTelefono.Text = socio.Telefono;
                chkAptoFisico.Checked = socio.AptoFisico;
                nudCuotaMensual.Value = socio.CuotaMensual;
                chkCarnetEntrega.Checked = socio.CarnetEntrega;

                if (socio.EstadoPago)
                {
                    cmbEstadoPago.SelectedItem = "Pagado";
                }
                else
                {
                    cmbEstadoPago.SelectedItem = "Pendiente";
                }
            }
            else
            {
                MessageBox.Show("No se encontró el socio con ese ID.");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private bool EsEmailValido(string email)
        {
            // Expresión regular para validar el formato de un correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(patronEmail);
            return regex.IsMatch(email);
        }

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

            // Validar el formato del correo electrónico
            if (!EsEmailValido(txtMail.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el formato no es válido
            }

            // Convertir el valor seleccionado del ComboBox en un booleano
            bool estadoPago = cmbEstadoPago.SelectedItem.ToString() == "Pagado";

            // Crea un nuevo socio con los datos del formulario
            Socio socioModificado = new Socio(
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

            // Llama al método para modificar el socio en la base de datos
            socioModificado.ModificarSocio(this.idCliente);

            // Mostrar mensaje de confirmación
            MessageBox.Show("El socio ha sido modificado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario después de guardar y confirma el resultado
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cierra el formulario
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }

        private void btnEntregarCarnet_Click(object sender, EventArgs e)
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

            // Crea la instancia del socio con los datos del formulario
            Socio socioModificado = new Socio(
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                txtMail.Text,
                txtTelefono.Text,
                chkAptoFisico.Checked,
                0,
                true, // CarnetEntrega marcado como true debido a que se entregará el carnet
                nudCuotaMensual.Value,
                estadoPago // Aquí se asigna el valor del estado de pago
            );

            // Llama al método para modificar el socio en la base de datos
            socioModificado.ModificarSocio(this.idCliente);

            // Aquí llamas a la función para generar el PDF
            try
            {
                GenerarCarnetImagen(socioModificado);  // Función para generar el PDF (donde se maneja el flujo)

                // Mostrar mensaje de éxito
                MessageBox.Show("El socio ha sido guardado exitosamente y el carnet ha sido generado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Manejar error de generación de carnet
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Cierra el formulario después de guardar
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void GenerarCarnetImagen(Socio socio)
        {
            // Crear instancia del formulario Carnet
            FormCarnet carnet = new FormCarnet();

            // Asignar valores al carnet usando propiedades
            carnet.Nombre = socio.Nombre;
            carnet.Apellido = socio.Apellido;
            carnet.DNI = socio.DNI;
            carnet.Mail = socio.Mail;

            // Mostrar el formulario fuera de pantalla para capturarlo
            carnet.StartPosition = FormStartPosition.Manual;
            carnet.Location = new Point(-2000, -2000); // Ubicación fuera del área visible
            carnet.Show();
            carnet.Refresh();

            // Esperamos a que el formulario se cargue completamente
            System.Threading.Thread.Sleep(500); // Pequeña pausa para asegurarnos de que los controles se actualicen

            // Crear un bitmap del tamaño del formulario
            Bitmap bitmap = new Bitmap(carnet.ClientSize.Width, carnet.ClientSize.Height);  // Usamos el tamaño real del formulario

            // Capturar el contenido del formulario en el bitmap
            carnet.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));

            // Cerrar el formulario una vez capturado
            carnet.Close();

            // Guardar el archivo en la carpeta seleccionada
            string carpetaSeleccionada = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = carpetaSeleccionada;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    carpetaSeleccionada = folderDialog.SelectedPath;
                }
            }

            string filePath = Path.Combine(carpetaSeleccionada, $"{socio.Nombre}_{socio.Apellido}_Carnet.png");

            // Guardar la imagen en formato PNG
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            MessageBox.Show($"Carnet guardado en: {filePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

