namespace ClubDeportivoG3
{
    partial class FormListadoCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListadoCuotas));
            dataGridViewCuotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.BackgroundColor = Color.AliceBlue;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuotas.Dock = DockStyle.Fill;
            dataGridViewCuotas.Location = new Point(0, 0);
            dataGridViewCuotas.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.RowHeadersWidth = 51;
            dataGridViewCuotas.Size = new Size(700, 338);
            dataGridViewCuotas.TabIndex = 0;
            // 
            // FormListadoCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewCuotas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormListadoCuotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socios que en la fecha les vence la cuota";
            Load += FormListadoCuotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCuotas;
    }
}