using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyInvestments.Models
{
    public class DepositInvestments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepositId { get; set; }

        public string DepositTypeId { get; set; }

        public int CompanyId { get; set; }

        public string DepositScheme { get; set; }

        public DateTime DepositStartDate { get; set; }

        public DateTime? DepositMaturityDate { get; set; }

        public Double DepositPeriodInMonths { get; set; }

        public Double DepositAmount { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
