using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Unidades")]
    public class Unidad
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Unidad")]
        public string UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre")]
        public string DES_UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo unidad")]
        public string TIPOUNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Conversión")]
        public int? CG_DNBASICA { get; set; }
        [ColumnaGridViewAtributo(Name = "Codigo")]
        public int? CODIGO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
