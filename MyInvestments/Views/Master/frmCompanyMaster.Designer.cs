namespace MyInvestments.Views.Master
{
    partial class FrmCompanyMaster
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
            this.DgvExistingCompanies = new System.Windows.Forms.DataGridView();
            this.LblExitingCompanies = new System.Windows.Forms.Label();
            this.LblEditCompany = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblCompanyIdHidden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExistingCompanies
            // 
            this.DgvExistingCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExistingCompanies.Location = new System.Drawing.Point(103, 43);
            this.DgvExistingCompanies.Name = "DgvExistingCompanies";
            this.DgvExistingCompanies.ReadOnly = true;
            this.DgvExistingCompanies.RowHeadersWidth = 62;
            this.DgvExistingCompanies.RowTemplate.Height = 33;
            this.DgvExistingCompanies.Size = new System.Drawing.Size(573, 200);
            this.DgvExistingCompanies.TabIndex = 0;
            this.DgvExistingCompanies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExistingCompanies_CellDoubleClick);
            // 
            // LblExitingCompanies
            // 
            this.LblExitingCompanies.AutoSize = true;
            this.LblExitingCompanies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblExitingCompanies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblExitingCompanies.Location = new System.Drawing.Point(27, 9);
            this.LblExitingCompanies.Name = "LblExitingCompanies";
            this.LblExitingCompanies.Size = new System.Drawing.Size(232, 25);
            this.LblExitingCompanies.TabIndex = 1;
            this.LblExitingCompanies.Text = "List of existing companies";
            // 
            // LblEditCompany
            // 
            this.LblEditCompany.AutoSize = true;
            this.LblEditCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEditCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblEditCompany.Location = new System.Drawing.Point(27, 269);
            this.LblEditCompany.Name = "LblEditCompany";
            this.LblEditCompany.Size = new System.Drawing.Size(274, 25);
            this.LblEditCompany.TabIndex = 2;
            this.LblEditCompany.Text = "Insert-Update company details";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(191, 309);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(141, 25);
            this.LblCompanyName.TabIndex = 3;
            this.LblCompanyName.Text = "Company Name";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(338, 306);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(250, 31);
            this.TxtCompanyName.TabIndex = 4;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(281, 362);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(100, 34);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(398, 362);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 34);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(164, 362);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(100, 34);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(515, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 34);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblCompanyIdHidden
            // 
            this.LblCompanyIdHidden.AutoSize = true;
            this.LblCompanyIdHidden.Location = new System.Drawing.Point(614, 9);
            this.LblCompanyIdHidden.Name = "LblCompanyIdHidden";
            this.LblCompanyIdHidden.Size = new System.Drawing.Size(163, 25);
            this.LblCompanyIdHidden.TabIndex = 10;
            this.LblCompanyIdHidden.Text = "HiddenCompanyId";
            this.LblCompanyIdHidden.Visible = false;
            // 
            // FrmCompanyMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.LblCompanyIdHidden);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.LblCompanyName);
            this.Controls.Add(this.LblEditCompany);
            this.Controls.Add(this.LblExitingCompanies);
            this.Controls.Add(this.DgvExistingCompanies);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new master company";
            this.Load += new System.EventHandler(this.FrmCompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExistingCompanies;
        private System.Windows.Forms.Label LblExitingCompanies;
        private System.Windows.Forms.Label LblEditCompany;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblCompanyIdHidden;
    }
}