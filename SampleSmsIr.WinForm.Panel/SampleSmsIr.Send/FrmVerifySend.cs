using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Requests;
using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Send
{
    public partial class FrmVerifySend : Form
    {
        public FrmVerifySend()
        {
            InitializeComponent();
        }

        private void FrmVerficationSend_Load(object sender, EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            //verify send
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                VerifySendParameter[] verifySendParameters = new VerifySendParameter[TxtParameterName.Text.Split(',').Length];

                for (int i = 0; i < verifySendParameters.Length; i++)
                {
                    verifySendParameters[i] = new VerifySendParameter(TxtParameterName.Text.Trim().Split(',')[i], TxtParameterValue.Text.Trim().Split(',')[i]);
                }

                var sendResult = await smsIr.VerifySendAsync(TxtMobileNumber.Text, int.Parse(TxtTamplateId.Text),
                  verifySendParameters);

                //smsIr.VerifySend(TxtMobileNumber.Text, int.Parse(TxtTamplateId.Text),
                //verifySendParameters);

                MessageBox.Show(@$" status: {sendResult.Status} " +
                  $"\n message: {sendResult.Message} " +
                  $"\n message id: {sendResult.Data.MessageId} " +
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