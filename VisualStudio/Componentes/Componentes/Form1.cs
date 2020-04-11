﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo!");
                tb_veiculo.Focus();
                return;
            }
            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";
            tb_veiculo.Clear();
            tb_veiculo.Focus();


        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_veiculos = new F_Veiculos(tb_listaVeiculos.Text);
            f_veiculos.ShowDialog();
        }
    }
}
