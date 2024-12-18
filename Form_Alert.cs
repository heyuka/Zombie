﻿using System;
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
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        private void Button_Abort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Sanitize_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new("shutdown", "/s /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        int timeout = 5;

        private void Timer_Sanitation_Tick(object sender, EventArgs e)
        {
            Button_Sanitize.Text = $"Sanitize Facility ({timeout})";
            if (timeout <= 0) Button_Sanitize.PerformClick();
            timeout--;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }
            base.WndProc(ref m);
        }
    }
}
