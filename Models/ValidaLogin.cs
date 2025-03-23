﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncentivoPro.Models.Connection;
using IncentivoPro.Models.Tables;

namespace IncentivoPro.Models
{
    public class ValidaLogin
    {

        private readonly AppDbContext _context;


        public ValidaLogin(AppDbContext context) {


            _context = context;
        
        }

        public bool ValidarLogin(string nomeUsuario, string senha) {

            try
            {

                var usuario = _context.Admins
                                            .FirstOrDefault(u => u.Login == nomeUsuario && u.Senha == senha);

                return usuario != null;
            }
            catch(Exception ex) {

                MessageBox.Show($"Erro ao validar o login: {ex.Message}");
                return false;
            
            }
        
        }
        
            
       
    }
}
