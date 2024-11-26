using ClubDeportivoG3.Datos;
using ClubDeportivoG3.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormSocios : Form
    {
        private List<Socio> listaSocios;
        public string NombreUsuario { get; set; }
        public FormSocios()
        {
            InitializeComponent();
            CargarSocios();

        }


        private void CargarSocios()
        {
            dataGridViewSocios.DataSource = Socio.ListarSocios();

        }

        private void btnAgregarSocio_Click_1(object sender, EventArgs e)
        {
            // Abre el formulario para agregar un socio
            FormAgregarSocios agregarSocioForm = new FormAgregarSocios();


            agregarSocioForm.ShowDialog();

            // Después de cerrar el formulario de agregar, recarga la lista de socios
            CargarSocios();
        }

        private void btnModificarSocio_Click_1(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un socio para modificar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente1 = Convert.ToInt32(dataGridViewSocios.SelectedRows[0].Cells["Id"].Value);
            FormModificarSocios gestionModificar = new FormModificarSocios(idCliente1);

            gestionModificar.ShowDialog();

            // Después de cerrar el formulario de modificar, recarga la lista de socios
            CargarSocios();
        }

        private void btnEliminarSocio_Click_1(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un socio para dar de baja.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja a este socio?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente = Convert.ToInt32(dataGridViewSocios.SelectedRows[0].Cells["Id"].Value);

            // Creamos una instancia de Socio para usar el método DarBaja
            Socio socio = new Socio("nombre", "apellido", "dni", "mail", "telefono", true, idCliente, false, 0m, false);
            socio.DarBaja(idCliente); // Llama al método de baja pasando el id_cliente

            // Actualiza el DataGridView
            CargarSocios(); // Método para actualizar la lista
        }



        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un socio para inscribir.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool estadoPago = Convert.ToBoolean(dataGridViewSocios.SelectedRows[0].Cells["EstadoPago"].Value);

            if (!estadoPago)
            {
                MessageBox.Show("No se puede inscribir a este socio porque tiene pagos pendientes.", "Pago pendiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea inscribir a este socio?", "Confirmar socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente1 = Convert.ToInt32(dataGridViewSocios.SelectedRows[0].Cells["Id"].Value);
            InscribirActividad gestionInscribir = new InscribirActividad(idCliente1);
            gestionInscribir.ShowDialog();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un socio para registrar pago.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de que desea registrar pago a este socio?", "Confirmar socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            //
            int idCliente1 = Convert.ToInt32(dataGridViewSocios.SelectedRows[0].Cells["Id"].Value);
            Socio socio = new Socio("nombre", "apellido", "dni", "mail", "telefono", true, idCliente1, false, 0m, false);
            socio.RegistrarPago(idCliente1); // Llama al método de RegistrarPago pasando el id_cliente y monto

            // Después de registrar el pago, recarga la lista de socios
            CargarSocios();
        }

        private void btnCuotasVencidas_Click(object sender, EventArgs e)
        {
            FormListadoCuotas listadoForm = new FormListadoCuotas();


            listadoForm.ShowDialog();
        }

        private void dataGridViewSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSocios_Load(object sender, EventArgs e)
        {

        }

        private void FormSocios_Resize(object sender, EventArgs e)
        {
            // Ajusta el tamaño del DataGridView
            dataGridViewSocios.Width = this.ClientSize.Width; // Restar un margen
            dataGridViewSocios.Height = this.ClientSize.Height - 100; // Restar un margen

            // Ajusta la posición (opcional)
            dataGridViewSocios.Left = 0;  // Margen izquierdo
            dataGridViewSocios.Top = 75;   // Margen superior   
        }
    }
}




