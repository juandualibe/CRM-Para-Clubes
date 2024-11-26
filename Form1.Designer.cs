namespace ClubDeportivoG3
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pLeft = new Panel();
            pLogo = new PictureBox();
            pTop = new Panel();
            lblTitle = new Label();
            pIconoUser = new PictureBox();
            pIconoPass = new PictureBox();
            pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pLogo).BeginInit();
            pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pIconoUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pIconoPass).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.White;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(32, 47, 66);
            btnIngresar.FlatAppearance.BorderSize = 2;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.GhostWhite;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.GhostWhite;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.FromArgb(32, 47, 66);
            btnIngresar.Location = new Point(258, 190);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(377, 46);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.AcceptsTab = true;
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(298, 92);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(337, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsTab = true;
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(298, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(337, 27);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // pLeft
            // 
            pLeft.BackColor = Color.FromArgb(32, 47, 66);
            pLeft.Controls.Add(pLogo);
            pLeft.Dock = DockStyle.Left;
            pLeft.Location = new Point(0, 0);
            pLeft.Name = "pLeft";
            pLeft.Size = new Size(239, 283);
            pLeft.TabIndex = 4;
            // 
            // pLogo
            // 
            pLogo.BackgroundImage = (Image)resources.GetObject("pLogo.BackgroundImage");
            pLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pLogo.Location = new Point(27, 44);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(185, 183);
            pLogo.TabIndex = 0;
            pLogo.TabStop = false;
            // 
            // pTop
            // 
            pTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pTop.BackColor = Color.FromArgb(32, 47, 66);
            pTop.Controls.Add(lblTitle);
            pTop.Location = new Point(238, 0);
            pTop.Name = "pTop";
            pTop.Size = new Size(429, 51);
            pTop.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.GhostWhite;
            lblTitle.Location = new Point(123, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CLUB DEPORTIVO";
            lblTitle.Click += lblTitle_Click;
            // 
            // pIconoUser
            // 
            pIconoUser.Anchor = AnchorStyles.None;
            pIconoUser.BackgroundImage = (Image)resources.GetObject("pIconoUser.BackgroundImage");
            pIconoUser.BackgroundImageLayout = ImageLayout.Center;
            pIconoUser.Location = new Point(257, 92);
            pIconoUser.Name = "pIconoUser";
            pIconoUser.Size = new Size(37, 27);
            pIconoUser.TabIndex = 6;
            pIconoUser.TabStop = false;
            // 
            // pIconoPass
            // 
            pIconoPass.Anchor = AnchorStyles.None;
            pIconoPass.BackgroundImage = (Image)resources.GetObject("pIconoPass.BackgroundImage");
            pIconoPass.BackgroundImageLayout = ImageLayout.Center;
            pIconoPass.Location = new Point(257, 138);
            pIconoPass.Name = "pIconoPass";
            pIconoPass.Size = new Size(37, 27);
            pIconoPass.TabIndex = 7;
            pIconoPass.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(668, 283);
            Controls.Add(pIconoPass);
            Controls.Add(pIconoUser);
            Controls.Add(pTop);
            Controls.Add(pLeft);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(64, 0, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            pLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pLogo).EndInit();
            pTop.ResumeLayout(false);
            pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pIconoUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pIconoPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Panel pLeft;
        private PictureBox pLogo;
        private Panel pTop;
        private PictureBox pIconoUser;
        private PictureBox pIconoPass;
        private Label lblTitle;
    }
}
