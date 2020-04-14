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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_MostrarCpf_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox2.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            String msg = maskedTextBox2.Text;
            MessageBox.Show(msg);
        }

        private void cb_MostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_MostrarSenha.Checked)
            {
                mtb_Senha.PasswordChar = ' ';
            }
            else
            {
                mtb_Senha.PasswordChar = '*';

            }
        }

        private void cb_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (cb_MostrarSenha.Checked)
            {
                mtb_Senha.PasswordChar = '\0';
            }
            else
            {
                mtb_Senha.PasswordChar = '*';
            }
        }
    }
}
