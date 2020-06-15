using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Indic")]
    public class Indice
    {
        [ColumnaGridViewAtributo(Name = "Indice")]
        public string DES_IND { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor venta")]
        public int? VA_INDIC { get; set; }
        [ColumnaGridViewAtributo(Name = "Valor compra")]
        public int? VA_COMPRA { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha valor")]
        public DateTime FE_INDIC { get; set; }
        [Key]
        [ColumnaGridViewAtributo(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? REGISTRO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
