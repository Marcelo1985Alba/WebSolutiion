using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PCP.Shared.Models
{
	[Table("Depos")]
    public class Deposito
    {
		[Key]
        public int CG_DEP { get; set; }
        public string DES_DEP { get; set; }
        public string TIPO_DEP { get; set; }
        public int CG_CIA { get; set; }
        public int? CG_CLI { get; set; }
        public int? CG_PROVE { get; set; }

	}
}
