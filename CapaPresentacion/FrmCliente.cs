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
    public partial class FrmCliente : FrmBaseNuevo
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
        public override void insertar()
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
                    rpta = Nreclutamiento.insertar(Convert.ToInt32(textBox1.Text), textBox2.Text.Trim().ToUpper(), textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text),
                        dateTimePicker1.Value, textBox7.Text, Convert.ToInt32(textBox8.Text));
                }



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se añadio exitosamente!");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
