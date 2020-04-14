namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtb_Senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_MostrarCpf = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cb_MostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_Senha
            // 
            this.mtb_Senha.Location = new System.Drawing.Point(59, 19);
            this.mtb_Senha.Name = "mtb_Senha";
            this.mtb_Senha.PasswordChar = '*';
            this.mtb_Senha.Size = new System.Drawing.Size(100, 20);
            this.mtb_Senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(59, 68);
            this.maskedTextBox1.Mask = "00000-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(59, 118);
            this.maskedTextBox2.Mask = "000.000.000-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF";
            // 
            // btn_MostrarCpf
            // 
            this.btn_MostrarCpf.Location = new System.Drawing.Point(258, 115);
            this.btn_MostrarCpf.Name = "btn_MostrarCpf";
            this.btn_MostrarCpf.Size = new System.Drawing.Size(75, 23);
            this.btn_MostrarCpf.TabIndex = 6;
            this.btn_MostrarCpf.Text = "Mostrar CPF";
            this.btn_MostrarCpf.UseVisualStyleBackColor = true;
            this.btn_MostrarCpf.Click += new System.EventHandler(this.btn_MostrarCpf_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(166, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Somente Texto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cb_MostrarSenha
            // 
            this.cb_MostrarSenha.AutoSize = true;
            this.cb_MostrarSenha.Location = new System.Drawing.Point(166, 17);
            this.cb_MostrarSenha.Name = "cb_MostrarSenha";
            this.cb_MostrarSenha.Size = new System.Drawing.Size(61, 17);
            this.cb_MostrarSenha.TabIndex = 8;
            this.cb_MostrarSenha.Text = "Mostrar";
            this.cb_MostrarSenha.UseVisualStyleBackColor = true;
            this.cb_MostrarSenha.CheckedChanged += new System.EventHandler(this.cb_MostrarSenha_CheckedChanged);
            this.cb_MostrarSenha.Click += new System.EventHandler(this.cb_MostrarSenha_Click);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_MostrarSenha);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_MostrarCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_MostrarCpf;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cb_MostrarSenha;
    }
}