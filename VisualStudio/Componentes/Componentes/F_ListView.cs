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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_ListView_Load(object sender, EventArgs e)
        {

        }

        private void limpar()
        {
            tb_Id.Clear();
            tb_Produto.Clear();
            tb_Qtde.Clear();
            tb_Preco.Clear();
            tb_Id.Focus();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text == "")
            {
                MessageBox.Show("Id não pode ser vazio");
            }
            else if (tb_Produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio");
            }
            else if (tb_Qtde.Text == "")
            {
                MessageBox.Show("Quantidade não pode ser vazio");
            }
            else if (tb_Preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio");
            }
            else
            {
                string[] pr = new string[4];
                pr[0] = tb_Id.Text;
                pr[1] = tb_Produto.Text;
                pr[2] = tb_Qtde.Text;
                pr[3] = tb_Preco.Text;

                ListViewItem l = new ListViewItem(pr);
                lv_Produtos.Items.Add(l);
                limpar();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_Qtde.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void lv_Produtos_Click(object sender, EventArgs e)
        {
            tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_Qtde.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
