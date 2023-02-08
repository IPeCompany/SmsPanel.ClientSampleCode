
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Setting
{
    partial class FrmGetCredit
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
            this.LblApiKey = new System.Windows.Forms.Label();
            this.BtnGetCredit = new System.Windows.Forms.Button();
            this.GvCredit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 24);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(44, 15);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "ApiKey";
            // 
            // BtnGetCredit
            // 
            this.BtnGetCredit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetCredit.Location = new System.Drawing.Point(12, 243);
            this.BtnGetCredit.Name = "BtnGetCredit";
            this.BtnGetCredit.Size = new System.Drawing.Size(476, 29);
            this.BtnGetCredit.TabIndex = 1;
            this.BtnGetCredit.Text = "Get Result";
            this.BtnGetCredit.UseVisualStyleBackColor = true;
            this.BtnGetCredit.Click += new System.EventHandler(this.BtnGetCredit_Click);
            // 
            // GvCredit
            // 
            this.GvCredit.AllowUserToAddRows = false;
            this.GvCredit.AllowUserToDeleteRows = false;
            this.GvCredit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GvCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvCredit.Location = new System.Drawing.Point(12, 76);
            this.GvCredit.Name = "GvCredit";
            this.GvCredit.ReadOnly = true;
            this.GvCredit.RowTemplate.Height = 25;
            this.GvCredit.Size = new System.Drawing.Size(476, 150);
            this.GvCredit.TabIndex = 2;
            // 
            // FrmGetCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(499, 283);
            this.Controls.Add(this.GvCredit);
            this.Controls.Add(this.BtnGetCredit);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetCredit";
            this.Load += new System.EventHandler(this.FrmGetCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Button BtnGetCredit;
        private System.Windows.Forms.DataGridView GvCredit;
    }
}