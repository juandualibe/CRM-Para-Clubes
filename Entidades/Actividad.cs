using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Entidades
{
    internal class Actividad
    {
        private int id;
        private string nombre;
        private int cupo;
        private int cupoActual;
        private string dia;
        private string horario;
        private decimal monto;

        public Actividad(int id, string nombre, int cupo, int cupoActual, string dia, string horario, decimal monto)
        {
            this.id = id;
            this.nombre = nombre;
            this.cupo = cupo;
            this.cupoActual = cupoActual;
            this.dia = dia;
            this.horario = horario;
            this.monto = monto;
        }

        // Propiedades públicas para acceder a los valores de los campos privados
        public int Id => id;
        public string Nombre => nombre;
        public int Cupo => cupo;
        public int CupoActual => cupoActual;
        public string Dia => dia;
        public string Horario => horario;
        public decimal Monto => monto;

        public static List<Actividad> ObtenerActividades()
        {
            List<Actividad> listaActividades = new List<Actividad>();
            string query = "SELECT * FROM Actividad";

            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Cargar las columnas desde la base de datos
                            int id = reader.GetInt32("idActividad");
                            string nombre = reader.GetString("Nombre");
                            int cupo = reader.GetInt32("Cupo");
                            int cupoActual = reader.GetInt32("CupoActual");
                            string dia = reader.GetString("dia");
                            string horario = reader.GetString("horario");
                            decimal monto = reader.GetDecimal("monto");

                            // Crear una nueva instancia de Actividad con los datos de la base de datos
                            Actividad actividad = new Actividad(id, nombre, cupo, cupoActual, dia, horario, monto);
                            listaActividades.Add(actividad);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las actividades: " + ex.Message);
                }
            }

            return listaActividades;
        }


        public bool VerificarCupoDisponible()
        {
            return cupoActual < cupo;
        }

        public void IncrementarCupo()
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand("incrementarCupoActual", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("idAct", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al incrementar cupo de actividad: " + ex.Message);
                }
            }
        }
        public void EliminarActividad(int idActividad)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())  // Iniciar una transacción
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM inscripciones WHERE idActividad = @idActividad", connection))
                        {
                            cmd.Parameters.AddWithValue("@idActividad", idActividad);
                            cmd.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd = new MySqlCommand("sp_EliminarActividad", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("id", idActividad);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la actividad: " + ex.Message);
                }
            }
        }

        public static bool EsNoSocio(int idCliente)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM NoSocio WHERE id_cliente = @idCliente";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void ActualizarMonto(int idActividad, decimal nuevoMonto)
        {
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    connection.Open();

                    // Actualizamos el monto de la actividad en la base de datos
                    string query = "UPDATE Actividad SET monto = @monto WHERE idActividad = @idActividad";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@monto", nuevoMonto);
                        cmd.Parameters.AddWithValue("@idActividad", idActividad);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Monto actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el monto de la actividad: " + ex.Message);
                }
            }
        }
        public override string ToString()
        {
            return Nombre; // Esto se mostrará en el ComboBox de NoSocio.
        }
    }
}