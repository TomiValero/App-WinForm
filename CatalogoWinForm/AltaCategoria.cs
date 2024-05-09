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

namespace CatalogoWinForm
{
    public partial class AltaCategoria : Form
    {
        private Categoria cate = null;
        public AltaCategoria()
        {
            InitializeComponent();
        }

        public AltaCategoria(Categoria seleccion)
        {
            InitializeComponent();
            cate = seleccion;
        }

        public void BtnCancelarAlta_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (tbAltaCategoria.Text.Length > 0)
                {
                    if (cate == null)
                    {
                        cate = new Categoria();
                    }
                        

                    cate.Descripcion = tbAltaCategoria.Text;
                    if (cate.Id != 0)
                    {
                        negocio.Modificar(cate);
                        MessageBox.Show("Modificado correctamente");

                    }
                    else
                    {
                        negocio.Agregar(cate);
                        MessageBox.Show("Agregado correctamente");
                    }

                    Close();
                } else MessageBox.Show("Escriba una descripcion antes de agregar");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if(cate != null)
                {
                    tbAltaCategoria.Text = cate.Descripcion;
                    lblTituloAgregarCategoria.Text = "MODIFICAR CATEGORIA";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
