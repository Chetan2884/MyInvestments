namespace MyInvestments.Views
{
    partial class FrmMutualFunds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVExistingMutualFunds = new System.Windows.Forms.DataGridView();
            this.LblExitingMutualFunds = new System.Windows.Forms.Label();
            this.LblEditMutualFunds = new System.Windows.Forms.Label();
            this.CmbMutualFundCompanyName = new System.Windows.Forms.ComboBox();
            this.LblMutualFundCompanyName = new System.Windows.Forms.Label();
            this.CmbMutualFundSchemeType = new System.Windows.Forms.ComboBox();
            this.LblMutualFundSchemeType = new System.Windows.Forms.Label();
            this.LblMutualFundSchemeName = new System.Windows.Forms.Label();
            this.TxtMutualFundSchemeName = new System.Windows.Forms.TextBox();
            this.TxtMutualFundFolioNumber = new System.Windows.Forms.TextBox();
            this.LblMutualFundFolioNumber = new System.Windows.Forms.Label();
            this.LblMutualFundPurchaseDate = new System.Windows.Forms.Label();
            this.DtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.LblMutualFundPurchaseAmount = new System.Windows.Forms.Label();
            this.TxtMutualFundAmount = new System.Windows.Forms.TextBox();
            this.LblMutualFundTransactionType = new System.Windows.Forms.Label();
            this.CmbMutualFundTrasnactionType = new System.Windows.Forms.ComboBox();
            this.LblMutualFundNAV = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblMutualFundUnits = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingMutualFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVExistingMutualFunds
            // 
            this.DGVExistingMutualFunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVExistingMutualFunds.Location = new System.Drawing.Point(48, 41);
            this.DGVExistingMutualFunds.Name = "DGVExistingMutualFunds";
            this.DGVExistingMutualFunds.RowHeadersWidth = 62;
            this.DGVExistingMutualFunds.RowTemplate.Height = 33;
            this.DGVExistingMutualFunds.Size = new System.Drawing.Size(829, 250);
            this.DGVExistingMutualFunds.TabIndex = 0;
            // 
            // LblExitingMutualFunds
            // 
            this.LblExitingMutualFunds.AutoSize = true;
            this.LblExitingMutualFunds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblExitingMutualFunds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblExitingMutualFunds.Location = new System.Drawing.Point(48, 9);
            this.LblExitingMutualFunds.Name = "LblExitingMutualFunds";
            this.LblExitingMutualFunds.Size = new System.Drawing.Size(354, 25);
            this.LblExitingMutualFunds.TabIndex = 2;
            this.LblExitingMutualFunds.Text = "List of existing mutual fund investments";
            // 
            // LblEditMutualFunds
            // 
            this.LblEditMutualFunds.AutoSize = true;
            this.LblEditMutualFunds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEditMutualFunds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblEditMutualFunds.Location = new System.Drawing.Point(48, 307);
            this.LblEditMutualFunds.Name = "LblEditMutualFunds";
            this.LblEditMutualFunds.Size = new System.Drawing.Size(340, 25);
            this.LblEditMutualFunds.TabIndex = 3;
            this.LblEditMutualFunds.Text = "Insert-Update mutual fund investment";
            // 
            // CmbMutualFundCompanyName
            // 
            this.CmbMutualFundCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMutualFundCompanyName.FormattingEnabled = true;
            this.CmbMutualFundCompanyName.Location = new System.Drawing.Point(195, 353);
            this.CmbMutualFundCompanyName.Name = "CmbMutualFundCompanyName";
            this.CmbMutualFundCompanyName.Size = new System.Drawing.Size(250, 33);
            this.CmbMutualFundCompanyName.TabIndex = 12;
            // 
            // LblMutualFundCompanyName
            // 
            this.LblMutualFundCompanyName.AutoSize = true;
            this.LblMutualFundCompanyName.Location = new System.Drawing.Point(48, 353);
            this.LblMutualFundCompanyName.Name = "LblMutualFundCompanyName";
            this.LblMutualFundCompanyName.Size = new System.Drawing.Size(141, 25);
            this.LblMutualFundCompanyName.TabIndex = 11;
            this.LblMutualFundCompanyName.Text = "Company Name";
            // 
            // CmbMutualFundSchemeType
            // 
            this.CmbMutualFundSchemeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMutualFundSchemeType.FormattingEnabled = true;
            this.CmbMutualFundSchemeType.Location = new System.Drawing.Point(627, 350);
            this.CmbMutualFundSchemeType.Name = "CmbMutualFundSchemeType";
            this.CmbMutualFundSchemeType.Size = new System.Drawing.Size(250, 33);
            this.CmbMutualFundSchemeType.TabIndex = 14;
            // 
            // LblMutualFundSchemeType
            // 
            this.LblMutualFundSchemeType.AutoSize = true;
            this.LblMutualFundSchemeType.Location = new System.Drawing.Point(488, 356);
            this.LblMutualFundSchemeType.Name = "LblMutualFundSchemeType";
            this.LblMutualFundSchemeType.Size = new System.Drawing.Size(116, 25);
            this.LblMutualFundSchemeType.TabIndex = 13;
            this.LblMutualFundSchemeType.Text = "Scheme Type";
            // 
            // LblMutualFundSchemeName
            // 
            this.LblMutualFundSchemeName.AutoSize = true;
            this.LblMutualFundSchemeName.Location = new System.Drawing.Point(48, 411);
            this.LblMutualFundSchemeName.Name = "LblMutualFundSchemeName";
            this.LblMutualFundSchemeName.Size = new System.Drawing.Size(126, 25);
            this.LblMutualFundSchemeName.TabIndex = 15;
            this.LblMutualFundSchemeName.Text = "Scheme Name";
            // 
            // TxtMutualFundSchemeName
            // 
            this.TxtMutualFundSchemeName.Location = new System.Drawing.Point(195, 412);
            this.TxtMutualFundSchemeName.Name = "TxtMutualFundSchemeName";
            this.TxtMutualFundSchemeName.Size = new System.Drawing.Size(686, 31);
            this.TxtMutualFundSchemeName.TabIndex = 16;
            // 
            // TxtMutualFundFolioNumber
            // 
            this.TxtMutualFundFolioNumber.Location = new System.Drawing.Point(195, 469);
            this.TxtMutualFundFolioNumber.Name = "TxtMutualFundFolioNumber";
            this.TxtMutualFundFolioNumber.Size = new System.Drawing.Size(250, 31);
            this.TxtMutualFundFolioNumber.TabIndex = 18;
            // 
            // LblMutualFundFolioNumber
            // 
            this.LblMutualFundFolioNumber.AutoSize = true;
            this.LblMutualFundFolioNumber.Location = new System.Drawing.Point(48, 469);
            this.LblMutualFundFolioNumber.Name = "LblMutualFundFolioNumber";
            this.LblMutualFundFolioNumber.Size = new System.Drawing.Size(121, 25);
            this.LblMutualFundFolioNumber.TabIndex = 17;
            this.LblMutualFundFolioNumber.Text = "Folio Number";
            // 
            // LblMutualFundPurchaseDate
            // 
            this.LblMutualFundPurchaseDate.AutoSize = true;
            this.LblMutualFundPurchaseDate.Location = new System.Drawing.Point(48, 535);
            this.LblMutualFundPurchaseDate.Name = "LblMutualFundPurchaseDate";
            this.LblMutualFundPurchaseDate.Size = new System.Drawing.Size(142, 25);
            this.LblMutualFundPurchaseDate.TabIndex = 19;
            this.LblMutualFundPurchaseDate.Text = "Transaction Date";
            // 
            // DtpTransactionDate
            // 
            this.DtpTransactionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpTransactionDate.Location = new System.Drawing.Point(195, 529);
            this.DtpTransactionDate.MaxDate = new System.DateTime(2022, 5, 11, 0, 0, 0, 0);
            this.DtpTransactionDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtpTransactionDate.Name = "DtpTransactionDate";
            this.DtpTransactionDate.Size = new System.Drawing.Size(250, 31);
            this.DtpTransactionDate.TabIndex = 20;
            this.DtpTransactionDate.Value = new System.DateTime(2022, 5, 11, 0, 0, 0, 0);
            // 
            // LblMutualFundPurchaseAmount
            // 
            this.LblMutualFundPurchaseAmount.AutoSize = true;
            this.LblMutualFundPurchaseAmount.Location = new System.Drawing.Point(488, 529);
            this.LblMutualFundPurchaseAmount.Name = "LblMutualFundPurchaseAmount";
            this.LblMutualFundPurchaseAmount.Size = new System.Drawing.Size(77, 25);
            this.LblMutualFundPurchaseAmount.TabIndex = 21;
            this.LblMutualFundPurchaseAmount.Text = "Amount";
            // 
            // TxtMutualFundAmount
            // 
            this.TxtMutualFundAmount.Location = new System.Drawing.Point(627, 529);
            this.TxtMutualFundAmount.Name = "TxtMutualFundAmount";
            this.TxtMutualFundAmount.Size = new System.Drawing.Size(250, 31);
            this.TxtMutualFundAmount.TabIndex = 22;
            // 
            // LblMutualFundTransactionType
            // 
            this.LblMutualFundTransactionType.AutoSize = true;
            this.LblMutualFundTransactionType.Location = new System.Drawing.Point(481, 469);
            this.LblMutualFundTransactionType.Name = "LblMutualFundTransactionType";
            this.LblMutualFundTransactionType.Size = new System.Drawing.Size(142, 25);
            this.LblMutualFundTransactionType.TabIndex = 23;
            this.LblMutualFundTransactionType.Text = "Transaction Type";
            // 
            // CmbMutualFundTrasnactionType
            // 
            this.CmbMutualFundTrasnactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMutualFundTrasnactionType.FormattingEnabled = true;
            this.CmbMutualFundTrasnactionType.Location = new System.Drawing.Point(627, 466);
            this.CmbMutualFundTrasnactionType.Name = "CmbMutualFundTrasnactionType";
            this.CmbMutualFundTrasnactionType.Size = new System.Drawing.Size(250, 33);
            this.CmbMutualFundTrasnactionType.TabIndex = 24;
            // 
            // LblMutualFundNAV
            // 
            this.LblMutualFundNAV.AutoSize = true;
            this.LblMutualFundNAV.Location = new System.Drawing.Point(48, 594);
            this.LblMutualFundNAV.Name = "LblMutualFundNAV";
            this.LblMutualFundNAV.Size = new System.Drawing.Size(135, 25);
            this.LblMutualFundNAV.TabIndex = 25;
            this.LblMutualFundNAV.Text = "Net Asset Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 591);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 31);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(627, 588);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 31);
            this.textBox2.TabIndex = 28;
            // 
            // LblMutualFundUnits
            // 
            this.LblMutualFundUnits.AutoSize = true;
            this.LblMutualFundUnits.Location = new System.Drawing.Point(488, 591);
            this.LblMutualFundUnits.Name = "LblMutualFundUnits";
            this.LblMutualFundUnits.Size = new System.Drawing.Size(52, 25);
            this.LblMutualFundUnits.TabIndex = 27;
            this.LblMutualFundUnits.Text = "Units";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(590, 640);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 34);
            this.BtnCancel.TabIndex = 32;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(239, 640);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(100, 34);
            this.BtnInsert.TabIndex = 31;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(473, 640);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 34);
            this.BtnDelete.TabIndex = 30;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(356, 640);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 34);
            this.BtnUpdate.TabIndex = 29;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmMutualFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 694);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblMutualFundUnits);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblMutualFundNAV);
            this.Controls.Add(this.CmbMutualFundTrasnactionType);
            this.Controls.Add(this.LblMutualFundTransactionType);
            this.Controls.Add(this.TxtMutualFundAmount);
            this.Controls.Add(this.LblMutualFundPurchaseAmount);
            this.Controls.Add(this.DtpTransactionDate);
            this.Controls.Add(this.LblMutualFundPurchaseDate);
            this.Controls.Add(this.TxtMutualFundFolioNumber);
            this.Controls.Add(this.LblMutualFundFolioNumber);
            this.Controls.Add(this.TxtMutualFundSchemeName);
            this.Controls.Add(this.LblMutualFundSchemeName);
            this.Controls.Add(this.CmbMutualFundSchemeType);
            this.Controls.Add(this.LblMutualFundSchemeType);
            this.Controls.Add(this.CmbMutualFundCompanyName);
            this.Controls.Add(this.LblMutualFundCompanyName);
            this.Controls.Add(this.LblEditMutualFunds);
            this.Controls.Add(this.LblExitingMutualFunds);
            this.Controls.Add(this.DGVExistingMutualFunds);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMutualFunds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new or update existing mutual fund investments";
            this.Load += new System.EventHandler(this.FrmMutualFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVExistingMutualFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVExistingMutualFunds;
        private System.Windows.Forms.Label LblExitingMutualFunds;
        private System.Windows.Forms.Label LblEditMutualFunds;
        private System.Windows.Forms.ComboBox CmbMutualFundCompanyName;
        private System.Windows.Forms.Label LblMutualFundCompanyName;
        private System.Windows.Forms.ComboBox CmbMutualFundSchemeType;
        private System.Windows.Forms.Label LblMutualFundSchemeType;
        private System.Windows.Forms.Label LblMutualFundSchemeName;
        private System.Windows.Forms.TextBox TxtMutualFundSchemeName;
        private System.Windows.Forms.TextBox TxtMutualFundFolioNumber;
        private System.Windows.Forms.Label LblMutualFundFolioNumber;
        private System.Windows.Forms.Label LblMutualFundPurchaseDate;
        private System.Windows.Forms.DateTimePicker DtpTransactionDate;
        private System.Windows.Forms.Label LblMutualFundPurchaseAmount;
        private System.Windows.Forms.TextBox TxtMutualFundAmount;
        private System.Windows.Forms.Label LblMutualFundTransactionType;
        private System.Windows.Forms.ComboBox CmbMutualFundTrasnactionType;
        private System.Windows.Forms.Label LblMutualFundNAV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblMutualFundUnits;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
    }
}