using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Principal_Cliente frm = new Frm_Principal_Cliente();
            frm.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Principal_Reclutamiento frm = new Frm_Principal_Reclutamiento();
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Principal_Encuesta frm = new Frm_Principal_Encuesta();
            frm.ShowDialog();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Principal_Encuestador frm = new Frm_Principal_Encuestador();
            frm.ShowDialog()
        }
    }
}
