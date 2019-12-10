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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReclutamiento frm = new FrmReclutamiento();
            frm.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if (dataGridView1.RowCount > 0)
            {

                Frm_Editar_Reclutamiento frm = new Frm_Editar_Reclutamiento();
               

                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_reclu"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells["nivel_acade"].Value.ToString();
                frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells["fecha_naci"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
           
                this.dataGridView1.DataSource = Nreclutamiento.mostrar();


            
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                Frm_Eliminar_Recluta frm = new Frm_Eliminar_Recluta();


                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_reclu"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells["nivel_acade"].Value.ToString();
                frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                frm.textBox8.Text = this.dataGridView1.CurrentRow.Cells["fecha_crea"].Value.ToString();
                frm.textBox9.Text = this.dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells["fecha_naci"].Value.ToString();


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

                Frm_CamEsta_recluta frm = new Frm_CamEsta_recluta();

                frm.cambioestado = Convert.ToString(this.dataGridView1.CurrentRow.Cells["estado"].Value);

                frm.id = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_reclu"].Value);

                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_reclu"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells["nivel_acade"].Value.ToString();
                frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells["fecha_naci"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {

                Frm_Mostrar_Recluta frm = new Frm_Mostrar_Recluta();


                frm.textBox1.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_reclu"].Value);
                frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells["apellido"].Value.ToString();
                frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells["nivel_acade"].Value.ToString();
                frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                frm.textBox8.Text = this.dataGridView1.CurrentRow.Cells["fecha_crea"].Value.ToString();
                frm.textBox9.Text = this.dataGridView1.CurrentRow.Cells["estado"].Value.ToString();
                frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells["fecha_naci"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }
    }
}
