using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("ProTarea")]
    public class TareaProceso
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public string TAREAPROC { get; set; }
        [ColumnaGridViewAtributo(Name = "Tarea del proceso")]
        public string DESCRIP { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSERVAC { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
