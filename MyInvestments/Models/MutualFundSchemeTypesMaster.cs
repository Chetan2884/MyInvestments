using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyInvestments.Models
{
    public class MutualFundSchemeTypesMaster
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MutualFundSchemeTypeId { get; set; }

        public string MutualFundSchemeTypeName { get; set;}

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
