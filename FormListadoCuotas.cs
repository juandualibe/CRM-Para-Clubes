using ClubDeportivoG3.Entidades;
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
    public partial class FormListadoCuotas : Form
    {
        public FormListadoCuotas()
        {
            InitializeComponent();
            cargarCuotasVencidas();
        }

        private void cargarCuotasVencidas()
        {
            var listaCuotas = Cuota.ListarCuotas();

            // Asignar los datos al DataGridView
            dataGridViewCuotas.DataSource = listaCuotas;

            // Asegurarse de que las columnas están generadas
            if (dataGridViewCuotas.Columns.Count > 0)
            {
                // Si las columnas existen, podemos configurar el HeaderText
                dataGridViewCuotas.Columns["Id"].HeaderText = "ID Cuota";  // Nombre correcto de la columna
                dataGridViewCuotas.Columns["IdCliente"].HeaderText = "ID Cliente";
                dataGridViewCuotas.Columns["Monto"].HeaderText = "Monto";
                dataGridViewCuotas.Columns["FechaPago"].HeaderText = "Fecha de Pago";
            }

            // Refrescar el DataGridView
            dataGridViewCuotas.Refresh();
        }

        private void FormListadoCuotas_Load(object sender, EventArgs e)
        {

        }

    }
}


