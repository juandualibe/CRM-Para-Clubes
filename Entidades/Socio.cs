using ClubDeportivoG3.Datos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iText.Layout.Properties;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using System.Data;






namespace ClubDeportivoG3.Entidades
{
    internal class Socio : Cliente
    {
        private int id;
        private bool carnetEntrega;
        private decimal cuotaMensual;
        private bool estadoPago;

        public Socio(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico, int id, bool carnetEntrega, decimal cuotaMensual, bool estadoPago)
            : base(nombre, apellido, dni, mail, telefono, aptoFisico)
        {
            this.id = id;
            this.carnetEntrega = carnetEntrega;
            this.cuotaMensual = cuotaMensual;
            this.estadoPago = estadoPago;
        }

        // Propiedades de solo lectura usando la sintaxis abreviada para getters
        public int Id => id;
        public bool CarnetEntrega => carnetEntrega;
        public decimal CuotaMensual => cuotaMensual;
        public bool EstadoPago => estadoPago;

        public void AbonarCuota()
        {
            estadoPago = true;
            
        }    
        

        public static List<Socio> ListarSocios() // Método estático para listar todos los socios
        {
            List<Socio> listaSocios = new List<Socio>(); // Creamos una lista para almacenar los socios

            // Abrimos una conexión a la base de datos
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Ejecutamos el procedimiento para actualizar el estado de pago de los socios
                using (MySqlCommand cmdActualizarEstado = new MySqlCommand("ActualizarEstadoPagoSocios", connection))
                {
                    cmdActualizarEstado.CommandType = CommandType.StoredProcedure;
                    cmdActualizarEstado.ExecuteNonQuery(); // Ejecutamos el procedimiento
                }

                // Definimos la consulta SQL para obtener datos de socios y clientes
                string query = @"
        SELECT 
            c.id_cliente AS id, 
            c.nombre, 
            c.apellido, 
            c.dni, 
            c.mail, 
            c.telefono,
            c.apto_fisico,
            s.carnet_entregado AS carnet, 
            s.cuota_mensual, 
            s.estado_pago AS estadoPago 
        FROM 
            Socio s 
        JOIN 
            Cliente c ON s.id_cliente = c.id_cliente;";

                // Preparamos el comando con la consulta y la conexión
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Ejecutamos el comando y obtenemos un lector para leer los resultados
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iteramos sobre cada fila de resultados
                        while (reader.Read())
                        {
                            // Obtenemos el ID del socio
                            int id = reader.GetInt32("id");

                            // Verificamos si el socio ya está en la lista usando su ID
                            var socioExistente = listaSocios.FirstOrDefault(s => s.Id == id); // var permite inferir el tipo de la variable automáticamente basado en el valor que se le asigna.

                            if (socioExistente == null) // Si no existe, lo creamos
                            {
                                
                                // Creamos un nuevo objeto Socio con los datos leídos
                                Socio socio = new Socio(
                                    reader.GetString("nombre"),
                                    reader.GetString("apellido"),
                                    reader.GetString("dni"),
                                    reader.GetString("mail"),
                                    reader.GetString("telefono"),
                                    reader.GetBoolean("apto_fisico"),
                                    id, // ID del cliente
                                    reader.GetBoolean("carnet"), // carnetEntrega
                                    reader.GetDecimal("cuota_mensual"),
                                    reader.GetBoolean("estadoPago")
                                );
                                
                                // Agregamos el nuevo socio a la lista
                                listaSocios.Add(socio);
                            }
                        }
                    }
                }
            }
            return listaSocios; // Retornamos la lista de socios
        }

        public static Socio BuscarSocio(int idCliente) // Método estático para buscar un socio
        {
            Socio socio = null; // Inicializamos socio como null en caso de no encontrarlo.
            // Abrimos una conexión a la base de datos
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                // Definimos la consulta SQL para obtener datos del socio
                string query = @$"
        SELECT  
            c.nombre,
            c.apellido,
            c.dni,
            c.mail,
            c.telefono,
            c.apto_fisico,
            s.carnet_entregado AS carnet,
            s.cuota_mensual,
            s.estado_pago AS estadoPago
        FROM
            Socio s
        JOIN
            Cliente c ON s.id_cliente = c.id_cliente
        WHERE
            s.id_cliente = {idCliente};";
                // Preparamos el comando con la consulta y la conexión
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Ejecutamos el comando y obtenemos un lector para leer los resultados
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificamos si hay resultados
                        if (reader.Read())
                        {
                            // Creamos un nuevo objeto Socio con los datos leídos
                            socio = new Socio(
                                reader.GetString("nombre"),
                                reader.GetString("apellido"),
                                reader.GetString("dni"),
                                reader.GetString("mail"),
                                reader.GetString("telefono"),
                                reader.GetBoolean("apto_fisico"),
                                idCliente, // ID del cliente
                                reader.GetBoolean("carnet"), // carnetEntrega
                                reader.GetDecimal("cuota_mensual"),
                                reader.GetBoolean("estadoPago")
                            );
                        }
                    }
                }
            }
            return socio; // Retornamos el socio
        }


        
        //Metodo para validar la existencia del usuario en la BD por medio del DNI
        public static bool ExisteEnBaseDeDatos(string dni)
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Consulta para verificar la existencia del DNI
                    string query = "SELECT COUNT(*) FROM Cliente WHERE DNI = @DNI";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DNI", dni);

                        // Ejecuta la consulta y obtiene el resultado
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Devuelve true si ya existe, de lo contrario false
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar la existencia en la base de datos: {ex.Message}");
                return false;
            }
        }

        // Metodo para registrar al Socio
        public override void DarAlta()
        {
            try
            {
                // Verifica si el socio ya existe antes de intentar agregarlo
                if (ExisteEnBaseDeDatos(this.DNI))
                {
                    MessageBox.Show("El Cliente ya existe en la base de datos.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama al procedimiento almacenado para dar de alta al socio.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Prepara la consulta para llamar al procedimiento almacenado
                    using (MySqlCommand cmd = new MySqlCommand("AgregarSocio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Añadimos los parámetros necesarios para el procedimiento almacenado
                        cmd.Parameters.AddWithValue("p_nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("p_apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("p_dni", this.DNI);
                        cmd.Parameters.AddWithValue("p_mail", this.Mail);
                        cmd.Parameters.AddWithValue("p_telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("p_apto_fisico", this.AptoFisico);
                        cmd.Parameters.AddWithValue("p_cuota_mensual", this.CuotaMensual);
                        cmd.Parameters.AddWithValue("p_carnet_entregado", this.CarnetEntrega);
                        cmd.Parameters.AddWithValue("p_estado_pago", this.EstadoPago);

                        // Ejecutamos el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dar de alta al socio: {ex.Message}");
            }
        }

        public void ModificarSocio(int idCliente)
        {
            try
            {
                // Llama al procedimiento almacenado para modificar los datos del socio.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Prepara la consulta para llamar al procedimiento almacenado
                    using (MySqlCommand cmd = new MySqlCommand("ModificarSocio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Añadimos los parámetros necesarios para el procedimiento almacenado
                        cmd.Parameters.AddWithValue("p_id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("p_nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("p_apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("p_dni", this.DNI);
                        cmd.Parameters.AddWithValue("p_mail", this.Mail);
                        cmd.Parameters.AddWithValue("p_telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("p_apto_fisico", this.AptoFisico);
                        cmd.Parameters.AddWithValue("p_cuota_mensual", this.CuotaMensual);
                        cmd.Parameters.AddWithValue("p_carnet_entregado", this.CarnetEntrega);
                        cmd.Parameters.AddWithValue("p_estado_pago", this.EstadoPago);

                        // Ejecutamos el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar los datos del socio: {ex.Message}");
            }
        }
        public static void GenerarCarnetImagen(Socio socio)
        {
            // Crear instancia del formulario Carnet
            FormCarnet carnet = new FormCarnet();

            // Asignar valores al carnet usando propiedades
            carnet.Nombre = socio.Nombre;
            carnet.Apellido = socio.Apellido;
            carnet.DNI = socio.DNI;
            carnet.Mail = socio.Mail;

            // Mostrar el formulario fuera de pantalla para capturarlo
            carnet.StartPosition = FormStartPosition.Manual;
            carnet.Location = new Point(-2000, -2000); // Ubicación fuera del área visible
            carnet.Show();
            carnet.Refresh();

            // Esperamos a que el formulario se cargue completamente
            System.Threading.Thread.Sleep(500); // Pequeña pausa para asegurarnos de que los controles se actualicen

            // Crear un bitmap del tamaño del formulario
            Bitmap bitmap = new Bitmap(carnet.ClientSize.Width, carnet.ClientSize.Height);  // Usamos el tamaño real del formulario

            // Capturar el contenido del formulario en el bitmap
            carnet.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));

            // Cerrar el formulario una vez capturado
            carnet.Close();

            // Guardar el archivo en la carpeta seleccionada
            string carpetaSeleccionada = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.SelectedPath = carpetaSeleccionada;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    carpetaSeleccionada = folderDialog.SelectedPath;
                }
            }

            string filePath = Path.Combine(carpetaSeleccionada, $"{socio.Nombre}_{socio.Apellido}_Carnet.png");

            // Guardar la imagen en formato PNG
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

            
        }

        public void RegistrarPago(int idCliente)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("RegistrarPago", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_id_cliente", idCliente);

                        // Leer el mensaje que devuelve el procedimiento almacenado
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Verifica si hay algún resultado
                            {
                                string mensaje = reader.GetString("mensaje");
                                MessageBox.Show(mensaje); // Mostrar el mensaje en un MessageBox
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el pago: " + ex.Message);
                }
            }
        }
    }
}
