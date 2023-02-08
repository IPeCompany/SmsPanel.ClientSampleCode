using SampleSmsIr.WinForm.Panel.SampleSmsIr.Report;
using SampleSmsIr.WinForm.Panel.SampleSmsIr.Send;
using SampleSmsIr.WinForm.Panel.SampleSmsIr.Setting;
using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel
{
    public partial class FrmSampleSmsIr : Form
    {
        public static string ApiKey;

        public FrmSampleSmsIr()
        {
            InitializeComponent();
        }

        private void TxtApiKey_TextChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = !string.IsNullOrEmpty(TxtApiKey.Text);
                }
            }
        }

        private void BtnBulkSend_Click(object sender, EventArgs e)
        {
            FrmBulkSend frmBulkSend = new FrmBulkSend();
            ApiKey = TxtApiKey.Text;
            frmBulkSend.ShowDialog();
        }

        private void BtnVerficationSend_Click(object sender, EventArgs e)
        {
            FrmVerifySend frmVerficationSend = new FrmVerifySend();
            ApiKey = TxtApiKey.Text;
            frmVerficationSend.ShowDialog();
        }

        private void BtnLikeToLikeSend_Click(object sender, EventArgs e)
        {
            FrmLikeToLikeSend frmLikeToLikeSend = new FrmLikeToLikeSend();
            ApiKey = TxtApiKey.Text;
            frmLikeToLikeSend.ShowDialog();
        }

        private void BtnRemoveScheduledMessages_Click(object sender, EventArgs e)
        {
            FrmRemoveScheduleMessages frmRemoveScheduleMessage = new FrmRemoveScheduleMessages();
            ApiKey = TxtApiKey.Text;
            frmRemoveScheduleMessage.ShowDialog();
        }

        private void BtnGetReport_Click(object sender, EventArgs e)
        {
            FrmGetReport frmGetReport = new FrmGetReport();
            ApiKey = TxtApiKey.Text;
            frmGetReport.ShowDialog();
        }

        private void BtnGetLiveReport_Click(object sender, EventArgs e)
        {
            FrmGetLiveReports frmGetLiveReports = new FrmGetLiveReports();
            ApiKey = TxtApiKey.Text;
            frmGetLiveReports.ShowDialog();
        }

        private void BtnGetLiveReceive_Click(object sender, EventArgs e)
        {
            FrmGetLiveReceive frmGetLiveReceive = new FrmGetLiveReceive();
            ApiKey = TxtApiKey.Text;
            frmGetLiveReceive.ShowDialog();
        }

        private void BtnGetSendPacks_Click(object sender, EventArgs e)
        {
            FrmGetSendPacks frmGetSendPacks = new FrmGetSendPacks();
            ApiKey = TxtApiKey.Text;
            frmGetSendPacks.ShowDialog();
        }

        private void BtnGetArchiveReport_Click(object sender, EventArgs e)
        {
            FrmGetArchivedReport frmGetArchiveReport = new FrmGetArchivedReport();
            ApiKey = TxtApiKey.Text;
            frmGetArchiveReport.ShowDialog();
        }

        private void BtnGetArchivedReceives_Click(object sender, EventArgs e)
        {
            FrmGetArchivedReceives frmGetArchivedReceives = new FrmGetArchivedReceives();
            ApiKey = TxtApiKey.Text;
            frmGetArchivedReceives.ShowDialog();
        }

        private void BtnGetLatestReceives_Click(object sender, EventArgs e)
        {
            FrmGetLatestReceives frmGetLatestReceives = new FrmGetLatestReceives();
            ApiKey = TxtApiKey.Text;
            frmGetLatestReceives.ShowDialog();
        }

        private void BtnGetCredit_Click(object sender, EventArgs e)
        {
            FrmGetCredit frmGetCredit = new FrmGetCredit();
            ApiKey = TxtApiKey.Text;
            frmGetCredit.ShowDialog();
        }

        private void BtnGetLines_Click(object sender, EventArgs e)
        {
            FrmGetLines frmGetLines = new FrmGetLines();
            ApiKey = TxtApiKey.Text;
            frmGetLines.ShowDialog();
        }
    }
}