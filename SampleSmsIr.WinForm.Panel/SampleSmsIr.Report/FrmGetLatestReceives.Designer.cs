
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    partial class FrmGetLatestReceives
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
            this.LblCount = new System.Windows.Forms.Label();
            this.LblShowData = new System.Windows.Forms.Label();
            this.GetLatestReceives = new System.Windows.Forms.Button();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.GvLatestReceives = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvLatestReceives)).BeginInit();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 29);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(44, 15);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "ApiKey";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(12, 94);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(132, 15);
            this.LblCount.TabIndex = 1;
            this.LblCount.Text = "The number of requests";
            // 
            // LblShowData
            // 
            this.LblShowData.AutoSize = true;
            this.LblShowData.Location = new System.Drawing.Point(12, 167);
            this.LblShowData.Name = "LblShowData";
            this.LblShowData.Size = new System.Drawing.Size(31, 15);
            this.LblShowData.TabIndex = 2;
            this.LblShowData.Text = "Data";
            // 
            // GetLatestReceives
            // 
            this.GetLatestReceives.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetLatestReceives.Location = new System.Drawing.Point(338, 112);
            this.GetLatestReceives.Name = "GetLatestReceives";
            this.GetLatestReceives.Size = new System.Drawing.Size(203, 28);
            this.GetLatestReceives.TabIndex = 3;
            this.GetLatestReceives.Text = "Get Reports";
            this.GetLatestReceives.UseVisualStyleBackColor = true;
            this.GetLatestReceives.Click += new System.EventHandler(this.GetLatestReceives_Click);
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(12, 112);
            this.TxtCount.Multiline = true;
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(290, 28);
            this.TxtCount.TabIndex = 4;
            this.TxtCount.Text = "(default = 100) ";
            // 
            // GvLatestReceives
            // 
            this.GvLatestReceives.AllowUserToAddRows = false;
            this.GvLatestReceives.AllowUserToDeleteRows = false;
            this.GvLatestReceives.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GvLatestReceives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLatestReceives.Location = new System.Drawing.Point(12, 185);
            this.GvLatestReceives.Name = "GvLatestReceives";
            this.GvLatestReceives.ReadOnly = true;
            this.GvLatestReceives.RowTemplate.Height = 25;
            this.GvLatestReceives.Size = new System.Drawing.Size(529, 186);
            this.GvLatestReceives.TabIndex = 5;
            // 
            // FrmGetLatestReceives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(553, 383);
            this.Controls.Add(this.GvLatestReceives);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.GetLatestReceives);
            this.Controls.Add(this.LblShowData);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetLatestReceives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetLatestReceives";
            this.Load += new System.EventHandler(this.FrmGetLatestReceives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvLatestReceives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblShowData;
        private System.Windows.Forms.Button GetLatestReceives;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.DataGridView GvLatestReceives;
    }
}