using MyInvestments.Common;
using MyInvestments.Models;
using MyInvestments.ViewModel;
using System;
using System.Windows.Forms;

namespace MyInvestments.Views
{
    public partial class FrmMutualFunds : Form
    {

        #region Properties & Variables


        #endregion

        #region Constructors

        public FrmMutualFunds()
        {
            InitializeComponent();
        }

        #endregion

        #region User Defined Functions

        private void Reset()
        {
            try
            {
                BindCompanyNameDropDown();
                BindSchemeTypesDropDown();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindCompanyNameDropDown()
        {
            try
            {
                CmbMutualFundCompanyName.DataSource = null;
                int InvestmentTypeId = InvestmentTypesViewModel.GetInvestmentTypeIdFromName(Constants.MutualFund.Trim());
                var lstMutualFundCompanyNames = CompanyViewModel.GetCompaniesFromCompanyType(InvestmentTypeId);
                if (lstMutualFundCompanyNames != null)
                {
                    lstMutualFundCompanyNames.Insert(0, new CompanyMaster { CompanyId = 0, CompanyName = "-- Select Company Name --" });
                    CmbMutualFundCompanyName.DataSource = lstMutualFundCompanyNames;
                    CmbMutualFundCompanyName.DisplayMember = Constants.Companies.CompanyName.ToString();
                    CmbMutualFundCompanyName.ValueMember = Constants.Companies.CompanyId.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindSchemeTypesDropDown()
        {
            try
            {
                CmbMutualFundSchemeType.DataSource = null;                
                var lstMutualFundSchemeTypes = MutualFundSchemeTypesViewModel.GetMutualFundSchemeTypes();
                if (lstMutualFundSchemeTypes != null)
                {
                    lstMutualFundSchemeTypes.Insert(0, new MutualFundSchemeTypesMaster { MutualFundSchemeTypeId = 0, MutualFundSchemeTypeName = "-- Select Scheme Type --" });
                    CmbMutualFundSchemeType.DataSource = lstMutualFundSchemeTypes;
                    CmbMutualFundSchemeType.DisplayMember = Constants.MutualFundSchemeTypes.MutualFundSchemeTypeName.ToString();
                    CmbMutualFundSchemeType.ValueMember = Constants.MutualFundSchemeTypes.MutualFundSchemeTypeId.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Form & Other Control Events

        private void FrmMutualFunds_Load(object sender, EventArgs e)
        {
            Reset();
        }

        #endregion
    }
}
