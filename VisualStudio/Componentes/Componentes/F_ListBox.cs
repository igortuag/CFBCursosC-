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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public void AtualizarListaCarros()
        {
            lb_carros.DataSource = null;
            lb_carros.DataSource = carros;
        }
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Gol");
            carros.Add("Focus");
            carros.Add("Argo");
            carros.Add("Toro");

            AtualizarListaCarros();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if(tb_Carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                tb_Carro.Focus();
            }
            else
            {
                carros.Add(tb_Carro.Text);
                AtualizarListaCarros();
                tb_Carro.Clear();
                tb_Carro.Focus();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            AtualizarListaCarros();
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            tb_Carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizarListaCarros();
        }
    }
}
