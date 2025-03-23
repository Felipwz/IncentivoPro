using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using IncentivoPro.Models;
using IncentivoPro.Models.Connection;
using IncentivoPro.Pages;
using static System.Windows.Forms.DataFormats;


namespace IncentivoPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var validador = new ValidaLogin(context);



            bool loginValido = validador.ValidarLogin(txtUsuario.Text, txtSenha.Text);


          

            if (txtSenha.Text == "" || txtUsuario.Text == "")
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("É necessário preencher todos os campos", 2000); // 2000 ms (2 segundos)
                mensagem.Show();
            }
            else if (loginValido)
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("Login realizado!", 2000); // 2000 ms (2 segundos)
                mensagem.Show();
                this.Close();


            }
            else
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("Algum erro ocorreu, verifique os campos", 2000); // 2000 ms (2 segundos)
                mensagem.Show();
            }


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
