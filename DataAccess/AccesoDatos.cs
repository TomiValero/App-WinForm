using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class AccesoDatos
    {
        private SqlConnection conexion { get; }
        private SqlCommand comando { get; }
        private SqlDataReader lector;
        public SqlDataReader Lector { get; set; }

 
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void SetearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                Lector = lector;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EjecutarScalar()
        {

            int idart;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                idart = (int)comando.ExecuteScalar();
                CerrarConexion();

                return idart;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void SetearParametros(string name, object value)
        {
            comando.Parameters.AddWithValue(name, value);
        }
        public void CerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
