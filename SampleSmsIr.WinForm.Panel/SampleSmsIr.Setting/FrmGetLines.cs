using IPE.SmsIrClient;
using IPE.SmsIrClient.Models.Results;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel.SampleSmsIr.Setting
{
    public partial class FrmGetLines : Form
    {
        public FrmGetLines()
        {
            InitializeComponent();
        }

        private void FrmGetLines_Load(object sender, EventArgs e)
        {
            LblApiKey.Text = FrmSampleSmsIr.ApiKey;
        }

        private async void BtnGetLines_Click(object sender, EventArgs e)
        {
            //get lines
            try
            {
                SmsIr smsIr = new SmsIr(LblApiKey.Text);

                SmsIrResult<long[]> smsIrResult = await smsIr.GetLinesAsync();

                GvGetLines.Columns.Add("col1", "Numbers");

                for (int i = 0; i < smsIrResult.Data.Count(); i++)
                {
                    GvGetLines.Rows.Add(smsIrResult.Data[i]);
                }

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