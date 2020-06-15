using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("TiposNoConf")]
    public class TipoNoConformidad
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Cg_TipoNc { get; set; }
        [ColumnaGridViewAtributo(Name = "No conformidad")]
        public string Des_TipoNc { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
