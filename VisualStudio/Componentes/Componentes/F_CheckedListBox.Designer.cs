namespace Componentes
{
    partial class F_CheckedListBox
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
            this.btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.clb_Transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.btn_NovoTransporte = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MostrarSelecionado
            // 
            this.btn_MostrarSelecionado.Location = new System.Drawing.Point(145, 12);
            this.btn_MostrarSelecionado.Name = "btn_MostrarSelecionado";
            this.btn_MostrarSelecionado.Size = new System.Drawing.Size(163, 25);
            this.btn_MostrarSelecionado.TabIndex = 0;
            this.btn_MostrarSelecionado.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionado.Click += new System.EventHandler(this.btn_MostrarSelecionado_Click);
            // 
            // clb_Transportes
            // 
            this.clb_Transportes.FormattingEnabled = true;
            this.clb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_Transportes.Location = new System.Drawing.Point(13, 13);
            this.clb_Transportes.Name = "clb_Transportes";
            this.clb_Transportes.Size = new System.Drawing.Size(126, 169);
            this.clb_Transportes.TabIndex = 1;
            this.clb_Transportes.SelectedIndexChanged += new System.EventHandler(this.clb_Transportes_SelectedIndexChanged);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(145, 43);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(163, 25);
            this.btn_LimparElementos.TabIndex = 2;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(145, 74);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(163, 25);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // btn_NovoTransporte
            // 
            this.btn_NovoTransporte.Location = new System.Drawing.Point(145, 157);
            this.btn_NovoTransporte.Name = "btn_NovoTransporte";
            this.btn_NovoTransporte.Size = new System.Drawing.Size(163, 25);
            this.btn_NovoTransporte.TabIndex = 4;
            this.btn_NovoTransporte.Text = "Adicionar novo Transporte";
            this.btn_NovoTransporte.UseVisualStyleBackColor = true;
            this.btn_NovoTransporte.Click += new System.EventHandler(this.btn_NovoTransporte_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Location = new System.Drawing.Point(145, 131);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(163, 20);
            this.tb_NovoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_NovoTransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.clb_Transportes);
            this.Controls.Add(this.btn_MostrarSelecionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarSelecionado;
        private System.Windows.Forms.CheckedListBox clb_Transportes;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.Button btn_NovoTransporte;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Label label1;
    }
}