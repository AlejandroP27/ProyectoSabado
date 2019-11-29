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
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }

        private void FormularioBase_Load(object sender, EventArgs e)
        {

        }

        public virtual void insertar()
        {

        }

        public virtual void editar()
        {

        }

        public virtual void eliminar()
        {

        }


        public virtual void buscar()
        {

        }

        public virtual void estado()
        {


        }


        public virtual void duplicado()
        {

        }

        public virtual void filtrartodo()
        {

        }

        public virtual void cancelar()
        {
            this.Close();
        }
    }
}
