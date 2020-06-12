using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Prod")]
    public class Producto
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Cod. Producto")]
        public string CG_PROD { get; set; }
        [ColumnaGridViewAtributo(Name = "Descripcion Producto")]
        public string DES_PROD { get; set; }
		public int CG_ORDEN { get; set; }
		public string TIPO { get; set; }
		public int CG_CLAS { get; set; }
		public string UNID { get; set; }
		public decimal CG_DENSEG { get; set; }
		public string UNIDSEG { get; set; }
		public decimal PESO { get; set; }
		public string UNIDPESO { get; set; }
		public string ESPECIF { get; set; }
		public string NORMA { get; set; }
		public bool EXIGEDESPACHO { get; set; }
		public bool EXIGELOTE { get; set; }
		public bool EXIGESERIE { get; set; }
		public decimal STOCKMIN { get; set; }
		public decimal LOPTIMO { get; set; }
		public int CG_DEPOSM { get; set; }
		public int CG_AREA { get; set; }
		public DateTime? FE_UMA_ACT { get; set; }
		public string LINEA { get; set; }
		public int CANT_CAJA { get; set; }
		public int PER_GTIA { get; set; }
		public int CG_LINEA { get; set; }
		public int CG_FORM { get; set; }
		public decimal MERMA { get; set; }
		public string CG_ACTIVO { get; set; }
		public decimal TIEMPOFAB { get; set; }
		public decimal COSTO { get; set; }
		public decimal COSTOTER { get; set; }
		public string MONEDA { get; set; }
		public decimal SETUP { get; set; }
		public string CG_CELDA { get; set; }
		public string CERFAB { get; set; }
		public int CG_TIPOAREA { get; set; }
		public string NROPLANO { get; set; }
		public string PROYECTO { get; set; }
		public string CAMPOCOM1 { get; set; }
		public string CAMPOCOM2 { get; set; }
		public string CAMPOCOM3 { get; set; }
		public string CAMPOCOM4 { get; set; }
		public string CAMPOCOM5 { get; set; }
		public string CAMPOCOM6 { get; set; }
		public string CAMPOCOM7 { get; set; }
		public string CAMPOCOM8 { get; set; }
		public string CAMPOCOM9 { get; set; }
		public string CAMPOCOM10 { get; set; }
		public string CAMPOCOM11 { get; set; }
		public string CAMPOCOM12 { get; set; }
		public decimal CG_CUENT1 { get; set; }
		public int LOTEVALOR1 { get; set; }
		public int LOTEVALOR2 { get; set; }
		public int CG_COS { get; set; }
		public string DESPLANO { get; set; }
		public string POSARAN { get; set; }
		public decimal UNIDEQUI { get; set; }
		public decimal COSTOUC { get; set; }
		public string MONEDAUC { get; set; }
		public decimal COSTOUC1 { get; set; }
		public DateTime? FE_UC { get; set; }
		public string UBICACION { get; set; }
		public int CG_EST { get; set; }
		public decimal PENDIENTE { get; set; }
		public decimal PPEDIDO { get; set; }
		public int DIAS { get; set; }
		public string WEB { get; set; }
		public string CG_PRODCLI { get; set; }
		public bool ExigeOA { get; set; }
		public int CG_CIA { get; set; }
	}
}
