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
        conexion cn = new conexion();
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
            cn.ExecuteQuery("EXECUTE INSERT_MODELO " + text_num.Text + "," + spin_capacidad.Value + "," + spin_peso.Value+";");

        }

        private void Modelos_Load(object sender, EventArgs e)
        {

        }

        private void spinner2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
