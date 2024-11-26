namespace ClubDeportivoG3
{
    partial class FormModificarSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarSocios));
            panel1 = new Panel();
            pIcon = new PictureBox();
            lblTitulo = new Label();
            panel2 = new Panel();
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
            label6 = new Label();
            txtId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1069, 75);
            panel1.TabIndex = 1;
            // 
            // pIcon
            // 
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(3, 3);
            pIcon.Margin = new Padding(3, 4, 3, 4);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(58, 69);
            pIcon.TabIndex = 71;
            pIcon.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.AliceBlue;
            lblTitulo.Location = new Point(392, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Modificar SOCIO";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 47, 66);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 75);
            panel2.TabIndex = 2;
            // 
            // btnEntregarCarnet
            // 
            btnEntregarCarnet.Anchor = AnchorStyles.None;
            btnEntregarCarnet.BackColor = Color.FromArgb(32, 47, 66);
            btnEntregarCarnet.Cursor = Cursors.Hand;
            btnEntregarCarnet.FlatStyle = FlatStyle.Flat;
            btnEntregarCarnet.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntregarCarnet.ForeColor = Color.AliceBlue;
            btnEntregarCarnet.Location = new Point(815, 316);
            btnEntregarCarnet.Name = "btnEntregarCarnet";
            btnEntregarCarnet.Size = new Size(187, 80);
            btnEntregarCarnet.TabIndex = 68;
            btnEntregarCarnet.Text = "Entregar Carnet y Guardar";
            btnEntregarCarnet.UseVisualStyleBackColor = false;
            btnEntregarCarnet.Click += btnEntregarCarnet_Click;
            // 
            // lblEstadoPago
            // 
            lblEstadoPago.Anchor = AnchorStyles.None;
            lblEstadoPago.AutoSize = true;
            lblEstadoPago.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadoPago.Location = new Point(259, 557);
            lblEstadoPago.Name = "lblEstadoPago";
            lblEstadoPago.Size = new Size(139, 24);
            lblEstadoPago.TabIndex = 67;
            lblEstadoPago.Text = "Estado de Pago";
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.Anchor = AnchorStyles.None;
            cmbEstadoPago.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Items.AddRange(new object[] { "Pagado", "Pendiente" });
            cmbEstadoPago.Location = new Point(462, 549);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(226, 32);
            cmbEstadoPago.TabIndex = 58;
            // 
            // chkCarnetEntrega
            // 
            chkCarnetEntrega.Anchor = AnchorStyles.None;
            chkCarnetEntrega.AutoSize = true;
            chkCarnetEntrega.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkCarnetEntrega.Location = new Point(462, 504);
            chkCarnetEntrega.Name = "chkCarnetEntrega";
            chkCarnetEntrega.Size = new Size(181, 28);
            chkCarnetEntrega.TabIndex = 57;
            chkCarnetEntrega.Text = "Carnet Engregado";
            chkCarnetEntrega.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(259, 455);
            label7.Name = "label7";
            label7.Size = new Size(137, 24);
            label7.TabIndex = 66;
            label7.Text = "Cuota Mensual";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(259, 359);
            label5.Name = "label5";
            label5.Size = new Size(82, 24);
            label5.TabIndex = 65;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(259, 311);
            label4.Name = "label4";
            label4.Size = new Size(47, 24);
            label4.TabIndex = 64;
            label4.Text = "Mail";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(259, 260);
            label3.Name = "label3";
            label3.Size = new Size(41, 24);
            label3.TabIndex = 63;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 215);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 62;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 167);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 60;
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
            btnCancelar.Location = new Point(815, 433);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(187, 80);
            btnCancelar.TabIndex = 61;
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
            btnGuardar.Location = new Point(815, 204);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(187, 80);
            btnGuardar.TabIndex = 59;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // nudCuotaMensual
            // 
            nudCuotaMensual.Anchor = AnchorStyles.None;
            nudCuotaMensual.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudCuotaMensual.Location = new Point(462, 453);
            nudCuotaMensual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudCuotaMensual.Name = "nudCuotaMensual";
            nudCuotaMensual.Size = new Size(226, 32);
            nudCuotaMensual.TabIndex = 56;
            // 
            // chkAptoFisico
            // 
            chkAptoFisico.Anchor = AnchorStyles.None;
            chkAptoFisico.AutoSize = true;
            chkAptoFisico.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkAptoFisico.Location = new Point(462, 408);
            chkAptoFisico.Name = "chkAptoFisico";
            chkAptoFisico.Size = new Size(124, 28);
            chkAptoFisico.TabIndex = 55;
            chkAptoFisico.Text = "Apto Físico";
            chkAptoFisico.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(462, 356);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(226, 32);
            txtTelefono.TabIndex = 54;
            // 
            // txtMail
            // 
            txtMail.Anchor = AnchorStyles.None;
            txtMail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(462, 308);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(226, 32);
            txtMail.TabIndex = 53;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(462, 211);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(226, 32);
            txtApellido.TabIndex = 51;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.None;
            txtDNI.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDNI.Location = new Point(462, 257);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(226, 32);
            txtDNI.TabIndex = 52;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(462, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 32);
            txtNombre.TabIndex = 50;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(261, 121);
            label6.Name = "label6";
            label6.Size = new Size(26, 24);
            label6.TabIndex = 70;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.BackColor = Color.White;
            txtId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(462, 117);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(226, 32);
            txtId.TabIndex = 69;
            // 
            // FormModificarSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1069, 721);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(btnEntregarCarnet);
            Controls.Add(lblEstadoPago);
            Controls.Add(cmbEstadoPago);
            Controls.Add(chkCarnetEntrega);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudCuotaMensual);
            Controls.Add(chkAptoFisico);
            Controls.Add(txtTelefono);
            Controls.Add(txtMail);
            Controls.Add(txtApellido);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificarSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Socios";
            Load += FormModificarSocios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCuotaMensual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel2;
        private Button btnEntregarCarnet;
        private Label lblEstadoPago;
        private ComboBox cmbEstadoPago;
        private CheckBox chkCarnetEntrega;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown nudCuotaMensual;
        private CheckBox chkAptoFisico;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtId;
        private PictureBox pIcon;
    }
}