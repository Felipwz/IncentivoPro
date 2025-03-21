using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IncentivoPro.Modelos
{
   public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Sala { get; set; }

        public int Pontos { get; set; }

        public string PremiosGanhos { get; set; }

    }


}

