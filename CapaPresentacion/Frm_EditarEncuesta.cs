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
    public partial class Frm_EditarEncuesta : Form
    {
        public Frm_EditarEncuesta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (validar_formulario())
            {
                int duplicad = Nencuesta.duplicado(Convert.ToInt32(txtIdEncues.Text));
                if (duplicad > 0)
                {
                    MessageBox.Show("Codigo duplicado");
                    txtNombre.Focus();
                }

                else
                {
                    rpta = Nencuesta.editar(Convert.ToInt32(txtIdEncues.Text), Convert.ToInt32(txtcliente.Text), txtNombre.Text.Trim().ToUpper(), txtDescrip.Text.Trim().ToUpper(), dtpFechaini.Value, dtpFechafin.Value);
                }



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se modifico exitosamente!");
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool validar_formulario()
        {


            if (txtIdEncues.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Codigo ");
                return false;
            }
            if (txtNombre.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Descripcion");
                return false;
            }

            return true;

        }

        private void Frm_EditarEncuesta_Load(object sender, EventArgs e)
        {

        }
    }
}
