using System;
using System.Windows.Forms;

namespace SampleSmsIr.WinForm.Panel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplashScreenSmsIr());
            Application.Run(new FrmSampleSmsIr());
        }
    }
}