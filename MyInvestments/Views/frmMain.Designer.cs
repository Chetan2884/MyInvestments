
namespace MyInvestments.Views
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.PbLogout = new System.Windows.Forms.PictureBox();
            this.ToolTipMainForm = new System.Windows.Forms.ToolTip(this.components);
            this.LblInvestmentTypes = new System.Windows.Forms.Label();
            this.CmbInvestmentTypes = new System.Windows.Forms.ComboBox();
            this.LblMainFormHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // PbLogout
            // 
            this.PbLogout.Image = global::MyInvestments.Properties.Resources.logout;
            this.PbLogout.Location = new System.Drawing.Point(548, 138);
            this.PbLogout.Name = "PbLogout";
            this.PbLogout.Size = new System.Drawing.Size(64, 64);
            this.PbLogout.TabIndex = 6;
            this.PbLogout.TabStop = false;
            this.ToolTipMainForm.SetToolTip(this.PbLogout, "Log Out");
            this.PbLogout.Click += new System.EventHandler(this.PbLogout_Click);
            // 
            // LblInvestmentTypes
            // 
            this.LblInvestmentTypes.AutoSize = true;
            this.LblInvestmentTypes.Location = new System.Drawing.Point(80, 100);
            this.LblInvestmentTypes.Name = "LblInvestmentTypes";
            this.LblInvestmentTypes.Size = new System.Drawing.Size(142, 25);
            this.LblInvestmentTypes.TabIndex = 8;
            this.LblInvestmentTypes.Text = "Investment Type";
            // 
            // CmbInvestmentTypes
            // 
            this.CmbInvestmentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbInvestmentTypes.FormattingEnabled = true;
            this.CmbInvestmentTypes.Location = new System.Drawing.Point(239, 92);
            this.CmbInvestmentTypes.MaxDropDownItems = 5;
            this.CmbInvestmentTypes.Name = "CmbInvestmentTypes";
            this.CmbInvestmentTypes.Size = new System.Drawing.Size(300, 33);
            this.CmbInvestmentTypes.TabIndex = 1;
            this.CmbInvestmentTypes.SelectedIndexChanged += new System.EventHandler(this.CmbInvestmentTypes_SelectedIndexChanged);
            // 
            // LblMainFormHeader
            // 
            this.LblMainFormHeader.AutoSize = true;
            this.LblMainFormHeader.Location = new System.Drawing.Point(80, 29);
            this.LblMainFormHeader.Name = "LblMainFormHeader";
            this.LblMainFormHeader.Size = new System.Drawing.Size(446, 25);
            this.LblMainFormHeader.TabIndex = 11;
            this.LblMainFormHeader.Text = "Select type of investment details you would like to add";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(618, 214);
            this.ControlBox = false;
            this.Controls.Add(this.LblMainFormHeader);
            this.Controls.Add(this.CmbInvestmentTypes);
            this.Controls.Add(this.LblInvestmentTypes);
            this.Controls.Add(this.PbLogout);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Investments";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox PbLogout;
        private System.Windows.Forms.ToolTip ToolTipMainForm;
        private System.Windows.Forms.Label LblInvestmentTypes;
        private System.Windows.Forms.ComboBox CmbInvestmentTypes;
        private System.Windows.Forms.Label LblMainFormHeader;
    }
}



