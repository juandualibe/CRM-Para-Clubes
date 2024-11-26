namespace ClubDeportivoG3
{
    partial class OpcionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesForm));
            btnSalir = new Button();
            pnl_Inferior = new Panel();
            lblUsuario = new Label();
            pnlSuperior = new Panel();
            pIcon = new PictureBox();
            lblTitulo = new Label();
            panel1 = new Panel();
            btnGestionActividades = new Button();
            btnGestionNoSocios = new Button();
            btnGestionSocios = new Button();
            pnl_Inferior.SuspendLayout();
            pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.AliceBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(1088, 22);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 33);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnl_Inferior
            // 
            pnl_Inferior.BackColor = Color.FromArgb(32, 47, 66);
            pnl_Inferior.Controls.Add(lblUsuario);
            pnl_Inferior.Controls.Add(btnSalir);
            pnl_Inferior.Dock = DockStyle.Bottom;
            pnl_Inferior.Location = new Point(0, 565);
            pnl_Inferior.Margin = new Padding(3, 2, 3, 2);
            pnl_Inferior.Name = "pnl_Inferior";
            pnl_Inferior.Size = new Size(1244, 75);
            pnl_Inferior.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.GhostWhite;
            lblUsuario.Location = new Point(10, 27);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 19);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario: ";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(32, 47, 66);
            pnlSuperior.Controls.Add(pIcon);
            pnlSuperior.Controls.Add(lblTitulo);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Margin = new Padding(3, 2, 3, 2);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1244, 98);
            pnlSuperior.TabIndex = 6;
            // 
            // pIcon
            // 
            pIcon.BackgroundImage = (Image)resources.GetObject("pIcon.BackgroundImage");
            pIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pIcon.Location = new Point(10, 4);
            pIcon.Name = "pIcon";
            pIcon.Size = new Size(93, 89);
            pIcon.TabIndex = 55;
            pIcon.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.GhostWhite;
            lblTitulo.Location = new Point(528, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menú de Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(btnGestionActividades);
            panel1.Controls.Add(btnGestionNoSocios);
            panel1.Controls.Add(btnGestionSocios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 98);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 467);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnGestionActividades
            // 
            btnGestionActividades.Anchor = AnchorStyles.None;
            btnGestionActividades.BackColor = Color.FromArgb(32, 47, 66);
            btnGestionActividades.Cursor = Cursors.Hand;
            btnGestionActividades.FlatStyle = FlatStyle.Flat;
            btnGestionActividades.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionActividades.ForeColor = Color.AliceBlue;
            btnGestionActividades.Location = new Point(872, 158);
            btnGestionActividades.Margin = new Padding(3, 2, 3, 2);
            btnGestionActividades.Name = "btnGestionActividades";
            btnGestionActividades.Size = new Size(248, 138);
            btnGestionActividades.TabIndex = 7;
            btnGestionActividades.Text = "Gestión ACTIVIDADES";
            btnGestionActividades.UseVisualStyleBackColor = false;
            btnGestionActividades.Click += btnGestionActividades_Click;
            // 
            // btnGestionNoSocios
            // 
            btnGestionNoSocios.Anchor = AnchorStyles.None;
            btnGestionNoSocios.BackColor = Color.FromArgb(32, 47, 66);
            btnGestionNoSocios.Cursor = Cursors.Hand;
            btnGestionNoSocios.FlatStyle = FlatStyle.Flat;
            btnGestionNoSocios.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionNoSocios.ForeColor = Color.AliceBlue;
            btnGestionNoSocios.Location = new Point(507, 158);
            btnGestionNoSocios.Margin = new Padding(3, 2, 3, 2);
            btnGestionNoSocios.Name = "btnGestionNoSocios";
            btnGestionNoSocios.Size = new Size(248, 138);
            btnGestionNoSocios.TabIndex = 6;
            btnGestionNoSocios.Text = "Gestión NO SOCIOS";
            btnGestionNoSocios.UseVisualStyleBackColor = false;
            btnGestionNoSocios.Click += btnGestionNoSocios_Click;
            // 
            // btnGestionSocios
            // 
            btnGestionSocios.Anchor = AnchorStyles.None;
            btnGestionSocios.BackColor = Color.FromArgb(32, 47, 66);
            btnGestionSocios.Cursor = Cursors.Hand;
            btnGestionSocios.FlatStyle = FlatStyle.Flat;
            btnGestionSocios.Font = new Font("Calibri", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnGestionSocios.ForeColor = Color.AliceBlue;
            btnGestionSocios.Location = new Point(135, 158);
            btnGestionSocios.Margin = new Padding(3, 2, 3, 2);
            btnGestionSocios.Name = "btnGestionSocios";
            btnGestionSocios.Size = new Size(248, 138);
            btnGestionSocios.TabIndex = 5;
            btnGestionSocios.Text = "Gestión SOCIOS";
            btnGestionSocios.UseVisualStyleBackColor = false;
            btnGestionSocios.Click += btnGestionSocios_Click_1;
            // 
            // OpcionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1244, 640);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Controls.Add(pnl_Inferior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "OpcionesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opciones";
            FormClosing += OpcionesForm_FormClosing;
            Load += Form2_Load;
            Resize += OpcionesForm_Resize;
            pnl_Inferior.ResumeLayout(false);
            pnl_Inferior.PerformLayout();
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnSalir;
        private Panel pnl_Inferior;
        private Label lblUsuario;
        private Panel pnlSuperior;
        private Label lblTitulo;
        private Panel panel1;
        private Button btnGestionActividades;
        private Button btnGestionNoSocios;
        private Button btnGestionSocios;
        private PictureBox pIcon;
    }
}