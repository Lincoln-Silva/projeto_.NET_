
namespace TestesWindowsForm
{
    partial class FrmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLoginObrigatorio = new System.Windows.Forms.Label();
            this.lblSenhaObrigatoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(22, 35);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(128, 35);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(22, 51);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(128, 51);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(234, 51);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 20);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLoginObrigatorio
            // 
            this.lblLoginObrigatorio.AutoSize = true;
            this.lblLoginObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblLoginObrigatorio.Location = new System.Drawing.Point(22, 74);
            this.lblLoginObrigatorio.Name = "lblLoginObrigatorio";
            this.lblLoginObrigatorio.Size = new System.Drawing.Size(108, 13);
            this.lblLoginObrigatorio.TabIndex = 5;
            this.lblLoginObrigatorio.Text = "O Login é obrigatório.";
            this.lblLoginObrigatorio.Visible = false;
            // 
            // lblSenhaObrigatoria
            // 
            this.lblSenhaObrigatoria.AutoSize = true;
            this.lblSenhaObrigatoria.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaObrigatoria.Location = new System.Drawing.Point(128, 74);
            this.lblSenhaObrigatoria.Name = "lblSenhaObrigatoria";
            this.lblSenhaObrigatoria.Size = new System.Drawing.Size(112, 13);
            this.lblSenhaObrigatoria.TabIndex = 6;
            this.lblSenhaObrigatoria.Text = "A Senha é obrigatória.";
            this.lblSenhaObrigatoria.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 158);
            this.Controls.Add(this.lblSenhaObrigatoria);
            this.Controls.Add(this.lblLoginObrigatorio);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Text = "Login do Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLoginObrigatorio;
        private System.Windows.Forms.Label lblSenhaObrigatoria;
    }
}

