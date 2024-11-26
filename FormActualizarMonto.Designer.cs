namespace ClubDeportivoG3
{
    partial class FormActualizarMonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarMonto));
            label1 = new Label();
            txtNuevoMonto = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 46);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Monto";
            // 
            // txtNuevoMonto
            // 
            txtNuevoMonto.Location = new Point(163, 46);
            txtNuevoMonto.Margin = new Padding(3, 2, 3, 2);
            txtNuevoMonto.Name = "txtNuevoMonto";
            txtNuevoMonto.Size = new Size(110, 23);
            txtNuevoMonto.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(32, 47, 66);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.AliceBlue;
            btnAceptar.Location = new Point(47, 101);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 38);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(32, 47, 66);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.AliceBlue;
            btnCancelar.Location = new Point(185, 101);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 38);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormActualizarMonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(334, 174);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNuevoMonto);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(350, 213);
            MinimumSize = new Size(350, 213);
            Name = "FormActualizarMonto";
            Text = "Actualizar Monto";
            Load += FormActualizarMonto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNuevoMonto;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}