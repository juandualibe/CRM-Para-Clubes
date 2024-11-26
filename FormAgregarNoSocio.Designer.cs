namespace ClubDeportivoG3
{
    partial class FormAgregarNoSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarNoSocio));
            panel1 = new Panel();
            pIcon = new PictureBox();
            lblTitulo = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            nudPagoDiario = new NumericUpDown();
            label1 = new Label();
            chkAptoFisico = new CheckBox();
            lblActividadInteres = new Label();
            btnGuardar = new Button();
            cmbActividad = new ComboBox();
            lblTeléfono = new Label();
            lblMail = new Label();
            lblDNI = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            btnCancelar = new Button();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPagoDiario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 47, 66);
            panel1.Controls.Add(pIcon);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 64);
            panel1.TabIndex = 1;
            // 
            // pIcon
            // 
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(12, 7);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(51, 52);
            pIcon.TabIndex = 54;
            pIcon.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.GhostWhite;
            lblTitulo.Location = new Point(294, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(392, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de Registro NO SOCIO";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(942, 480);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(nudPagoDiario);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(chkAptoFisico);
            panel4.Controls.Add(lblActividadInteres);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(cmbActividad);
            panel4.Controls.Add(lblTeléfono);
            panel4.Controls.Add(lblMail);
            panel4.Controls.Add(lblDNI);
            panel4.Controls.Add(lblApellido);
            panel4.Controls.Add(lblNombre);
            panel4.Controls.Add(btnCancelar);
            panel4.Controls.Add(txtTelefono);
            panel4.Controls.Add(txtMail);
            panel4.Controls.Add(txtApellido);
            panel4.Controls.Add(txtDNI);
            panel4.Controls.Add(txtNombre);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(942, 406);
            panel4.TabIndex = 51;
            // 
            // nudPagoDiario
            // 
            nudPagoDiario.Anchor = AnchorStyles.None;
            nudPagoDiario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudPagoDiario.ForeColor = Color.FromArgb(32, 47, 66);
            nudPagoDiario.Location = new Point(403, 306);
            nudPagoDiario.Margin = new Padding(3, 2, 3, 2);
            nudPagoDiario.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPagoDiario.Name = "nudPagoDiario";
            nudPagoDiario.Size = new Size(198, 27);
            nudPagoDiario.TabIndex = 53;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 47, 66);
            label1.Location = new Point(226, 306);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 52;
            label1.Text = "Pago Diario";
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.Anchor = AnchorStyles.None;
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAptoFisico.ForeColor = Color.FromArgb(32, 47, 66);
            chkAptoFisico.Location = new Point(403, 274);
            chkAptoFisico.Margin = new Padding(3, 2, 3, 2);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(99, 23);
            chkAptoFisico.TabIndex = 51;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // lblActividadInteres
            // 
            lblActividadInteres.Anchor = AnchorStyles.None;
            lblActividadInteres.AutoSize = true;
            lblActividadInteres.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblActividadInteres.ForeColor = Color.FromArgb(32, 47, 66);
            lblActividadInteres.Location = new Point(226, 239);
            lblActividadInteres.Name = "lblActividadInteres";
            lblActividadInteres.Size = new Size(145, 19);
            lblActividadInteres.TabIndex = 50;
            lblActividadInteres.Text = "Actividad de Interés";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(32, 47, 66);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.AliceBlue;
            btnGuardar.Location = new Point(697, 118);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 40);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbActividad
            // 
            cmbActividad.Anchor = AnchorStyles.None;
            cmbActividad.BackColor = Color.GhostWhite;
            cmbActividad.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbActividad.ForeColor = Color.FromArgb(32, 47, 66);
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Location = new Point(403, 239);
            cmbActividad.Margin = new Padding(3, 2, 3, 2);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(198, 27);
            cmbActividad.TabIndex = 39;
            // 
            // lblTeléfono
            // 
            lblTeléfono.Anchor = AnchorStyles.None;
            lblTeléfono.AutoSize = true;
            lblTeléfono.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTeléfono.ForeColor = Color.FromArgb(32, 47, 66);
            lblTeléfono.Location = new Point(226, 202);
            lblTeléfono.Name = "lblTeléfono";
            lblTeléfono.Size = new Size(68, 19);
            lblTeléfono.TabIndex = 45;
            lblTeléfono.Text = "Telefono";
            // 
            // lblMail
            // 
            lblMail.Anchor = AnchorStyles.None;
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.ForeColor = Color.FromArgb(32, 47, 66);
            lblMail.Location = new Point(226, 166);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 19);
            lblMail.TabIndex = 44;
            lblMail.Text = "Mail";
            // 
            // lblDNI
            // 
            lblDNI.Anchor = AnchorStyles.None;
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.FromArgb(32, 47, 66);
            lblDNI.Location = new Point(226, 128);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 43;
            lblDNI.Text = "DNI";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.FromArgb(32, 47, 66);
            lblApellido.Location = new Point(226, 94);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 42;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(32, 47, 66);
            lblNombre.Location = new Point(226, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(32, 47, 66);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.AliceBlue;
            btnCancelar.Location = new Point(697, 218);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 40);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(32, 47, 66);
            txtTelefono.Location = new Point(403, 200);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(198, 27);
            txtTelefono.TabIndex = 35;
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.ForeColor = Color.FromArgb(32, 47, 66);
            txtMail.Location = new Point(403, 164);
            txtMail.Margin = new Padding(3, 2, 3, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(198, 27);
            txtMail.TabIndex = 34;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.FromArgb(32, 47, 66);
            txtApellido.Location = new Point(403, 91);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(198, 27);
            txtApellido.TabIndex = 32;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.ForeColor = Color.FromArgb(32, 47, 66);
            txtDNI.Location = new Point(403, 126);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(198, 27);
            txtDNI.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(32, 47, 66);
            txtNombre.Location = new Point(403, 59);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 27);
            txtNombre.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 47, 66);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 406);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 74);
            panel2.TabIndex = 50;
            // 
            // FormAgregarNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 544);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar No Socio";
            Load += FormAgregarNoSocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPagoDiario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private CheckBox chkAptoFisico;
        private Label lblActividadInteres;
        private Button btnGuardar;
        private ComboBox cmbActividad;
        private Label lblTeléfono;
        private Label lblMail;
        private Label lblDNI;
        private Label lblApellido;
        private Label lblNombre;
        private Button btnCancelar;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label label1;
        private NumericUpDown nudPagoDiario;
        private PictureBox pIcon;
    }
}