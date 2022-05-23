using MyInvestments.Common;
using MyInvestments.Models;
using MyInvestments.ViewModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyInvestments.Views.Master
{
    public partial class FrmCompanyTypesMapping : Form
    {
        #region Properties & Variables

        private static string existingCompanyName = string.Empty;
        private static string existingCompanyType = string.Empty;
        private static int selectedMappingId = 0;

        #endregion

        #region Constructors
        public FrmCompanyTypesMapping()
        {
            InitializeComponent();
        }

        #endregion

        #region User Defined Functions

        private void Reset()
        {
            try
            {
                BindCompanyMappingGridData();
                BindCompanyNameDropDown();
                BindCompanyTypeDropDown();
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
                BtnCancel.Enabled = false;
                BtnInsert.Enabled = true;
                existingCompanyName = string.Empty;
                existingCompanyType = string.Empty;
                selectedMappingId = 0;
                CmbCompanyName.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindCompanyMappingGridData()
        {
            try
            {
                DgvExistingCompanyMapping.DataSource = null;
                var lstCompanyTypeMapping = CompanyTypesMappingViewModel.GetCompanyTypesMapping();
                if (lstCompanyTypeMapping != null)
                {
                    DgvExistingCompanyMapping.DataSource = lstCompanyTypeMapping;
                    DgvExistingCompanyMapping.Refresh();
                    DgvExistingCompanyMapping.Columns[Constants.Companies.CompanyId.ToString()].Visible = false;
                    DgvExistingCompanyMapping.Columns[Constants.CompanyTypes.CompanyTypeId.ToString()].Visible = false;
                    DgvExistingCompanyMapping.Columns[Constants.CompanyTypesMapping.CompanyTypesMappingId.ToString()].Visible = false;
                }
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
                CmbCompanyName.DataSource = null;
                List<CompanyMaster> lstCompanyNames = CompanyViewModel.GetCompanies();
                if (lstCompanyNames != null)
                {
                    lstCompanyNames.Insert(0, new CompanyMaster { CompanyId = 0, CompanyName = "-- Select Company Name --" });
                    CmbCompanyName.DataSource = lstCompanyNames;
                    CmbCompanyName.DisplayMember = Constants.Companies.CompanyName.ToString();
                    CmbCompanyName.ValueMember = Constants.Companies.CompanyId.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BindCompanyTypeDropDown()
        {
            try
            {
                CmbCompanyType.DataSource = null;
                List<CompanyTypesMaster> lstCompanyTypes = CompanyTypeViewModel.GetCompanyTypes();
                if (lstCompanyTypes != null)
                {
                    lstCompanyTypes.Insert(0, new CompanyTypesMaster { CompanyTypeId = 0, CompanyTypeName = "-- Select Company Type --" });
                    CmbCompanyType.DataSource = lstCompanyTypes;
                    CmbCompanyType.DisplayMember = Constants.CompanyTypes.CompanyTypeName.ToString();
                    CmbCompanyType.ValueMember = Constants.CompanyTypes.CompanyTypeId.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool CheckMappingExistance(int SelectedCompanyId, int SelectedCompanyTypeId)
        {
            try
            {
                dynamic mappingData = DgvExistingCompanyMapping.DataSource;
                foreach (var company in mappingData)
                {
                    if (company.CompanyId == SelectedCompanyId && company.CompanyTypeId == SelectedCompanyTypeId)
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

        private void DgvExistingCompanyMapping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedMappingId = Convert.ToInt32(DgvExistingCompanyMapping.Rows[e.RowIndex].Cells[Constants.CompanyTypesMapping.CompanyTypesMappingId.ToString()].Value);
                CmbCompanyName.Text = Convert.ToString(DgvExistingCompanyMapping.Rows[e.RowIndex].Cells[Constants.Companies.CompanyName.ToString()].Value);
                CmbCompanyType.Text = Convert.ToString(DgvExistingCompanyMapping.Rows[e.RowIndex].Cells[Constants.CompanyTypes.CompanyTypeName.ToString()].Value);
                existingCompanyName = CmbCompanyName.Text;
                existingCompanyType = CmbCompanyType.Text;
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
                int selectedNameId = Convert.ToInt32(CmbCompanyName.SelectedValue);
                int selectedTypeId = Convert.ToInt32(CmbCompanyType.SelectedValue);
                if (selectedNameId == 0 || selectedTypeId == 0)
                {
                    MessageBox.Show("Kindly select both company name & type to insert.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckMappingExistance(selectedNameId, selectedTypeId))
                {
                    MessageBox.Show("Selected company & type pair already exist.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Can you confirm '" + CmbCompanyName.Text + " ~ " + CmbCompanyType.Text + "' pairing to be inserted?", "Insert Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyTypesMapping ctm = new();
                        ctm.CompanyId = selectedNameId;
                        ctm.CompanyTypeId = selectedTypeId;
                        ctm.CreatedDate = DateTime.Now;
                        CompanyTypesMappingViewModel.InsertCompanyTypesMapping(ctm);
                        MessageBox.Show("New pair '" + CmbCompanyName.Text + " ~ " + CmbCompanyType.Text + "' inserted successfully!", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                int selectedNameId = Convert.ToInt32(CmbCompanyName.SelectedValue);
                int selectedTypeId = Convert.ToInt32(CmbCompanyType.SelectedValue);
                if (selectedNameId == 0 || selectedTypeId == 0)
                {
                    MessageBox.Show("Kindly select both company name & type to updated.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CheckMappingExistance(selectedNameId, selectedTypeId))
                {
                    MessageBox.Show("Selected company & type pair already exist.", "Existance Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to update existing company & type mapping from '" + existingCompanyName + " ~ " + existingCompanyType + "' to '" + CmbCompanyName.Text + " ~ " + CmbCompanyType.Text +  "' ?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CompanyTypesMapping ctm = new();
                        ctm.CompanyId = selectedNameId;
                        ctm.CompanyTypeId = selectedTypeId;
                        ctm.CompanyTypesMappingId = selectedMappingId;
                        ctm.UpdatedDate = DateTime.Now;
                        CompanyTypesMappingViewModel.UpdateCompanyTypesMapping(ctm);
                        MessageBox.Show("Company & type mapping '" + existingCompanyName + " ~ " + existingCompanyType +  "' updated successfully to '" + CmbCompanyName.Text + " ~ " + CmbCompanyType.Text + "'!", "Update Successful.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete '" + existingCompanyName + " ~ " + existingCompanyType + "' company & type mapping ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    CompanyTypesMapping ctm = new();                    
                    ctm.CompanyId = selectedMappingId;
                    int selectedNameId = Convert.ToInt32(CmbCompanyName.SelectedValue);
                    int selectedTypeId = Convert.ToInt32(CmbCompanyType.SelectedValue);
                    if (selectedNameId == 0 || selectedTypeId == 0)
                    {
                        MessageBox.Show("Company & type pair is required to delete.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (CompanyTypesMappingViewModel.DeleteCompanyTypesMapping(ctm))
                    {
                        MessageBox.Show("Company & type pair '" + existingCompanyName + " ~ " + existingCompanyType + "' deleted successfully!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("No such company & type pair exists. Kindly select existing record to delete", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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