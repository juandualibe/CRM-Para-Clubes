namespace ClubDeportivoG3
{
    partial class FormSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSocios));
            btnAgregarSocio = new Button();
            btnModificarSocio = new Button();
            btnEliminarSocio = new Button();
            lblListaSocios = new Label();
            panel1 = new Panel();
            dataGridViewSocios = new DataGridView();
            panel2 = new Panel();
            btnCuotasVencidas = new Button();
            btnPago = new Button();
            btnInscribirActividad = new Button();
            panel3 = new Panel();
            pIcon = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.Anchor = AnchorStyles.Top;
            btnAgregarSocio.BackColor = Color.AliceBlue;
            btnAgregarSocio.Cursor = Cursors.Hand;
            btnAgregarSocio.FlatStyle = FlatStyle.Flat;
            btnAgregarSocio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarSocio.ForeColor = Color.FromArgb(32, 47, 66);
            btnAgregarSocio.Location = new Point(67, 32);
            btnAgregarSocio.Margin = new Padding(3, 2, 3, 2);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(148, 48);
            btnAgregarSocio.TabIndex = 1;
            btnAgregarSocio.Text = "Agregar Socio";
            btnAgregarSocio.UseVisualStyleBackColor = false;
            btnAgregarSocio.Click += btnAgregarSocio_Click_1;
            // 
            // btnModificarSocio
            // 
            btnModificarSocio.Anchor = AnchorStyles.Top;
            btnModificarSocio.BackColor = Color.AliceBlue;
            btnModificarSocio.Cursor = Cursors.Hand;
            btnModificarSocio.FlatStyle = FlatStyle.Flat;
            btnModificarSocio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarSocio.ForeColor = Color.FromArgb(32, 47, 66);
            btnModificarSocio.Location = new Point(233, 32);
            btnModificarSocio.Margin = new Padding(3, 2, 3, 2);
            btnModificarSocio.Name = "btnModificarSocio";
            btnModificarSocio.Size = new Size(148, 48);
            btnModificarSocio.TabIndex = 2;
            btnModificarSocio.Text = "Modificar Socio";
            btnModificarSocio.UseVisualStyleBackColor = false;
            btnModificarSocio.Click += btnModificarSocio_Click_1;
            // 
            // btnEliminarSocio
            // 
            btnEliminarSocio.Anchor = AnchorStyles.Top;
            btnEliminarSocio.BackColor = Color.AliceBlue;
            btnEliminarSocio.Cursor = Cursors.Hand;
            btnEliminarSocio.FlatStyle = FlatStyle.Flat;
            btnEliminarSocio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarSocio.ForeColor = Color.FromArgb(32, 47, 66);
            btnEliminarSocio.Location = new Point(403, 32);
            btnEliminarSocio.Margin = new Padding(3, 2, 3, 2);
            btnEliminarSocio.Name = "btnEliminarSocio";
            btnEliminarSocio.Size = new Size(148, 48);
            btnEliminarSocio.TabIndex = 3;
            btnEliminarSocio.Text = "Eliminar Socio";
            btnEliminarSocio.UseVisualStyleBackColor = false;
            btnEliminarSocio.Click += btnEliminarSocio_Click_1;
            // 
            // lblListaSocios
            // 
            lblListaSocios.Anchor = AnchorStyles.Top;
            lblListaSocios.AutoSize = true;
            lblListaSocios.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaSocios.ForeColor = Color.GhostWhite;
            lblListaSocios.Location = new Point(488, 22);
            lblListaSocios.Name = "lblListaSocios";
            lblListaSocios.Size = new Size(178, 33);
            lblListaSocios.TabIndex = 4;
            lblListaSocios.Text = "Lista de Socios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridViewSocios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 583);
            panel1.TabIndex = 5;
            // 
            // dataGridViewSocios
            // 
            dataGridViewSocios.BackgroundColor = Color.AliceBlue;
            dataGridViewSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSocios.Location = new Point(0, 75);
            dataGridViewSocios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSocios.Name = "dataGridViewSocios";
            dataGridViewSocios.RowHeadersWidth = 51;
            dataGridViewSocios.RowTemplate.Height = 29;
            dataGridViewSocios.Size = new Size(1167, 399);
            dataGridViewSocios.TabIndex = 0;
            dataGridViewSocios.CellContentClick += dataGridViewSocios_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 47, 66);
            panel2.Controls.Add(btnCuotasVencidas);
            panel2.Controls.Add(btnPago);
            panel2.Controls.Add(btnInscribirActividad);
            panel2.Controls.Add(btnEliminarSocio);
            panel2.Controls.Add(btnAgregarSocio);
            panel2.Controls.Add(btnModificarSocio);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 469);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 114);
            panel2.TabIndex = 6;
            // 
            // btnCuotasVencidas
            // 
            btnCuotasVencidas.Anchor = AnchorStyles.Top;
            btnCuotasVencidas.BackColor = Color.AliceBlue;
            btnCuotasVencidas.Cursor = Cursors.Hand;
            btnCuotasVencidas.FlatStyle = FlatStyle.Flat;
            btnCuotasVencidas.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCuotasVencidas.ForeColor = Color.FromArgb(32, 47, 66);
            btnCuotasVencidas.Location = new Point(925, 32);
            btnCuotasVencidas.Margin = new Padding(3, 2, 3, 2);
            btnCuotasVencidas.Name = "btnCuotasVencidas";
            btnCuotasVencidas.Size = new Size(148, 48);
            btnCuotasVencidas.TabIndex = 6;
            btnCuotasVencidas.Text = "Cuotas por vencer";
            btnCuotasVencidas.UseVisualStyleBackColor = false;
            btnCuotasVencidas.Click += btnCuotasVencidas_Click;
            // 
            // btnPago
            // 
            btnPago.Anchor = AnchorStyles.Top;
            btnPago.BackColor = Color.AliceBlue;
            btnPago.Cursor = Cursors.Hand;
            btnPago.FlatStyle = FlatStyle.Flat;
            btnPago.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPago.ForeColor = Color.FromArgb(32, 47, 66);
            btnPago.Location = new Point(752, 32);
            btnPago.Margin = new Padding(3, 2, 3, 2);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(148, 48);
            btnPago.TabIndex = 5;
            btnPago.Text = "Registrar Pago";
            btnPago.UseVisualStyleBackColor = false;
            btnPago.Click += btnPago_Click;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.Anchor = AnchorStyles.Top;
            btnInscribirActividad.BackColor = Color.AliceBlue;
            btnInscribirActividad.Cursor = Cursors.Hand;
            btnInscribirActividad.FlatStyle = FlatStyle.Flat;
            btnInscribirActividad.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribirActividad.ForeColor = Color.FromArgb(32, 47, 66);
            btnInscribirActividad.Location = new Point(578, 32);
            btnInscribirActividad.Margin = new Padding(3, 2, 3, 2);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(148, 48);
            btnInscribirActividad.TabIndex = 4;
            btnInscribirActividad.Text = "Inscribir en actividad";
            btnInscribirActividad.UseVisualStyleBackColor = false;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 47, 66);
            panel3.Controls.Add(pIcon);
            panel3.Controls.Add(lblListaSocios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 76);
            panel3.TabIndex = 7;
            // 
            // pIcon
            // 
            pIcon.BackColor = Color.FromArgb(0, 0, 0, 0);
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(6, 5);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(67, 65);
            pIcon.TabIndex = 56;
            pIcon.TabStop = false;
            // 
            // FormSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 583);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socios";
            Load += FormSocios_Load;
            Resize += FormSocios_Resize;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSocios).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarSocio;
        private Button btnModificarSocio;
        private Button btnEliminarSocio;
        private Label lblListaSocios;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnInscribirActividad;
        private Button btnPago;
        private Button btnCuotasVencidas;
        private PictureBox pIcon;
        private DataGridView dataGridViewSocios;
    }
}