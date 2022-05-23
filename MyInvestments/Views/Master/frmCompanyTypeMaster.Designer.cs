namespace MyInvestments.Views.Master
{
    partial class FrmCompanyTypeMaster
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
            this.DgvExistingCompanyTypes = new System.Windows.Forms.DataGridView();
            this.LblExitingCompanyTypes = new System.Windows.Forms.Label();
            this.LblEditCompanyType = new System.Windows.Forms.Label();
            this.LblCompanyTypeName = new System.Windows.Forms.Label();
            this.TxtCompanyTypeName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanyTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExistingCompanyTypes
            // 
            this.DgvExistingCompanyTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExistingCompanyTypes.Location = new System.Drawing.Point(103, 43);
            this.DgvExistingCompanyTypes.Name = "DgvExistingCompanyTypes";
            this.DgvExistingCompanyTypes.ReadOnly = true;
            this.DgvExistingCompanyTypes.RowHeadersWidth = 62;
            this.DgvExistingCompanyTypes.RowTemplate.Height = 33;
            this.DgvExistingCompanyTypes.Size = new System.Drawing.Size(573, 200);
            this.DgvExistingCompanyTypes.TabIndex = 0;
            this.DgvExistingCompanyTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExistingCompanyTypes_CellDoubleClick);
            // 
            // LblExitingCompanyTypes
            // 
            this.LblExitingCompanyTypes.AutoSize = true;
            this.LblExitingCompanyTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblExitingCompanyTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblExitingCompanyTypes.Location = new System.Drawing.Point(27, 9);
            this.LblExitingCompanyTypes.Name = "LblExitingCompanyTypes";
            this.LblExitingCompanyTypes.Size = new System.Drawing.Size(270, 25);
            this.LblExitingCompanyTypes.TabIndex = 1;
            this.LblExitingCompanyTypes.Text = "List of existing company types";
            // 
            // LblEditCompanyType
            // 
            this.LblEditCompanyType.AutoSize = true;
            this.LblEditCompanyType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEditCompanyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblEditCompanyType.Location = new System.Drawing.Point(27, 269);
            this.LblEditCompanyType.Name = "LblEditCompanyType";
            this.LblEditCompanyType.Size = new System.Drawing.Size(274, 25);
            this.LblEditCompanyType.TabIndex = 2;
            this.LblEditCompanyType.Text = "Insert-Update company details";
            // 
            // LblCompanyTypeName
            // 
            this.LblCompanyTypeName.AutoSize = true;
            this.LblCompanyTypeName.Location = new System.Drawing.Point(191, 309);
            this.LblCompanyTypeName.Name = "LblCompanyTypeName";
            this.LblCompanyTypeName.Size = new System.Drawing.Size(131, 25);
            this.LblCompanyTypeName.TabIndex = 3;
            this.LblCompanyTypeName.Text = "Company Type";
            // 
            // TxtCompanyTypeName
            // 
            this.TxtCompanyTypeName.Location = new System.Drawing.Point(338, 306);
            this.TxtCompanyTypeName.Name = "TxtCompanyTypeName";
            this.TxtCompanyTypeName.Size = new System.Drawing.Size(250, 31);
            this.TxtCompanyTypeName.TabIndex = 4;
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
            // FrmCompanyTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtCompanyTypeName);
            this.Controls.Add(this.LblCompanyTypeName);
            this.Controls.Add(this.LblEditCompanyType);
            this.Controls.Add(this.LblExitingCompanyTypes);
            this.Controls.Add(this.DgvExistingCompanyTypes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyTypeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new master company type";
            this.Load += new System.EventHandler(this.FrmCompanyTypeMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanyTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExistingCompanyTypes;
        private System.Windows.Forms.Label LblExitingCompanyTypes;
        private System.Windows.Forms.Label LblEditCompanyType;
        private System.Windows.Forms.Label LblCompanyTypeName;
        private System.Windows.Forms.TextBox TxtCompanyTypeName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCancel;
    }
}