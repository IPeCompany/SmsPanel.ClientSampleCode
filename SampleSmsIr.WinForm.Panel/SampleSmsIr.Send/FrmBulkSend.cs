using IPE.SmsIrClient;
using SampleSmsIr.Dll.Tools;
using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    public partial class FrmBulkSend : Form
    {
        public FrmBulkSend()
        {
            InitializeComponent();
        }

        private void FrmBulkSend_Load(object sender, EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            //bulk send
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                var sendResult = await smsIr.BulkSendAsync(long.Parse(TxtLineNumber.Text), TxtMessageText.Text, TxtMobileNumber.Text.Split(','), TxtSendDateTime.Text.ToNullableInt());

                //smsIr.BulkSend(long.Parse(TxtLineNumber.Text), TxtMessageText.Text, TxtMobileNumber.Text.Split(','), TxtSendDateTime.Text.ToNullableInt());

                MessageBox.Show(@$" status: {sendResult.Status} " +
                $"\n message: {sendResult.Message} " +
                $"\n pack id: {sendResult.Data.PackId} \n message id: {string.Concat(sendResult.Data.MessageIds)} " +
                $"\n cost: {sendResult.Data.Cost}"
                , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}