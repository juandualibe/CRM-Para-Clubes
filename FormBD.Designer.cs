namespace ClubDeportivoG3
{
    partial class FormBD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnAceptar = new Button();
            label4 = new Label();
            label5 = new Label();
            txtPuerto = new TextBox();
            txtServidor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 18);
            label1.TabIndex = 0;
            label1.Text = "Ingresa las credenciales de MySQL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(120, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(165, 26);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "root";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(120, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(165, 26);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(32, 47, 66);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.AliceBlue;
            btnAceptar.Location = new Point(133, 164);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(85, 40);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 43);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 6;
            label4.Text = "Servidor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 70);
            label5.Name = "label5";
            label5.Size = new Size(54, 18);
            label5.TabIndex = 7;
            label5.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            txtPuerto.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuerto.Location = new Point(120, 68);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(165, 26);
            txtPuerto.TabIndex = 2;
            txtPuerto.Text = "3306";
            // 
            // txtServidor
            // 
            txtServidor.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtServidor.Location = new Point(120, 38);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(165, 26);
            txtServidor.TabIndex = 1;
            txtServidor.Text = "localhost";
            // 
            // FormBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(386, 242);
            ControlBox = false;
            Controls.Add(txtServidor);
            Controls.Add(txtPuerto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAceptar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credenciales MySQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnAceptar;
        private Label label4;
        private Label label5;
        private TextBox txtPuerto;
        private TextBox txtServidor;
    }
}