using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using DataAccess;
using negocio;

namespace CatalogoWinForm
{
    public partial class ListaCategorias : Form
    {
        private List<Categoria> listaCategoria;
        public ListaCategorias()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            CategoriaNegocio catategoriaNeg = new CategoriaNegocio();
            try
            {          
                listaCategoria = catategoriaNeg.Listar();
                dgvListaCategorias.DataSource = listaCategoria;
                OcultarColumnas();

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");
            }
            
        }
        private void OcultarColumnas()
        {
            dgvListaCategorias.Columns["Id"].Visible = false;
        }

        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void BtnAgregarCategorias_Click(object sender, EventArgs e)
        {
            AltaCategoria altaCategoria = new AltaCategoria();
            altaCategoria.ShowDialog();
            Cargar();
        }


        private void BtnModificarCategorias_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.CurrentRow != null)
            {
                try
                {
                    Categoria seleccionado;

                    seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;

                    AltaCategoria ModCategoria = new AltaCategoria(seleccionado);
                    ModCategoria.ShowDialog();
                    Cargar();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else MessageBox.Show("Seleccione una Categoria");     
            
        }

        private void BtnEliminarCategorias_Click(object sender, EventArgs e)
        {
            if (dgvListaCategorias.CurrentRow != null)
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria seleccionado;

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;
                        if (!(ComprobarEliminacion(seleccionado.Id)))
                        {
                            categoriaNegocio.Eliminar(seleccionado.Id);
                            MessageBox.Show("Eliminado correctamente");
                            Cargar();
                        }
                        else MessageBox.Show("La categoria que intenta eliminar esta en uso");



                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un error al eliminar los datos, comuniquese con el servicio tecnico");
                }
            }
            else MessageBox.Show("Seleccione una Categoria");
            
        }

        private bool ComprobarEliminacion(int id)
        {
            List<int> listaUsados = new List<int>();
            AccesoDatos accesoDatos = new AccesoDatos();
            bool Usando = false;
            try
            {
                accesoDatos.SetearConsulta("SELECT IdCategoria FROM ARTICULOS");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    listaUsados.Add((int)accesoDatos.Lector["IdCategoria"]);
                }
                foreach (int item in listaUsados)
                {
                    if(id == item)
                    {
                        Usando = true; 
                    }
                }
                return Usando;
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

        private void TbBuscarCategorias_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listafiltrada;
            string filtro = tbBuscarCategorias.Text;
            if (filtro != "")
            {
                listafiltrada = listaCategoria.FindAll(x => x.Descripcion.ToLower().Contains(filtro.ToLower()) || x.Id.ToString() == filtro);
            }
            else
            {
                listafiltrada = listaCategoria;
            }

            dgvListaCategorias.DataSource = null;
            dgvListaCategorias.DataSource = listafiltrada;
            OcultarColumnas();
            btnModificarCategorias.Enabled = true;
            btnEliminarCategorias.Enabled = true;
            if (listafiltrada.Count <= 0)
            {
                btnModificarCategorias.Enabled = false;
                btnEliminarCategorias.Enabled = false;
            }
        }
    }
}
