using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinForm
{
    public partial class Inicio : Form
    {
    
        public Inicio()
        {
            InitializeComponent();
            ListaArticulos ventana = new ListaArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void MenuArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            ListaArticulos ventana = new ListaArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }
        private void MenuMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            ListaMarcas ventana = new ListaMarcas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void MenuCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            ListaCategorias ventana = new ListaCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void CerrarVentanas()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarVentanas();
            AcercaDe ventana = new AcercaDe();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
