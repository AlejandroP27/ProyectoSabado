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
    public partial class Frm_CamEsta_recluta : Form
    {

        public string cambioestado = "";
        public string id = "";


        public Frm_CamEsta_recluta()
        {
            InitializeComponent();
        }

        private void Frm_CamEsta_recluta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";
            // en la tabla privilegio usamos el comando compareto() para comparar lo que contenia cambioestado... en este caso no 
            //necesitamos el comparador directamente usamos la comsulta if() para comprara cambioestado....
            if (cambioestado == "activo")
            {
                cambioestado = "inactivo";
                rpta = Nreclutamiento.estado(Convert.ToInt32(id), cambioestado);
                MessageBox.Show("cambio de estado actualizado");
                Close();

            }

            else
            {
                cambioestado = "activo";
                rpta = Nreclutamiento.estado(Convert.ToInt32(id), cambioestado);
                MessageBox.Show("cambio de estado actualizado");
                Close();
            }

        }
    }
}
