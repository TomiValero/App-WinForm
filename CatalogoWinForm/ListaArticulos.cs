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
using negocio;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatalogoWinForm
{
    public partial class ListaArticulos : Form
    {
        private List<Articulo> listaArticulos = new List<Articulo>();

        public ListaArticulos() {
            InitializeComponent();
        }

        private void ListaArticulos_Load(object sender, EventArgs e) {
            Cargar();
        }

        private void Cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try {
                listaArticulos = articuloNegocio.Listar();
                dgvListaArticulos.DataSource = listaArticulos;
                OcultarColumnas();
            } catch (Exception exception) {
                MessageBox.Show(exception.ToString());
            }
        }

        private void OcultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
        }


        private void BtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AltaArticulo agregarArticulo = new AltaArticulo();
            agregarArticulo.ShowDialog();
            Cargar();
        }

        private void BtnDetalle_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;

                DetalleArticulo detalleArticulo = new DetalleArticulo(articulo);
                detalleArticulo.ShowDialog();
            }
            else MessageBox.Show("Seleccione una columna");
        }

        private void BtnModificarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvListaArticulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                AltaArticulo modificarArticulo = new AltaArticulo(articulo);
                modificarArticulo.ShowDialog();
                Cargar();
            }
            else MessageBox.Show("Seleccione una columna");
        }

        private void BtnEliminar_Click(object sender, EventArgs e) {
            if(dgvListaArticulos.CurrentRow != null) {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                try {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes) {
                        Articulo articulo = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                        articuloNegocio.Eliminar(articulo.Id);
                        Cargar();
                    }
                } catch (Exception exception) {
                    MessageBox.Show(exception.ToString());
                }
            } else {
                MessageBox.Show("Seleccione una columna");
            }
        }


        private void menuMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMarcas ventana = new ListaMarcas();
            ventana.ShowDialog();
        }

        private void menuCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCategorias ventana = new ListaCategorias();
            ventana.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string textoFiltrado = txtBuscar.Text.ToUpper();

            if (textoFiltrado != "")
            {
                listaFiltrada = listaArticulos.FindAll(articulo => articulo.Codigo.ToUpper().Contains(textoFiltrado) ||
                                articulo.Nombre.ToUpper().Contains(textoFiltrado) ||
                                articulo.Descripcion.ToUpper().Contains(textoFiltrado) ||
                                articulo.Categoria.Descripcion.ToUpper().Contains(textoFiltrado) ||
                                articulo.Marca.Descripcion.ToUpper().Contains(textoFiltrado));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            btnDetalle.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificarArticulo.Enabled = true;

            if (listaFiltrada.Count <= 0)
            {
                btnDetalle.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificarArticulo.Enabled = false;
            }
            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            OcultarColumnas();
        }
    }
}
