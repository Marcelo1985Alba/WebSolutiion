using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PCP.Shared.Models
{
	[Table("Compras")]
	public class Compra
	{
		[ColumnaGridViewAtributo(Name ="Numero OC")]
		public decimal NUMERO { get; set; }
		[ColumnaGridViewAtributo(Name = "Fecha"), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime FE_EMIT { get; set; }
        public string CG_PREP { get; set; }
		public int CG_ORDEN { get; set; }
		public string CG_MAT { get; set; }
		public string DES_MAT { get; set; }
		public string TIPO { get; set; }
		public string TILDE { get; set; }
		public string TILDE1 { get; set; }
		public string TILDE2 { get; set; }
		public string TILDE3 { get; set; }
		public decimal NECESARIO { get; set; }
		public decimal SOLICITADO { get; set; }
		public decimal AUTORIZADO { get; set; }
		public string UNID { get; set; }
		public decimal CG_DEN { get; set; }
		public string UNID1 { get; set; }
		public decimal PRECIO { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public decimal PRECIONETO { get; set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public decimal PRECIOTOT { get; set; }
		public decimal BON { get; set; }
		public string MONEDA { get; set; }
		public int CG_PROVE { get; set; }
		[ColumnaGridViewAtributo(Name ="Proveedor")]
		public string DES_PROVE { get; set; }
		public DateTime? FE_PREV { get; set; }
		public DateTime? FE_REAL { get; set; }
		public DateTime? FE_VENC { get; set; }
		public DateTime? FE_CIERRE { get; set; }
		public string CONDVEN { get; set; }
		public decimal CG_CUENT { get; set; }
		public int DIASVIGE { get; set; }
		public decimal? CANTLOTE { get; set; }
		public decimal CANTMIN { get; set; }
		public string ESPECIFICA { get; set; }
		public string ESPEGEN { get; set; }
		public string ESTADO { get; set; }
		public DateTime? FE_DISP { get; set; }
		public bool ABIERTOPREPARACION { get; set; }
		public decimal NUMREQ { get; set; }
		public DateTime? FE_REQ { get; set; }
		public DateTime? FE_AUTREQ { get; set; }
		public int CG_PROVEREQ { get; set; }
		public string OBSEREQ { get; set; }
		public string MARCAREQ { get; set; }
		public decimal AVANCE { get; set; }
		public string TXTOBSERVADO { get; set; }
		public string TXTCORREGIDO { get; set; }
		public string USUARIO_AUT { get; set; }
		public DateTime? FE_AUT { get; set; }
		public DateTime? FE_CIERREREQ { get; set; }
		public string USUREQ { get; set; }
		public int ESTADO_CAB { get; set; }
		public int ESTADO_IT { get; set; }
		public decimal NECESARIO_ORI { get; set; }
		public decimal NUM_SOLCOT { get; set; }
		public decimal SOLICITADO_ORI { get; set; }
		public bool MODIF_INGRESO { get; set; }
		public decimal PENDIENTE { get; set; }
		public string OBSERVACIONES { get; set; }
		public string USUARIO { get; set; }
		public DateTime? FE_REG { get; set; }
		[Key]
		public decimal REGISTRO { get; set; }
		public int CG_CIA { get; set; }
	}
}
