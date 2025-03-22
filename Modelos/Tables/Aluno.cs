using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncentivoPro.Modelos.Tables
{

    [Table("tb01_alunos")]
    public class Aluno
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Sala { get; set; }

        public int Pontos { get; set; }

        public string PremiosGanhos { get; set; }

    }


}

