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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace ClubDeportivoG3
{
    public partial class FormAgregarNoSocio : Form
    {
        public FormAgregarNoSocio()
        {
            InitializeComponent();
        }

        private void FormAgregarNoSocio_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void CargarActividades()
        {
            // Crear la lista de actividades
            List<Actividad> listaActividades = Actividad.ObtenerActividades();

            // Crear la opción especial "Ninguna"
            List<Actividad> listaConOpcion = new List<Actividad>();

            // Crear el objeto "Ninguna" con valor -1
            listaConOpcion.Add(new Actividad(-1, "Ninguna", 0, 0, "", "", 0));

            // Añadir todas las actividades existentes
            listaConOpcion.AddRange(listaActividades);

            // Asignar la lista modificada al ComboBox
            cmbActividad.DataSource = listaConOpcion;

            // Configurar el ComboBox para mostrar el nombre y el Id
            cmbActividad.DisplayMember = "Nombre";
            cmbActividad.ValueMember = "Id";

            // Seleccionar la opción Ninguna
            cmbActividad.SelectedIndex = 0;

            // Agregar evento para calcular el pago diario
            cmbActividad.SelectedIndexChanged += CmbActividad_SelectedIndexChanged;
        }

        private void CmbActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActividad.SelectedItem != null)
            {
                Actividad actividadSeleccionada = (Actividad)cmbActividad.SelectedItem;

                // Si se selecciona "Ninguna", establece el pago diario en 0
                if (actividadSeleccionada.Id == -1)
                {
                    nudPagoDiario.Value = 0;
                }
                else
                {
                    // Asignar el monto completo de la actividad
                    decimal pagoDiario = actividadSeleccionada.Monto;

                    // Asignar el valor calculado al NumericUpDown
                    nudPagoDiario.Value = pagoDiario;
                }
            }
        }

        private bool EsEmailValido(string email)
        {
            // Expresión regular para validar el formato de un correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(patronEmail);
            return regex.IsMatch(email);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
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

            // Verificar si el DNI ya existe en la base de datos
            if (Socio.ExisteEnBaseDeDatos(txtDNI.Text))
            {
                MessageBox.Show("El cliente ya existe en la base de datos.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el cliente ya existe
            }


            // Validar que el pago diario sea al menos 5000
            if (nudPagoDiario.Value <= 0)
            {
                MessageBox.Show("Por favor, ingresa un monto válido para el pago diario antes de proceder con la inscripción.", "Pago no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el pago es insuficiente
            }

            // Crea un nuevo no socio con los datos del formulario
            NoSocio noSocio = new NoSocio(
                                       txtNombre.Text,
                                       txtApellido.Text,
                                       txtDNI.Text,
                                       txtMail.Text,
                                       txtTelefono.Text,
                                       chkAptoFisico.Checked,  // Asegurarse de usar el valor de la casilla de verificación
                                       0,
                                       nudPagoDiario.Value
                                        );

            // Llama al método para guardar el no socio en la base de datos
            noSocio.DarAlta();

            // Ahora obtenemos el ID del cliente insertado utilizando LAST_INSERT_ID
            int idCliente = 0;
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();

                // Creamos el comando para obtener el ID del último cliente insertado
                using (MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn))
                {
                    idCliente = Convert.ToInt32(cmd.ExecuteScalar());  // Ejecutamos el comando y obtenemos el ID
                }
            }

            // Guardar el ID de la actividad
            int idActividad = Convert.ToInt32(cmbActividad.SelectedValue);

            // Si la actividad es diferente de "Ninguna" inscribe la actividad
            if (idActividad != -1)
            {
                using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
                {
                    try
                    {
                        connection.Open();

                        // Llamar al procedimiento almacenado para inscribir al cliente en la actividad
                        using (MySqlCommand cmd = new MySqlCommand("InscribirActividad", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Agregar los parámetros necesarios
                            cmd.Parameters.AddWithValue("@p_id_cliente", idCliente); // Suponiendo que `idC` es el ID del cliente
                            cmd.Parameters.AddWithValue("@p_id_actividad", idActividad);

                            // Usamos un DataReader para capturar la salida del procedimiento
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string mensaje = reader.GetString(0); // Obtener el mensaje que retorna el procedimiento
                                    MessageBox.Show(mensaje);
                                }
                            }
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // En caso de que haya un error en la conexión o en la ejecución
                        MessageBox.Show("Error al inscribir al cliente: " + ex.Message);
                    }
                }
            }

            // Mostrar mensaje de confirmación
            MessageBox.Show("El cliente ha sido guardado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario después de guardar y confirma el resultado
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cierra el formulario
        }
    }
}

