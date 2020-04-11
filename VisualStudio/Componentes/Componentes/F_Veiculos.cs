using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {
        Form1 fp;
        public F_Veiculos(String v, Form1 f)
        {
            InitializeComponent();

            tb_listaVeiculos.Text = v;

            fp = f;
            fp.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.btn_valNum.Text = tb_listaVeiculos.Text;
        }
    }
}
