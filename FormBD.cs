using ClubDeportivoG3.Datos;
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
    public partial class FormBD : Form
    {
        public FormBD()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;
            // Guardar credenciales en la instancia de Conexion
            var conexion = Conexion.getInstancia();

            // Verificar si las credenciales son válidas
            if (conexion.ValidarCredenciales(txtServidor.Text, txtPuerto.Text, txtUsuario.Text, txtPassword.Text))
            {
                conexion.SetCredenciales(txtServidor.Text, txtPuerto.Text, txtUsuario.Text, txtPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Limpiar los campos de texto para que el usuario vuelva a ingresar los datos
                txtPassword.Clear();
                txtPassword.Focus(); // Coloca el cursor en el campo de contraseña
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtServidor.Text))
            {
                MessageBox.Show("Debe ingresar un servidor", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServidor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPuerto.Text))
            {
                MessageBox.Show("Debe ingresar un puerto", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPuerto.Focus();
                return false;
            }

            if (!int.TryParse(txtPuerto.Text, out _))
            {
                MessageBox.Show("El puerto debe ser un número", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPuerto.Focus();
                return false;
            }

            return true;
        }
    }
}

 