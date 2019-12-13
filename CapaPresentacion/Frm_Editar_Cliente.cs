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
    public partial class Frm_Editar_Cliente : Form
    {
        public Frm_Editar_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (validar_formulario())
            {
                int duplicad = Ncliente.duplicado(Convert.ToInt32(textBox1.Text));
                if (duplicad > 0)
                {
                    MessageBox.Show("Codigo duplicado");
                    textBox1.Focus();
                }

                else
                {
                    rpta = Ncliente.editar(Convert.ToInt32(textBox1.Text), textBox2.Text.Trim().ToUpper(), textBox3.Text.Trim().ToUpper(), textBox4.Text.Trim().ToUpper());
                }



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se modifico exitosamente!");
                    Close();
                }
            }
        }
        public bool validar_formulario()
        {


            if (textBox1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Codigo ");
                return false;
            }
            if (textBox2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Descripcion");
                return false;
            }

            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
