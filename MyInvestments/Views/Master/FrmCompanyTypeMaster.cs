using MyInvestments.Common;
using MyInvestments.Models;
using MyInvestments.ViewModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyInvestments.Views.Master
{
    public partial class FrmCompanyTypeMaster : Form
    {
        #region Properties & Variables

        private static string existingTypeName = string.Empty;
        private static int selectedId = 0;
        private static List<CompanyTypesMaster> lstCompanyTypeMaster = new();

        #endregion

        #region Constructors
        public FrmCompanyTypeMaster()
        {
            InitializeComponent();
        }

        #endregion

        #region User Defined Functions

        private void Reset()
        {
            try
            {
                BindCompanyTypeGridData();
                TxtCompanyTypeName.Text = String.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
                BtnCancel.Enabled = false;
                BtnInsert.Enabled = true;
                existingTypeName = string.Empty;
                selectedId = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindCompanyTypeGridData()
        {
            try
            {
                lstCompanyTypeMaster = CompanyTypeViewModel.GetCompanyTypes();
                DgvExistingCompanyTypes.DataSource = lstCompanyTypeMaster;
                DgvExistingCompanyTypes.Refresh();
                DgvExistingCompanyTypes.Columns[Constants.CompanyTypes.CompanyTypeId.ToString()].Visible = false;

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
                foreach (var company in lstCompanyTypeMaster)
                {
                    if (company.CompanyTypeName.Trim().ToUpper() == EnteredCompanyName.ToUpper())
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

        private void FrmCompanyTypeMaster_Load(object sender, EventArgs e)
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

        private void DgvExistingCompanyTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    selectedId = Convert.ToInt32(DgvExistingCompanyTypes.Rows[e.RowIndex].Cells[0].Value);
                    TxtCompanyTypeName.Text = Convert.ToString(DgvExistingCompanyTypes.Rows[e.RowIndex].Cells[1].Value);
                    existingTypeName = TxtCompanyTypeName.Text;
                    BtnInsert.Enabled = false;
                    BtnUpdate.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnCancel.Enabled = true;
                }
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
                if (string.IsNullOrEmpty(TxtCompanyTypeName.Text) || string.IsNullOrWhiteSpace(TxtCompanyTypeName.Text))
                {
                    MessageBox.Show("Kindly provide new company type to be inserted.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!ValidateCompanyName(TxtCompanyTypeName.Text))
                {
                    MessageBox.Show("Characters except 'alphabets, numbers, &, space' not allowed in company type.", "Need Correction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckCompanyExistance(TxtCompanyTypeName.Text.Trim()))
                {
                    MessageBox.Show("Company type with same name already exists.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you confirm '" + TxtCompanyTypeName.Text + "' is new type to be inserted?", "Insert Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyTypesMaster cm = new();
                        cm.CompanyTypeName = TxtCompanyTypeName.Text;
                        CompanyTypeViewModel.InsertCompanyType(cm);
                        MessageBox.Show("New company type '" + TxtCompanyTypeName.Text + "' inserted successfully!", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(TxtCompanyTypeName.Text) || string.IsNullOrWhiteSpace(TxtCompanyTypeName.Text))
                {
                    MessageBox.Show("Kindly provide company type to be updated.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (existingTypeName == TxtCompanyTypeName.Text)
                {
                    MessageBox.Show("Company type with same name cannot be updated, kindly enter new value.", "Need Updated Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!ValidateCompanyName(TxtCompanyTypeName.Text.Trim()))
                {
                    MessageBox.Show("Characters except 'alphabets, numbers, &, space' not allowed in company type.", "Need Correction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckCompanyExistance(TxtCompanyTypeName.Text.Trim()))
                {
                    MessageBox.Show("Company type with same name already exists.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update existing company type from '" + existingTypeName + "' to '" + TxtCompanyTypeName.Text + "' ?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyMaster cm = new();
                        cm.CompanyName = TxtCompanyTypeName.Text.Trim();
                        cm.CompanyId = selectedId;
                        CompanyViewModel.UpdateCompany(cm);
                        MessageBox.Show("Company '" + existingTypeName + "' updated successfully to '" + TxtCompanyTypeName.Text + "'!", "Update Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete selected company type '" + TxtCompanyTypeName.Text + "' ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CompanyTypesMaster cm = new();
                    cm.CompanyTypeName = TxtCompanyTypeName.Text.Trim();
                    cm.CompanyTypeId = selectedId;
                    if (string.IsNullOrEmpty(TxtCompanyTypeName.Text) || string.IsNullOrWhiteSpace(TxtCompanyTypeName.Text))
                    {
                        MessageBox.Show("Company type cannot be blank, kindly select company from list to delete.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (CompanyTypeViewModel.DeleteCompanyType(cm))
                    {
                        MessageBox.Show("Company type '" + TxtCompanyTypeName.Text + "' deleted successfully!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("No such company type with name '" + TxtCompanyTypeName.Text + "' exists. Kindly select existing record to delete", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
