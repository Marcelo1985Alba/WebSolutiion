using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Paradas")]
    public class ParadaMaquina
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CP { get; set; }
        [ColumnaGridViewAtributo(Name = "Parada de máquina")]
        public string DESRIP { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
