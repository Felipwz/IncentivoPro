using System;
using System.Windows.Forms;
using IncentivoPro.Modelos;
using IncentivoPro.Modelos.Connection;


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


    }
}
