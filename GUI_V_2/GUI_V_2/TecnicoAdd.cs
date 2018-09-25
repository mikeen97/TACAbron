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
   
    public partial class TecnicoAdd : Form
    {
        public conexion cn = new conexion();
        public TecnicoAdd()
        {
            InitializeComponent();
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.ExecuteQuery("EXECUTE INSERT_TECNICO \"" +txt_dni.Text+"\",\""+txt_afiliacion.Text + "\",\"" +txt_nombre.Text + "\",\"" +txt_direccion.Text + "\",\"" +
                                                        txt_telefono.Text + "\"," +txt_sueldo.Text+",\"" +txt_username.Text + "\",\"" +txt_contra.Text+ "\",\"" + txt_correo.Text+"\";" );
        }
    }
}
