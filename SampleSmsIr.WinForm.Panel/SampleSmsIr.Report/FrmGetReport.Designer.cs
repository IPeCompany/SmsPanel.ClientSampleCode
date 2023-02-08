
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    partial class FrmGetReport
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
            this.LblMessageId = new System.Windows.Forms.Label();
            this.BtnGetReportByMessageId = new System.Windows.Forms.Button();
            this.TxtEarmark = new System.Windows.Forms.TextBox();
            this.GvReport = new System.Windows.Forms.DataGridView();
            this.LblShowData = new System.Windows.Forms.Label();
            this.BtnGetReportByPackId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 26);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(45, 15);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "ApiKey";
            // 
            // LblMessageId
            // 
            this.LblMessageId.AutoSize = true;
            this.LblMessageId.Location = new System.Drawing.Point(12, 80);
            this.LblMessageId.Name = "LblMessageId";
            this.LblMessageId.Size = new System.Drawing.Size(66, 15);
            this.LblMessageId.TabIndex = 1;
            this.LblMessageId.Text = "Message Id";
            // 
            // BtnGetReportByMessageId
            // 
            this.BtnGetReportByMessageId.Enabled = false;
            this.BtnGetReportByMessageId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGetReportByMessageId.Location = new System.Drawing.Point(536, 98);
            this.BtnGetReportByMessageId.Name = "BtnGetReportByMessageId";
            this.BtnGetReportByMessageId.Size = new System.Drawing.Size(118, 29);
            this.BtnGetReportByMessageId.TabIndex = 2;
            this.BtnGetReportByMessageId.Text = "Get By Message Id";
            this.BtnGetReportByMessageId.UseVisualStyleBackColor = true;
            this.BtnGetReportByMessageId.Click += new System.EventHandler(this.BtnGetReport_Click);
            // 
            // TxtEarmark
            // 
            this.TxtEarmark.Location = new System.Drawing.Point(12, 98);
            this.TxtEarmark.Multiline = true;
            this.TxtEarmark.Name = "TxtEarmark";
            this.TxtEarmark.Size = new System.Drawing.Size(471, 29);
            this.TxtEarmark.TabIndex = 3;
            this.TxtEarmark.TextChanged += new System.EventHandler(this.TxtEarmark_TextChanged);
            // 
            // GvReport
            // 
            this.GvReport.AllowUserToAddRows = false;
            this.GvReport.AllowUserToDeleteRows = false;
            this.GvReport.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvReport.Location = new System.Drawing.Point(12, 181);
            this.GvReport.Name = "GvReport";
            this.GvReport.ReadOnly = true;
            this.GvReport.RowTemplate.Height = 25;
            this.GvReport.Size = new System.Drawing.Size(776, 132);
            this.GvReport.TabIndex = 4;
            // 
            // LblShowData
            // 
            this.LblShowData.AutoSize = true;
            this.LblShowData.Location = new System.Drawing.Point(12, 163);
            this.LblShowData.Name = "LblShowData";
            this.LblShowData.Size = new System.Drawing.Size(31, 15);
            this.LblShowData.TabIndex = 5;
            this.LblShowData.Text = "Data";
            // 
            // BtnGetReportByPackId
            // 
            this.BtnGetReportByPackId.Enabled = false;
            this.BtnGetReportByPackId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGetReportByPackId.Location = new System.Drawing.Point(670, 98);
            this.BtnGetReportByPackId.Name = "BtnGetReportByPackId";
            this.BtnGetReportByPackId.Size = new System.Drawing.Size(118, 29);
            this.BtnGetReportByPackId.TabIndex = 6;
            this.BtnGetReportByPackId.Text = "Get by Pack Id";
            this.BtnGetReportByPackId.UseVisualStyleBackColor = true;
            this.BtnGetReportByPackId.Click += new System.EventHandler(this.BtnGetReportByPackId_Click);
            // 
            // FrmGetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.BtnGetReportByPackId);
            this.Controls.Add(this.LblShowData);
            this.Controls.Add(this.GvReport);
            this.Controls.Add(this.TxtEarmark);
            this.Controls.Add(this.BtnGetReportByMessageId);
            this.Controls.Add(this.LblMessageId);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetReport";
            this.Load += new System.EventHandler(this.FrmGetReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Label LblMessageId;
        private System.Windows.Forms.Button BtnGetReportByMessageId;
        private System.Windows.Forms.TextBox TxtEarmark;
        private System.Windows.Forms.DataGridView GvReport;
        private System.Windows.Forms.Label LblShowData;
        private System.Windows.Forms.Button BtnGetReportByPackId;
    }
}