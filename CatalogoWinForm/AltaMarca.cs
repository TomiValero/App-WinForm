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


namespace CatalogoWinForm
{
    public partial class frmAgregarMarca : Form
    {

        private Marca marca = null;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        public frmAgregarMarca(Marca seleccionado)
        {
            InitializeComponent();
            marca = seleccionado;
        }

        private void FrmAgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    tbAgregarMarca.Text = marca.Descripcion;
                    lblTituloAgregarMarca.Text = "MODIFICAR MARCA";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio= new MarcaNegocio();
            try
            {
                if (tbAgregarMarca.Text.Length > 0)
                {
                    if (marca == null)
                    {
                        marca = new Marca();
                    }


                   marca.Descripcion = tbAgregarMarca.Text;
                    if (marca.Id != 0)
                    {
                        marcaNegocio.Modificar(marca);
                        MessageBox.Show("Modificado correctamente");

                    }
                    else
                    {
                        marcaNegocio.Agregar(marca);
                        MessageBox.Show("Agregado correctamente");
                    }

                    Close();
                }
                else MessageBox.Show("Escriba una descripcion antes de agregar");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

