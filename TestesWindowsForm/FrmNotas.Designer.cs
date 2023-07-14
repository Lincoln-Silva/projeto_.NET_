
namespace TestesWindowsForm
{
    partial class FrmNotas
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
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblNoata1Sem = new System.Windows.Forms.Label();
            this.lblNota2Sem = new System.Windows.Forms.Label();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.lblAprovado = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtNota1Sem = new System.Windows.Forms.TextBox();
            this.txtNota2Sem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblNomeAlunoObrigatorio = new System.Windows.Forms.Label();
            this.lblNota1SemObrigatorio = new System.Windows.Forms.Label();
            this.lblNota2SemObrigatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(32, 69);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(83, 13);
            this.lblNomeAluno.TabIndex = 0;
            this.lblNomeAluno.Text = "Nome do Aluno:";
            // 
            // lblNoata1Sem
            // 
            this.lblNoata1Sem.AutoSize = true;
            this.lblNoata1Sem.Location = new System.Drawing.Point(32, 147);
            this.lblNoata1Sem.Name = "lblNoata1Sem";
            this.lblNoata1Sem.Size = new System.Drawing.Size(108, 13);
            this.lblNoata1Sem.TabIndex = 1;
            this.lblNoata1Sem.Text = "Nota do 1º Semestre:";
            // 
            // lblNota2Sem
            // 
            this.lblNota2Sem.AutoSize = true;
            this.lblNota2Sem.Location = new System.Drawing.Point(217, 147);
            this.lblNota2Sem.Name = "lblNota2Sem";
            this.lblNota2Sem.Size = new System.Drawing.Size(108, 13);
            this.lblNota2Sem.TabIndex = 2;
            this.lblNota2Sem.Text = "Nota do 2º Semestre:";
            // 
            // lblStatusAluno
            // 
            this.lblStatusAluno.AutoSize = true;
            this.lblStatusAluno.Location = new System.Drawing.Point(32, 313);
            this.lblStatusAluno.Name = "lblStatusAluno";
            this.lblStatusAluno.Size = new System.Drawing.Size(85, 13);
            this.lblStatusAluno.TabIndex = 3;
            this.lblStatusAluno.Text = "Status do Aluno:";
            // 
            // lblAprovado
            // 
            this.lblAprovado.AutoSize = true;
            this.lblAprovado.ForeColor = System.Drawing.Color.Gray;
            this.lblAprovado.Location = new System.Drawing.Point(123, 313);
            this.lblAprovado.Name = "lblAprovado";
            this.lblAprovado.Size = new System.Drawing.Size(95, 13);
            this.lblAprovado.TabIndex = 4;
            this.lblAprovado.Text = "Nota não enviada.";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(32, 85);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(293, 20);
            this.txtNomeAluno.TabIndex = 5;
            // 
            // txtNota1Sem
            // 
            this.txtNota1Sem.Location = new System.Drawing.Point(32, 163);
            this.txtNota1Sem.Name = "txtNota1Sem";
            this.txtNota1Sem.Size = new System.Drawing.Size(108, 20);
            this.txtNota1Sem.TabIndex = 6;
            this.txtNota1Sem.Validating += new System.ComponentModel.CancelEventHandler(this.txtNota1Sem_Validating);
            // 
            // txtNota2Sem
            // 
            this.txtNota2Sem.Location = new System.Drawing.Point(217, 163);
            this.txtNota2Sem.Name = "txtNota2Sem";
            this.txtNota2Sem.Size = new System.Drawing.Size(108, 20);
            this.txtNota2Sem.TabIndex = 7;
            this.txtNota2Sem.Validating += new System.ComponentModel.CancelEventHandler(this.txtNota2Sem_Validating);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(32, 226);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(174, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(217, 226);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(108, 23);
            this.btnLimparCampos.TabIndex = 9;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblNomeAlunoObrigatorio
            // 
            this.lblNomeAlunoObrigatorio.AutoSize = true;
            this.lblNomeAlunoObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblNomeAlunoObrigatorio.Location = new System.Drawing.Point(32, 108);
            this.lblNomeAlunoObrigatorio.Name = "lblNomeAlunoObrigatorio";
            this.lblNomeAlunoObrigatorio.Size = new System.Drawing.Size(155, 13);
            this.lblNomeAlunoObrigatorio.TabIndex = 10;
            this.lblNomeAlunoObrigatorio.Text = "O Nome do Aluno é obrigatório.";
            this.lblNomeAlunoObrigatorio.Visible = false;
            // 
            // lblNota1SemObrigatorio
            // 
            this.lblNota1SemObrigatorio.AutoSize = true;
            this.lblNota1SemObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblNota1SemObrigatorio.Location = new System.Drawing.Point(32, 186);
            this.lblNota1SemObrigatorio.Name = "lblNota1SemObrigatorio";
            this.lblNota1SemObrigatorio.Size = new System.Drawing.Size(179, 13);
            this.lblNota1SemObrigatorio.TabIndex = 11;
            this.lblNota1SemObrigatorio.Text = "A Nota do 1º Semestre é obrigatória.";
            this.lblNota1SemObrigatorio.Visible = false;
            // 
            // lblNota2SemObrigatorio
            // 
            this.lblNota2SemObrigatorio.AutoSize = true;
            this.lblNota2SemObrigatorio.ForeColor = System.Drawing.Color.Red;
            this.lblNota2SemObrigatorio.Location = new System.Drawing.Point(217, 186);
            this.lblNota2SemObrigatorio.Name = "lblNota2SemObrigatorio";
            this.lblNota2SemObrigatorio.Size = new System.Drawing.Size(179, 13);
            this.lblNota2SemObrigatorio.TabIndex = 12;
            this.lblNota2SemObrigatorio.Text = "A Nota do 2º Semestre é obrigatória.";
            this.lblNota2SemObrigatorio.Visible = false;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 453);
            this.Controls.Add(this.lblNota2SemObrigatorio);
            this.Controls.Add(this.lblNota1SemObrigatorio);
            this.Controls.Add(this.lblNomeAlunoObrigatorio);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNota2Sem);
            this.Controls.Add(this.txtNota1Sem);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.lblAprovado);
            this.Controls.Add(this.lblStatusAluno);
            this.Controls.Add(this.lblNota2Sem);
            this.Controls.Add(this.lblNoata1Sem);
            this.Controls.Add(this.lblNomeAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblNoata1Sem;
        private System.Windows.Forms.Label lblNota2Sem;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.Label lblAprovado;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtNota1Sem;
        private System.Windows.Forms.TextBox txtNota2Sem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblNomeAlunoObrigatorio;
        private System.Windows.Forms.Label lblNota1SemObrigatorio;
        private System.Windows.Forms.Label lblNota2SemObrigatorio;
    }
}