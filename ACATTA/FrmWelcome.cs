using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ACATTA
{
    public partial class FrmWelcome : SplashScreen
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var t = new FrmMain();
            Hide();
            t.Show();
            timer1.Enabled = false;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}