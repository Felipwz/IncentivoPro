using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncentivoPro.Models.Connection;
using IncentivoPro.Models.Tables;


namespace IncentivoPro.Models.Connection
{
    public class TestaConexao
    {
        public void ConexaoTeste()  
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    var novoAluno = new Aluno
                    {
                        Nome = "João Silva",
                        Idade = 15,
                        Sala = "8A",
                        Pontos = 100,
                        PremiosGanhos = "Nenhum"
                    };

                    context.Alunos.Add(novoAluno);
                    context.SaveChanges();

                    MessageBox.Show("Conexão estabelecida e dado salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ou salvar dados: {ex.Message}");
                }
            }
        }
    }
}
