using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Scrap")]
    public class Scrap
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_SCRAP { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo de scrap")]
        public string DES_SCRAP { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }

    }
}
