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
    public partial class Frm_Editar_Reclutamiento : Form
    {
        public Frm_Editar_Reclutamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            if (validar_formulario())
            {
                int duplicad = Nencuesta.duplicado(Convert.ToInt32(textBox1.Text));
                if (duplicad > 0)
                {
                    MessageBox.Show("Codigo duplicado");
                    textBox1.Focus();
                }

                else
                {
                    rpta = Nreclutamiento.editar(Convert.ToInt32(textBox1.Text), textBox2.Text.Trim().ToUpper(), textBox3.Text.Trim().ToUpper(), textBox4.Text.Trim().ToUpper(), Convert.ToInt32(textBox5.Text), dateTimePicker1.Value, textBox6.Text.Trim().ToUpper(), Convert.ToInt32(textBox7.Text));
                }



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se añadio exitosamente!");
                    Close();
                }
            }
        }

        private void Frm_Editar_Reclutamiento_Load(object sender, EventArgs e)
        {

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
    }
}
