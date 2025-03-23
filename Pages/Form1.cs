using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using IncentivoPro.Modelos;
using IncentivoPro.Modelos.Connection;
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
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
            else
            {
                using (var context = new AppDbContext()) 
                {

                    try
                    {

                    }
                    catch { 
                    }
                
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
