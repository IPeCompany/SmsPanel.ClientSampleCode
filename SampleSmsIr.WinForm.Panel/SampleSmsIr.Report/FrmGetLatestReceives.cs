using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using SampleSmsIr.Dll.Tools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    public partial class FrmGetLatestReceives : Form
    {
        public FrmGetLatestReceives()
        {
            InitializeComponent();
        }

        private void FrmGetLatestReceives_Load(object sender, EventArgs e)
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

        private async void GetLatestReceives_Click(object sender, EventArgs e)
        {
            // get latest receives
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                int count = TxtCount.Text.ToNullableInt() is null ? 100 : int.Parse(TxtCount.Text);

                SmsIrResult<ReceivedMessageResult[]> smsIrResult = await smsIr.GetLatestReceivesAsync(count);

                GvLatestReceives.DataSource = smsIrResult.Data.Select(x => new
                {
                    x.MessageText,
                    x.Number,
                    x.Mobile,
                    x.ReceivedDateTime
                }).ToArray();

                MessageBox.Show(@$" status: {smsIrResult.Status} " +
              $"\n message: {smsIrResult.Message} "
              , "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}