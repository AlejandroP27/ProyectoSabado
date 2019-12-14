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
    public partial class Frm_Login : Form
    {

        Frm_Principal login;
        Frm_Principal2 login2;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != " ") && (txtContraseña.Text!=" "))
            {
                if ((txtusuario.Text=="Admin")&& (txtContraseña.Text=="123"))
                {
                    login = new Frm_Principal();
                    login.Show();
                    this.Hide();
                }
                if ((txtusuario.Text == "Encuestador") && (txtContraseña.Text == "123"))
                {
                    login2 = new Frm_Principal2();
                    login2.Show();
                    this.Hide();
                }
                
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
