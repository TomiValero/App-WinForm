using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using DataAccess;

namespace negocio
{
    public class ImagenNegocio
    {
        public List<string> Imagenes(Articulo articulo)
        {
            List<string> listaimagenes = new List<string>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo =" + articulo.Id);
                // accesoDatos.setearParametros("@id", articulo.Id);
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                        listaimagenes.Add((string)accesoDatos.Lector["ImagenUrl"]);

                }
                return listaimagenes;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public void Agregar(List<string> img, int id)
        {

            try
            {
                foreach (string item in img)
                {
                    AccesoDatos datos = new AccesoDatos();
                    datos.SetearConsulta("INSERT INTO IMAGENES VALUES (@IdArticulo,'" + item + "')");
                    datos.SetearParametros("@IdArticulo", id);
                    datos.EjecutarAccion();
                    datos.CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("DELETE IMAGENES WHERE IdArticulo =" + id);
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
