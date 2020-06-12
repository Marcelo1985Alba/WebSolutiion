using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
	[Table("Pedidos")]
	public class Pedidos 
	{

		//[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[ColumnaGridViewAtributo(Name = "Fecha Vale")]
		public DateTime FE_MOV { get; /*private*/ set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[Column(TypeName = "decimal(37,8)")]
		public decimal IMPORTE2 { get; /*private*/ set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[Column(TypeName = "decimal(38,6)")]
		public decimal IMPORTE3 { get; /*private*/ set; }
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[Column(TypeName = "decimal(38,6)")]
		public decimal IMPORTE4 { get; /*private*/ set; }
		[ColumnaGridViewAtributo(Name = "Nro. Vale")]
		[Column(TypeName = "decimal(18,0)")]
		public decimal VALE { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal VOUCHER { get; set; }
		public string REMITO { get; set; }
		public int CG_COMP { get; set; }
		public int CG_TIRE { get; set; }
		public int TIPOO { get; set; }
		public bool CRGO { get; set; }
		public int CG_CIA { get; set; }
		public int CG_PROY { get; set; }
		public int CG_COS { get; set; }
		public int CG_IMPORT { get; set; }
		public int CG_EXPORT { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal PRESUP { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal PEDIDO { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal PEDIDON { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal PEDIDOX { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal OBRA { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal OCOMPRA { get; set; }
		public string OBS1 { get; set; }
		public string OBS2 { get; set; }
		public string OBS3 { get; set; }
		public string OBS4 { get; set; }
		public string AVISO { get; set; }
		public int CG_PROVE { get; set; }
		public int CG_CLI { get; set; }
		public string DIRENT { get; set; }
		public string CONDVEN { get; set; }
		public string CONDVENEX { get; set; }
		public int DFF { get; set; }
		public int CG_COBR { get; set; }
		public int CG_VEND { get; set; }
		public int CG_EXPRESO { get; set; }
		public int CG_TRANS { get; set; }
		public int CG_PALLET { get; set; }
		public string PALLET { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal LARGO { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal ANCHO { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal ALTURA { get; set; }
		public string IMPRESO { get; set; }
		public string OBSERITEM { get; set; }
		public int CG_ORDEN { get; set; }
		[ColumnaGridViewAtributo(Name = "Codigo Artículo")]
		public string CG_ART { get; set; }
		public string DESPACHO { get; set; }
		public string LOTE { get; set; }
		public string SERIE { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal CG_ORDING { get; set; }
		public string UBICACION { get; set; }
		[ColumnaGridViewAtributo(Name = "Descrip. Artículo")]
		public string DES_ART { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CANTENT { get; set; }
		public int CG_DEP { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal STOCK { get; set; }
		public string UNID { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CG_DEN { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal STOCKA { get; set; }
		public string UNIDA { get; set; }
		public DateTime ENTRREAL { get; set; }
		public string MONEDA { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal IMPORTE1 { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal IMPORTE6 { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal DESCUENTO { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal BONIFIC { get; set; }
		[Column(TypeName = "decimal(6,2)")]
		public decimal IVA { get; set; }
		public string CG_BARRAS { get; set; }
		public string POSARAN { get; set; }
		public string CG_ART1 { get; set; }
		public string DES_ART1 { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal VA_INDIC { get; set; }
		[Column(TypeName = "decimal(15,0)")]
		public decimal CG_CUENT { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal CG_ORDF { get; set; }
		public bool NETONOG { get; set; }
		public string USUARIO { get; set; }
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(TypeName = "decimal(18,0)")]
		public decimal REGISTRO { get; set; }
		public string COMPROB { get; set; }
		public string FACTURA { get; set; }
		public string LEYENDA { get; set; }
		public bool ENTRANSITO { get; set; }
		public int CG_VEN { get; set; }
		public int NUMREQ { get; set; }
		public string CAMPANA { get; set; }
		public string CUIT { get; set; }
		public string CG_COND { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal REGCOMPR { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CANTENTA { get; set; }
		public DateTime? FE_FAC { get; set; }
		[Column(TypeName = "decimal(18,0)")]
		public decimal PROFORMA { get; set; }
		public string DES_CLI { get; set; }
		public int DPP { get; set; }
		public string DIRECC { get; set; }
		public string LOCALIDAD { get; set; }
		public string CG_POSTA { get; set; }
		public string CG_ZONA { get; set; }
		public int VALE_DESCA { get; set; }
		public int CG_CATEG { get; set; }
		public string CONVMON { get; set; }
		public int CG_FORM_VENTAS { get; set; }
		public string ORCO { get; set; }
		public string TIPO_FAC_AGRO { get; set; }
		[Column(TypeName = "decimal(18,4)")]
		public decimal CANTPED { get; set; }
		public int FLAG { get; set; }
		public string OBSERVACIONES { get; set; }

	}
}
