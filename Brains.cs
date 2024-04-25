namespace Zombie
{
    public partial class Brains : Form
    {
        private DateTime endTime;
        private int mouseX = 0;

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
            TextBoxHours.Text = endTime.Hour.ToString("00");
            TextBoxMinutes.Text = endTime.Minute.ToString("00");
            TextBoxSeconds.Text = endTime.Second.ToString("00");
        }

        private void ButtonTerminate_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateWindowTitle()
        {
            // Set the window title to the remaining time
            TimeSpan remainingTime = endTime - DateTime.Now;
            string timeString = remainingTime.ToString(@"hh\:mm\:ss");

            this.Text = timeString;
            LabelRemainingTime.Text = timeString;
        }

        // Timer
        // When the timer ticks, the zombie will check if the user is still active
        private void EndTimer_Tick(object sender, EventArgs e)
        {

            // Check if the user is active
            if (!UserIsActive())
            {
                LabelStatus.Text = "SEARCHING";
                // Simulate a key press
                SendKeys.SendWait("{SCROLLLOCK}");
                Thread.Sleep(10);
                SendKeys.SendWait("{SCROLLLOCK}");

                LabelStatus.ForeColor = Color.Gold;
            }
            else
            {
                LabelStatus.Text = "FEEDING";
                LabelStatus.ForeColor = Color.Firebrick;
            }

            // Reset the timer
            TimerEnd.Interval = 30000;

            UpdateWindowTitle();
        }

        // Check if the user is active by checking if the mouse has moved. 
        // Set the mouseX variable to the current mouse position to set up for the next check
        private bool UserIsActive()
        {
            Point currentMousePosition = Cursor.Position;
            if (currentMousePosition.X != mouseX)
            {
                mouseX = currentMousePosition.X;
                return true;
            }
            return false;
        }

        private void NotificationAreaIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isVisible = !Visible;

            Visible = !Visible;
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(isVisible ? value : isVisible);
        }

        private void UpdateUserTime(object sender, EventArgs e)
        {
            int hours = ValidateUserInput(TextBoxHours.Text) % 24;
            int minutes = ValidateUserInput(TextBoxMinutes.Text) % 60;
            int seconds = ValidateUserInput(TextBoxSeconds.Text) % 60;

            // Update the end time
            UpdateEndTime(hours, minutes, seconds);
        }

        private static int ValidateUserInput(string text)
        {
            // this makes IntelliSense throw message CA1806, saying that I'm not doing anything with
            // the bool value returned by int.TryParse.
            // Thing is, I am, just indirectly. The documentation says that the out parameter is
            // set to 0 if the parsing fails, and I know that 0 is a perfectly valid value. In
            // fact, it's kind of what I want to return if the users puts something dumb in the
            // text box. 
            // Having the Message down there in the Error List is annoying, but I'm not going to
            // waste processing time dealing with that boolean when it's not going to change the
            // outcome of the program.
            int.TryParse(text, out int parsedValue);
            return parsedValue < 0 ? 0 : parsedValue;
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            // if current time is after endtime, open the Alert window
            if (DateTime.Now > endTime)
            {
                Hide();
                TimerClock.Enabled = false;

                AlertForm alert = new();
                alert.ShowDialog(this);
            }
            UpdateWindowTitle();
        }

        private void TerminateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
