namespace MyInvestments.Views.Master
{
    partial class FrmCompanyTypesMapping
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
            this.DgvExistingCompanyMapping = new System.Windows.Forms.DataGridView();
            this.LblExitingCompanyMapping = new System.Windows.Forms.Label();
            this.LblAddEditCompanyMapping = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CmbCompanyName = new System.Windows.Forms.ComboBox();
            this.CmbCompanyType = new System.Windows.Forms.ComboBox();
            this.LblCompanyType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanyMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExistingCompanyMapping
            // 
            this.DgvExistingCompanyMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExistingCompanyMapping.Location = new System.Drawing.Point(128, 43);
            this.DgvExistingCompanyMapping.Name = "DgvExistingCompanyMapping";
            this.DgvExistingCompanyMapping.ReadOnly = true;
            this.DgvExistingCompanyMapping.RowHeadersWidth = 62;
            this.DgvExistingCompanyMapping.RowTemplate.Height = 33;
            this.DgvExistingCompanyMapping.Size = new System.Drawing.Size(573, 200);
            this.DgvExistingCompanyMapping.TabIndex = 0;
            this.DgvExistingCompanyMapping.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExistingCompanyMapping_CellDoubleClick);
            // 
            // LblExitingCompanyMapping
            // 
            this.LblExitingCompanyMapping.AutoSize = true;
            this.LblExitingCompanyMapping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblExitingCompanyMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblExitingCompanyMapping.Location = new System.Drawing.Point(27, 9);
            this.LblExitingCompanyMapping.Name = "LblExitingCompanyMapping";
            this.LblExitingCompanyMapping.Size = new System.Drawing.Size(312, 25);
            this.LblExitingCompanyMapping.TabIndex = 1;
            this.LblExitingCompanyMapping.Text = "List of existing companies mapping";
            // 
            // LblAddEditCompanyMapping
            // 
            this.LblAddEditCompanyMapping.AutoSize = true;
            this.LblAddEditCompanyMapping.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAddEditCompanyMapping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblAddEditCompanyMapping.Location = new System.Drawing.Point(27, 269);
            this.LblAddEditCompanyMapping.Name = "LblAddEditCompanyMapping";
            this.LblAddEditCompanyMapping.Size = new System.Drawing.Size(293, 25);
            this.LblAddEditCompanyMapping.TabIndex = 2;
            this.LblAddEditCompanyMapping.Text = "Insert-Update company mapping";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(24, 309);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(141, 25);
            this.LblCompanyName.TabIndex = 3;
            this.LblCompanyName.Text = "Company Name";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(306, 362);
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
            this.BtnDelete.Location = new System.Drawing.Point(423, 362);
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
            this.BtnInsert.Location = new System.Drawing.Point(189, 362);
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
            this.BtnCancel.Location = new System.Drawing.Point(540, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 34);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CmbCompanyName
            // 
            this.CmbCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompanyName.FormattingEnabled = true;
            this.CmbCompanyName.Location = new System.Drawing.Point(161, 306);
            this.CmbCompanyName.Name = "CmbCompanyName";
            this.CmbCompanyName.Size = new System.Drawing.Size(250, 33);
            this.CmbCompanyName.TabIndex = 10;
            // 
            // CmbCompanyType
            // 
            this.CmbCompanyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompanyType.FormattingEnabled = true;
            this.CmbCompanyType.Location = new System.Drawing.Point(555, 306);
            this.CmbCompanyType.Name = "CmbCompanyType";
            this.CmbCompanyType.Size = new System.Drawing.Size(250, 33);
            this.CmbCompanyType.TabIndex = 12;
            // 
            // LblCompanyType
            // 
            this.LblCompanyType.AutoSize = true;
            this.LblCompanyType.Location = new System.Drawing.Point(418, 309);
            this.LblCompanyType.Name = "LblCompanyType";
            this.LblCompanyType.Size = new System.Drawing.Size(131, 25);
            this.LblCompanyType.TabIndex = 11;
            this.LblCompanyType.Text = "Company Type";
            // 
            // FrmCompanyTypesMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.CmbCompanyType);
            this.Controls.Add(this.LblCompanyType);
            this.Controls.Add(this.CmbCompanyName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.LblCompanyName);
            this.Controls.Add(this.LblAddEditCompanyMapping);
            this.Controls.Add(this.LblExitingCompanyMapping);
            this.Controls.Add(this.DgvExistingCompanyMapping);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyTypesMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new company type mapping";
            this.Load += new System.EventHandler(this.FrmCompanyMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingCompanyMapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExistingCompanyMapping;
        private System.Windows.Forms.Label LblExitingCompanyMapping;
        private System.Windows.Forms.Label LblAddEditCompanyMapping;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CmbCompanyName;
        private System.Windows.Forms.ComboBox CmbCompanyType;
        private System.Windows.Forms.Label LblCompanyType;
    }
}