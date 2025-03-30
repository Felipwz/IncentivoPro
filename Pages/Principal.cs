using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncentivoPro.Models;

namespace IncentivoPro.Pages
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();



            if (UsuarioLogado.UsuarioAdmin != null)
            {
                lbNomeUsuario.Text = UsuarioLogado.UsuarioAdmin.Login;
            }
        }


    }
}
