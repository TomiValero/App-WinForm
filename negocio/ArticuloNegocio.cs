using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos accesoDatos = new AccesoDatos();

        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            try
            {
                accesoDatos.SetearConsulta(
                 "SELECT Codigo, Nombre, A.Descripcion, C.Descripcion AS CDescripcion, M.Descripcion AS MDescripcion, A.Precio AS PRECIO, A.IdCategoria AS ICategoria, A.IdMarca AS IMarca, A.Id AS IdArt " +
                 "FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id"
                );
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read()) {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)accesoDatos.Lector["IdArt"];
                    articulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Precio = (decimal)accesoDatos.Lector["PRECIO"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatos.Lector["ICategoria"];
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["CDescripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatos.Lector["IMarca"];
                    articulo.Marca.Descripcion = (string)accesoDatos.Lector["MDescripcion"];
                    listaArticulos.Add(articulo);
                }
                return listaArticulos;
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

        public int Agregar(Articulo articulo)
        {
            int idArt;
            try
            {
                accesoDatos.SetearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio) " +
                    "OUTPUT INSERTED.ID " +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca, @Precio)"
                );
                accesoDatos.SetearParametros("@Codigo", articulo.Codigo);
                accesoDatos.SetearParametros("@Nombre", articulo.Nombre);
                accesoDatos.SetearParametros("@Descripcion", articulo.Descripcion);
                accesoDatos.SetearParametros("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.SetearParametros("@IdMarca", articulo.Marca.Id);
                accesoDatos.SetearParametros("@Precio", articulo.Precio);
                idArt = accesoDatos.EjecutarScalar();
                return idArt;
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

        public void Modificar(Articulo articulo)
        {           
            try
            {
                accesoDatos.SetearConsulta("UPDATE ARTICULOS SET Codigo=@Codigo,Nombre= @Nombre, Descripcion=@Descripcion,IdCategoria= @IdCategoria,Precio= @Precio, IdMarca= @IdMarca WHERE Id =" + articulo.Id); 
                accesoDatos.SetearParametros("@Codigo", articulo.Codigo);
                accesoDatos.SetearParametros("@Nombre", articulo.Nombre);
                accesoDatos.SetearParametros("@Descripcion", articulo.Descripcion);
                accesoDatos.SetearParametros("@IdCategoria", articulo.Categoria.Id);
                accesoDatos.SetearParametros("@Precio", articulo.Precio);
                accesoDatos.SetearParametros("@Id", articulo.Id);
                accesoDatos.SetearParametros("@IdMarca", articulo.Marca.Id);
                accesoDatos.EjecutarAccion();
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

        public void Eliminar(int ID) {
            try {
                accesoDatos.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @ID");
                accesoDatos.SetearParametros("@Id", ID);
                accesoDatos.EjecutarAccion();
            } catch (Exception exception) {
                throw exception;
            }
        }
    }
}
