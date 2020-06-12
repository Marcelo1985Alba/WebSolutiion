using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Prov")]
    public class Provincia
    {
        [Key]
        public int CG_PROV { get; set; }
        public string DES_PROV { get; set; }

    }
}
