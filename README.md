# IncentivoPro

**IncentivoPro** é um sistema de gerenciamento de pontos desenvolvido em **C#** com **Windows Forms** e conexão com um banco de dados **PostgreSQL** hospedado na nuvem (Supabase). O projeto visa incentivar alunos através de um sistema de recompensas, onde os alunos acumulam moedas virtuais chamadas **ProCoins** e podem trocá-las por prêmios ou mimos definidos pela escola.

## 📌 Objetivo

O objetivo principal do **IncentivoPro** é fornecer uma plataforma prática e intuitiva para instituições de ensino gerenciarem um sistema de recompensas que motive os alunos a atingirem melhores desempenhos acadêmicos e comportamentais.

## 🔨 Funcionalidades Planejadas

- **Cadastro de alunos.**
- **Atribuição de pontos (ProCoins)** aos alunos.
- **Registro de prêmios** disponíveis para troca.
- **Troca de pontos** por prêmios.
- **Consulta de saldo** de ProCoins dos alunos.
- **Relatórios básicos** para acompanhamento do sistema.

## 💡 Tecnologias Utilizadas

- **C# (.NET 6 ou superior):** Linguagem principal do projeto.
- **Windows Forms:** Interface gráfica do sistema.
- **Entity Framework Core:** ORM para facilitar o mapeamento e manipulação dos dados.
- **PostgreSQL (Supabase):** Banco de dados utilizado para armazenar as informações.


## 🚀 Como Executar o Projeto Localmente
1. Clone o repositório:
bash
Copiar
Editar
git clone https://github.com/SeuUsuario/IncentivoPro.git
cd IncentivoPro
2. Restaure as dependências:
bash
Copiar
Editar
dotnet restore
3. Compile o projeto:
bash
Copiar
Editar
dotnet build
4. Execute o projeto:
bash
Copiar
Editar
dotnet run

📌 Configuração do Banco de Dados
O projeto está configurado para utilizar um banco de dados PostgreSQL hospedado na Supabase. Certifique-se de configurar sua ConnectionString adequadamente no arquivo AppDbContext.cs:

csharp
Copiar
Editar
optionsBuilder.UseNpgsql("Host=XXXX;Port=5432;Database=XXXX;Username=XXXX;Password=XXXX");

## 📖 Roadmap
 Versão 1.0: Cadastro de alunos, atribuição de pontos e consulta de saldo.
 Versão 1.1: Implementação de troca de pontos por prêmios.
 Versão 2.0: Relatórios avançados e melhorias na interface gráfica.

## 🤝 Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias ou correções. Para sugestões, por favor, abra uma issue explicando a melhoria ou sugestão.

## 📜 Licença
Este projeto é de uso pessoal para aprendizado e pode ser modificado e utilizado livremente.

## 📌 Contato
Luiz Felipe - luizfelipesiqueira83@gmail.com








