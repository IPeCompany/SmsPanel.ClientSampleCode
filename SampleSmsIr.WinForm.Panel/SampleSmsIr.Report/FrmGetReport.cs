using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    public partial class FrmGetReport : Form
    {
        public FrmGetReport()
        {
            InitializeComponent();
        }

        private void FrmGetReport_Load(object sender, EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;
        }

        private async void BtnGetReport_Click(object sender, EventArgs e)
        {
            //get report by message id
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                List<MessageReportResult> messageReportResults = new List<MessageReportResult>();

                var messageReport = await smsIr.GetReportAsync(int.Parse(TxtEarmark.Text));

                messageReportResults.Add(messageReport.Data);

                GvReport.DataSource = messageReportResults;

                MessageBox.Show(@$" status: {messageReport.Status} " +
               $"\n message: {messageReport.Message} "
               , "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnGetReportByPackId_Click(object sender, EventArgs e)
        {
            //get report by pack id
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                SmsIrResult<MessageReportResult[]> ReportMessage = await smsIr.GetReportAsync(Guid.Parse(TxtEarmark.Text));

                GvReport.DataSource = ReportMessage.Data.Select(x => new
                {
                    x.MessageId,
                    x.Mobile,
                    x.MessageText,
                    x.SendDateTime,
                    x.LineNumber,
                    x.Cost,
                    x.DeliveryState,
                    x.DeliveryDateTime,
                }).ToArray(); ;

                MessageBox.Show(@$" status: {ReportMessage.Status} " +
               $"\n message: {ReportMessage.Message} "
               , "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtEarmark_TextChanged(object sender, EventArgs e)
        {
            if (TxtEarmark.Text.All(char.IsDigit))
            {
                BtnGetReportByMessageId.Enabled = true;
                BtnGetReportByPackId.Enabled = false;
            }
            else
            {
                BtnGetReportByPackId.Enabled = true;
                BtnGetReportByMessageId.Enabled = false;
            }
        }
    }
}