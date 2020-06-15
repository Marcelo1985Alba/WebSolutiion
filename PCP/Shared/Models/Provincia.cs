﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
    [Table("Prov")]
    public class Provincia
    {
        [Key]
        [ColumnaGridViewAtributo(Name = "Codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CG_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Provincia")]
        public string DES_PROV { get; set; }
        [ColumnaGridViewAtributo(Name = "Pais")]
        public int? CG_PAIS { get; set; }

    }
}
