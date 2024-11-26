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
    public partial class OpcionesForm : Form
    {
        public string NombreUsuario { get; set; }  // Propiedad para el nombre del usuario
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {NombreUsuario}"; // Establece el texto del Label con el nombre del usuario al cargar el formulario

        }

        private void btnGestionNoSocios_Click(object sender, EventArgs e)
        {
            FormNoSocios formNoSocios = new FormNoSocios();
            formNoSocios.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }

        private void btnGestionSocios_Click_1(object sender, EventArgs e)
        {
            FormSocios gestionSociosForm = new FormSocios();
            gestionSociosForm.ShowDialog();  // Mostrar el formulario de gestión de socios
        }

        private void btnGestionActividades_Click(object sender, EventArgs e)
        {
            FormActividades gestionActividadesForm = new FormActividades();
            gestionActividadesForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpcionesForm_Resize(object sender, EventArgs e)
        {
            // Tamaño común para todos los botones
            int buttonWidth = this.ClientSize.Width / 5;  // Un quinto del ancho del formulario
            int buttonHeight = this.ClientSize.Height / 4; // Un cuarto del alto del formulario

            // Espaciado horizontal entre botones
            int spacing = (this.ClientSize.Width - (buttonWidth * 3)) / 4; // Espacios entre los botones y los bordes

            // Posición y tamaño del btnGestionSocios (izquierda)
            btnGestionSocios.Width = buttonWidth;
            btnGestionSocios.Height = buttonHeight;
            btnGestionSocios.Left = spacing; // Separación desde el borde izquierdo
            btnGestionSocios.Top = (this.ClientSize.Height - buttonHeight) / 3;

            // Posición y tamaño del btnGestionActividades (derecha)
            btnGestionActividades.Width = buttonWidth;
            btnGestionActividades.Height = buttonHeight;
            btnGestionActividades.Left = spacing * 3 + buttonWidth * 2; // Espacio entre botones + ancho de btnGestionSocios
            btnGestionActividades.Top = (this.ClientSize.Height - buttonHeight) / 3;

            // Posición y tamaño del btnGestionNoSocios (centro)
            btnGestionNoSocios.Width = buttonWidth;
            btnGestionNoSocios.Height = buttonHeight;
            btnGestionNoSocios.Left = spacing * 2 + buttonWidth; // Espacios acumulados + ancho de los dos botones anteriores
            btnGestionNoSocios.Top = (this.ClientSize.Height - buttonHeight) / 3;

        }
        

        private void OpcionesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación
        }
    }
}
