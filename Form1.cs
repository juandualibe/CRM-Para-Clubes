using System.Data;

namespace ClubDeportivoG3
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            //this.Shown += Form1_Shown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //// Crear una instancia de FormBD
            //var DBForm = new FormBD();
            //// Mostrar el formulario de login como un cuadro de diálogo modal
            //DBForm.StartPosition = FormStartPosition.CenterParent;
            //DBForm.ShowDialog();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Crear una instancia de FormBD
            var DBForm = new FormBD();
            // Mostrar el formulario de login como un cuadro de diálogo modal
            DBForm.StartPosition = FormStartPosition.CenterParent;
            DBForm.ShowDialog();

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPassword.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el  usuario EXISTE
                MessageBox.Show("Ingreso exitoso", "Confirmación de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Pedir credenciales de la BBDD
                this.Form1_Shown(sender, e);

                OpcionesForm nuevoFormulario = new OpcionesForm(); // Crear instancia del segundo form
                nuevoFormulario.NombreUsuario = txtUsuario.Text; // Asigna el nombre del usuario a la propiedad NombreUsuario del formulario OpcionesForm

                nuevoFormulario.Show(); // Mostrar el nuevo form
            }
            else
            {
                // Mostrar mensaje de error si las credenciales son incorrectas
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Limpiar los campos de texto para que el usuario vuelva a ingresar los datos
                txtUsuario.Text = "USUARIO";
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;

                this.Show();
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
