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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Transportes.Text);
        }

        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
        }

        private void btn_ResetarElementos_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Add("Carro");
            cb_Transportes.Items.Add("Avião");
            cb_Transportes.Items.Add("Navio");
            cb_Transportes.Items.Add("Onibus");
            cb_Transportes.Items.Add("Trem");
        }

        private void btn_NovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_NovoTransporte.Text != "")
            {
                if(cb_Transportes.FindString(tb_NovoTransporte.Text) < 0)
                    cb_Transportes.Items.Add(tb_NovoTransporte.Text);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            }
        }

        private void cb_Transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_NovoTransporte.Text = cb_Transportes.Text;
        }
    }
}
