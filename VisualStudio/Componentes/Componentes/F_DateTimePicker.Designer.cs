namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_ObterData = new System.Windows.Forms.Button();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Mes = new System.Windows.Forms.TextBox();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.btn_SetarData = new System.Windows.Forms.Button();
            this.btn_Hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(13, 13);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(314, 20);
            this.dtp_Data.TabIndex = 0;
            // 
            // btn_ObterData
            // 
            this.btn_ObterData.Location = new System.Drawing.Point(333, 13);
            this.btn_ObterData.Name = "btn_ObterData";
            this.btn_ObterData.Size = new System.Drawing.Size(75, 24);
            this.btn_ObterData.TabIndex = 1;
            this.btn_ObterData.Text = "Obter Data";
            this.btn_ObterData.UseVisualStyleBackColor = true;
            this.btn_ObterData.Click += new System.EventHandler(this.btn_ObterData_Click);
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(13, 40);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(314, 20);
            this.tb_Data.TabIndex = 2;
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(13, 67);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(100, 20);
            this.tb_Dia.TabIndex = 3;
            // 
            // tb_Mes
            // 
            this.tb_Mes.Location = new System.Drawing.Point(120, 66);
            this.tb_Mes.Name = "tb_Mes";
            this.tb_Mes.Size = new System.Drawing.Size(100, 20);
            this.tb_Mes.TabIndex = 4;
            // 
            // tb_Ano
            // 
            this.tb_Ano.Location = new System.Drawing.Point(227, 66);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(100, 20);
            this.tb_Ano.TabIndex = 5;
            // 
            // btn_SetarData
            // 
            this.btn_SetarData.Location = new System.Drawing.Point(333, 67);
            this.btn_SetarData.Name = "btn_SetarData";
            this.btn_SetarData.Size = new System.Drawing.Size(75, 23);
            this.btn_SetarData.TabIndex = 9;
            this.btn_SetarData.Text = "Setar Data";
            this.btn_SetarData.UseVisualStyleBackColor = true;
            this.btn_SetarData.Click += new System.EventHandler(this.btn_SetarData_Click);
            // 
            // btn_Hoje
            // 
            this.btn_Hoje.Location = new System.Drawing.Point(334, 40);
            this.btn_Hoje.Name = "btn_Hoje";
            this.btn_Hoje.Size = new System.Drawing.Size(75, 23);
            this.btn_Hoje.TabIndex = 10;
            this.btn_Hoje.Text = "Hoje";
            this.btn_Hoje.UseVisualStyleBackColor = true;
            this.btn_Hoje.Click += new System.EventHandler(this.btn_Hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 104);
            this.Controls.Add(this.btn_Hoje);
            this.Controls.Add(this.btn_SetarData);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.tb_Mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.btn_ObterData);
            this.Controls.Add(this.dtp_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Button btn_ObterData;
        private System.Windows.Forms.TextBox tb_Data;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.TextBox tb_Mes;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Button btn_SetarData;
        private System.Windows.Forms.Button btn_Hoje;
    }
}