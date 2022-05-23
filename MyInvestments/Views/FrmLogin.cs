using MyInvestments.Common;
using System;
using System.Windows.Forms;
using MyInvestments.ViewModel;
using MyInvestments.Models;

namespace MyInvestments.Views
{
    public partial class FrmLogin : Form
    {
        #region User Defined Functions
        private void Reset()
        {
            try
            {
                TxtLoginId.Text = string.Empty;
                TxtPassword.Text = string.Empty;
                TxtLoginId.Focus();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Constructors

        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Form & Control Events

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginObject = new();
                loginObject.LoginName = TxtLoginId.Text.Trim();
                loginObject.Password = TxtPassword.Text.Trim();
                if (LoginViewModel.CheckLoginDetails(loginObject))
                {
                    this.Hide();
                    FrmMain frmMainObject = new();
                    frmMainObject.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PbExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show(Constants.AppExitConf, Constants.ApplExitCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
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
