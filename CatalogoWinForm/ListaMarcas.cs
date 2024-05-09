using dominio;
using negocio;
using System;
using System.Collections;
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
    public partial class ListaMarcas : Form
    {
        private List<Marca> listaMarca;
        public ListaMarcas()
        {
            InitializeComponent();

        }

        private void Cargar()
        {

            MarcaNegocio marcaNegocio = new MarcaNegocio();


            try
            {
                listaMarca = marcaNegocio.Listar();

                dgvListaMarcas.DataSource = listaMarca;
                OcultarColumnas();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar los datos, comuniquese con el servicio tecnico");

            }
        }


        private void ListaMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void OcultarColumnas()
        {
            dgvListaMarcas.Columns["Id"].Visible = false;
        }

        private void BtnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            Cargar();
        }

        private void BtnModificarMarcas_Click(object sender, EventArgs e)
        {
            if (dgvListaMarcas.CurrentRow != null)
            {
                try
                {
                    Marca seleccionado;

                    seleccionado = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;

                    frmAgregarMarca marca = new frmAgregarMarca(seleccionado);
                    marca.ShowDialog();
                    Cargar();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else MessageBox.Show("Seleccione una Marca");
            
            
        }



        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvListaMarcas.CurrentRow != null)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca seleccionado;

                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Estas seguro de eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Marca)dgvListaMarcas.CurrentRow.DataBoundItem;
                        if (ComprobarEliminacion(seleccionado.Id) == false)
                        {
                            marcaNegocio.Eliminar(seleccionado.Id);
                            MessageBox.Show("Eliminado correctamente");
                            Cargar();
                        }
                        else MessageBox.Show("La Marca que intenta eliminar esta en uso");



                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un error al eliminar los datos, comuniquese con el servicio tecnico");
                }
            }
            else MessageBox.Show("Seleccione una Marca");
            
        }

        private bool ComprobarEliminacion(int id)
        {
            List<int> listaUsados = new List<int>();
            AccesoDatos accesoDatos = new AccesoDatos();
            bool Usando = false;
            try
            {
                accesoDatos.SetearConsulta("SELECT IdMarca FROM ARTICULOS");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    listaUsados.Add((int)accesoDatos.Lector["IdMarca"]);
                }
                foreach (var item in listaUsados)
                {
                    if (id == item)
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

        private void TbBuscarMarcas_TextChanged(object sender, EventArgs e)
        {      
            List<Marca> listafiltrada;
            string filtro = tbBuscarMarcas.Text;
            if (filtro != "")
            {
                listafiltrada = listaMarca.FindAll(x => x.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listafiltrada = listaMarca;
            }

            dgvListaMarcas.DataSource = null;
            dgvListaMarcas.DataSource = listafiltrada;
            OcultarColumnas();
            btnModificarMarcas.Enabled = true;
            btnEliminarMarca.Enabled = true;
            if (listafiltrada.Count <= 0)
            {
                btnModificarMarcas.Enabled = false;
                btnEliminarMarca.Enabled = false;
            }
            
        }

    }
    
}