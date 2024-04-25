
namespace Zombie
{
    partial class Brains
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private bool isVisible = true;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brains));
            NotificationAreaIcon = new NotifyIcon(components);
            NotificationAreaContextMenu = new ContextMenuStrip(components);
            ToolStripMenuItemTerminate = new ToolStripMenuItem();
            ButtonTerminate = new Button();
            TimerEnd = new System.Windows.Forms.Timer(components);
            TextBoxHours = new TextBox();
            TextBoxMinutes = new TextBox();
            TextBoxSeconds = new TextBox();
            TimerClock = new System.Windows.Forms.Timer(components);
            LabelRemainingTime = new Label();
            LabelStatus = new Label();
            NotificationAreaContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // NotificationAreaIcon
            // 
            NotificationAreaIcon.BalloonTipIcon = ToolTipIcon.Info;
            resources.ApplyResources(NotificationAreaIcon, "NotificationAreaIcon");
            NotificationAreaIcon.ContextMenuStrip = NotificationAreaContextMenu;
            NotificationAreaIcon.MouseDoubleClick += NotificationAreaIcon_MouseDoubleClick;
            // 
            // NotificationAreaContextMenu
            // 
            resources.ApplyResources(NotificationAreaContextMenu, "NotificationAreaContextMenu");
            NotificationAreaContextMenu.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemTerminate });
            NotificationAreaContextMenu.Name = "contextMenuStrip1";
            // 
            // terminateToolStripMenuItem
            // 
            resources.ApplyResources(ToolStripMenuItemTerminate, "terminateToolStripMenuItem");
            ToolStripMenuItemTerminate.Name = "terminateToolStripMenuItem";
            ToolStripMenuItemTerminate.Click += TerminateToolStripMenuItem_Click;
            // 
            // terminateButton
            // 
            resources.ApplyResources(ButtonTerminate, "terminateButton");
            ButtonTerminate.BackColor = Color.Firebrick;
            ButtonTerminate.FlatAppearance.BorderSize = 0;
            ButtonTerminate.ForeColor = Color.Gold;
            ButtonTerminate.Name = "terminateButton";
            ButtonTerminate.UseVisualStyleBackColor = false;
            ButtonTerminate.Click += ButtonTerminate_Click;
            // 
            // EndTimer
            // 
            TimerEnd.Enabled = true;
            TimerEnd.Tick += EndTimer_Tick;
            // 
            // HoursTextBox
            // 
            resources.ApplyResources(TextBoxHours, "HoursTextBox");
            TextBoxHours.BackColor = SystemColors.WindowText;
            TextBoxHours.BorderStyle = BorderStyle.FixedSingle;
            TextBoxHours.CharacterCasing = CharacterCasing.Upper;
            TextBoxHours.ForeColor = Color.Lime;
            TextBoxHours.Name = "HoursTextBox";
            TextBoxHours.Leave += UpdateUserTime;
            // 
            // MinutesTextBox
            // 
            resources.ApplyResources(TextBoxMinutes, "MinutesTextBox");
            TextBoxMinutes.BackColor = SystemColors.WindowText;
            TextBoxMinutes.BorderStyle = BorderStyle.FixedSingle;
            TextBoxMinutes.CharacterCasing = CharacterCasing.Upper;
            TextBoxMinutes.ForeColor = Color.Lime;
            TextBoxMinutes.Name = "MinutesTextBox";
            TextBoxMinutes.Leave += UpdateUserTime;
            // 
            // SecondsTextBox
            // 
            resources.ApplyResources(TextBoxSeconds, "SecondsTextBox");
            TextBoxSeconds.BackColor = SystemColors.WindowText;
            TextBoxSeconds.BorderStyle = BorderStyle.FixedSingle;
            TextBoxSeconds.CharacterCasing = CharacterCasing.Upper;
            TextBoxSeconds.ForeColor = Color.Lime;
            TextBoxSeconds.Name = "SecondsTextBox";
            TextBoxSeconds.Leave += UpdateUserTime;
            // 
            // ClockTimer
            // 
            TimerClock.Enabled = true;
            TimerClock.Tick += TimerClock_Tick;
            // 
            // HoursRemaining
            // 
            resources.ApplyResources(LabelRemainingTime, "HoursRemaining");
            LabelRemainingTime.BackColor = Color.Black;
            LabelRemainingTime.ForeColor = Color.Lime;
            LabelRemainingTime.Name = "HoursRemaining";
            // 
            // StatusLabel
            // 
            resources.ApplyResources(LabelStatus, "StatusLabel");
            LabelStatus.ForeColor = SystemColors.WindowText;
            LabelStatus.Name = "StatusLabel";
            // 
            // Brains
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(LabelRemainingTime);
            Controls.Add(TextBoxSeconds);
            Controls.Add(TextBoxMinutes);
            Controls.Add(TextBoxHours);
            Controls.Add(ButtonTerminate);
            Controls.Add(LabelStatus);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Brains";
            NotificationAreaContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon NotificationAreaIcon;
        private Button ButtonTerminate;
        private System.Windows.Forms.Timer TimerEnd;
        private TextBox TextBoxHours;
        private TextBox TextBoxMinutes;
        private TextBox TextBoxSeconds;
        private System.Windows.Forms.Timer TimerClock;
        private ContextMenuStrip NotificationAreaContextMenu;
        private ToolStripMenuItem ToolStripMenuItemTerminate;
        private Label LabelRemainingTime;
        private Label LabelStatus;
    }
}
