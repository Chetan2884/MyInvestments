using MyInvestments.Common;
using MyInvestments.Models;
using MyInvestments.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyInvestments.Views
{
    public partial class FrmMain : Form
    {
        #region Properties & Variables

        #endregion

        #region Constructors

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region User Defined Functions

        private void Reset()
        {
            try
            {
                CmbInvestmentTypes.Items.Clear();
                List<InvestmentTypes> lstInvestmentTypes = GetInvestmentTypes();
                lstInvestmentTypes.Insert(0, new InvestmentTypes() { InvestmentTypeId = 0, InvestmentTypeName = " -- Select Investment Type -- " });
                CmbInvestmentTypes.DataSource = lstInvestmentTypes;
                CmbInvestmentTypes.DisplayMember = Constants.InvestmentTypes.InvestmentTypeName.ToString();
                CmbInvestmentTypes.ValueMember = Constants.InvestmentTypes.InvestmentTypeId.ToString();
                CmbInvestmentTypes.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static List<InvestmentTypes> GetInvestmentTypes()
        {
            try
            {
                return InvestmentTypesViewModel.GetInvestmentTypes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Form & Control Events
        private void PbLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Do you wish to logout?", "Application Logoff", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin loginObj = new();
                loginObj.ShowDialog();
                this.Close();
                Application.Exit();
            }
        }        

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CmbInvestmentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (CmbInvestmentTypes.Text)
                {
                    case Constants.Bonds:
                        {
                            frmBonds bondsObj = new();
                            bondsObj.ShowDialog();
                            break;
                        }
                    case Constants.Deposits:
                        {
                            frmDeposits depositsObj = new();
                            depositsObj.ShowDialog();
                            break;
                        }
                    case Constants.Stocks:
                        {
                            frmStocks stocksObj = new();
                            stocksObj.ShowDialog();
                            break;
                        }
                    case Constants.Insurance:
                        {
                            frmInsurance insuranceObj = new();
                            insuranceObj.ShowDialog();
                            break;
                        }
                    case Constants.MutualFund:
                        {
                            FrmMutualFunds mutualfundsObj = new();
                            mutualfundsObj.ShowDialog();
                            break;
                        }
                    case Constants.ProvidentFund:
                        {
                            frmProvidentFund providentfundObj = new();
                            providentfundObj.ShowDialog();
                            break;
                        }
                }
                CmbInvestmentTypes.SelectedIndex = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
