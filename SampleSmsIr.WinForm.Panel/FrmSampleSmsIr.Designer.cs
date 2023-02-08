
namespace SampleSmsIr.WinForm.Panel
{
    partial class FrmSampleSmsIr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSampleSmsIr));
            this.BtnBulkSend = new System.Windows.Forms.Button();
            this.TxtApiKey = new System.Windows.Forms.TextBox();
            this.LblApiKey = new System.Windows.Forms.Label();
            this.BtnVerficationSend = new System.Windows.Forms.Button();
            this.BtnLikeToLikeSend = new System.Windows.Forms.Button();
            this.LblBulkSend = new System.Windows.Forms.Label();
            this.LblVerficationSend = new System.Windows.Forms.Label();
            this.LblLikeToLikeSend = new System.Windows.Forms.Label();
            this.BtnRemoveScheduledMessages = new System.Windows.Forms.Button();
            this.LblRemoveScheduledMessages = new System.Windows.Forms.Label();
            this.LblSends = new System.Windows.Forms.Label();
            this.LblReports = new System.Windows.Forms.Label();
            this.LblGetLiveReceive = new System.Windows.Forms.Label();
            this.LblGetLiveReport = new System.Windows.Forms.Label();
            this.LblGetReport = new System.Windows.Forms.Label();
            this.BtnGetLiveReceive = new System.Windows.Forms.Button();
            this.BtnGetLiveReport = new System.Windows.Forms.Button();
            this.BtnGetReport = new System.Windows.Forms.Button();
            this.LblGetLatestReceives = new System.Windows.Forms.Label();
            this.BtnGetLatestReceives = new System.Windows.Forms.Button();
            this.LblGetArchivedReceives = new System.Windows.Forms.Label();
            this.LblGetArchiveReport = new System.Windows.Forms.Label();
            this.LblGetSendPacks = new System.Windows.Forms.Label();
            this.BtnGetArchivedReceives = new System.Windows.Forms.Button();
            this.BtnGetArchiveReport = new System.Windows.Forms.Button();
            this.BtnGetSendPacks = new System.Windows.Forms.Button();
            this.LblSetting = new System.Windows.Forms.Label();
            this.LblgetLines = new System.Windows.Forms.Label();
            this.BtnGetLines = new System.Windows.Forms.Button();
            this.LblGetCredit = new System.Windows.Forms.Label();
            this.BtnGetCredit = new System.Windows.Forms.Button();
            this.PbSmsIr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSmsIr)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBulkSend
            // 
            this.BtnBulkSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBulkSend.Enabled = false;
            this.BtnBulkSend.Location = new System.Drawing.Point(851, 155);
            this.BtnBulkSend.Name = "BtnBulkSend";
            this.BtnBulkSend.Size = new System.Drawing.Size(210, 40);
            this.BtnBulkSend.TabIndex = 1;
            this.BtnBulkSend.Text = "ارسال گروهی";
            this.BtnBulkSend.UseVisualStyleBackColor = false;
            this.BtnBulkSend.Click += new System.EventHandler(this.BtnBulkSend_Click);
            // 
            // TxtApiKey
            // 
            this.TxtApiKey.Location = new System.Drawing.Point(12, 56);
            this.TxtApiKey.Multiline = true;
            this.TxtApiKey.Name = "TxtApiKey";
            this.TxtApiKey.Size = new System.Drawing.Size(527, 24);
            this.TxtApiKey.TabIndex = 0;
            this.TxtApiKey.TextChanged += new System.EventHandler(this.TxtApiKey_TextChanged);
            // 
            // LblApiKey
            // 
            this.LblApiKey.AutoSize = true;
            this.LblApiKey.Location = new System.Drawing.Point(12, 38);
            this.LblApiKey.Name = "LblApiKey";
            this.LblApiKey.Size = new System.Drawing.Size(47, 15);
            this.LblApiKey.TabIndex = 2;
            this.LblApiKey.Text = "Api Key";
            // 
            // BtnVerficationSend
            // 
            this.BtnVerficationSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVerficationSend.Enabled = false;
            this.BtnVerficationSend.Location = new System.Drawing.Point(851, 245);
            this.BtnVerficationSend.Name = "BtnVerficationSend";
            this.BtnVerficationSend.Size = new System.Drawing.Size(210, 40);
            this.BtnVerficationSend.TabIndex = 2;
            this.BtnVerficationSend.Text = "VERIFY ارسال ";
            this.BtnVerficationSend.UseVisualStyleBackColor = false;
            this.BtnVerficationSend.Click += new System.EventHandler(this.BtnVerficationSend_Click);
            // 
            // BtnLikeToLikeSend
            // 
            this.BtnLikeToLikeSend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLikeToLikeSend.Enabled = false;
            this.BtnLikeToLikeSend.Location = new System.Drawing.Point(851, 335);
            this.BtnLikeToLikeSend.Name = "BtnLikeToLikeSend";
            this.BtnLikeToLikeSend.Size = new System.Drawing.Size(210, 40);
            this.BtnLikeToLikeSend.TabIndex = 3;
            this.BtnLikeToLikeSend.Text = "ارسال نظیر به نظیر";
            this.BtnLikeToLikeSend.UseVisualStyleBackColor = false;
            this.BtnLikeToLikeSend.Click += new System.EventHandler(this.BtnLikeToLikeSend_Click);
            // 
            // LblBulkSend
            // 
            this.LblBulkSend.Location = new System.Drawing.Point(604, 154);
            this.LblBulkSend.Name = "LblBulkSend";
            this.LblBulkSend.Size = new System.Drawing.Size(228, 41);
            this.LblBulkSend.TabIndex = 4;
            this.LblBulkSend.Text = "این کلید برای ارسال یک متن پیامک به گروهی از شماره موبایل ها مورد استفاده قرار می" +
    "گیرد\r\n";
            this.LblBulkSend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblVerficationSend
            // 
            this.LblVerficationSend.Location = new System.Drawing.Point(587, 233);
            this.LblVerficationSend.Name = "LblVerficationSend";
            this.LblVerficationSend.Size = new System.Drawing.Size(245, 65);
            this.LblVerficationSend.TabIndex = 5;
            this.LblVerficationSend.Text = "با استفاده از این کلید شما قادر به ارسال پیامک به منظور ارسال کد اعتبارسنجی، کد ت" +
    "ایید، فاکتور خرید و به طور کلی پیامک‌هایی با اولویت بالا و پارامترهای پویا می‌با" +
    "شید\r\n  \r\n";
            this.LblVerficationSend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblLikeToLikeSend
            // 
            this.LblLikeToLikeSend.Location = new System.Drawing.Point(604, 336);
            this.LblLikeToLikeSend.Name = "LblLikeToLikeSend";
            this.LblLikeToLikeSend.Size = new System.Drawing.Size(228, 51);
            this.LblLikeToLikeSend.TabIndex = 6;
            this.LblLikeToLikeSend.Text = "این کلید برای ارسال به گروهی از موبایل‌ها با متن‌های متفاوت برای هر کدام، مورد اس" +
    "تفاده قرار می‌گیرد";
            this.LblLikeToLikeSend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnRemoveScheduledMessages
            // 
            this.BtnRemoveScheduledMessages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemoveScheduledMessages.Enabled = false;
            this.BtnRemoveScheduledMessages.Location = new System.Drawing.Point(851, 418);
            this.BtnRemoveScheduledMessages.Name = "BtnRemoveScheduledMessages";
            this.BtnRemoveScheduledMessages.Size = new System.Drawing.Size(210, 40);
            this.BtnRemoveScheduledMessages.TabIndex = 7;
            this.BtnRemoveScheduledMessages.Text = "حذف ارسال زمانبندی شده";
            this.BtnRemoveScheduledMessages.UseVisualStyleBackColor = false;
            this.BtnRemoveScheduledMessages.Click += new System.EventHandler(this.BtnRemoveScheduledMessages_Click);
            // 
            // LblRemoveScheduledMessages
            // 
            this.LblRemoveScheduledMessages.Location = new System.Drawing.Point(604, 418);
            this.LblRemoveScheduledMessages.Name = "LblRemoveScheduledMessages";
            this.LblRemoveScheduledMessages.Size = new System.Drawing.Size(228, 40);
            this.LblRemoveScheduledMessages.TabIndex = 8;
            this.LblRemoveScheduledMessages.Text = "به‌منظور حذف و انصراف از ارسال زمانبندی شده می‌توانید از این کلید  استفاده نمایید" +
    "";
            this.LblRemoveScheduledMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblSends
            // 
            this.LblSends.AutoSize = true;
            this.LblSends.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSends.Location = new System.Drawing.Point(1007, 125);
            this.LblSends.Name = "LblSends";
            this.LblSends.Size = new System.Drawing.Size(54, 17);
            this.LblSends.TabIndex = 9;
            this.LblSends.Text = "ارسال ها";
            this.LblSends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblReports
            // 
            this.LblReports.AutoSize = true;
            this.LblReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblReports.Location = new System.Drawing.Point(1004, 490);
            this.LblReports.Name = "LblReports";
            this.LblReports.Size = new System.Drawing.Size(57, 17);
            this.LblReports.TabIndex = 16;
            this.LblReports.Text = "گزارش ها";
            this.LblReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGetLiveReceive
            // 
            this.LblGetLiveReceive.Location = new System.Drawing.Point(604, 700);
            this.LblGetLiveReceive.Name = "LblGetLiveReceive";
            this.LblGetLiveReceive.Size = new System.Drawing.Size(228, 48);
            this.LblGetLiveReceive.TabIndex = 15;
            this.LblGetLiveReceive.Text = "با استفاده از این کلید گزارش پیامک‌های دریافتی روز جاری (اعم از خوانده شده و نشده" +
    ") قابل دستیابی می‌باشد";
            this.LblGetLiveReceive.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblGetLiveReport
            // 
            this.LblGetLiveReport.Location = new System.Drawing.Point(587, 609);
            this.LblGetLiveReport.Name = "LblGetLiveReport";
            this.LblGetLiveReport.Size = new System.Drawing.Size(245, 40);
            this.LblGetLiveReport.TabIndex = 14;
            this.LblGetLiveReport.Text = "با استفاده از این کلید، گزارشی از ارسال‌های انجام شده در روز جاری قابل دریافت است" +
    "";
            this.LblGetLiveReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblGetReport
            // 
            this.LblGetReport.Location = new System.Drawing.Point(587, 509);
            this.LblGetReport.Name = "LblGetReport";
            this.LblGetReport.Size = new System.Drawing.Size(245, 67);
            this.LblGetReport.TabIndex = 13;
            this.LblGetReport.Text = "/شما میتوانید با استفاده از (شناسه یکتای پیامک \r\n شناسه مجموع ارسال) که پس از انج" +
    "ام  ارسال‌ها دریافت کرده‌اید، به دریافت اطلاعات پیامک و همینطور اطلاع از وضعیت آ" +
    "ن اقدام نمایید\r\n\r\n\r\n";
            this.LblGetReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGetLiveReceive
            // 
            this.BtnGetLiveReceive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetLiveReceive.Enabled = false;
            this.BtnGetLiveReceive.Location = new System.Drawing.Point(851, 699);
            this.BtnGetLiveReceive.Name = "BtnGetLiveReceive";
            this.BtnGetLiveReceive.Size = new System.Drawing.Size(210, 40);
            this.BtnGetLiveReceive.TabIndex = 12;
            this.BtnGetLiveReceive.Text = "گزارش پیامک‌های دریافتی روز";
            this.BtnGetLiveReceive.UseVisualStyleBackColor = false;
            this.BtnGetLiveReceive.Click += new System.EventHandler(this.BtnGetLiveReceive_Click);
            // 
            // BtnGetLiveReport
            // 
            this.BtnGetLiveReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetLiveReport.Enabled = false;
            this.BtnGetLiveReport.Location = new System.Drawing.Point(851, 609);
            this.BtnGetLiveReport.Name = "BtnGetLiveReport";
            this.BtnGetLiveReport.Size = new System.Drawing.Size(210, 40);
            this.BtnGetLiveReport.TabIndex = 11;
            this.BtnGetLiveReport.Text = "گزارش ارسال‌های روز";
            this.BtnGetLiveReport.UseVisualStyleBackColor = false;
            this.BtnGetLiveReport.Click += new System.EventHandler(this.BtnGetLiveReport_Click);
            // 
            // BtnGetReport
            // 
            this.BtnGetReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetReport.Enabled = false;
            this.BtnGetReport.Location = new System.Drawing.Point(851, 519);
            this.BtnGetReport.Name = "BtnGetReport";
            this.BtnGetReport.Size = new System.Drawing.Size(210, 40);
            this.BtnGetReport.TabIndex = 10;
            this.BtnGetReport.Text = "گزارش پیامک / گزارش مجموعه ارسال";
            this.BtnGetReport.UseVisualStyleBackColor = false;
            this.BtnGetReport.Click += new System.EventHandler(this.BtnGetReport_Click);
            // 
            // LblGetLatestReceives
            // 
            this.LblGetLatestReceives.Location = new System.Drawing.Point(12, 397);
            this.LblGetLatestReceives.Name = "LblGetLatestReceives";
            this.LblGetLatestReceives.Size = new System.Drawing.Size(298, 81);
            this.LblGetLatestReceives.TabIndex = 24;
            this.LblGetLatestReceives.Text = resources.GetString("LblGetLatestReceives.Text");
            this.LblGetLatestReceives.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGetLatestReceives
            // 
            this.BtnGetLatestReceives.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGetLatestReceives.Enabled = false;
            this.BtnGetLatestReceives.Location = new System.Drawing.Point(329, 418);
            this.BtnGetLatestReceives.Name = "BtnGetLatestReceives";
            this.BtnGetLatestReceives.Size = new System.Drawing.Size(210, 40);
            this.BtnGetLatestReceives.TabIndex = 23;
            this.BtnGetLatestReceives.Text = "گزارش تازه‌ترین پیامک‌های دریافتی";
            this.BtnGetLatestReceives.UseVisualStyleBackColor = false;
            this.BtnGetLatestReceives.Click += new System.EventHandler(this.BtnGetLatestReceives_Click);
            // 
            // LblGetArchivedReceives
            // 
            this.LblGetArchivedReceives.Location = new System.Drawing.Point(12, 336);
            this.LblGetArchivedReceives.Name = "LblGetArchivedReceives";
            this.LblGetArchivedReceives.Size = new System.Drawing.Size(298, 39);
            this.LblGetArchivedReceives.TabIndex = 22;
            this.LblGetArchivedReceives.Text = "با فراخوانی متد زیر، گزارشی از پیامک‌های دریافتی در گذشته (تا انتهای روز قبل)، را" +
    " مشاهده خواهید نمود";
            this.LblGetArchivedReceives.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblGetArchiveReport
            // 
            this.LblGetArchiveReport.Location = new System.Drawing.Point(12, 245);
            this.LblGetArchiveReport.Name = "LblGetArchiveReport";
            this.LblGetArchiveReport.Size = new System.Drawing.Size(298, 40);
            this.LblGetArchiveReport.TabIndex = 21;
            this.LblGetArchiveReport.Text = "با استفاده از این کلید، گزارشی از ارسال‌های انجام شده در گذشته (تا انتهای روز قبل" +
    ")، را دریافت خواهید نمود";
            this.LblGetArchiveReport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblGetSendPacks
            // 
            this.LblGetSendPacks.Location = new System.Drawing.Point(12, 154);
            this.LblGetSendPacks.Name = "LblGetSendPacks";
            this.LblGetSendPacks.Size = new System.Drawing.Size(298, 41);
            this.LblGetSendPacks.TabIndex = 20;
            this.LblGetSendPacks.Text = "شما می‌توانید با استفاده از این کلید گزارش اطلاعات کلی مجموعه ارسال‌های روز جاری " +
    "را دریافت نمایید";
            this.LblGetSendPacks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGetArchivedReceives
            // 
            this.BtnGetArchivedReceives.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetArchivedReceives.Enabled = false;
            this.BtnGetArchivedReceives.Location = new System.Drawing.Point(329, 335);
            this.BtnGetArchivedReceives.Name = "BtnGetArchivedReceives";
            this.BtnGetArchivedReceives.Size = new System.Drawing.Size(210, 40);
            this.BtnGetArchivedReceives.TabIndex = 19;
            this.BtnGetArchivedReceives.Text = "گزارش پیامک‌های دریافتی آرشیو شده";
            this.BtnGetArchivedReceives.UseVisualStyleBackColor = false;
            this.BtnGetArchivedReceives.Click += new System.EventHandler(this.BtnGetArchivedReceives_Click);
            // 
            // BtnGetArchiveReport
            // 
            this.BtnGetArchiveReport.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetArchiveReport.Enabled = false;
            this.BtnGetArchiveReport.Location = new System.Drawing.Point(329, 245);
            this.BtnGetArchiveReport.Name = "BtnGetArchiveReport";
            this.BtnGetArchiveReport.Size = new System.Drawing.Size(210, 40);
            this.BtnGetArchiveReport.TabIndex = 18;
            this.BtnGetArchiveReport.Text = "گزارش ارسال‌های آرشیو شده";
            this.BtnGetArchiveReport.UseVisualStyleBackColor = false;
            this.BtnGetArchiveReport.Click += new System.EventHandler(this.BtnGetArchiveReport_Click);
            // 
            // BtnGetSendPacks
            // 
            this.BtnGetSendPacks.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetSendPacks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGetSendPacks.Enabled = false;
            this.BtnGetSendPacks.Location = new System.Drawing.Point(329, 155);
            this.BtnGetSendPacks.Name = "BtnGetSendPacks";
            this.BtnGetSendPacks.Size = new System.Drawing.Size(210, 40);
            this.BtnGetSendPacks.TabIndex = 17;
            this.BtnGetSendPacks.Text = "گزارش مجموعه ارسال‌های روز";
            this.BtnGetSendPacks.UseVisualStyleBackColor = false;
            this.BtnGetSendPacks.Click += new System.EventHandler(this.BtnGetSendPacks_Click);
            // 
            // LblSetting
            // 
            this.LblSetting.AutoSize = true;
            this.LblSetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSetting.Location = new System.Drawing.Point(485, 490);
            this.LblSetting.Name = "LblSetting";
            this.LblSetting.Size = new System.Drawing.Size(54, 17);
            this.LblSetting.TabIndex = 25;
            this.LblSetting.Text = "تنظیمات";
            this.LblSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblgetLines
            // 
            this.LblgetLines.Location = new System.Drawing.Point(12, 602);
            this.LblgetLines.Name = "LblgetLines";
            this.LblgetLines.Size = new System.Drawing.Size(298, 40);
            this.LblgetLines.TabIndex = 29;
            this.LblgetLines.Text = "با استفاده از این کلید، لیست خطوط آماده استفاده برای ارسال، قابل مشاهده است";
            this.LblgetLines.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGetLines
            // 
            this.BtnGetLines.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGetLines.Enabled = false;
            this.BtnGetLines.Location = new System.Drawing.Point(329, 602);
            this.BtnGetLines.Name = "BtnGetLines";
            this.BtnGetLines.Size = new System.Drawing.Size(210, 40);
            this.BtnGetLines.TabIndex = 28;
            this.BtnGetLines.Text = "دریافت لیست خطوط";
            this.BtnGetLines.UseVisualStyleBackColor = false;
            this.BtnGetLines.Click += new System.EventHandler(this.BtnGetLines_Click);
            // 
            // LblGetCredit
            // 
            this.LblGetCredit.Location = new System.Drawing.Point(12, 520);
            this.LblGetCredit.Name = "LblGetCredit";
            this.LblGetCredit.Size = new System.Drawing.Size(298, 39);
            this.LblGetCredit.TabIndex = 27;
            this.LblGetCredit.Text = "برای مشاهده مقدار اعتبار فعلی از این کلید استفاده نمایید";
            this.LblGetCredit.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnGetCredit
            // 
            this.BtnGetCredit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGetCredit.Enabled = false;
            this.BtnGetCredit.Location = new System.Drawing.Point(329, 519);
            this.BtnGetCredit.Name = "BtnGetCredit";
            this.BtnGetCredit.Size = new System.Drawing.Size(210, 40);
            this.BtnGetCredit.TabIndex = 26;
            this.BtnGetCredit.Text = "دریافت مقدار اعتبار فعلی";
            this.BtnGetCredit.UseVisualStyleBackColor = false;
            this.BtnGetCredit.Click += new System.EventHandler(this.BtnGetCredit_Click);
            // 
            // PbSmsIr
            // 
            this.PbSmsIr.Image = ((System.Drawing.Image)(resources.GetObject("PbSmsIr.Image")));
            this.PbSmsIr.Location = new System.Drawing.Point(851, 38);
            this.PbSmsIr.Name = "PbSmsIr";
            this.PbSmsIr.Size = new System.Drawing.Size(210, 63);
            this.PbSmsIr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbSmsIr.TabIndex = 30;
            this.PbSmsIr.TabStop = false;
            // 
            // FrmSampleSmsIr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1073, 770);
            this.Controls.Add(this.PbSmsIr);
            this.Controls.Add(this.LblgetLines);
            this.Controls.Add(this.BtnGetLines);
            this.Controls.Add(this.LblGetCredit);
            this.Controls.Add(this.BtnGetCredit);
            this.Controls.Add(this.LblSetting);
            this.Controls.Add(this.LblGetLatestReceives);
            this.Controls.Add(this.BtnGetLatestReceives);
            this.Controls.Add(this.LblGetArchivedReceives);
            this.Controls.Add(this.LblGetArchiveReport);
            this.Controls.Add(this.LblGetSendPacks);
            this.Controls.Add(this.BtnGetArchivedReceives);
            this.Controls.Add(this.BtnGetArchiveReport);
            this.Controls.Add(this.BtnGetSendPacks);
            this.Controls.Add(this.LblReports);
            this.Controls.Add(this.LblGetLiveReceive);
            this.Controls.Add(this.LblGetLiveReport);
            this.Controls.Add(this.LblGetReport);
            this.Controls.Add(this.BtnGetLiveReceive);
            this.Controls.Add(this.BtnGetLiveReport);
            this.Controls.Add(this.BtnGetReport);
            this.Controls.Add(this.LblSends);
            this.Controls.Add(this.LblRemoveScheduledMessages);
            this.Controls.Add(this.BtnRemoveScheduledMessages);
            this.Controls.Add(this.LblLikeToLikeSend);
            this.Controls.Add(this.LblVerficationSend);
            this.Controls.Add(this.LblBulkSend);
            this.Controls.Add(this.BtnLikeToLikeSend);
            this.Controls.Add(this.BtnVerficationSend);
            this.Controls.Add(this.LblApiKey);
            this.Controls.Add(this.TxtApiKey);
            this.Controls.Add(this.BtnBulkSend);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSampleSmsIr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSampleSmsIr";
            ((System.ComponentModel.ISupportInitialize)(this.PbSmsIr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBulkSend;
        private System.Windows.Forms.TextBox TxtApiKey;
        private System.Windows.Forms.Label LblApiKey;
        private System.Windows.Forms.Button BtnVerficationSend;
        private System.Windows.Forms.Button BtnLikeToLikeSend;
        private System.Windows.Forms.Label LblBulkSend;
        private System.Windows.Forms.Label LblVerficationSend;
        private System.Windows.Forms.Label LblLikeToLikeSend;
        private System.Windows.Forms.Button BtnRemoveScheduledMessages;
        private System.Windows.Forms.Label LblRemoveScheduledMessages;
        private System.Windows.Forms.Label LblSends;
        private System.Windows.Forms.Label LblReports;
        private System.Windows.Forms.Label LblGetLiveReceive;
        private System.Windows.Forms.Label LblGetLiveReport;
        private System.Windows.Forms.Label LblGetReport;
        private System.Windows.Forms.Button BtnGetLiveReceive;
        private System.Windows.Forms.Button BtnGetLiveReport;
        private System.Windows.Forms.Button BtnGetReport;
        private System.Windows.Forms.Label LblGetLatestReceives;
        private System.Windows.Forms.Button BtnGetLatestReceives;
        private System.Windows.Forms.Label LblGetArchivedReceives;
        private System.Windows.Forms.Label LblGetArchiveReport;
        private System.Windows.Forms.Label LblGetSendPacks;
        private System.Windows.Forms.Button BtnGetArchivedReceives;
        private System.Windows.Forms.Button BtnGetArchiveReport;
        private System.Windows.Forms.Button BtnGetSendPacks;
        private System.Windows.Forms.Label LblSetting;
        private System.Windows.Forms.Label LblgetLines;
        private System.Windows.Forms.Button BtnGetLines;
        private System.Windows.Forms.Label LblGetCredit;
        private System.Windows.Forms.Button BtnGetCredit;
        private System.Windows.Forms.PictureBox PbSmsIr;
    }
}