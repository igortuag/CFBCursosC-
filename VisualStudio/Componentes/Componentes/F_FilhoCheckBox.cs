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
    public partial class F_FilhoCheckBox : Form
    {
        public F_Checkbox f_Checkbox;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                f_Checkbox = Application.OpenForms["F_CheckBox"] as F_Checkbox;
                cb_Carro.Checked = f_Checkbox.cb_Carro.Checked;
                cb_Aviao.Checked = f_Checkbox.cb_Aviao.Checked;
                cb_Navio.Checked = f_Checkbox.cb_Navio.Checked;
                cb_Onibus.Checked = f_Checkbox.cb_Onibus.Checked;
                cb_Patinete.Checked = f_Checkbox.cb_Patinete.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir formulário")
            }
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            f_Checkbox.cb_Carro.Checked = cb_Carro.Checked;
        }

        private void cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            f_Checkbox.cb_Onibus.Checked = cb_Onibus.Checked;
        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            f_Checkbox.cb_Navio.Checked = cb_Navio.Checked;
        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            f_Checkbox.cb_Aviao.Checked = cb_Aviao.Checked;
        }
    }
}
