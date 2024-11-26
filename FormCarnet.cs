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
    public partial class FormCarnet : Form
    {
        public FormCarnet()
        {
            InitializeComponent();
        }

        public string Mail
        {
            get => lblMail.Text;
            set => lblMail.Text = $"Mail: {value}";
        }

        public string Nombre
        {
            get => lblNombre.Text;
            set => lblNombre.Text = $"Nombre: {value}";
        }

        public string Apellido
        {
            get => lblApellido.Text;
            set => lblApellido.Text = $"Apellido: {value}";
        }

        public string DNI
        {
            get => lblDni.Text;
            set => lblDni.Text = $"DNI: {value}";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
