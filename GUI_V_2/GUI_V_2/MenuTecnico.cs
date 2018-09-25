﻿using System;
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
    public partial class MenuTecnico : Form
    {
        public MenuTecnico()
        {
            InitializeComponent();
        }

        public void AbrirFormMenu2(object Formhijo)
        {
            if (this.ContenedorMenuAvion.Controls.Count > 0)
                this.ContenedorMenuAvion.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContenedorMenuAvion.Controls.Add(fh);
            this.ContenedorMenuAvion.Tag = fh;
            fh.Show();
            Console.WriteLine("Finalizo Abrir Form");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new TecnicoDelete());
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new TecnicoAdd());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormMenu2(new TecnicoFind());
        }
    }
}
