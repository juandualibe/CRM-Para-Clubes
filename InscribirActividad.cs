using ClubDeportivoG3.Datos;
using ClubDeportivoG3.Entidades;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivoG3
{
    public partial class InscribirActividad : Form
    {
        private int idC;

        // Constructor que recibe el ID del cliente
        public InscribirActividad(int idCliente)
        {
            InitializeComponent();
            idC = idCliente;
            CargarActividades();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(InscribirActividad));
            dataGridView1 = new DataGridView();
            btnInscribirActividad = new Button();
            pnl_Inferior = new Panel();
            ((ISupportInitialize)dataGridView1).BeginInit();
            pnl_Inferior.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(796, 313);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInscribirActividad
            // 
            btnInscribirActividad.Anchor = AnchorStyles.Top;
            btnInscribirActividad.AutoSize = true;
            btnInscribirActividad.BackColor = Color.AliceBlue;
            btnInscribirActividad.Cursor = Cursors.Hand;
            btnInscribirActividad.FlatStyle = FlatStyle.Flat;
            btnInscribirActividad.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribirActividad.Location = new Point(303, 330);
            btnInscribirActividad.Name = "btnInscribirActividad";
            btnInscribirActividad.Size = new Size(190, 53);
            btnInscribirActividad.TabIndex = 1;
            btnInscribirActividad.Text = "Inscribir";
            btnInscribirActividad.UseVisualStyleBackColor = false;
            btnInscribirActividad.Click += btnInscribirActividad_Click;
            // 
            // pnl_Inferior
            // 
            pnl_Inferior.BackColor = Color.FromArgb(32, 47, 66);
            pnl_Inferior.Dock = DockStyle.Bottom;
            pnl_Inferior.Location = new Point(0, 303);
            pnl_Inferior.Margin = new Padding(3, 2, 3, 2);
            pnl_Inferior.Name = "pnl_Inferior";
            pnl_Inferior.Size = new Size(796, 100);
            pnl_Inferior.TabIndex = 6;
            // 
            // InscribirActividad
            // 
            BackColor = Color.White;
            ClientSize = new Size(796, 403);
            Controls.Add(btnInscribirActividad);
            Controls.Add(dataGridView1);
            Controls.Add(pnl_Inferior);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(812, 442);
            MinimumSize = new Size(812, 442);
            Name = "InscribirActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscribir Actividad";
            Load += InscribirActividad_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            pnl_Inferior.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Panel pnl_Inferior;
        private Button btnInscribirActividad;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void CargarActividades()
        {
            try
            {
                // Verificar si el cliente es NoSocio
                bool esNoSocio = Actividad.EsNoSocio(idC); // idC es el ID del cliente actual.

                // Obtener las actividades desde la base de datos
                List<Actividad> actividades = Actividad.ObtenerActividades();

                // Crear un DataTable para mostrar los resultados
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("idActividad", typeof(int));
                dataTable.Columns.Add("Nombre", typeof(string));
                dataTable.Columns.Add("Cupos Restantes", typeof(string));
                dataTable.Columns.Add("Día", typeof(string));
                dataTable.Columns.Add("Horario", typeof(string));

                // Si el cliente es NoSocio, agregar la columna "Monto"
                if (esNoSocio)
                {
                    dataTable.Columns.Add("Monto", typeof(decimal));
                }

                // Llenar el DataTable con los datos de las actividades
                foreach (var actividad in actividades)
                {
                    string cuposRestantes = $"{actividad.Cupo - actividad.CupoActual}/{actividad.Cupo}";
                    decimal monto = actividad.Monto;

                    // Si el cliente es NoSocio, asignar el monto sin modificarlo
                    if (esNoSocio)
                    {
                        dataTable.Rows.Add(actividad.Id, actividad.Nombre, cuposRestantes, actividad.Dia, actividad.Horario, monto);
                    }
                    else
                    {
                        dataTable.Rows.Add(actividad.Id, actividad.Nombre, cuposRestantes, actividad.Dia, actividad.Horario);
                    }
                }

                // Asignar el DataTable al DataGridView
                dataGridView1.DataSource = dataTable;

                // Ocultar columnas que no son necesarias
                if (dataGridView1.Columns.Contains("idActividad"))
                {
                    dataGridView1.Columns["idActividad"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las actividades: " + ex.Message);
            }
        }

        private void btnInscribirActividad_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una actividad.", "Selección incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int actividadId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idActividad"].Value);

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    // Llamar al procedimiento almacenado para inscribir al cliente en la actividad
                    using (MySqlCommand cmd = new MySqlCommand("InscribirActividad", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros necesarios
                        cmd.Parameters.AddWithValue("@p_id_cliente", idC); // Suponiendo que `idC` es el ID del cliente
                        cmd.Parameters.AddWithValue("@p_id_actividad", actividadId);

                        // Usamos un DataReader para capturar la salida del procedimiento
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string mensaje = reader.GetString(0); // Obtener el mensaje que retorna el procedimiento
                                MessageBox.Show(mensaje);
                            }
                        }
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    // En caso de que haya un error en la conexión o en la ejecución
                    MessageBox.Show("Error al inscribir al cliente: " + ex.Message);
                }
            }
        }


        private void InscribirActividad_Load(object sender, EventArgs e)
        {

        }


    }
}

