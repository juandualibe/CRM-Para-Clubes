using ClubDeportivoG3.Datos;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net;
using System.Data;

namespace ClubDeportivoG3.Entidades
{
    internal class NoSocio : Cliente
    {
        private int id;
        private decimal pagoDiario;

        public NoSocio(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico, int id, decimal pagoDiario)
            : base(nombre, apellido, dni, mail, telefono, aptoFisico)
        {
            this.id = id;
            this.pagoDiario = pagoDiario;
        }
        public int Id
        {
            get { return id; }
        }

        public decimal PagoDiario
        {
            get { return pagoDiario; }
        }


        public static List<NoSocio> ListarNoSocios()
        {
            List<NoSocio> listaNoSocios = new List<NoSocio>();

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Asegúrate de obtener el campo 'aptoFisico' desde la tabla Cliente
                string query = @"
            SELECT c.id_cliente AS id, c.nombre, c.apellido, c.dni, c.mail, c.telefono, 
                   ns.pago_diario, c.apto_fisico
            FROM NoSocio ns
            JOIN Cliente c ON ns.id_cliente = c.id_cliente";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NoSocio noSocio = new NoSocio(
                                reader.GetString("nombre"),
                                reader.GetString("apellido"),
                                reader.GetString("dni"),
                                reader.GetString("mail"),
                                reader.GetString("telefono"),
                                reader.GetBoolean("apto_fisico"),  // Leer 'apto_fisico' de la tabla Cliente
                                reader.GetInt32("id"),
                                reader.GetDecimal("pago_diario")
                            );
                            listaNoSocios.Add(noSocio);
                        }
                    }
                }
            }

            return listaNoSocios;
        }


        public void abonarActividad(int idActividad, decimal monto)
        {
            // Verificar si el monto a abonar es válido
            if (monto <= 0)
            {
                Console.WriteLine("El monto a abonar debe ser mayor que cero.");
                return;
            }

            // Lógica para realizar el pago
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Consultamos el saldo actual del NoSocio, si lo deseas hacer así
                string querySaldo = "SELECT saldo FROM NoSocio WHERE id_cliente = @id_cliente";
                using (MySqlCommand commandSaldo = new MySqlCommand(querySaldo, connection))
                {
                    commandSaldo.Parameters.AddWithValue("@id_cliente", this.Id);

                    var saldoActual = commandSaldo.ExecuteScalar();

                    if (saldoActual != null && Convert.ToDecimal(saldoActual) >= monto)
                    {
                        // Si el saldo es suficiente, procesamos el pago
                        string queryPago = "INSERT INTO Pagos (id_cliente, id_actividad, monto_pago, fecha_pago) VALUES (@id_cliente, @actividadId, @monto, NOW())";
                        using (MySqlCommand commandPago = new MySqlCommand(queryPago, connection))
                        {
                            commandPago.Parameters.AddWithValue("@id_cliente", this.Id);
                            commandPago.Parameters.AddWithValue("@actividadId", idActividad);
                            commandPago.Parameters.AddWithValue("@monto", monto);

                            int resultado = commandPago.ExecuteNonQuery();

                            if (resultado > 0)
                            {
                                Console.WriteLine("Pago registrado con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("Hubo un error al registrar el pago.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para realizar el pago.");
                    }
                }
            }
        }

        //Metodo para guardar No Socio en la base de datos
        public override void DarAlta()
        {
            try
            {
                // Verifica si el No Socio ya existe antes de intentar agregarlo
                if (Socio.ExisteEnBaseDeDatos(this.DNI))
                {
                    MessageBox.Show("El Cliente ya existe en la base de datos.", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llama al procedimiento almacenado para dar de alta al No Socio
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Prepara la consulta para llamar al procedimiento almacenado
                    using (MySqlCommand cmd = new MySqlCommand("AgregarNoSocio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Añade los parámetros necesarios para el procedimiento almacenado
                        cmd.Parameters.AddWithValue("p_nombre", this.Nombre);
                        cmd.Parameters.AddWithValue("p_apellido", this.Apellido);
                        cmd.Parameters.AddWithValue("p_dni", this.DNI);
                        cmd.Parameters.AddWithValue("p_mail", this.Mail);
                        cmd.Parameters.AddWithValue("p_telefono", this.Telefono);
                        cmd.Parameters.AddWithValue("p_apto_fisico", this.AptoFisico);
                        cmd.Parameters.AddWithValue("p_pago_diario", this.PagoDiario);

                        // Ejecuta el procedimiento almacenado
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dar de alta al No Socio: {ex.Message}");
            }
        }
    }
}
