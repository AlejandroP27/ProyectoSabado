using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmPreguntas : Form
    {
        string res1 = "";
        string res2 = "";
        string res3 = "";
        string res4 = "";
        string res5 = "";
        string res6 = "";

        public FrmPreguntas()
        {
            InitializeComponent();
            
            SqlConnection Cn = new SqlConnection("Data Source=DIEGOST; Initial Catalog=EquipoMori; Integrated Security=true");
            
            SqlCommand command = new SqlCommand("SELECT pregunta_1,pregunta_2,pregunta_3,pregunta_4,pregunta_5,pregunta_6 FROM pregunta  WHERE id_pregunta= '2'", Cn);
            Cn.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            
            if (reader.Read())
            {
                label1.Text = reader["pregunta_1"].ToString();
                label2.Text = reader["pregunta_2"].ToString();
                label3.Text = reader["pregunta_3"].ToString();
                label4.Text = reader["pregunta_4"].ToString();
                label5.Text = reader["pregunta_5"].ToString();
                label6.Text = reader["pregunta_6"].ToString();

            }
            reader.Close();


            






        }

        private void FrmPreguntas_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

            rpta = Nrespuesta.insertar(Convert.ToInt32(txtid.Text),comboBox1.Text,comboBox2.Text,comboBox3.Text,comboBox4.Text,comboBox5.Text,comboBox6.Text);

            if (rpta.Equals("ok"))
            {

                MessageBox.Show("se añadio exitosamente!");
                Close();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
