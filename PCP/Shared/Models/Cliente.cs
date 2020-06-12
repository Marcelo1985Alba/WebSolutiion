using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCP.Shared.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        public int CG_CLI { get; set; }
        public string DES_CLI { get; set; }
    }
}
