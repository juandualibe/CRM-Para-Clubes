namespace ClubDeportivoG3
{
    partial class FormCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarnet));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblMail = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 47, 66);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 297);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.GhostWhite;
            panel3.Controls.Add(lblMail);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblDni);
            panel3.Controls.Add(lblApellido);
            panel3.Controls.Add(lblNombre);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 144);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(375, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 129);
            panel4.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.ForeColor = Color.FromArgb(32, 47, 66);
            lblDni.Location = new Point(12, 69);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 19);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.FromArgb(32, 47, 66);
            lblApellido.Location = new Point(12, 41);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 19);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(32, 47, 66);
            lblNombre.Location = new Point(12, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 19);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(125, 65);
            label2.Name = "label2";
            label2.Size = new Size(162, 33);
            label2.TabIndex = 2;
            label2.Text = "Carnet SOCIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(121, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 42);
            label1.TabIndex = 1;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 108);
            panel2.TabIndex = 0;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.ForeColor = Color.FromArgb(32, 47, 66);
            lblMail.Location = new Point(12, 96);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(47, 19);
            lblMail.TabIndex = 5;
            lblMail.Text = "Mail: ";
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 297);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarnet";
            Text = "FormCarnet";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label lblNombre;
        private Panel panel4;
        private Label lblDni;
        private Label lblApellido;
        private Label lblMail;
    }
}