using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncentivoPro.Modelos.Tables
{

    [Table("using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncentivoPro.Modelos.Tables
{

    [Table("tb03_admin")]
    public class Admin
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("login")]
        public string Login { get; set; } = string.Empty;

        [Column("senha")]
        public string Senha { get; set; } = string.Empty;



        }


}

")]
    public class Admin
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("idade")]
        public int Idade { get; set; }

        [Column("sala")]
        public string Sala { get; set; }

        [Column("Pontos")]
        public int Pontos { get; set; }

        [Column("premios_ganhos")]
        public string PremiosGanhos { get; set; }

    }


}

