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



        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new AppDbContext();
            var validador = new ValidaLogin(context);



            bool loginValido = validador.ValidarLogin(txtUsuario.Text, txtSenha.Text);




            if (txtSenha.Text == "" || txtUsuario.Text == "")
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("� necess�rio preencher todos os campos", 2000, "aviso"); // 2000 ms (2 segundos)
                mensagem.ForeColor = Color.FromArgb(233, 214, 0);
                mensagem.Show();

            }
            else if (loginValido)
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("Login realizado!", 2000, "sucesso"); // 2000 ms (2 segundos)
                mensagem.Show();
                await Task.Delay(2000);
                this.Close();




            }
            else
            {
                MensagemTemporaria mensagem = new MensagemTemporaria("Algum erro ocorreu, verifique os campos", 2000, "erro"); // 2000 ms (2 segundos)
                mensagem.ForeColor = Color.FromArgb(194, 0, 0);
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

        private void checkViewPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarSenha.Checked)
            {
                
                txtSenha.PasswordChar = '\0';
            }
            else
            {
          
                txtSenha.PasswordChar = '*';
            }
        }
    }
}
