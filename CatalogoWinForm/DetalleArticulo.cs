using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace CatalogoWinForm
{
    public partial class DetalleArticulo : Form
    {
        private List<string> listaImagen = new List<string>();

        private Articulo articulo = null;

        private int indi = -1;

        public DetalleArticulo()
        {
            InitializeComponent();
        }

        public DetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            indi = -1;


            try
            {

                lblCodigo.Text = articulo.Codigo;
                lblNombre.Text = articulo.Nombre;
                lblCategoria.Text = articulo.Categoria.Descripcion;
                lblPrecio.Text = articulo.Precio.ToString();
                lblDescripcion.Text = articulo.Descripcion;
                listaImagen = imagenNegocio.Imagenes(articulo);


                if (listaImagen.Count <= 0)
                {
                    MessageBox.Show("Este articulo no tiene imagenes");
                }
                else
                {
                    indi++;

                    try
                    {
                        pbxCuadroImagen.Load(listaImagen[indi]);
                    }
                    catch (Exception)
                    {
                        indi = 0;
                        BtnNextImgDetalles_Click(sender, e);

                    }

                }


            }


            catch (Exception)
            {
                MessageBox.Show("Algunas Imagenes de este Articulo NO estan disponible, comuniquese con el servicio tecnico");
            }
        }

        private void BtnNextImgDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (indi < listaImagen.Count - 1)
                {
                    indi++;

                    pbxCuadroImagen.Load(listaImagen[indi]);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imagen No disponible, comuniquese con el servicio tecnico");
                listaImagen.Remove(pbxCuadroImagen.ImageLocation);
                indi = 0;
                try
                {
                    pbxCuadroImagen.Load(listaImagen[indi]);
                }
                catch (Exception)
                {

                    ImgDefoult();
                }


            }


        }

        private void BtnBeforeImgDetalles_Click(object sender, EventArgs e)
        {
            try
            {

                if (indi > 0)
                {
                    indi--;
                    pbxCuadroImagen.Load(listaImagen[indi]);
                }
            }
            catch (Exception)
            {
                listaImagen.Remove(pbxCuadroImagen.ImageLocation);
                MessageBox.Show("Imagen No disponible, comuniquese con el servicio tecnico");
                indi = 0;
                try
                {
                    pbxCuadroImagen.Load(listaImagen[indi]);
                }
                catch (Exception)
                {

                    ImgDefoult();
                }
            }
        }
        private void ImgDefoult()
        {
            try
            {

                pbxCuadroImagen.Load("https://th.bing.com/th/id/OIP.WeSkkwLXkUXbRcLJuN7I_gHaHa?rs=1&pid=ImgDetMain");

            }
            catch (Exception)
            {

                MessageBox.Show("No funciona la defoult");
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
