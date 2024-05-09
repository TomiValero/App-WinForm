using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinForm
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void pbxLiDesarrollador1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/tomas-valero-b125481a7/");
        }

        private void pbxGHDesarrollador1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/TomiValero");
        }

        private void pbxLiDesarrollador2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/arieleonchang/");
        }

        private void pbxGHDesarrollador2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/aruuleon");
        }

        

        private void pbxGHDesarrollador3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Gabriel1998-Cordoba");
        }

        private void linkRepo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/TomiValero/App-WinForm/tree/main");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/aruuleon/tp-winform-equipo-15");
        }
    }
}
