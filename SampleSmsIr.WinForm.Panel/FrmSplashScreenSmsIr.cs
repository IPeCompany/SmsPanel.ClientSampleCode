using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel
{
    public partial class FrmSplashScreenSmsIr : Form
    {
        public FrmSplashScreenSmsIr()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Start();
            this.Close();
        }
    }
}