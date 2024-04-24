using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie
{
    public partial class AlertForm : Form
    {
        public AlertForm()
        {
            InitializeComponent();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 60");
        }

        int timeout = 5;

        private void SanitationTimer_Tick(object sender, EventArgs e)
        {
            TerminateButton.Text = $"Sanitize Facility ({timeout})";
            if (timeout <= 0) TerminateButton.PerformClick();
            timeout--;
        }
    }
}
