using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Column(TypeName = "decimal(18,4)")]
        public decimal CG_DENBASICA { get; set; }
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [Column(TypeName = "decimal(2,0)")]
        public int? CODIGO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }


    }
}
