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
    public partial class FormNoSocios : Form
    {
        public FormNoSocios()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewNoSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ListarNoSocios()
        {
            // Obtiene la lista de No Socios desde la base de datos
            dataGridViewNoSocios.DataSource = NoSocio.ListarNoSocios();
        }

        private void btnAgregarNoSocio_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de registro de No Socios
            FormAgregarNoSocio formAgregarNoSocio = new FormAgregarNoSocio();

            // Mostrar el formulario como una ventana modal (bloqueante)
            formAgregarNoSocio.ShowDialog();

            // Después de que el formulario se cierre, actualizamos la lista de No Socios
            ListarNoSocios();
        }



        private void btnEliminarNoSocio_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewNoSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un no socio para dar de baja.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja a este no socio?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente = Convert.ToInt32(dataGridViewNoSocios.SelectedRows[0].Cells["Id"].Value);

            // Creamos una instancia de NoSocio para usar el método DarBaja
            NoSocio noSocio = new NoSocio("nombre", "apellido", "dni", "mail", "telefono", true, idCliente, 0);
            noSocio.DarBaja(idCliente); // Llama al método de baja pasando el id_cliente

            // Actualiza el DataGridView
            ListarNoSocios(); // Método para actualizar la lista
        }

        private void FormNoSocios_Load(object sender, EventArgs e)
        {
            ListarNoSocios();

        }

        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewNoSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un no socio para inscribir.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea inscribir a este no socio?", "Confirmar no socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente1 = Convert.ToInt32(dataGridViewNoSocios.SelectedRows[0].Cells["Id"].Value);
            InscribirActividad gestionInscribir = new InscribirActividad(idCliente1);
            gestionInscribir.ShowDialog();
        }
    }
}
