namespace Zombie
{
    public partial class Form_Brains : Form
    {
        private DateTime endTime;
        private int mouseX = 0;
        private const string KEY = "{SCROLLLOCK}";
        private Clock clock;

        public Form_Brains()
        {
            InitializeComponent();

            UpdateEndTime(16, 0, 0);
        }

        // Update the end time based on the provided hours, minutes, and seconds.
        // Make sure the end time is some time in the next 24 hours.
        // Output the formatted value.
        private void UpdateEndTime(int hours, int minutes, int seconds)
        {
            endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hours, minutes, seconds);

            endTime = DateTime.Now > endTime ? endTime.AddDays(1) : endTime;
            endTime = endTime - DateTime.Now > new TimeSpan(1, 0, 0, 0) ? endTime.AddDays(-1) : endTime;

            TextBox_Hours.Text = endTime.Hour.ToString("00");
            TextBox_Minutes.Text = endTime.Minute.ToString("00");
            TextBox_Seconds.Text = endTime.Second.ToString("00");

            UpdateWindowTitle();
        }

        // The ending time is stored in a local variable. This function updates the window title to
        // show the remaining time.
        private void UpdateWindowTitle()
        {
            TimeSpan timeSpan = endTime - DateTime.Now;

            Text = timeSpan.ToString(@"hh\:mm\:ss");
            SetTimeRemaining(timeSpan);
        }

        private void SetTimeRemaining(TimeSpan timeSpan)
        {
            // if clock is not initialized, initialize it
            if (clock == null)
            {
                clock = new Clock();
            }
            Image[] rasters = clock.SetTime(timeSpan);

            pictureBox_RemainingTime_HoursTens.Image = rasters[0];
            pictureBox_RemainingTime_HoursOnes.Image = rasters[1];
            pictureBox_RemainingTime_MinutesTens.Image = rasters[2];
            pictureBox_RemainingTime_MinutesOnes.Image = rasters[3];
            pictureBox_RemainingTime_SecondsTens.Image = rasters[4];
            pictureBox_RemainingTime_SecondsOnes.Image = rasters[5];
        }

        // When the timer ticks, the zombie will check if the user is still active. 
        // If the user is not active, the zombie will simulate a key press to keep the computer awake.
        private void Timer_End_Tick(object sender, EventArgs e)
        {

            // Check if the user is active
            if (!UserIsActive())
            {
                // Simulate a key press
                SendKeys.SendWait(KEY);
                Thread.Sleep(10);
                SendKeys.SendWait(KEY);

                Label_Searching.ForeColor = Color.Gold;
                Label_Feeding.ForeColor = Color.FromArgb(21, 4, 4);
            }
            else
            {
                Label_Searching.ForeColor = Color.FromArgb(26, 22, 0);
                Label_Feeding.ForeColor = Color.Firebrick;
            }

            // Reset the timer
            Timer_End.Interval = 30000;

            UpdateWindowTitle();
        }

        // Check if the user is active by checking if the mouse has moved. 
        // Set the mouseX variable to the current mouse position to set up for the next check
        private bool UserIsActive()
        {
            int currentMousePositionX = Cursor.Position.X;
            bool isActive = currentMousePositionX != mouseX;
            mouseX = currentMousePositionX;
            return isActive;
        }

        // When the user double clicks the notification area icon, the zombie toggles its visibility.
        private void NotifyIcon_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isVisible = !Visible;
            Visible = !Visible;
        }

        // Set the visibility of the window based on the provided value.
        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(isVisible ? value : isVisible);
        }

        private void UpdateUserTime(object sender, EventArgs e)
        {
            int hours = ValidateUserInput(TextBox_Hours.Text) % 24;
            int minutes = ValidateUserInput(TextBox_Minutes.Text) % 60;
            int seconds = ValidateUserInput(TextBox_Seconds.Text) % 60;

            // Update the end time
            UpdateEndTime(hours, minutes, seconds);
        }

        private static int ValidateUserInput(string text)
        {
            // this makes IntelliSense throw message CA1806, saying that I'm not doing anything with
            // the bool value returned by TryParse.
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

        // Monitor the end time and show the alert window when the time is up.
        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            // if current time is after endtime, open the Alert window
            if (DateTime.Now > endTime)
            {
                Hide();
                Timer_Clock.Enabled = false;

                Form_Alert alert = new();
                alert.ShowDialog(this);
            }
            UpdateWindowTitle();
        }

        // Common event handler for the terminate menu item and button.
        private void Terminator(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_RemainingTime_Paint(object sender, PaintEventArgs e)
        {
            SetTimeRemaining(new TimeSpan(0));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
