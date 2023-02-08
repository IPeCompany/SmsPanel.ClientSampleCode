
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Setting
{
    partial class FrmGetLines
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
            this.BtnGetLines = new System.Windows.Forms.Button();
            this.GvGetLines = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvGetLines)).BeginInit();
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
            // BtnGetLines
            // 
            this.BtnGetLines.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGetLines.Location = new System.Drawing.Point(12, 243);
            this.BtnGetLines.Name = "BtnGetLines";
            this.BtnGetLines.Size = new System.Drawing.Size(475, 29);
            this.BtnGetLines.TabIndex = 1;
            this.BtnGetLines.Text = "Get Result";
            this.BtnGetLines.UseVisualStyleBackColor = true;
            this.BtnGetLines.Click += new System.EventHandler(this.BtnGetLines_Click);
            // 
            // GvGetLines
            // 
            this.GvGetLines.AllowUserToAddRows = false;
            this.GvGetLines.AllowUserToDeleteRows = false;
            this.GvGetLines.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GvGetLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvGetLines.Location = new System.Drawing.Point(12, 76);
            this.GvGetLines.Name = "GvGetLines";
            this.GvGetLines.ReadOnly = true;
            this.GvGetLines.RowTemplate.Height = 25;
            this.GvGetLines.Size = new System.Drawing.Size(475, 150);
            this.GvGetLines.TabIndex = 2;
            // 
            // FrmGetLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(499, 283);
            this.Controls.Add(this.GvGetLines);
            this.Controls.Add(this.BtnGetLines);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGetLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGetLines";
            this.Load += new System.EventHandler(this.FrmGetLines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvGetLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Button BtnGetLines;
        private System.Windows.Forms.DataGridView GvGetLines;
    }
}