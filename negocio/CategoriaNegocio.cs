using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoCategoria = new AccesoDatos();    

            try
            {
                accesoCategoria.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoCategoria.EjecutarLectura();

                while (accesoCategoria.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)accesoCategoria.Lector["Id"];

                    if(!(accesoCategoria.Lector["Descripcion"] is DBNull))
                    aux.Descripcion = (string)accesoCategoria.Lector["Descripcion"];

                    lista.Add(aux);
                }
                                                   
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoCategoria.CerrarConexion();
            }
                     
        }

        public void Agregar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("INSERT INTO CATEGORIAS VALUES ('" + nueva.Descripcion + "')");
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                datos.CerrarConexion();
            }
        }

        public void Modificar(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("UPDATE CATEGORIAS SET Descripcion = '" + nueva.Descripcion + "' WHERE ID = " + nueva.Id );
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE CATEGORIAS WHERE Id =" + id );
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
