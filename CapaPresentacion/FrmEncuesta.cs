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
    public partial class FrmEncuesta : Form
    {
        public FrmEncuesta()
        {
            InitializeComponent();
        }

        private void FrmEncuesta_Load(object sender, EventArgs e)
        {

        }

        public bool validar_formulario()
        {


            if (txtIdEncues.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Codigo ");
                return false;
            }
            if (txtcliente.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el codigo de cliente");
                return false;
            }

            return true;

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
                    txtIdEncues.Focus();
                }

                else
                {
                    rpta = Nencuesta.insertar(Convert.ToInt32(txtIdEncues.Text), Convert.ToInt32(txtcliente.Text), txtNombre.Text.Trim().ToUpper(), txtDescrip.Text,
                        dtpFechaini.Value, dtpFechafin.Value, dtpFechacrea.Value, dtpFechasinc.Value);
                }



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se añadio exitosamente!");
                    Close();
                }
            }
        }
    }
}
