using CapaNegocio;
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
    public partial class Frm_Principal_Cuestionario : Form
    {
        public Frm_Principal_Cuestionario()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPreguntas frm = new FrmPreguntas();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nrespuesta.mostrar();
        }
    }
}
