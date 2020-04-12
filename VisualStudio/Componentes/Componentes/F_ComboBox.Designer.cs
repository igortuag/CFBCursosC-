namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_Transportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_ResetarElementos = new System.Windows.Forms.Button();
            this.tb_NovoTransporte = new System.Windows.Forms.TextBox();
            this.btn_NovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Transportes
            // 
            this.cb_Transportes.FormattingEnabled = true;
            this.cb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônivus",
            "Trem"});
            this.cb_Transportes.Location = new System.Drawing.Point(13, 13);
            this.cb_Transportes.Name = "cb_Transportes";
            this.cb_Transportes.Size = new System.Drawing.Size(216, 21);
            this.cb_Transportes.TabIndex = 0;
            this.cb_Transportes.SelectedIndexChanged += new System.EventHandler(this.cb_Transportes_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionado
            // 
            this.btn_MostrarSelecionado.Location = new System.Drawing.Point(235, 13);
            this.btn_MostrarSelecionado.Name = "btn_MostrarSelecionado";
            this.btn_MostrarSelecionado.Size = new System.Drawing.Size(150, 23);
            this.btn_MostrarSelecionado.TabIndex = 1;
            this.btn_MostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionado.Click += new System.EventHandler(this.btn_MostrarSelecionado_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(235, 43);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(150, 23);
            this.btn_LimparElementos.TabIndex = 2;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_ResetarElementos
            // 
            this.btn_ResetarElementos.Location = new System.Drawing.Point(235, 73);
            this.btn_ResetarElementos.Name = "btn_ResetarElementos";
            this.btn_ResetarElementos.Size = new System.Drawing.Size(150, 23);
            this.btn_ResetarElementos.TabIndex = 3;
            this.btn_ResetarElementos.Text = "Resetar Elementos";
            this.btn_ResetarElementos.UseVisualStyleBackColor = true;
            this.btn_ResetarElementos.Click += new System.EventHandler(this.btn_ResetarElementos_Click);
            // 
            // tb_NovoTransporte
            // 
            this.tb_NovoTransporte.Location = new System.Drawing.Point(235, 103);
            this.tb_NovoTransporte.Name = "tb_NovoTransporte";
            this.tb_NovoTransporte.Size = new System.Drawing.Size(150, 20);
            this.tb_NovoTransporte.TabIndex = 4;
            // 
            // btn_NovoTransporte
            // 
            this.btn_NovoTransporte.Location = new System.Drawing.Point(235, 130);
            this.btn_NovoTransporte.Name = "btn_NovoTransporte";
            this.btn_NovoTransporte.Size = new System.Drawing.Size(150, 23);
            this.btn_NovoTransporte.TabIndex = 5;
            this.btn_NovoTransporte.Text = "Adicionar";
            this.btn_NovoTransporte.UseVisualStyleBackColor = true;
            this.btn_NovoTransporte.Click += new System.EventHandler(this.btn_NovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btn_NovoTransporte);
            this.Controls.Add(this.tb_NovoTransporte);
            this.Controls.Add(this.btn_ResetarElementos);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionado);
            this.Controls.Add(this.cb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionado;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_ResetarElementos;
        private System.Windows.Forms.TextBox tb_NovoTransporte;
        private System.Windows.Forms.Button btn_NovoTransporte;
    }
}