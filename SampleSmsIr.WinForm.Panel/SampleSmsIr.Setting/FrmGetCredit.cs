using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Setting
{
    public partial class FrmGetCredit : Form
    {
        public FrmGetCredit()
        {
            InitializeComponent();
        }

        private void FrmGetCredit_Load(object sender, EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;
        }

        private async void BtnGetCredit_Click(object sender, EventArgs e)
        {
            //get credit
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                List<SmsIrResult<decimal>> creditReportResults = new List<SmsIrResult<decimal>>();

                var creditReport = await smsIr.GetCreditAsync();

                creditReportResults.Add(creditReport);

                GvCredit.DataSource = creditReportResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}