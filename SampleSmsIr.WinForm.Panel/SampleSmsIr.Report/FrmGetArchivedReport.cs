using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using SampleSmsIr.Dll.Tools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    public partial class FrmGetArchivedReport : Form
    {
        public FrmGetArchivedReport()
        {
            InitializeComponent();
        }

        private void FrmGetArchivedReport_Load(object sender, EventArgs e)
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

        private async void BtnGetArchivedReport_Click(object sender, EventArgs e)
        {
            // get archived report
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                int pageNumber = TxtPageNumber.Text.ToNullableInt() is null ? 1 : int.Parse(TxtPageNumber.Text);
                int pageSize = TxtPageSize.Text.ToNullableInt() is null ? 100 : int.Parse(TxtPageSize.Text);

                SmsIrResult<MessageReportResult[]> smsIrResult = await smsIr.GetArchivedReportAsync(pageNumber, pageSize, TxtFromDate.Text.ToNullableInt(), TxtToDate.Text.ToNullableInt());

                GvArchivedReport.DataSource = smsIrResult.Data.Select(x => new
                {
                    x.MessageId,
                    x.Mobile,
                    x.MessageText,
                    x.SendDateTime,
                    x.LineNumber,
                    x.Cost,
                    x.DeliveryState,
                    x.DeliveryDateTime
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