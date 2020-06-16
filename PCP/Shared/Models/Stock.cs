﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Shared.Models
{
    [Table("Pedidos")]
    public class Stock
    {
        [ColumnaGridViewAtributo(Name = "Vale")]
        public decimal? VALE { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha vale")]
        public DateTime FE_MOV { get; set; }
        [ColumnaGridViewAtributo(Name = "Asiento contable")]
        public decimal? VOUCHER { get; set; }
        [ColumnaGridViewAtributo(Name = "Comprobante")]
        public string COMPROB { get; set; }
        [ColumnaGridViewAtributo(Name = "Factura")]
        public string FACTURA { get; set; }
        [ColumnaGridViewAtributo(Name = "Letra de la factura")]
        public string LEYENDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Remito")]
        public string REMITO { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo de operación")]
        public int? TIPOO { get; set; }
        [ColumnaGridViewAtributo(Name = "Pedido")]
        public decimal? PEDIDO { get; set; }
        [ColumnaGridViewAtributo(Name = "Orden de compra cliente")]
        public decimal? NUMOCI { get; set; }
        [ColumnaGridViewAtributo(Name = "Orden de compra proveedor")]
        public decimal? OCOMPRA { get; set; }
        [ColumnaGridViewAtributo(Name = "Orden de fabricación")]
        public decimal? CG_ORDF { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBSERVACIONES { get; set; }
        [ColumnaGridViewAtributo(Name = "Especificaciones")]
        public string OBSERITEM { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS1 { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS2 { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS3 { get; set; }
        [ColumnaGridViewAtributo(Name = "Observaciones")]
        public string OBS4 { get; set; }
        [ColumnaGridViewAtributo(Name = "Aviso")]
        public string AVISO { get; set; }
        [ColumnaGridViewAtributo(Name = "Dirección entrega")]
        public string DIRENT { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo insumo")]
        public int? CG_ORDEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Código artículo")]
        public string CG_ART { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre artículo")]
        public string DES_ART { get; set; }
        [ColumnaGridViewAtributo(Name = "Tipo artículo")]
        public string TIPO { get; set; }
        [ColumnaGridViewAtributo(Name = "Lote")]
        public string LOTE { get; set; }
        [ColumnaGridViewAtributo(Name = "Serie")]
        public string SERIE { get; set; }
        [ColumnaGridViewAtributo(Name = "Despacho")]
        public string DESPACHO { get; set; }
        [ColumnaGridViewAtributo(Name = "Ubicación")]
        public string UBICACION { get; set; }
        [ColumnaGridViewAtributo(Name = "Depósito")]
        public int? CG_DEP { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad")]
        public decimal? CANTENT { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad operación")]
        public decimal? STOCK { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad stock")]
        public string UNID { get; set; }
        [ColumnaGridViewAtributo(Name = "Factor conversión")]
        public decimal? CG_DEN { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad comercial")]
        public decimal? STOCKA { get; set; }
        [ColumnaGridViewAtributo(Name = "Unidad comercial")]
        public string UNIDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad comercial")]
        public decimal? CANTENTA { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha entrega")]
        public DateTime ENTRREAL { get; set; }
        [ColumnaGridViewAtributo(Name = "Moneda")]
        public string MONEDA { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio unitario")]
        public decimal? IMPORTE1 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Precio total")]
        public decimal? IMPORTE2 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Importe del descuento")]
        public decimal? IMPORTE3 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [ColumnaGridViewAtributo(Name = "Precio total con descuento")]
        public decimal? IMPORTE4 { get; set; }
        [ColumnaGridViewAtributo(Name = "Precio")]
        public decimal? IMPORTE6 { get; set; }
        [ColumnaGridViewAtributo(Name = "Porciento descuento")]
        public decimal? DESCUENTO { get; set; }
        [ColumnaGridViewAtributo(Name = "Porciento bonificación")]
        public decimal? BONIFIC { get; set; }
        [ColumnaGridViewAtributo(Name = "Porciento IVA")]
        public decimal? IVA { get; set; }
        [ColumnaGridViewAtributo(Name = "Indice conversión moneda")]
        public decimal? VA_INDIC { get; set; }
        [ColumnaGridViewAtributo(Name = "Cuenta contable")]
        public decimal? CG_CUENT { get; set; }
        [ColumnaGridViewAtributo(Name = "CUIT")]
        public string CUIT { get; set; }
        [ColumnaGridViewAtributo(Name = "Código proveedor")]
        public int? CG_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre proveedor")]
        public string DES_PROVE { get; set; }
        [ColumnaGridViewAtributo(Name = "Código cliente")]
        public int? CG_CLI { get; set; }
        [ColumnaGridViewAtributo(Name = "Nombre cliente")]
        public string DES_CLI { get; set; }
        [ColumnaGridViewAtributo(Name = "Dirección")]
        public string DIRECC { get; set; }
        [ColumnaGridViewAtributo(Name = "Localidad")]
        public string LOCALIDAD { get; set; }
        [ColumnaGridViewAtributo(Name = "Código postal")]
        public string CG_POSTA { get; set; }
        [ColumnaGridViewAtributo(Name = "Orden compra cliente")]
        public string ORCO { get; set; }
        [ColumnaGridViewAtributo(Name = "Cantidad pedida")]
        public decimal? CANTPED { get; set; }
        [ColumnaGridViewAtributo(Name = "Flag")]
        public int? FLAG { get; set; }
        [ColumnaGridViewAtributo(Name = "Usuario")]
        public string USUARIO { get; set; }
        [ColumnaGridViewAtributo(Name = "Fecha registro")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime FE_REG { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ColumnaGridViewAtributo(Name = "Registro")]
        public decimal? REGISTRO { get; set; }
        [ColumnaGridViewAtributo(Name = "Compañía")]
        public int? CG_CIA { get; set; }
    }
}
