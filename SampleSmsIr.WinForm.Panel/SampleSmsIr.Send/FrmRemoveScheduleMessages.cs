using IPE.SmsIrClient;
using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    public partial class FrmRemoveScheduleMessages : Form
    {
        public FrmRemoveScheduleMessages()
        {
            InitializeComponent();
        }

        private void FrmRemoveScheduleMessage_Load(object sender, System.EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;
        }

        private async void BtnSend_Click(object sender, System.EventArgs e)
        {
            //remove scheduled messages
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                var sendResult = await smsIr.RemoveScheduledMessagesAsync(new Guid(TxtPackId.Text));

                //smsIr.RemoveScheduledMessages(new Guid(TxtPackId.Text));

                MessageBox.Show(@$" status: {sendResult.Status} " +
              $"\n message: {sendResult.Message} " +
              $"\n returned credit count: {sendResult.Data.ReturnedCreditCount} \n sms count: {sendResult.Data.SmsCount}"
              , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}