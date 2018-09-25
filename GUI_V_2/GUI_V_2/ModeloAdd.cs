using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_V_2
{
    public partial class ModeloAdd : Form
    {
        public ModeloAdd()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

           

            conexion cn = new conexion();
            cn.connectar();

           

        }

        private void Modelos_Load(object sender, EventArgs e)
        {

        }
    }
}
