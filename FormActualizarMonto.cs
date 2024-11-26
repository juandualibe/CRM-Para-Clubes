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
    public partial class FormActualizarMonto : Form
    {
        public decimal NuevoMonto { get; private set; }
        public bool Confirmado { get; private set; }
        public FormActualizarMonto()
        {
            InitializeComponent();
            Confirmado = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar que el monto ingresado sea un número decimal válido
            if (decimal.TryParse(txtNuevoMonto.Text, out decimal nuevoMonto))
            {
                NuevoMonto = nuevoMonto;
                Confirmado = true;
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número decimal válido para el monto.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario sin actualizar
        }

        private void FormActualizarMonto_Load(object sender, EventArgs e)
        {

        }
    }
}

