namespace MyInvestments.Views.Master
{
    partial class FrmMutualFundSchemeTypesMaster
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
            this.DgvExistingMutualFundSchemeTypes = new System.Windows.Forms.DataGridView();
            this.LblMutualFundExistingSchemeTypes = new System.Windows.Forms.Label();
            this.LblEditMutualFundSchemeType = new System.Windows.Forms.Label();
            this.LblMutualFundSchemeTypeName = new System.Windows.Forms.Label();
            this.TxtMutualFundSchemeTypeName = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblMutualFundSchemeTypeIdHidden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingMutualFundSchemeTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExistingMutualFundSchemeTypes
            // 
            this.DgvExistingMutualFundSchemeTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExistingMutualFundSchemeTypes.Location = new System.Drawing.Point(103, 43);
            this.DgvExistingMutualFundSchemeTypes.Name = "DgvExistingMutualFundSchemeTypes";
            this.DgvExistingMutualFundSchemeTypes.ReadOnly = true;
            this.DgvExistingMutualFundSchemeTypes.RowHeadersWidth = 62;
            this.DgvExistingMutualFundSchemeTypes.RowTemplate.Height = 33;
            this.DgvExistingMutualFundSchemeTypes.Size = new System.Drawing.Size(573, 200);
            this.DgvExistingMutualFundSchemeTypes.TabIndex = 0;
            this.DgvExistingMutualFundSchemeTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExistingCompanies_CellDoubleClick);
            // 
            // LblMutualFundExistingSchemeTypes
            // 
            this.LblMutualFundExistingSchemeTypes.AutoSize = true;
            this.LblMutualFundExistingSchemeTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMutualFundExistingSchemeTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblMutualFundExistingSchemeTypes.Location = new System.Drawing.Point(27, 9);
            this.LblMutualFundExistingSchemeTypes.Name = "LblMutualFundExistingSchemeTypes";
            this.LblMutualFundExistingSchemeTypes.Size = new System.Drawing.Size(366, 25);
            this.LblMutualFundExistingSchemeTypes.TabIndex = 1;
            this.LblMutualFundExistingSchemeTypes.Text = "List of existing mutual fund scheme types";
            // 
            // LblEditMutualFundSchemeType
            // 
            this.LblEditMutualFundSchemeType.AutoSize = true;
            this.LblEditMutualFundSchemeType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEditMutualFundSchemeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LblEditMutualFundSchemeType.Location = new System.Drawing.Point(27, 269);
            this.LblEditMutualFundSchemeType.Name = "LblEditMutualFundSchemeType";
            this.LblEditMutualFundSchemeType.Size = new System.Drawing.Size(413, 25);
            this.LblEditMutualFundSchemeType.TabIndex = 2;
            this.LblEditMutualFundSchemeType.Text = "Insert-Update mutual fund scheme type details";
            // 
            // LblMutualFundSchemeTypeName
            // 
            this.LblMutualFundSchemeTypeName.AutoSize = true;
            this.LblMutualFundSchemeTypeName.Location = new System.Drawing.Point(168, 309);
            this.LblMutualFundSchemeTypeName.Name = "LblMutualFundSchemeTypeName";
            this.LblMutualFundSchemeTypeName.Size = new System.Drawing.Size(168, 25);
            this.LblMutualFundSchemeTypeName.TabIndex = 3;
            this.LblMutualFundSchemeTypeName.Text = "Scheme Type Name";
            // 
            // TxtMutualFundSchemeTypeName
            // 
            this.TxtMutualFundSchemeTypeName.Location = new System.Drawing.Point(338, 306);
            this.TxtMutualFundSchemeTypeName.Name = "TxtMutualFundSchemeTypeName";
            this.TxtMutualFundSchemeTypeName.Size = new System.Drawing.Size(250, 31);
            this.TxtMutualFundSchemeTypeName.TabIndex = 4;
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
            // LblMutualFundSchemeTypeIdHidden
            // 
            this.LblMutualFundSchemeTypeIdHidden.AutoSize = true;
            this.LblMutualFundSchemeTypeIdHidden.Location = new System.Drawing.Point(614, 9);
            this.LblMutualFundSchemeTypeIdHidden.Name = "LblMutualFundSchemeTypeIdHidden";
            this.LblMutualFundSchemeTypeIdHidden.Size = new System.Drawing.Size(163, 25);
            this.LblMutualFundSchemeTypeIdHidden.TabIndex = 10;
            this.LblMutualFundSchemeTypeIdHidden.Text = "HiddenCompanyId";
            this.LblMutualFundSchemeTypeIdHidden.Visible = false;
            // 
            // FrmMutualFundSchemeTypeMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.LblMutualFundSchemeTypeIdHidden);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtMutualFundSchemeTypeName);
            this.Controls.Add(this.LblMutualFundSchemeTypeName);
            this.Controls.Add(this.LblEditMutualFundSchemeType);
            this.Controls.Add(this.LblMutualFundExistingSchemeTypes);
            this.Controls.Add(this.DgvExistingMutualFundSchemeTypes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMutualFundSchemeTypeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new mutual fund scheme type";
            this.Load += new System.EventHandler(this.FrmMutualFundSchemeTypesMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExistingMutualFundSchemeTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExistingMutualFundSchemeTypes;
        private System.Windows.Forms.Label LblMutualFundExistingSchemeTypes;
        private System.Windows.Forms.Label LblEditMutualFundSchemeType;
        private System.Windows.Forms.Label LblMutualFundSchemeTypeName;
        private System.Windows.Forms.TextBox TxtMutualFundSchemeTypeName;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblMutualFundSchemeTypeIdHidden;
    }
}