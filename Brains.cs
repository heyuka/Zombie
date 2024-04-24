namespace Zombie
{
    public partial class Brains : Form
    {
        public Brains()
        {
            InitializeComponent();

            UpdateEndTime(16, 0, 0);
        }

        private void UpdateEndTime(int hours, int minutes, int seconds)
        {
            // Update the end time
            endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, seconds);

            // Check if the end time is in the past
            if (DateTime.Now > endTime)
            {
                // Add a day to the end time
                endTime = endTime.AddDays(1);
            }

            // Format and display the end time
            FormatAndDisplayEndTime();
            UpdateWindowTitle();
        }

        private void FormatAndDisplayEndTime()
        {
            // Update the text boxes to show the current end time, padded with zeros
            HoursTextBox.Text = endTime.Hour.ToString("00");
            MinutesTextBox.Text = endTime.Minute.ToString("00");
            SecondsTextBox.Text = endTime.Second.ToString("00");
        }

        private DateTime endTime;

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            // Terminate
            Application.Exit();
        }

        private void UpdateWindowTitle()
        {
            // Set the window title to the remaining time
            TimeSpan remainingTime = endTime - DateTime.Now;
            this.Text = remainingTime.ToString(@"hh\:mm\:ss");
        }

        private int mouseX = 0;

        // Timer
        // When the timer ticks, the zombie will check if the user is still active
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //// Check if the current time is past the end time
            //if (DateTime.Now > endTime)
            //{
            //    throw new Exception("Time's up!");
            //    // Terminate
            //    Application.Exit();
            //}

            string labelText = "Braaaaaaaiinnnsss...";
            // Check if the user is active
            if (UserIsActive())
            {
                labelText = "Braaaaaiinns!!";
            }
            else
            {
                // Simulate a key press
                SendKeys.SendWait("{SCROLLLOCK}");
                Thread.Sleep(10);
                SendKeys.SendWait("{SCROLLLOCK}");
            }

            // Reset the timer
            timer1.Interval = 30000;

            // Update the label
            label.Text = labelText;

            UpdateWindowTitle();
        }

        private bool UserIsActive()
        {
            // Get the current mouse position
            Point currentMousePosition = Cursor.Position;

            // Check if the mouse has moved
            if (currentMousePosition.X != mouseX)
            {
                // Mouse has moved
                // Update the mouse position
                mouseX = currentMousePosition.X;

                // Return true
                return true;
            }

            // Mouse has not moved
            // Return false
            return false;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                isVisible = false;
            }
            else
            {
                isVisible = true;
            }
            this.Visible = !this.Visible;
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(isVisible ? value : isVisible);
        }

        private void SecondsTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserTime();
        }

        private void MinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserTime();
        }

        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUserTime();
        }

        private void UpdateUserTime()
        {
            string userHours = HoursTextBox.Text;
            string userMinutes = MinutesTextBox.Text;
            string userSeconds = SecondsTextBox.Text;

            // Check if the user has entered a valid number
            if (!int.TryParse(userHours, out int hours))
            {
                // Invalid number
                // Set the hours to 0
                userHours = "00";
                HoursTextBox.Text = userHours;
                return;
            }

            // Check if the user has entered a valid number
            if (!int.TryParse(userMinutes, out int minutes))
            {
                // Invalid number
                // Set the minutes to 0
                userMinutes = "00";
                MinutesTextBox.Text = userMinutes;
                return;
            }

            // Check if the user has entered a valid number
            if (!int.TryParse(userSeconds, out int seconds))
            {
                // Invalid number
                // Set the seconds to 0
                userSeconds = "00";
                SecondsTextBox.Text = userSeconds;
                return;
            }

            // Update the end time
            UpdateEndTime(hours, minutes, seconds);
        }
    }
}
