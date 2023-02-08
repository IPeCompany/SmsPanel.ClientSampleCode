using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using SampleSmsIr.Dll.Tools;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Report
{
    public partial class FrmGetSendPacks : Form
    {
        public FrmGetSendPacks()
        {
            InitializeComponent();
        }

        private void FrmGetSendPacks_Load(object sender, EventArgs e)
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

        private async void BtnGetSendPacks_Click(object sender, EventArgs e)
        {
            // get send packs
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                SmsIrResult<PackResult[]> smsIrResult = new SmsIrResult<PackResult[]>();

                int pageNumber = TxtPageNumber.Text.ToNullableInt() is null ? 1 : int.Parse(TxtPageNumber.Text);
                int pageSize = TxtPageSize.Text.ToNullableInt() is null ? 100 : int.Parse(TxtPageSize.Text);

                smsIrResult = await smsIr.GetSendPacksAsync(pageNumber, pageSize);

                GvSendPacks.DataSource = smsIrResult.Data.Select(x => new
                {
                    x.PackId,
                    x.RecipientCount,
                    x.CreationDateTime
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