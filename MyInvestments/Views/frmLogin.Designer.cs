
namespace MyInvestments.Views
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PbApplicationName = new System.Windows.Forms.PictureBox();
            this.LblLoginId = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtLoginId = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.PbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbApplicationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // PbApplicationName
            // 
            this.PbApplicationName.Image = ((System.Drawing.Image)(resources.GetObject("PbApplicationName.Image")));
            this.PbApplicationName.Location = new System.Drawing.Point(134, 23);
            this.PbApplicationName.Name = "PbApplicationName";
            this.PbApplicationName.Size = new System.Drawing.Size(376, 59);
            this.PbApplicationName.TabIndex = 0;
            this.PbApplicationName.TabStop = false;
            // 
            // LblLoginId
            // 
            this.LblLoginId.AutoSize = true;
            this.LblLoginId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLoginId.Location = new System.Drawing.Point(134, 131);
            this.LblLoginId.Name = "LblLoginId";
            this.LblLoginId.Size = new System.Drawing.Size(114, 25);
            this.LblLoginId.TabIndex = 1;
            this.LblLoginId.Text = "Login Name";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPassword.Location = new System.Drawing.Point(134, 199);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(92, 25);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Password";
            // 
            // TxtLoginId
            // 
            this.TxtLoginId.Location = new System.Drawing.Point(252, 125);
            this.TxtLoginId.MaxLength = 12;
            this.TxtLoginId.Name = "TxtLoginId";
            this.TxtLoginId.Size = new System.Drawing.Size(258, 31);
            this.TxtLoginId.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(252, 193);
            this.TxtPassword.MaxLength = 12;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '#';
            this.TxtPassword.Size = new System.Drawing.Size(258, 31);
            this.TxtPassword.TabIndex = 2;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogin.Location = new System.Drawing.Point(198, 269);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 34);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReset.Location = new System.Drawing.Point(321, 269);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 34);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // PbExit
            // 
            this.PbExit.Image = ((System.Drawing.Image)(resources.GetObject("PbExit.Image")));
            this.PbExit.Location = new System.Drawing.Point(568, 269);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(64, 64);
            this.PbExit.TabIndex = 7;
            this.PbExit.TabStop = false;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(644, 344);
            this.ControlBox = false;
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtLoginId);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblLoginId);
            this.Controls.Add(this.PbApplicationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PbApplicationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbApplicationName;
        private System.Windows.Forms.Label LblLoginId;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtLoginId;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.PictureBox PbExit;
    }
}