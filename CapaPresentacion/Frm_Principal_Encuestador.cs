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
    public partial class Frm_Principal_Encuestador : Form
    {
        public Frm_Principal_Encuestador()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Encuestador_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmencuestador frm = new Frmencuestador();
            frm.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                Frm_editar_encuestador frm = new Frm_editar_encuestador();


                frm.txt1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_encuestador"].Value);
                frm.txt2.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["idencuesta"].Value);
                frm.txt3.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["idreclutamiento"].Value);
                frm.txt4.Text = this.dataGridView1.CurrentRow.Cells["instancia"].Value.ToString();
                frm.txt5.Text = this.dataGridView1.CurrentRow.Cells["basededatos"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nencuestador.mostrar();
        }
    }
}
