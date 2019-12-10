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
    public partial class Frmencuestador : Form
    {
        public Frmencuestador()
        {
            InitializeComponent();
        }

        private void Frmencuestador_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Ingrese el codigo de cliente");
                return false;
            }

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            //if (validar_formulario())
            //{
            //    int duplicad = Nencuestador.duplicado(Convert.ToInt32(txt1.Text));
            //    if (duplicad > 0)
            //    {
            //        MessageBox.Show("Codigo duplicado");
            //        txt1.Focus();
            //    }

            //    else
            //    {
            rpta = Nencuestador.insertar(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text), Convert.ToInt32(txt3.Text), dtpFechacrea.Value, dtpFechasinc.Value);
                //}



                if (rpta.Equals("ok"))
                {

                    MessageBox.Show("se añadio exitosamente!");
                    Close();
                }
            }
        }
    }

