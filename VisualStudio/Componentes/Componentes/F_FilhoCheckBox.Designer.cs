namespace Componentes
{
    partial class F_FilhoCheckBox
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
            this.cb_Patinete = new System.Windows.Forms.CheckBox();
            this.btn_TransportesMarcados = new System.Windows.Forms.Button();
            this.cb_Aviao = new System.Windows.Forms.CheckBox();
            this.cb_Navio = new System.Windows.Forms.CheckBox();
            this.cb_Onibus = new System.Windows.Forms.CheckBox();
            this.cb_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_Patinete
            // 
            this.cb_Patinete.AutoSize = true;
            this.cb_Patinete.Location = new System.Drawing.Point(12, 151);
            this.cb_Patinete.Name = "cb_Patinete";
            this.cb_Patinete.Size = new System.Drawing.Size(65, 17);
            this.cb_Patinete.TabIndex = 11;
            this.cb_Patinete.Text = "Patinete";
            this.cb_Patinete.UseVisualStyleBackColor = true;
            // 
            // btn_TransportesMarcados
            // 
            this.btn_TransportesMarcados.Location = new System.Drawing.Point(124, 12);
            this.btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            this.btn_TransportesMarcados.Size = new System.Drawing.Size(183, 23);
            this.btn_TransportesMarcados.TabIndex = 10;
            this.btn_TransportesMarcados.Text = "Transportes Marcados";
            this.btn_TransportesMarcados.UseVisualStyleBackColor = true;
            // 
            // cb_Aviao
            // 
            this.cb_Aviao.AutoSize = true;
            this.cb_Aviao.Location = new System.Drawing.Point(12, 84);
            this.cb_Aviao.Name = "cb_Aviao";
            this.cb_Aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_Aviao.TabIndex = 9;
            this.cb_Aviao.Text = "Avião";
            this.cb_Aviao.UseVisualStyleBackColor = true;
            this.cb_Aviao.CheckedChanged += new System.EventHandler(this.cb_Aviao_CheckedChanged);
            // 
            // cb_Navio
            // 
            this.cb_Navio.AutoSize = true;
            this.cb_Navio.Location = new System.Drawing.Point(12, 60);
            this.cb_Navio.Name = "cb_Navio";
            this.cb_Navio.Size = new System.Drawing.Size(54, 17);
            this.cb_Navio.TabIndex = 8;
            this.cb_Navio.Text = "Navio";
            this.cb_Navio.UseVisualStyleBackColor = true;
            this.cb_Navio.CheckedChanged += new System.EventHandler(this.cb_Navio_CheckedChanged);
            // 
            // cb_Onibus
            // 
            this.cb_Onibus.AutoSize = true;
            this.cb_Onibus.Location = new System.Drawing.Point(12, 36);
            this.cb_Onibus.Name = "cb_Onibus";
            this.cb_Onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_Onibus.TabIndex = 7;
            this.cb_Onibus.Text = "Onibus";
            this.cb_Onibus.UseVisualStyleBackColor = true;
            this.cb_Onibus.CheckedChanged += new System.EventHandler(this.cb_Onibus_CheckedChanged);
            // 
            // cb_Carro
            // 
            this.cb_Carro.AutoSize = true;
            this.cb_Carro.Location = new System.Drawing.Point(12, 12);
            this.cb_Carro.Name = "cb_Carro";
            this.cb_Carro.Size = new System.Drawing.Size(51, 17);
            this.cb_Carro.TabIndex = 6;
            this.cb_Carro.Text = "Carro";
            this.cb_Carro.UseVisualStyleBackColor = true;
            this.cb_Carro.CheckedChanged += new System.EventHandler(this.cb_Carro_CheckedChanged);
            // 
            // F_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 188);
            this.Controls.Add(this.cb_Patinete);
            this.Controls.Add(this.btn_TransportesMarcados);
            this.Controls.Add(this.cb_Aviao);
            this.Controls.Add(this.cb_Navio);
            this.Controls.Add(this.cb_Onibus);
            this.Controls.Add(this.cb_Carro);
            this.Name = "F_FilhoCheckBox";
            this.Text = "F_FilhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Patinete;
        private System.Windows.Forms.Button btn_TransportesMarcados;
        private System.Windows.Forms.CheckBox cb_Aviao;
        private System.Windows.Forms.CheckBox cb_Navio;
        private System.Windows.Forms.CheckBox cb_Onibus;
        private System.Windows.Forms.CheckBox cb_Carro;
    }
}