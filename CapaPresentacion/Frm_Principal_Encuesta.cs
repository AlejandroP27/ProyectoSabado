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
    public partial class Frm_Principal_Encuesta : Form
    {
        public Frm_Principal_Encuesta()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Encuesta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Nencuesta.mostrar();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEncuesta frm = new FrmEncuesta();
            frm.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            if (dataGridView1.RowCount > 0)
            {

                Frm_EditarEncuesta frm = new Frm_EditarEncuesta();


                frm.txtIdEncues.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_encuesta"].Value);
                frm.txtcliente.Text = this.dataGridView1.CurrentRow.Cells["idcliente"].Value.ToString();
                frm.txtNombre.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.txtDescrip.Text = this.dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                frm.dtpFechaini.Text = this.dataGridView1.CurrentRow.Cells["fecha_ini"].Value.ToString();
                frm.dtpFechafin.Text = this.dataGridView1.CurrentRow.Cells["fecha_fin"].Value.ToString();
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

                Frm_CamEstado_Encuesta frm = new Frm_CamEstado_Encuesta();


                frm.txtIdEncues.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_encuesta"].Value);
                frm.txtcliente.Text = this.dataGridView1.CurrentRow.Cells["idcliente"].Value.ToString();
                frm.txtNombre.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.txtDescrip.Text = this.dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                frm.dtpFechaini.Text = this.dataGridView1.CurrentRow.Cells["fecha_ini"].Value.ToString();
                frm.dtpFechafin.Text = this.dataGridView1.CurrentRow.Cells["fecha_fin"].Value.ToString();


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

                Frm_MostrarEncuesta frm = new Frm_MostrarEncuesta();


                frm.txtIdEncues.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["id_encuesta"].Value);
                frm.txtcliente.Text = this.dataGridView1.CurrentRow.Cells["idcliente"].Value.ToString();
                frm.txtNombre.Text = this.dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                frm.txtDescrip.Text = this.dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                frm.dtpFechaini.Text = this.dataGridView1.CurrentRow.Cells["fecha_ini"].Value.ToString();
                frm.dtpFechafin.Text = this.dataGridView1.CurrentRow.Cells["fecha_fin"].Value.ToString();


                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe filtrar datos y selecionar!!!");
            }
        }
    }
}
