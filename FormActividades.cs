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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClubDeportivoG3
{
    public partial class FormActividades : Form
    {

        public FormActividades()
        {
            InitializeComponent();
            CargarActividades();
        }

        private void CargarActividades()
        {
            try
            {
                // Obtener las actividades desde la base de datos
                List<Actividad> actividades = Actividad.ObtenerActividades();

                // Crear un DataTable para mostrar los resultados, incluyendo idActividad
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("idActividad", typeof(int));  // Añadir idActividad
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Cupos Restantes", typeof(string));
                dataTable.Columns.Add("Día", typeof(string));
                dataTable.Columns.Add("Horario", typeof(string));
                dataTable.Columns.Add("Monto", typeof(decimal));

                // Llenar el DataTable con los datos de las actividades
                foreach (var actividad in actividades)
                {
                    string cuposRestantes = $"{actividad.Cupo - actividad.CupoActual}/{actividad.Cupo}";
                    dataTable.Rows.Add(actividad.Id, actividad.Nombre, cuposRestantes, actividad.Dia, actividad.Horario, actividad.Monto);
                }

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;

                // Ocultar la columna de idActividad
                dataGridView1.Columns["idActividad"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las actividades: " + ex.Message);
            }
        }

        private void AgregarActividad(string nombre, string dia, string horario, decimal monto, int cupo)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_AgregarActividad", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombreActividad", nombre);
                        cmd.Parameters.AddWithValue("diaActividad", dia);
                        cmd.Parameters.AddWithValue("horarioActividad", horario);
                        cmd.Parameters.AddWithValue("montoActividad", monto);
                        cmd.Parameters.AddWithValue("cupoActividad", cupo);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actividad agregada correctamente.");
                        CargarActividades();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar actividad: " + ex.Message);
                }
            }
        }



        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDia.Text) ||
                string.IsNullOrWhiteSpace(txtHorario.Text) || string.IsNullOrWhiteSpace(txtMonto.Text) ||
                string.IsNullOrWhiteSpace(txtCupo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar la actividad.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("El monto debe ser un número decimal válido.");
                return;
            }

            if (!int.TryParse(txtCupo.Text, out int cupo))
            {
                MessageBox.Show("El cupo debe ser un número entero válido.");
                return;
            }

            string nombre = txtNombre.Text;
            string dia = txtDia.Text;
            string horario = txtHorario.Text;

            AgregarActividad(nombre, dia, horario, monto, cupo);
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el id de la actividad seleccionada desde la columna "idActividad"
                int idActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idActividad"].Value);

                // Mostrar un mensaje de confirmación
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta actividad?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                // Si el usuario selecciona "Sí"
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Crear la instancia de la clase Actividad solo con el id
                        Actividad actividad = new Actividad(idActividad, "", 0, 0, "", "", 0);
                        actividad.EliminarActividad(idActividad);

                        MessageBox.Show("Actividad eliminada correctamente.");
                        CargarActividades();  // Recargar las actividades después de la eliminación
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar actividad: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecciona una actividad para eliminar.");
            }
        }

        private void FormActividades_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizarMonto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el id de la actividad seleccionada desde la columna "idActividad"
                int idActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idActividad"].Value);

                // Mostrar el formulario de actualización
                FormActualizarMonto frmActualizarMonto = new FormActualizarMonto();
                frmActualizarMonto.ShowDialog();

                // Verificar si el usuario confirmó la operación
                if (frmActualizarMonto.Confirmado)
                {
                    try
                    {
                        decimal nuevoMonto = frmActualizarMonto.NuevoMonto;

                        // Crear la instancia de la clase Actividad solo con el id
                        Actividad actividad = new Actividad(idActividad, "", 0, 0, "", "", 0);
                        actividad.ActualizarMonto(idActividad, nuevoMonto); // Llamar al método para actualizar el monto

                        // Recargar las actividades para mostrar la actualización
                        CargarActividades();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el monto: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una actividad para actualizar.");
            }
        }
    }
}


