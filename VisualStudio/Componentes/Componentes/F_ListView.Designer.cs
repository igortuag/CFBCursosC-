namespace Componentes
{
    partial class F_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.lv_Produtos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.tb_Qtde = new System.Windows.Forms.TextBox();
            this.tb_Preco = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Produtos
            // 
            this.lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_Produto,
            this.col_Qtde,
            this.col_Preco});
            this.lv_Produtos.FullRowSelect = true;
            this.lv_Produtos.HideSelection = false;
            this.lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_Produtos.Location = new System.Drawing.Point(13, 13);
            this.lv_Produtos.MultiSelect = false;
            this.lv_Produtos.Name = "lv_Produtos";
            this.lv_Produtos.Size = new System.Drawing.Size(500, 287);
            this.lv_Produtos.TabIndex = 0;
            this.lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.lv_Produtos.View = System.Windows.Forms.View.Details;
            this.lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lv_Produtos.Click += new System.EventHandler(this.lv_Produtos_Click);
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 40;
            // 
            // col_Produto
            // 
            this.col_Produto.Text = "Produto";
            this.col_Produto.Width = 250;
            // 
            // col_Qtde
            // 
            this.col_Qtde.Text = "Quantidade";
            this.col_Qtde.Width = 80;
            // 
            // col_Preco
            // 
            this.col_Preco.Text = "Preço";
            this.col_Preco.Width = 120;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(22, 322);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(30, 20);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_Produto
            // 
            this.tb_Produto.Location = new System.Drawing.Point(58, 322);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(240, 20);
            this.tb_Produto.TabIndex = 2;
            // 
            // tb_Qtde
            // 
            this.tb_Qtde.Location = new System.Drawing.Point(304, 322);
            this.tb_Qtde.Name = "tb_Qtde";
            this.tb_Qtde.Size = new System.Drawing.Size(70, 20);
            this.tb_Qtde.TabIndex = 3;
            // 
            // tb_Preco
            // 
            this.tb_Preco.Location = new System.Drawing.Point(380, 322);
            this.tb_Preco.Name = "tb_Preco";
            this.tb_Preco.Size = new System.Drawing.Size(110, 20);
            this.tb_Preco.TabIndex = 4;
            this.tb_Preco.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(22, 303);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(22, 349);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 9;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(103, 349);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 10;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(184, 349);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(75, 23);
            this.btn_Obter.TabIndex = 11;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 391);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tb_Preco);
            this.Controls.Add(this.tb_Qtde);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lv_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.Load += new System.EventHandler(this.F_ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader col_Qtde;
        private System.Windows.Forms.ColumnHeader col_Preco;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Produto;
        private System.Windows.Forms.TextBox tb_Qtde;
        private System.Windows.Forms.TextBox tb_Preco;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Obter;
    }
}