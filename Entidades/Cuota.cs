using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoG3.Entidades
{
    internal class Cuota
    {
        private int id;
        private int id_cliente;
        private decimal monto;
        private DateTime fecha_pago;

        public Cuota(int id, int id_cliente, decimal monto, DateTime fecha_pago)
        {
            this.id = id;
            this.id_cliente = id_cliente;
            this.monto = monto;
            this.fecha_pago = fecha_pago;
        }

        // Propiedades de solo lectura usando la sintaxis abreviada para getters
        public int Id => id;
        public int IdCliente => id_cliente;
        public decimal Monto => monto;
        public DateTime FechaPago => fecha_pago;

        public static List<Cuota> ListarCuotas()
        {
            List<Cuota> listaCuotas = new List<Cuota>();

            // Abre la conexión
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Define la consulta SQL
                string query = @"
        SELECT 
            c.id_cuota AS Id,
            c.id_cliente AS IdCliente,
            c.monto AS Monto,
            c.fecha_pago AS FechaPago
        FROM 
            Cuota c
        JOIN 
            Cliente cl ON c.id_cliente = cl.id_cliente
        WHERE 
            DATE_ADD(c.fecha_pago, INTERVAL 1 MONTH) = CURRENT_DATE;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuota cuota = new Cuota(
                                reader.GetInt32("Id"),
                                reader.GetInt32("IdCliente"),
                                reader.GetDecimal("Monto"),
                                reader.GetDateTime("FechaPago")
                            );
                            listaCuotas.Add(cuota);
                        }
                    }
                }
            }
            return listaCuotas;
        }

    }
}
