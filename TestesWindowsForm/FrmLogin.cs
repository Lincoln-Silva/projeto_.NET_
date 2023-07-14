using System;
using System.Windows.Forms;

namespace TestesWindowsForm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                FrmNotas frmNotas = new FrmNotas();
                frmNotas.ShowDialog();
            }
        }

        //Verifica se os campos obrigatórios foram preenchidos
        private bool ValidaCampos()
        {
            Boolean valido = true;

            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                lblLoginObrigatorio.Visible = true;
                valido = false;
            }
            else
            {
                lblLoginObrigatorio.Visible = false;
            }

            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                lblSenhaObrigatoria.Visible = true;
                valido = false;
            }
            else
            {
                lblSenhaObrigatoria.Visible = false;
            }

            return valido;
        }
    }
}
