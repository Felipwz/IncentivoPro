using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IncentivoPro.Models.Tables
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





