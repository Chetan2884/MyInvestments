using System.ComponentModel.DataAnnotations;

namespace MyInvestments.Common
{
    public sealed class Constants
    {
        #region Variables

        public const string AppExitConf = "Do you really want to exit application?";
        public const string ApplExitCaption = "Application Exit";
        public const string MyInvestmentsConn = "MyInvestmentsConn";
        public const string Stocks = "Stocks";
        public const string Bonds = "Bonds";
        public const string MutualFund = "Mutual Fund";
        public const string Deposits = "Deposits";
        public const string ProvidentFund = "Provident Fund";
        public const string Insurance = "Insurance";        

        #endregion

        #region Enums

        public enum InvestmentTypes
        {
            InvestmentTypeId,
            InvestmentTypeName            
        }

        public enum Companies
        {
            CompanyId,
            CompanyName,
        }

        public enum CompanyTypes
        {
            CompanyTypeId,
            CompanyTypeName,
        }

        public enum CompanyTypesMapping
        {
            CompanyTypesMappingId
        }

        public enum MutualFundSchemeTypes
        {
            MutualFundSchemeTypeId,
            MutualFundSchemeTypeName
        }

        public enum DepositTypes 
        {
            [Display(Name="Fixed Deposit")]
            FixedDeposit = 1,
            [Display(Name = "Recurring Deposit")]
            RecurringDeposit = 2
        }

        #endregion
    }
}
