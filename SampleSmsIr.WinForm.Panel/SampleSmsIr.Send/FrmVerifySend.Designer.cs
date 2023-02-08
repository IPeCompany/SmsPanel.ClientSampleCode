
namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    partial class FrmVerifySend
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
            this.TxtMobileNumber = new System.Windows.Forms.TextBox();
            this.LblMobileNumber = new System.Windows.Forms.Label();
            this.TxtTamplateId = new System.Windows.Forms.TextBox();
            this.LblApiKey = new System.Windows.Forms.Label();
            this.LblTamplateId = new System.Windows.Forms.Label();
            this.LblParameterName = new System.Windows.Forms.Label();
            this.TxtParameterName = new System.Windows.Forms.TextBox();
            this.LblParameterValue = new System.Windows.Forms.Label();
            this.TxtParameterValue = new System.Windows.Forms.TextBox();
            this.LblParameter = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMobileNumber
            // 
            this.TxtMobileNumber.Location = new System.Drawing.Point(12, 130);
            this.TxtMobileNumber.Multiline = true;
            this.TxtMobileNumber.Name = "TxtMobileNumber";
            this.TxtMobileNumber.Size = new System.Drawing.Size(188, 22);
            this.TxtMobileNumber.TabIndex = 0;
            // 
            // LblMobileNumber
            // 
            this.LblMobileNumber.AutoSize = true;
            this.LblMobileNumber.Location = new System.Drawing.Point(12, 112);
            this.LblMobileNumber.Name = "LblMobileNumber";
            this.LblMobileNumber.Size = new System.Drawing.Size(91, 15);
            this.LblMobileNumber.TabIndex = 1;
            this.LblMobileNumber.Text = "Mobile Number";
            // 
            // TxtTamplateId
            // 
            this.TxtTamplateId.Location = new System.Drawing.Point(221, 130);
            this.TxtTamplateId.Multiline = true;
            this.TxtTamplateId.Name = "TxtTamplateId";
            this.TxtTamplateId.Size = new System.Drawing.Size(188, 22);
            this.TxtTamplateId.TabIndex = 2;
            // 
            // LblApiKey
            // 
            this.LblApiKey.Location = new System.Drawing.Point(13, 52);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(396, 49);
            this.LblApiKey.TabIndex = 8;
            this.LblApiKey.Text = "ApiKey";
            // 
            // LblTamplateId
            // 
            this.LblTamplateId.AutoSize = true;
            this.LblTamplateId.Location = new System.Drawing.Point(221, 112);
            this.LblTamplateId.Name = "LblTamplateId";
            this.LblTamplateId.Size = new System.Drawing.Size(68, 15);
            this.LblTamplateId.TabIndex = 9;
            this.LblTamplateId.Text = "Tamplate Id";
            // 
            // LblParameterName
            // 
            this.LblParameterName.AutoSize = true;
            this.LblParameterName.Location = new System.Drawing.Point(12, 223);
            this.LblParameterName.Name = "LblParameterName";
            this.LblParameterName.Size = new System.Drawing.Size(39, 15);
            this.LblParameterName.TabIndex = 11;
            this.LblParameterName.Text = "Name";
            // 
            // TxtParameterName
            // 
            this.TxtParameterName.Location = new System.Drawing.Point(12, 241);
            this.TxtParameterName.Multiline = true;
            this.TxtParameterName.Name = "TxtParameterName";
            this.TxtParameterName.Size = new System.Drawing.Size(397, 24);
            this.TxtParameterName.TabIndex = 10;
            // 
            // LblParameterValue
            // 
            this.LblParameterValue.AutoSize = true;
            this.LblParameterValue.Location = new System.Drawing.Point(13, 288);
            this.LblParameterValue.Name = "LblParameterValue";
            this.LblParameterValue.Size = new System.Drawing.Size(35, 15);
            this.LblParameterValue.TabIndex = 13;
            this.LblParameterValue.Text = "Value";
            // 
            // TxtParameterValue
            // 
            this.TxtParameterValue.Location = new System.Drawing.Point(13, 306);
            this.TxtParameterValue.Multiline = true;
            this.TxtParameterValue.Name = "TxtParameterValue";
            this.TxtParameterValue.Size = new System.Drawing.Size(397, 24);
            this.TxtParameterValue.TabIndex = 12;
            // 
            // LblParameter
            // 
            this.LblParameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblParameter.Location = new System.Drawing.Point(151, 193);
            this.LblParameter.Name = "LblParameter";
            this.LblParameter.Size = new System.Drawing.Size(112, 21);
            this.LblParameter.TabIndex = 11;
            this.LblParameter.Text = "Parameter";
            this.LblParameter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSend.Location = new System.Drawing.Point(105, 367);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(207, 60);
            this.BtnSend.TabIndex = 14;
            this.BtnSend.Text = "Send!";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // FrmVerifySend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(423, 441);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.LblParameter);
            this.Controls.Add(this.LblParameterValue);
            this.Controls.Add(this.TxtParameterValue);
            this.Controls.Add(this.LblParameterName);
            this.Controls.Add(this.TxtParameterName);
            this.Controls.Add(this.LblTamplateId);
            this.Controls.Add(this.LblApiKey);
            this.Controls.Add(this.TxtTamplateId);
            this.Controls.Add(this.LblMobileNumber);
            this.Controls.Add(this.TxtMobileNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmVerifySend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerficationSend";
            this.Load += new System.EventHandler(this.FrmVerficationSend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMobileNumber;
        private System.Windows.Forms.Label LblMobileNumber;
        private System.Windows.Forms.TextBox TxtTamplateId;
        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Label LblTamplateId;
        private System.Windows.Forms.Label LblParameterName;
        private System.Windows.Forms.TextBox TxtParameterName;
        private System.Windows.Forms.Label LblParameterValue;
        private System.Windows.Forms.TextBox TxtParameterValue;
        private System.Windows.Forms.Label LblParameter;
        private System.Windows.Forms.Button BtnSend;
    }
}