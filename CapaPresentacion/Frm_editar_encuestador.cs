using CapaNegocio;
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
    public partial class Frm_editar_encuestador : Form
    {
        public Frm_editar_encuestador()
        {
            InitializeComponent();
        }

        public bool validar_formulario()
        {


            if (txt1.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Codigo ");
                return false;
            }
            if (txt2.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ingrese el Descripcion");
                return false;
            }

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string rpta = "";
            ////if (validar_formulario())
            ////{
            //    //int duplicad = Nencuestador.duplicado(Convert.ToInt32(txt4.Text));
            //    //if (duplicad > 0)
            //    //{
            //    //    MessageBox.Show("Codigo duplicado");
            //    //    textBox1.Focus();
            //    //}

            //    //else
            //    //{
            //        rpta = Nencuestador.editar(Convert.ToInt32(txt1.Text), textBox2.Text.Trim().ToUpper(), textBox3.Text.Trim().ToUpper(), textBox4.Text.Trim().ToUpper());
                



            //    if (rpta.Equals("ok"))
            //    {

            //        MessageBox.Show("se modifico exitosamente!");
            //        Close();
            //    }
            }
        }
    }

