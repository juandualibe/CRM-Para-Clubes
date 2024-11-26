namespace ClubDeportivoG3
{
    partial class FormActividades
    {
       
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public System.Windows.Forms.DataGridView dataGridView;


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActividades));
            dataGridView1 = new DataGridView();
            btnAgregarActividad = new Button();
            btnEliminarActividad = new Button();
            txtNombre = new TextBox();
            txtDia = new TextBox();
            txtHorario = new TextBox();
            txtMonto = new TextBox();
            lblNombreActividad = new Label();
            lblDiaActividad = new Label();
            lblHorarioActividad = new Label();
            lblMontoActividad = new Label();
            txtCupo = new TextBox();
            lblCupo = new Label();
            btnActualizarMonto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(931, 232);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregarActividad
            // 
            btnAgregarActividad.Anchor = AnchorStyles.None;
            btnAgregarActividad.BackColor = Color.FromArgb(32, 47, 66);
            btnAgregarActividad.Cursor = Cursors.Hand;
            btnAgregarActividad.FlatStyle = FlatStyle.Flat;
            btnAgregarActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarActividad.ForeColor = Color.AliceBlue;
            btnAgregarActividad.Location = new Point(637, 260);
            btnAgregarActividad.Name = "btnAgregarActividad";
            btnAgregarActividad.Size = new Size(210, 77);
            btnAgregarActividad.TabIndex = 1;
            btnAgregarActividad.Text = "Agregar Actividad";
            btnAgregarActividad.UseVisualStyleBackColor = false;
            btnAgregarActividad.Click += btnAgregarActividad_Click;
            // 
            // btnEliminarActividad
            // 
            btnEliminarActividad.Anchor = AnchorStyles.None;
            btnEliminarActividad.BackColor = Color.FromArgb(32, 47, 66);
            btnEliminarActividad.Cursor = Cursors.Hand;
            btnEliminarActividad.FlatStyle = FlatStyle.Flat;
            btnEliminarActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarActividad.ForeColor = Color.AliceBlue;
            btnEliminarActividad.Location = new Point(637, 454);
            btnEliminarActividad.Name = "btnEliminarActividad";
            btnEliminarActividad.Size = new Size(210, 77);
            btnEliminarActividad.TabIndex = 2;
            btnEliminarActividad.Text = "Eliminar Actividad";
            btnEliminarActividad.UseVisualStyleBackColor = false;
            btnEliminarActividad.Click += btnEliminarActividad_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.FromArgb(32, 47, 66);
            txtNombre.Location = new Point(338, 283);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 32);
            txtNombre.TabIndex = 3;
            // 
            // txtDia
            // 
            txtDia.Anchor = AnchorStyles.None;
            txtDia.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDia.ForeColor = Color.FromArgb(32, 47, 66);
            txtDia.Location = new Point(338, 329);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(226, 32);
            txtDia.TabIndex = 4;
            // 
            // txtHorario
            // 
            txtHorario.Anchor = AnchorStyles.None;
            txtHorario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHorario.ForeColor = Color.FromArgb(32, 47, 66);
            txtHorario.Location = new Point(338, 377);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(226, 32);
            txtHorario.TabIndex = 5;
            // 
            // txtMonto
            // 
            txtMonto.Anchor = AnchorStyles.None;
            txtMonto.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.ForeColor = Color.FromArgb(32, 47, 66);
            txtMonto.Location = new Point(338, 427);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(226, 32);
            txtMonto.TabIndex = 6;
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.Anchor = AnchorStyles.None;
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreActividad.ForeColor = Color.FromArgb(32, 47, 66);
            lblNombreActividad.Location = new Point(137, 287);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(187, 24);
            lblNombreActividad.TabIndex = 7;
            lblNombreActividad.Text = "Nombre de Actividad";
            // 
            // lblDiaActividad
            // 
            lblDiaActividad.Anchor = AnchorStyles.None;
            lblDiaActividad.AutoSize = true;
            lblDiaActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiaActividad.ForeColor = Color.FromArgb(32, 47, 66);
            lblDiaActividad.Location = new Point(137, 333);
            lblDiaActividad.Name = "lblDiaActividad";
            lblDiaActividad.Size = new Size(147, 24);
            lblDiaActividad.TabIndex = 8;
            lblDiaActividad.Text = "Dia de Actividad";
            // 
            // lblHorarioActividad
            // 
            lblHorarioActividad.Anchor = AnchorStyles.None;
            lblHorarioActividad.AutoSize = true;
            lblHorarioActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarioActividad.ForeColor = Color.FromArgb(32, 47, 66);
            lblHorarioActividad.Location = new Point(137, 381);
            lblHorarioActividad.Name = "lblHorarioActividad";
            lblHorarioActividad.Size = new Size(183, 24);
            lblHorarioActividad.TabIndex = 9;
            lblHorarioActividad.Text = "Horario de Actividad";
            // 
            // lblMontoActividad
            // 
            lblMontoActividad.Anchor = AnchorStyles.None;
            lblMontoActividad.AutoSize = true;
            lblMontoActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMontoActividad.ForeColor = Color.FromArgb(32, 47, 66);
            lblMontoActividad.Location = new Point(137, 431);
            lblMontoActividad.Name = "lblMontoActividad";
            lblMontoActividad.Size = new Size(144, 24);
            lblMontoActividad.TabIndex = 10;
            lblMontoActividad.Text = "Monto Mensual";
            // 
            // txtCupo
            // 
            txtCupo.Anchor = AnchorStyles.None;
            txtCupo.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCupo.ForeColor = Color.FromArgb(32, 47, 66);
            txtCupo.Location = new Point(338, 476);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(226, 32);
            txtCupo.TabIndex = 11;
            // 
            // lblCupo
            // 
            lblCupo.Anchor = AnchorStyles.None;
            lblCupo.AutoSize = true;
            lblCupo.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCupo.ForeColor = Color.FromArgb(32, 47, 66);
            lblCupo.Location = new Point(137, 480);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(127, 24);
            lblCupo.TabIndex = 12;
            lblCupo.Text = "Cupo Maximo";
            // 
            // btnActualizarMonto
            // 
            btnActualizarMonto.BackColor = Color.FromArgb(32, 47, 66);
            btnActualizarMonto.Cursor = Cursors.Hand;
            btnActualizarMonto.FlatStyle = FlatStyle.Flat;
            btnActualizarMonto.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizarMonto.ForeColor = Color.AliceBlue;
            btnActualizarMonto.Location = new Point(637, 354);
            btnActualizarMonto.Name = "btnActualizarMonto";
            btnActualizarMonto.Size = new Size(210, 77);
            btnActualizarMonto.TabIndex = 13;
            btnActualizarMonto.Text = "Actualizar Monto";
            btnActualizarMonto.UseVisualStyleBackColor = false;
            btnActualizarMonto.Click += btnActualizarMonto_Click;
            // 
            // FormActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(931, 553);
            Controls.Add(btnActualizarMonto);
            Controls.Add(lblCupo);
            Controls.Add(txtCupo);
            Controls.Add(lblMontoActividad);
            Controls.Add(lblHorarioActividad);
            Controls.Add(lblDiaActividad);
            Controls.Add(lblNombreActividad);
            Controls.Add(txtMonto);
            Controls.Add(txtHorario);
            Controls.Add(txtDia);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminarActividad);
            Controls.Add(btnAgregarActividad);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(949, 600);
            MinimumSize = new Size(949, 600);
            Name = "FormActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actividades";
            Load += FormActividades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregarActividad;
        private Button btnEliminarActividad;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtDia;
        private TextBox txtHorario;
        private TextBox textBox1;
        private TextBox txtMonto;
        private Label lblNombreActividad;
        private Label lblDiaActividad;
        private Label lblHorarioActividad;
        private Label lblMontoActividad;
        private TextBox txtCupo;
        private Label lblCupo;
        private Button btnActualizarMonto;
    }
}