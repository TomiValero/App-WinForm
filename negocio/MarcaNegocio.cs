using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using dominio;

namespace negocio
{
    public class MarcaNegocio
        {
           private List<Marca> lista = new List<Marca>();
           private AccesoDatos accesoMarca = new AccesoDatos();
            private bool ComprobarDato(Marca m)
            {
                foreach (Marca marca in lista)
                {
                    if(marca.Descripcion == m.Descripcion)
                    {
                        return true;
                    }
                }
                return false;
            }
            public List<Marca> Listar()
            {
         

                try
                {
                    accesoMarca.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                    accesoMarca.EjecutarLectura();

                    while (accesoMarca.Lector.Read())
                    {
                        Marca aux = new Marca();
                        aux.Id = (int)accesoMarca.Lector["Id"];

                        if (!(accesoMarca.Lector["Descripcion"] is DBNull))
                            aux.Descripcion = (string)accesoMarca.Lector["Descripcion"];
                        if (!(ComprobarDato(aux)))
                        { 
                            lista.Add(aux);
                        }
                    
                    }

                    return lista;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    accesoMarca.CerrarConexion();
                }

            }
            public void Agregar(Marca marca)
            {
           
                try
                {
                    accesoMarca.SetearConsulta("INSERT INTO MARCAS VALUES ('" +marca.Descripcion + "')");
                    accesoMarca.EjecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                   accesoMarca.CerrarConexion();
                }
            }
            public void Modificar(Marca marca)
            {
          
                try
                {
                    accesoMarca.SetearConsulta("UPDATE MARCAS SET Descripcion = '" + marca.Descripcion + "' WHERE ID = " + marca.Id);
                    accesoMarca.EjecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    accesoMarca.CerrarConexion();
                }
            }


            public void Eliminar(int id)
            {
           
                try
                {
                   accesoMarca.SetearConsulta("DELETE MARCAS WHERE Id =" + id);
                    accesoMarca.EjecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    accesoMarca.CerrarConexion();
                }
            }
    }
}
