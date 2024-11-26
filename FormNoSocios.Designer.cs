namespace ClubDeportivoG3
{
    partial class FormNoSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoSocios));
            panel3 = new Panel();
            pIcon = new PictureBox();
            lblListaNoSocios = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnInscribirActividad = new Button();
            btnEliminarNoSocio = new Button();
            btnAgregarNoSocio = new Button();
            dataGridViewNoSocios = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoSocios).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 47, 66);
            panel3.Controls.Add(pIcon);
            panel3.Controls.Add(lblListaNoSocios);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 82);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // pIcon
            // 
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(12, 9);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(67, 65);
            pIcon.TabIndex = 55;
            pIcon.TabStop = false;
            // 
            // lblListaNoSocios
            // 
            lblListaNoSocios.Anchor = AnchorStyles.Top;
            lblListaNoSocios.AutoSize = true;
            lblListaNoSocios.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaNoSocios.ForeColor = Color.GhostWhite;
            lblListaNoSocios.Location = new Point(480, 27);
            lblListaNoSocios.Name = "lblListaNoSocios";
            lblListaNoSocios.Size = new Size(212, 33);
            lblListaNoSocios.TabIndex = 4;
            lblListaNoSocios.Text = "Listado No Socios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewNoSocios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 82);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 501);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 47, 66);
            panel2.Controls.Add(btnInscribirActividad);
            panel2.Controls.Add(btnEliminarNoSocio);
            panel2.Controls.Add(btnAgregarNoSocio);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 387);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 114);
            panel2.TabIndex = 7;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.Anchor = AnchorStyles.Top;
            btnInscribirActividad.BackColor = Color.AliceBlue;
            btnInscribirActividad.FlatStyle = FlatStyle.Flat;
            btnInscribirActividad.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscribirActividad.ForeColor = Color.FromArgb(32, 47, 66);
            btnInscribirActividad.Location = new Point(796, 31);
            btnInscribirActividad.Margin = new Padding(3, 2, 3, 2);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(160, 50);
            btnInscribirActividad.TabIndex = 4;
            btnInscribirActividad.Text = "Inscribir en actividad";
            btnInscribirActividad.UseVisualStyleBackColor = false;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            // 
            // btnEliminarNoSocio
            // 
            btnEliminarNoSocio.Anchor = AnchorStyles.Top;
            btnEliminarNoSocio.BackColor = Color.AliceBlue;
            btnEliminarNoSocio.FlatStyle = FlatStyle.Flat;
            btnEliminarNoSocio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarNoSocio.ForeColor = Color.FromArgb(32, 47, 66);
            btnEliminarNoSocio.Location = new Point(514, 31);
            btnEliminarNoSocio.Margin = new Padding(3, 2, 3, 2);
            btnEliminarNoSocio.Name = "btnEliminarNoSocio";
            btnEliminarNoSocio.Size = new Size(160, 50);
            btnEliminarNoSocio.TabIndex = 3;
            btnEliminarNoSocio.Text = "Eliminar";
            btnEliminarNoSocio.UseVisualStyleBackColor = false;
            btnEliminarNoSocio.Click += btnEliminarNoSocio_Click;
            // 
            // btnAgregarNoSocio
            // 
            btnAgregarNoSocio.Anchor = AnchorStyles.Top;
            btnAgregarNoSocio.BackColor = Color.AliceBlue;
            btnAgregarNoSocio.FlatStyle = FlatStyle.Flat;
            btnAgregarNoSocio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarNoSocio.ForeColor = Color.FromArgb(32, 47, 66);
            btnAgregarNoSocio.Location = new Point(234, 31);
            btnAgregarNoSocio.Margin = new Padding(3, 2, 3, 2);
            btnAgregarNoSocio.Name = "btnAgregarNoSocio";
            btnAgregarNoSocio.Size = new Size(160, 50);
            btnAgregarNoSocio.TabIndex = 1;
            btnAgregarNoSocio.Text = "Agregar";
            btnAgregarNoSocio.UseVisualStyleBackColor = false;
            btnAgregarNoSocio.Click += btnAgregarNoSocio_Click;
            // 
            // dataGridViewNoSocios
            // 
            dataGridViewNoSocios.BackgroundColor = Color.AliceBlue;
            dataGridViewNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNoSocios.Dock = DockStyle.Fill;
            dataGridViewNoSocios.Location = new Point(0, 0);
            dataGridViewNoSocios.Margin = new Padding(3, 2, 3, 2);
            dataGridViewNoSocios.Name = "dataGridViewNoSocios";
            dataGridViewNoSocios.RowHeadersWidth = 51;
            dataGridViewNoSocios.RowTemplate.Height = 29;
            dataGridViewNoSocios.Size = new Size(1167, 501);
            dataGridViewNoSocios.TabIndex = 0;
            dataGridViewNoSocios.CellContentClick += dataGridViewNoSocios_CellContentClick;
            // 
            // FormNoSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 583);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNoSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "No Socios";
            Load += FormNoSocios_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNoSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label lblListaNoSocios;
        private Panel panel1;
        private Panel panel2;
        private Button btnEliminarNoSocio;
        private Button btnAgregarNoSocio;
        private DataGridView dataGridViewNoSocios;
        private Button btnInscribirActividad;
        private PictureBox pIcon;
    }
}