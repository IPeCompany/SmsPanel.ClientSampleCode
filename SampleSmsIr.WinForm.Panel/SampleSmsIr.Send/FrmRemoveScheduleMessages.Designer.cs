
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    partial class FrmRemoveScheduleMessages
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
            this.TxtPackId = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblPackId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblApiKey
            // 
            this.LblApiKey.Location = new System.Drawing.Point(13, 52);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(463, 49);
            this.LblApiKey.TabIndex = 0;
            this.LblApiKey.Text = "ApiKey";
            // 
            // TxtPackId
            // 
            this.TxtPackId.Location = new System.Drawing.Point(12, 130);
            this.TxtPackId.Multiline = true;
            this.TxtPackId.Name = "TxtPackId";
            this.TxtPackId.Size = new System.Drawing.Size(464, 26);
            this.TxtPackId.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSend.Location = new System.Drawing.Point(176, 179);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(142, 46);
            this.BtnSend.TabIndex = 2;
            this.BtnSend.Text = "Send!";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LblPackId
            // 
            this.LblPackId.AutoSize = true;
            this.LblPackId.Location = new System.Drawing.Point(13, 112);
            this.LblPackId.Name = "LblPackId";
            this.LblPackId.Size = new System.Drawing.Size(45, 15);
            this.LblPackId.TabIndex = 3;
            this.LblPackId.Text = "Pack Id";
            // 
            // FrmRemoveScheduleMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(488, 237);
            this.Controls.Add(this.LblPackId);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtPackId);
            this.Controls.Add(this.LblApiKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRemoveScheduleMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemoveScheduleMessage";
            this.Load += new System.EventHandler(this.FrmRemoveScheduleMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.TextBox TxtPackId;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LblPackId;
    }
}