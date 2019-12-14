using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_Principal_Preguntas : Form
    {
        public Frm_Principal_Preguntas()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Nrespuesta.mostrarpregunta();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPreguntas frm = new FrmPreguntas();
            frm.label1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["pregunta_1"].Value);
            frm.label2.Text = this.dataGridView1.CurrentRow.Cells["pregunta_2"].Value.ToString();
            frm.label3.Text = this.dataGridView1.CurrentRow.Cells["pregunta_3"].Value.ToString();
            frm.label4.Text = this.dataGridView1.CurrentRow.Cells["pregunta_4"].Value.ToString();
            frm.label5.Text = this.dataGridView1.CurrentRow.Cells["pregunta_5"].Value.ToString();
            frm.label6.Text = this.dataGridView1.CurrentRow.Cells["pregunta_6"].Value.ToString();

         
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nrespuesta.mostrarsincronizar();
            MessageBox.Show("¡Sincronizado Exitoso!");
        }
    }
}
