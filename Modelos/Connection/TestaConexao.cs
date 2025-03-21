using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IncentivoPro.Modelos.Connection
{
    class TestaConexao
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    // Testa a conexão tentando salvar um novo aluno
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

                    Console.WriteLine("Conexão estabelecida e dado salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ou salvar dados: {ex.Message}");
                }
            }
        }
    }
}
