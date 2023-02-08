
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    partial class FrmGetLiveReceive
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
            this.GvLiveReceive = new System.Windows.Forms.DataGridView();
            this.BtnGetLiveReceive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvLiveReceive)).BeginInit();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 30);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(43, 15);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "Apikey";
            // 
            // LblPageSize
            // 
            this.LblPageSize.AutoSize = true;
            this.LblPageSize.Location = new System.Drawing.Point(418, 92);
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
            this.TxtPageSize.Location = new System.Drawing.Point(418, 110);
            this.TxtPageSize.Multiline = true;
            this.TxtPageSize.Name = "TxtPageSize";
            this.TxtPageSize.Size = new System.Drawing.Size(370, 29);
            this.TxtPageSize.TabIndex = 5;
            this.TxtPageSize.Text = "(default = 100)";
            // 
            // TxtPageNumber
            // 
            this.TxtPageNumber.Location = new System.Drawing.Point(12, 110);
            this.TxtPageNumber.Multiline = true;
            this.TxtPageNumber.Name = "TxtPageNumber";
            this.TxtPageNumber.Size = new System.Drawing.Size(370, 29);
            this.TxtPageNumber.TabIndex = 4;
            this.TxtPageNumber.Text = "(default = 1)";
            // 
            // GvLiveReceive
            // 
            this.GvLiveReceive.AllowUserToAddRows = false;
            this.GvLiveReceive.AllowUserToDeleteRows = false;
            this.GvLiveReceive.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GvLiveReceive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLiveReceive.Location = new System.Drawing.Point(12, 213);
            this.GvLiveReceive.Name = "GvLiveReceive";
            this.GvLiveReceive.ReadOnly = true;
            this.GvLiveReceive.RowTemplate.Height = 25;
            this.GvLiveReceive.Size = new System.Drawing.Size(776, 291);
            this.GvLiveReceive.TabIndex = 6;
            // 
            // BtnGetLiveReceive
            // 
            this.BtnGetLiveReceive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetLiveReceive.Location = new System.Drawing.Point(681, 160);
            this.BtnGetLiveReceive.Name = "BtnGetLiveReceive";
            this.BtnGetLiveReceive.Size = new System.Drawing.Size(107, 31);
            this.BtnGetLiveReceive.TabIndex = 7;
            this.BtnGetLiveReceive.Text = "Get Reports";
            this.BtnGetLiveReceive.UseVisualStyleBackColor = true;
            this.BtnGetLiveReceive.Click += new System.EventHandler(this.BtnGetLiveReceive_Click);
            // 
            // FrmGetLiveReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.BtnGetLiveReceive);
            this.Controls.Add(this.GvLiveReceive);
            this.Controls.Add(this.TxtPageNumber);
            this.Controls.Add(this.TxtPageSize);
            this.Controls.Add(this.LblShowData);
            this.Controls.Add(this.LblPageNumber);
            this.Controls.Add(this.LblPageSize);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetLiveReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetLiveReceive";
            this.Load += new System.EventHandler(this.FrmGetLiveReceive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvLiveReceive)).EndInit();
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
        private System.Windows.Forms.DataGridView GvLiveReceive;
        private System.Windows.Forms.Button BtnGetLiveReceive;
    }
}