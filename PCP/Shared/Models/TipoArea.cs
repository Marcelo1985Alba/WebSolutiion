using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("TipoArea")]
    public class TipoArea
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_TIPOAREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo de área")]
        public string DES_TIPOAREA { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
