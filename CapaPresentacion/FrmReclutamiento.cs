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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FrmReclutamiento : Form
    {

        

        public FrmReclutamiento()
        {
            InitializeComponent();
        }

        private void FrmReclutamiento_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";


            rpta = Nreclutamiento.insertar(Convert.ToInt32(textBox1.Text),textBox2.Text.Trim().ToUpper(), textBox3.Text.Trim().ToUpper(), textBox4.Text.Trim().ToUpper(), Convert.ToInt32(textBox5.Text), dateTimePicker1.Value, textBox6.Text.Trim().ToUpper(), Convert.ToInt32(textBox7.Text));



            if (rpta.Equals("ok"))
            {
                MessageBox.Show("se añadio exitosamente!");
                Close();
            }
        }

  
    }
}
