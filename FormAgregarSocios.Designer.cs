namespace ClubDeportivoG3
{
    partial class FormAgregarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarSocios));
            panel1 = new Panel();
            pIcon = new PictureBox();
            lblTitulo = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnEntregarCarnet = new Button();
            lblEstadoPago = new Label();
            cmbEstadoPago = new ComboBox();
            chkCarnetEntrega = new CheckBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            nudCuotaMensual = new NumericUpDown();
            chkAptoFisico = new CheckBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).BeginInit();
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
            panel1.Size = new Size(935, 64);
            panel1.TabIndex = 0;
            // 
            // pIcon
            // 
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(10, 6);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(51, 52);
            pIcon.TabIndex = 55;
            pIcon.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.GhostWhite;
            lblTitulo.Location = new Point(309, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(350, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de Registro SOCIO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 47, 66);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 471);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(935, 70);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(935, 407);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(btnEntregarCarnet);
            panel4.Controls.Add(lblEstadoPago);
            panel4.Controls.Add(cmbEstadoPago);
            panel4.Controls.Add(chkCarnetEntrega);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btnCancelar);
            panel4.Controls.Add(btnGuardar);
            panel4.Controls.Add(nudCuotaMensual);
            panel4.Controls.Add(chkAptoFisico);
            panel4.Controls.Add(txtTelefono);
            panel4.Controls.Add(txtMail);
            panel4.Controls.Add(txtApellido);
            panel4.Controls.Add(txtDNI);
            panel4.Controls.Add(txtNombre);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(935, 407);
            panel4.TabIndex = 5;
            // 
            // btnEntregarCarnet
            // 
            btnEntregarCarnet.Anchor = AnchorStyles.None;
            btnEntregarCarnet.BackColor = Color.FromArgb(32, 47, 66);
            btnEntregarCarnet.Cursor = Cursors.Hand;
            btnEntregarCarnet.FlatStyle = FlatStyle.Flat;
            btnEntregarCarnet.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntregarCarnet.ForeColor = Color.AliceBlue;
            btnEntregarCarnet.Location = new Point(711, 146);
            btnEntregarCarnet.Margin = new Padding(3, 2, 3, 2);
            btnEntregarCarnet.Name = "btnEntregarCarnet";
            btnEntregarCarnet.Size = new Size(164, 51);
            btnEntregarCarnet.TabIndex = 49;
            btnEntregarCarnet.Text = "Entregar Carnet y Guardar";
            btnEntregarCarnet.UseVisualStyleBackColor = false;
            btnEntregarCarnet.Click += btnEntregarCarnet_Click_1;
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.Anchor = AnchorStyles.None;
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoPago.ForeColor = Color.FromArgb(32, 47, 66);
            lblEstadoPago.Location = new Point(227, 335);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(114, 19);
            lblEstadoPago.TabIndex = 48;
            lblEstadoPago.Text = "Estado de Pago";
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.Anchor = AnchorStyles.None;
            cmbEstadoPago.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstadoPago.ForeColor = Color.FromArgb(32, 47, 66);
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Items.AddRange(new object[] { "Pagado", "Pendiente" });
            cmbEstadoPago.Location = new Point(404, 329);
            cmbEstadoPago.Margin = new Padding(3, 2, 3, 2);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(198, 27);
            cmbEstadoPago.TabIndex = 39;
            // 
            // chkCarnetEntrega
            // 
            chkCarnetEntrega.Anchor = AnchorStyles.None;
            chkCarnetEntrega.AutoSize = true;
            chkCarnetEntrega.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCarnetEntrega.ForeColor = Color.FromArgb(32, 47, 66);
            chkCarnetEntrega.Location = new Point(404, 295);
            chkCarnetEntrega.Margin = new Padding(3, 2, 3, 2);
            chkCarnetEntrega.Name = "chkCarnetEntrega";
            chkCarnetEntrega.Size = new Size(144, 23);
            chkCarnetEntrega.TabIndex = 38;
            chkCarnetEntrega.Text = "Carnet Engregado";
            chkCarnetEntrega.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(32, 47, 66);
            label7.Location = new Point(227, 258);
            label7.Name = "label7";
            label7.Size = new Size(111, 19);
            label7.TabIndex = 46;
            label7.Text = "Cuota Mensual";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 47, 66);
            label5.Location = new Point(227, 186);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 45;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(32, 47, 66);
            label4.Location = new Point(227, 148);
            label4.Name = "label4";
            label4.Size = new Size(39, 19);
            label4.TabIndex = 44;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(32, 47, 66);
            label3.Location = new Point(227, 107);
            label3.Name = "label3";
            label3.Size = new Size(34, 19);
            label3.TabIndex = 43;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(32, 47, 66);
            label2.Location = new Point(227, 68);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 42;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(32, 47, 66);
            label1.Location = new Point(227, 26);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 40;
            label1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.FromArgb(32, 47, 66);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.AliceBlue;
            btnCancelar.Location = new Point(711, 241);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 51);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(32, 47, 66);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.AliceBlue;
            btnGuardar.Location = new Point(711, 54);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 51);
            btnGuardar.TabIndex = 40;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudCuotaMensual
            // 
            nudCuotaMensual.Anchor = AnchorStyles.None;
            nudCuotaMensual.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCuotaMensual.ForeColor = Color.FromArgb(32, 47, 66);
            nudCuotaMensual.Location = new Point(404, 257);
            nudCuotaMensual.Margin = new Padding(3, 2, 3, 2);
            nudCuotaMensual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCuotaMensual.Name = "nudCuotaMensual";
            nudCuotaMensual.Size = new Size(198, 27);
            nudCuotaMensual.TabIndex = 37;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.Anchor = AnchorStyles.None;
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAptoFisico.ForeColor = Color.FromArgb(32, 47, 66);
            chkAptoFisico.Location = new Point(404, 223);
            chkAptoFisico.Margin = new Padding(3, 2, 3, 2);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(99, 23);
            chkAptoFisico.TabIndex = 36;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.ForeColor = Color.FromArgb(32, 47, 66);
            txtTelefono.Location = new Point(404, 184);
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
            txtMail.Location = new Point(404, 146);
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
            txtApellido.Location = new Point(404, 65);
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
            txtDNI.Location = new Point(404, 105);
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
            txtNombre.Location = new Point(404, 27);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 27);
            txtNombre.TabIndex = 31;
            // 
            // FormAgregarSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 541);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAgregarSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Socios";
            Load += FormAgregarSocios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblTitulo;
        private Panel panel3;
        private Panel panel4;
        private Button btnEntregarCarnet;
        private ComboBox cmbEstadoPago;
        private CheckBox chkCarnetEntrega;
        private Button btnCancelar;
        private Button btnGuardar;
        private CheckBox chkAptoFisico;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nudCuotaMensual;
        private Label lblEstadoPago;
        private PictureBox pIcon;
    }
}