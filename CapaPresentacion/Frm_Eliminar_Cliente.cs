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
    public partial class Frm_Eliminar_Cliente : Form
    {
        public Frm_Eliminar_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            // en la tabla privilegio usamos el comando con parametro() para comparar lo que contenia cambioestado... en este caso no 
            //necesitamos el comparador directamente usamos la comsulta if() para comprara cambioestado....


            rpta = Ncliente.eliminar(Convert.ToInt32(textBox1.Text));
            MessageBox.Show("Se elimino correctamente");
            Close();
        }
    }
}
