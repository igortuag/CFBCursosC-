namespace Aula60
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnt_texto = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_texto
            // 
            this.bnt_texto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bnt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_texto.ForeColor = System.Drawing.Color.CadetBlue;
            this.bnt_texto.Location = new System.Drawing.Point(16, 69);
            this.bnt_texto.Name = "bnt_texto";
            this.bnt_texto.Size = new System.Drawing.Size(173, 40);
            this.bnt_texto.TabIndex = 0;
            this.bnt_texto.Text = "OK!";
            this.bnt_texto.UseVisualStyleBackColor = false;
            this.bnt_texto.Click += new System.EventHandler(this.bnt_canal_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(51, 112);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(96, 20);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Click em Ok!";
            this.lb_texto.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(16, 43);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(173, 20);
            this.tb_texto.TabIndex = 2;
            this.tb_texto.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qual é o seu nome?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.bnt_texto);
            this.Name = "F_Principal";
            this.Text = "Curso de C# - CFB CUrsos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_texto;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.TextBox tb_texto;
        private System.Windows.Forms.Label label1;
    }
}

