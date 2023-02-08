
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    partial class FrmGetArchivedReport
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
            this.LblPageSize = new System.Windows.Forms.Label();
            this.LblPageNumber = new System.Windows.Forms.Label();
            this.LblShowData = new System.Windows.Forms.Label();
            this.TxtPageSize = new System.Windows.Forms.TextBox();
            this.TxtPageNumber = new System.Windows.Forms.TextBox();
            this.GvArchivedReport = new System.Windows.Forms.DataGridView();
            this.BtnGetArchivedReport = new System.Windows.Forms.Button();
            this.LblFromDate = new System.Windows.Forms.Label();
            this.LblToDate = new System.Windows.Forms.Label();
            this.TxtFromDate = new System.Windows.Forms.TextBox();
            this.TxtToDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GvArchivedReport)).BeginInit();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 30);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(44, 15);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "ApiKey";
            // 
            // LblPageSize
            // 
            this.LblPageSize.AutoSize = true;
            this.LblPageSize.Location = new System.Drawing.Point(210, 92);
            this.LblPageSize.Name = "LblPageSize";
            this.LblPageSize.Size = new System.Drawing.Size(56, 15);
            this.LblPageSize.TabIndex = 1;
            this.LblPageSize.Text = "Page Size";
            // 
            // LblPageNumber
            // 
            this.LblPageNumber.AutoSize = true;
            this.LblPageNumber.Location = new System.Drawing.Point(12, 92);
            this.LblPageNumber.Name = "LblPageNumber";
            this.LblPageNumber.Size = new System.Drawing.Size(80, 15);
            this.LblPageNumber.TabIndex = 2;
            this.LblPageNumber.Text = "Page Number";
            // 
            // LblShowData
            // 
            this.LblShowData.AutoSize = true;
            this.LblShowData.Location = new System.Drawing.Point(12, 186);
            this.LblShowData.Name = "LblShowData";
            this.LblShowData.Size = new System.Drawing.Size(31, 15);
            this.LblShowData.TabIndex = 3;
            this.LblShowData.Text = "Data";
            // 
            // TxtPageSize
            // 
            this.TxtPageSize.Location = new System.Drawing.Point(210, 110);
            this.TxtPageSize.Multiline = true;
            this.TxtPageSize.Name = "TxtPageSize";
            this.TxtPageSize.Size = new System.Drawing.Size(173, 29);
            this.TxtPageSize.TabIndex = 5;
            this.TxtPageSize.Text = "(default = 100)";
            // 
            // TxtPageNumber
            // 
            this.TxtPageNumber.Location = new System.Drawing.Point(12, 110);
            this.TxtPageNumber.Multiline = true;
            this.TxtPageNumber.Name = "TxtPageNumber";
            this.TxtPageNumber.Size = new System.Drawing.Size(173, 29);
            this.TxtPageNumber.TabIndex = 4;
            this.TxtPageNumber.Text = "(default = 1)";
            // 
            // GvArchiveReport
            // 
            this.GvArchivedReport.AllowUserToAddRows = false;
            this.GvArchivedReport.AllowUserToDeleteRows = false;
            this.GvArchivedReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GvArchivedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvArchivedReport.Location = new System.Drawing.Point(12, 213);
            this.GvArchivedReport.Name = "GvArchiveReport";
            this.GvArchivedReport.ReadOnly = true;
            this.GvArchivedReport.RowTemplate.Height = 25;
            this.GvArchivedReport.Size = new System.Drawing.Size(776, 291);
            this.GvArchivedReport.TabIndex = 6;
            // 
            // BtnGetArchivedReport
            // 
            this.BtnGetArchivedReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetArchivedReport.Location = new System.Drawing.Point(681, 160);
            this.BtnGetArchivedReport.Name = "BtnGetArchivedReport";
            this.BtnGetArchivedReport.Size = new System.Drawing.Size(107, 31);
            this.BtnGetArchivedReport.TabIndex = 7;
            this.BtnGetArchivedReport.Text = "Get Reports";
            this.BtnGetArchivedReport.UseVisualStyleBackColor = true;
            this.BtnGetArchivedReport.Click += new System.EventHandler(this.BtnGetArchivedReport_Click);
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.Location = new System.Drawing.Point(415, 92);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(152, 15);
            this.LblFromDate.TabIndex = 8;
            this.LblFromDate.Text = "From Date Time (unix time)";
            // 
            // LblToDate
            // 
            this.LblToDate.AutoSize = true;
            this.LblToDate.Location = new System.Drawing.Point(615, 92);
            this.LblToDate.Name = "LblToDate";
            this.LblToDate.Size = new System.Drawing.Size(136, 15);
            this.LblToDate.TabIndex = 9;
            this.LblToDate.Text = "To Date Time (unix time)";
            // 
            // TxtFromDate
            // 
            this.TxtFromDate.Location = new System.Drawing.Point(415, 110);
            this.TxtFromDate.Multiline = true;
            this.TxtFromDate.Name = "TxtFromDate";
            this.TxtFromDate.Size = new System.Drawing.Size(173, 29);
            this.TxtFromDate.TabIndex = 10;
            this.TxtFromDate.Text = "nullable";
            // 
            // TxtToDate
            // 
            this.TxtToDate.Location = new System.Drawing.Point(615, 110);
            this.TxtToDate.Multiline = true;
            this.TxtToDate.Name = "TxtToDate";
            this.TxtToDate.Size = new System.Drawing.Size(173, 29);
            this.TxtToDate.TabIndex = 11;
            this.TxtToDate.Text = "nullable";
            // 
            // FrmGetArchivedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.TxtToDate);
            this.Controls.Add(this.TxtFromDate);
            this.Controls.Add(this.LblToDate);
            this.Controls.Add(this.LblFromDate);
            this.Controls.Add(this.BtnGetArchivedReport);
            this.Controls.Add(this.GvArchivedReport);
            this.Controls.Add(this.TxtPageNumber);
            this.Controls.Add(this.TxtPageSize);
            this.Controls.Add(this.LblShowData);
            this.Controls.Add(this.LblPageNumber);
            this.Controls.Add(this.LblPageSize);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetArchivedReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetArchivedReport";
            this.Load += new System.EventHandler(this.FrmGetArchivedReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvArchivedReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Label LblPageSize;
        private System.Windows.Forms.Label LblPageNumber;
        private System.Windows.Forms.Label LblShowData;
        private System.Windows.Forms.TextBox TxtPageSize;
        private System.Windows.Forms.TextBox TxtPageNumber;
        private System.Windows.Forms.DataGridView GvArchivedReport;
        private System.Windows.Forms.Button BtnGetArchivedReport;
        private System.Windows.Forms.Label LblFromDate;
        private System.Windows.Forms.Label LblToDate;
        private System.Windows.Forms.TextBox TxtFromDate;
        private System.Windows.Forms.TextBox TxtToDate;
    }
}