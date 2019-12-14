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
    public partial class Frm_Principal2 : Form
    {
        public Frm_Principal2()
        {
            InitializeComponent();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            this.Close();
            frm.ShowDialog();
        }
    }
}
