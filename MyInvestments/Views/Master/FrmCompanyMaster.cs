using MyInvestments.Common;
using MyInvestments.Models;
using MyInvestments.ViewModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyInvestments.Views.Master
{
    public partial class FrmCompanyMaster : Form
    {
        #region Properties & Variables

        private static string existingName = string.Empty;
        private static int selectedId = 0;
        private static List<CompanyMaster> lstCompanyMaster = new();

        #endregion

        #region Constructors
        public FrmCompanyMaster()
        {
            InitializeComponent();
        }

        #endregion

        #region User Defined Functions

        private void Reset()
        {
            try
            {
                BindCompanyGridData();
                TxtCompanyName.Text = String.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
                BtnCancel.Enabled = false;
                BtnInsert.Enabled = true;
                existingName = string.Empty;
                selectedId = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindCompanyGridData()
        {
            try
            {
                lstCompanyMaster = CompanyViewModel.GetCompanies();
                DgvExistingCompanies.DataSource = lstCompanyMaster;
                DgvExistingCompanies.Refresh();
                DgvExistingCompanies.Columns[Constants.Companies.CompanyId.ToString()].Visible = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool ValidateCompanyName(string EnteredCompanyName)
        {
            try
            {
                if (!Regex.IsMatch(EnteredCompanyName, "^[A-Za-z0-9& ]*$"))
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool CheckCompanyExistance(string EnteredCompanyName)
        {
            try
            {
                foreach (var company in lstCompanyMaster)
                {
                    if (company.CompanyName.Trim().ToUpper() == EnteredCompanyName.ToUpper())
                        return true;

                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Form & Control Events

        private void FrmCompanyMaster_Load(object sender, EventArgs e)
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

        private void DgvExistingCompanies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedId = Convert.ToInt32(DgvExistingCompanies.Rows[e.RowIndex].Cells[0].Value);
                TxtCompanyName.Text = Convert.ToString(DgvExistingCompanies.Rows[e.RowIndex].Cells[1].Value);
                existingName = TxtCompanyName.Text;
                BtnInsert.Enabled = false;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
                BtnCancel.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtCompanyName.Text) || string.IsNullOrWhiteSpace(TxtCompanyName.Text))
                {
                    MessageBox.Show("Kindly provide new company name to be inserted.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!ValidateCompanyName(TxtCompanyName.Text))
                {
                    MessageBox.Show("Characters except 'alphabets, numbers, &, space' not allowed in company name.", "Need Correction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckCompanyExistance(TxtCompanyName.Text.Trim()))
                {
                    MessageBox.Show("Company with same name already exists.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Can you confirm '" + TxtCompanyName.Text + "' is new company name to be inserted?", "Insert Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyMaster cm = new()
                        {
                            CompanyName = TxtCompanyName.Text
                        };
                        CompanyViewModel.InsertCompany(cm);
                        MessageBox.Show("New company '" + TxtCompanyName.Text + "' inserted successfully!", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                existingName = TxtCompanyName.Text;
                if (string.IsNullOrEmpty(TxtCompanyName.Text) || string.IsNullOrWhiteSpace(TxtCompanyName.Text))
                {
                    MessageBox.Show("Kindly provide company name to be updated.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (existingName == TxtCompanyName.Text)
                {
                    MessageBox.Show("Company with same name cannot be updated, kindly enter new value.", "Need Updated Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!ValidateCompanyName(TxtCompanyName.Text.Trim()))
                {
                    MessageBox.Show("Characters except 'alphabets, numbers, &, space' not allowed in company name.", "Need Correction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckCompanyExistance(TxtCompanyName.Text.Trim()))
                {
                    MessageBox.Show("Company with same name already exists.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update existing company name from '" + existingName + "' to '" + TxtCompanyName.Text + "' ?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyMaster cm = new()
                        {
                            CompanyName = TxtCompanyName.Text.Trim(),
                            CompanyId = selectedId
                        };
                        CompanyViewModel.UpdateCompany(cm);
                        MessageBox.Show("Company '" + existingName + "' updated successfully to '" + TxtCompanyName.Text + "'!", "Update Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete selected company " + TxtCompanyName.Text.Trim() + " ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CompanyMaster cm = new()
                    {
                        CompanyName = TxtCompanyName.Text.Trim(),
                        CompanyId = selectedId
                    };
                    if (string.IsNullOrEmpty(TxtCompanyName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtCompanyName.Text.Trim()))
                    {
                        MessageBox.Show("Company name cannot be blank, kindly select company from list to delete.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (CompanyViewModel.DeleteCompany(cm))
                    {
                        MessageBox.Show("Company " + TxtCompanyName.Text.Trim() + " deleted successfully!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("No such company with name " + TxtCompanyName.Text.Trim() + "exists. Kindly select existing record to delete", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
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

        #endregion
    }
}
