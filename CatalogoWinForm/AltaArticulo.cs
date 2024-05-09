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
using System.Data.SqlTypes;

namespace CatalogoWinForm
{
    public partial class AltaArticulo : Form
    {
        public int idArt;

        private List<string> img = new List<string>();

        private Articulo articulo = null;

        int indice = -1;

        public bool i = false;

        public AltaArticulo()
        {
            InitializeComponent();
        }

        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            i = true;
        }

        private bool ValidarFiltro() {
            if (string.IsNullOrEmpty(txtNombre.Text)) {
                MessageBox.Show("Por favor, ingrese un Nombre.");
                return true;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text)) {
                MessageBox.Show("Por favor, ingrese un Codigo.");
                return true;
            }
            if (cboCategoria.SelectedIndex < 0) {
                MessageBox.Show("Por favor, seleccione una Categoría.");
                return true;
            }
            if(cboMarca.SelectedIndex < 0) {
                MessageBox.Show("Por favor, seleccione una Marca.");
                return true;
            }
            if (ValidarNumeros(txtPrecio.Text)) {
                MessageBox.Show("El Precio no debe contener letras.");
                return true;
            } 
            if (txtPrecio.Text.Length <= 0) {
                MessageBox.Show("Por favor, ingrese un Precio ");
                return true;
            }
            return false;
        }

        private bool ValidarNumeros(string cadena) {
            bool necesitaValidacion = false;
            foreach (var caracter in cadena) {
                string car = caracter.ToString();
                if((!char.IsNumber(caracter)) && (car != ",")) {
                    return true;
                }
            }
            return necesitaValidacion;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            Articulo articulonuevo = new Articulo();
            try
            {
                if (ValidarFiltro())
                {
                    return;
                }
                else
                {
               
                    articulonuevo.Codigo = txtCodigo.Text;
                    articulonuevo.Nombre = txtNombre.Text;
                    articulonuevo.Descripcion = txtDescripcion.Text;
                    articulonuevo.Categoria = (Categoria)cboCategoria.SelectedItem;
                    articulonuevo.Marca = (Marca)cboMarca.SelectedItem;
                    articulonuevo.Precio = decimal.Parse(txtPrecio.Text);

                    if (i == false)
                    {
                        idArt = articuloNegocio.Agregar(articulonuevo);
                        imagenNegocio.Agregar(img, idArt);
                        MessageBox.Show("Agregado correctamente");
                        Close();
                    }
                    else if (i == true)
                    {
                        articulonuevo.Id = articulo.Id;
                        articuloNegocio.Modificar(articulonuevo);
                        imagenNegocio.Eliminar(articulonuevo.Id);
                        imagenNegocio.Agregar(img, articulo.Id);
                        MessageBox.Show("Modificado correctamente");
                        Close();
                    }
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();  
            try
            {
                cboCategoria.DataSource = categoriaNegocio.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = marcaNegocio.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    img = imagenNegocio.Imagenes(articulo);
                    i = true;

                    if (img.Count <= 0)
                    {
                        MessageBox.Show("Este articulo no tiene imagenes");
                    }
                    else
                    {
                        indice++;

                        try
                        {
                            pbImgAgregar.Load(img[indice]);
                        }
                        catch (Exception)
                        {
                            indice = 0;                         
                            BtnNextImg_Click(sender, e);
                        }
                    }
                } else {
                    cboCategoria.SelectedIndex = -1;
                    cboMarca.SelectedIndex = -1;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void BtnSubirImgAgregarArt_Click(object sender, EventArgs e)
        {
            
                try
                {
                    pbImgAgregar.Load(txtUrlImg.Text);
                    img.Add(txtUrlImg.Text);
                    indice = img.Count() - 1;
                    txtUrlImg.Text = "";
                }
                catch (Exception)
                {
                    if (indice >= 0)
                    {
                        pbImgAgregar.Load(img[indice]);
                    }
                    else
                    {
                        ImgDefoult();
                    }

                    txtUrlImg.Text = "";
                    MessageBox.Show("Imagen no encontrada");
                }
             
        }

        private void BtnNextImg_Click(object sender, EventArgs e)
        {
            if (i == false)
            {
                try
                {

                    if (indice < img.Count - 1)
                    {
                        indice++;
                        pbImgAgregar.Load(img[indice]);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (i == true)
            {
                try
                {
                    if (indice < img.Count - 1)
                    {
                        indice++;

                        pbImgAgregar.Load(img[indice]);

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Imagen No disponible, comuniquese con el servicio tecnico");
                    img.Remove(pbImgAgregar.ImageLocation);
                    indice = 0;
                    try
                    {
                        pbImgAgregar.Load(img[indice]);
                    }
                    catch (Exception)
                    {

                        ImgDefoult();
                    }
                }
            }
        }

        private void BtnBeforeImg_Click(object sender, EventArgs e)
        {
            if (i == false)
            {
                try
                {

                    if (indice > 0)
                    {
                        indice--;
                        pbImgAgregar.Load(img[indice]);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else if (i == true)
            {
                try
                {
                    if (indice > 0)
                    {
                        indice--;
                        pbImgAgregar.Load(img[indice]);
                    }
                }
                catch (Exception)
                {
                    img.Remove(pbImgAgregar.ImageLocation);
                    MessageBox.Show("Imagen No disponible, comuniquese con el servicio tecnico");
                    indice = 0;
                    try
                    {
                        pbImgAgregar.Load(img[indice]);
                    }
                    catch (Exception)
                    {
                        ImgDefoult();
                    }
                }
            }
        }

        private void BtnEliminarImg_Click(object sender, EventArgs e)
        {
            try
            {
                img.Remove(pbImgAgregar.ImageLocation);
                indice=0;
                try
                {
                    pbImgAgregar.Load(img[indice]);
                }
                catch (Exception)
                {
                    ImgDefoult();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay imagenes para eliminar");
            }

        }

        private void ImgDefoult()
        {
            try
            {
                pbImgAgregar.Load("https://th.bing.com/th/id/OIP.WeSkkwLXkUXbRcLJuN7I_gHaHa?rs=1&pid=ImgDetMain");
            }
            catch (Exception)
            {
                MessageBox.Show("No funciona la defoult");
            }
        }
    }
}
