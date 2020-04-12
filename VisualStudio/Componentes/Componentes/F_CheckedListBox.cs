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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void clb_Transportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_MostrarSelecionado_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (var item in clb_Transportes.CheckedItems)
            {

                txt += item + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");
            clb_Transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_NovoTransporte_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Add(tb_NovoTransporte.Text, false);
            tb_NovoTransporte.Clear();
            tb_NovoTransporte.Focus();
        }
    }
}
