
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    partial class FrmLikeToLikeSend
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
            this.TxtLineNumber = new System.Windows.Forms.TextBox();
            this.TxtMobileNumber = new System.Windows.Forms.TextBox();
            this.TxtMessageText = new System.Windows.Forms.TextBox();
            this.LblApiKey = new System.Windows.Forms.Label();
            this.LblLineNumber = new System.Windows.Forms.Label();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.LblTextMessage = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblSendDateTime = new System.Windows.Forms.Label();
            this.TxtSendDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtLineNumber
            // 
            this.TxtLineNumber.Location = new System.Drawing.Point(12, 120);
            this.TxtLineNumber.Name = "TxtLineNumber";
            this.TxtLineNumber.Size = new System.Drawing.Size(190, 23);
            this.TxtLineNumber.TabIndex = 0;
            // 
            // TxtMobileNumber
            // 
            this.TxtMobileNumber.Location = new System.Drawing.Point(15, 175);
            this.TxtMobileNumber.Multiline = true;
            this.TxtMobileNumber.Name = "TxtMobileNumber";
            this.TxtMobileNumber.Size = new System.Drawing.Size(400, 150);
            this.TxtMobileNumber.TabIndex = 1;
            this.TxtMobileNumber.Text = "9120000000,9120000001,9120000002";
            // 
            // TxtMessageText
            // 
            this.TxtMessageText.Location = new System.Drawing.Point(15, 362);
            this.TxtMessageText.Multiline = true;
            this.TxtMessageText.Name = "TxtMessageText";
            this.TxtMessageText.Size = new System.Drawing.Size(400, 150);
            this.TxtMessageText.TabIndex = 2;
            this.TxtMessageText.Text = "Sms.ir,Sms.Ir,Sms.ir";
            // 
            // LblApiKey
            // 
            this.LblApiKey.Location = new System.Drawing.Point(15, 40);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(400, 50);
            this.LblApiKey.TabIndex = 3;
            this.LblApiKey.Text = "ApiKey";
            // 
            // LblLineNumber
            // 
            this.LblLineNumber.AutoSize = true;
            this.LblLineNumber.Location = new System.Drawing.Point(15, 100);
            this.LblLineNumber.Name = "LblLineNumber";
            this.LblLineNumber.Size = new System.Drawing.Size(76, 15);
            this.LblLineNumber.TabIndex = 4;
            this.LblLineNumber.Text = "Line Number";
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Location = new System.Drawing.Point(15, 160);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(91, 15);
            this.LblMobileNumber.TabIndex = 5;
            this.LblMobileNumber.Text = "Mobile Number";
            // 
            // LblTextMessage
            // 
            this.LblTextMessage.AutoSize = true;
            this.LblTextMessage.Location = new System.Drawing.Point(15, 342);
            this.LblTextMessage.Name = "LblTextMessage";
            this.LblTextMessage.Size = new System.Drawing.Size(77, 15);
            this.LblTextMessage.TabIndex = 6;
            this.LblTextMessage.Text = "Text Message";
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSend.Location = new System.Drawing.Point(110, 541);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(210, 60);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Send!";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LblSendDateTime
            // 
            this.LblSendDateTime.AutoSize = true;
            this.LblSendDateTime.Location = new System.Drawing.Point(220, 100);
            this.LblSendDateTime.Name = "LblSendDateTime";
            this.LblSendDateTime.Size = new System.Drawing.Size(150, 15);
            this.LblSendDateTime.TabIndex = 12;
            this.LblSendDateTime.Text = "Send Date Time (unix time)";
            // 
            // TxtSendDateTime
            // 
            this.TxtSendDateTime.Location = new System.Drawing.Point(220, 120);
            this.TxtSendDateTime.Multiline = true;
            this.TxtSendDateTime.Name = "TxtSendDateTime";
            this.TxtSendDateTime.Size = new System.Drawing.Size(190, 20);
            this.TxtSendDateTime.TabIndex = 11;
            this.TxtSendDateTime.Text = "nullable";
            // 
            // FrmLikeToLikeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(430, 630);
            this.Controls.Add(this.LblSendDateTime);
            this.Controls.Add(this.TxtSendDateTime);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.LblTextMessage);
            this.Controls.Add(this.LblMobileNumber);
            this.Controls.Add(this.LblLineNumber);
            this.Controls.Add(this.LblApiKey);
            this.Controls.Add(this.TxtMessageText);
            this.Controls.Add(this.TxtMobileNumber);
            this.Controls.Add(this.TxtLineNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLikeToLikeSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLikeToLikeSend";
            this.Load += new System.EventHandler(this.FrmLikeToLikeSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLineNumber;
        private System.Windows.Forms.TextBox TxtMobileNumber;
        private System.Windows.Forms.TextBox TxtMessageText;
        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Label LblLineNumber;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.Label LblTextMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label LblSendDateTime;
        private System.Windows.Forms.TextBox TxtSendDateTime;
    }
}