using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using IncentivoPro.Models;
using IncentivoPro.Models.Connection;
using static System.Windows.Forms.DataFormats;


namespace IncentivoPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            TestaConexao testaConexao = new TestaConexao();
            testaConexao.ConexaoTeste();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var validador = new ValidaLogin(context);


            bool loginValido = validador.ValidarLogin(txtUsuario.Text, txtSenha.Text);

            if (txtSenha.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
            else if (loginValido)
            {
                MessageBox.Show("Login realizado com sucesso");
            }
            else {
                MessageBox.Show($"Erro ao validar o login");
            }



            

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
