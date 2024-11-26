using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ClubDeportivoG3.Datos
{
    internal class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private Conexion()
        {
            this.baseDatos = "baseusuarios";
            this.servidor = "";
            this.puerto = "";
            this.usuario = "";  
            this.clave = "";   
        }

        public void SetCredenciales(string servidor, string puerto, string usuario, string clave)
        {
            this.servidor = servidor;
            this.puerto = puerto;
            this.usuario = usuario;
            this.clave = clave;
        }

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        public bool ValidarCredenciales(string servidor, string puerto, string usuario, string clave)
        {
            SetCredenciales(servidor, puerto, usuario, clave);

            using (var conexionPrueba = CrearConexion())
            {
                try
                {
                    conexionPrueba.Open();
                    conexionPrueba.Close();
                    return true; // Credenciales válidas
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de autenticación, revise los datos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}
