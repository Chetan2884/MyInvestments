using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyInvestments.Models
{
    public class MutualFundsInvestment
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MutualFundInvestmentId { get; set; }

        public int CompanyId { get; set;}

        public int MutualFundSchemeTypeId { get; set; }

        public string MutualFundSchemeName { get; set; }

        public string MutualFundFolioNumber { get; set; }

        public int MutualFundTransactionType { get; set; }

        public DateTime MutualFundTransactionDate { get; set; }

        public double MutualFundTransactionAmount { get; set; }

        public double MutualFundNetAssetValue { get; set; }

        public double MutualFundUnits { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
