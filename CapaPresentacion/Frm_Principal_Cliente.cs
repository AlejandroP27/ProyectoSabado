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
    public partial class Frm_Principal_Cliente : Form
    {
        public Frm_Principal_Cliente()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                Frm_Editar_Cliente frm = new Frm_Editar_Cliente();


                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_cliente"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }

        private void cambioDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                Frm_CamEstado_Cliente frm = new Frm_CamEstado_Cliente();

                frm.cambioestado = Convert.ToString(this.dataGridView1.CurrentRow.Cells["estado"].Value);

                frm.id = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_cliente"].Value);

                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_cliente"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }
    }
}
