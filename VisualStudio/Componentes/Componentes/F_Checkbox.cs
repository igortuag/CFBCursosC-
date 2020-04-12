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
    public partial class F_Checkbox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();
        public F_Checkbox()
        {
            InitializeComponent();
            transp.Add(cb_Carro);
            transp.Add(cb_Aviao);
            transp.Add(cb_Navio);
            transp.Add(cb_Onibus);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (var veiculo in transp)
            {
                if (veiculo.Checked)
                {
                    txt += veiculo.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Patinete.Checked)
            {
                MessageBox.Show("Patinete marcada");
            }
        }

        private void btn_MostrarFilho_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_FilhoCheckBox = new F_FilhoCheckBox();
            f_FilhoCheckBox.ShowDialog();
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}