using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncentivoPro.Modelos.Tables
{

    [Table("tb02_professores")]
    public class Professor
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("salas")]
        public string Salas { get; set; }

        [Column("senha")]
        public string SenhaProfessor { get; set; }

        [Column("login")]
        public string LoginProfessor { get; set; }


    }


}