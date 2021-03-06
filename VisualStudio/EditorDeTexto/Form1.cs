﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfb_streamWriter = new StreamWriter(arquivo);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfb_streamWriter.Write(this.richTextBox1.Text);
                    cfb_streamWriter.Flush();
                    cfb_streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"D:\IgorTuagAndradedeFre\Documents\CURSO C#\VisualStudio\EditorDeTexto";
            openFileDialog1.Filter = "(*.CFB)|*.CFB";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfb_streamReader = new StreamReader(arquivo);
                    cfb_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfb_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfb_streamReader.ReadLine();
                    }
                    cfb_streamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }

        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;
            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);
            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void btn_Direta_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;
            if (MargemEsquerda < 5)
            {
                MargemEsquerda = 20;
            }
            if (MargemSuperior < 5)
            {
                MargemSuperior = 20;
            }
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(cont < linhasPagina)
            {
                PosY = (MargemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, MargemEsquerda, PosY, new StringFormat());
                cont++;
                linha = leitura.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
