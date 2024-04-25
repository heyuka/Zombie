
namespace Zombie
{
    partial class Form_Brains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Brains));

            //
            // Components
            //
            // NotifyIcon
            NotifyIcon_Main = new NotifyIcon(components);
            // ContextMenuStrip
            ContextMenu_NotificationArea = new ContextMenuStrip(components);
            // ToolStripMenuItem
            ToolStripMenuItem_Terminate = new ToolStripMenuItem();
            // Button
            Button_Terminate = new Button();
            // Timer
            Timer_Clock = new System.Windows.Forms.Timer(components);
            Timer_End = new System.Windows.Forms.Timer(components);
            // TextBox
            TextBox_Hours = new TextBox();
            TextBox_Minutes = new TextBox();
            TextBox_Seconds = new TextBox();
            // Label
            Label_RemainingTime = new Label();
            Label_Status = new Label();


            ContextMenu_NotificationArea.SuspendLayout();
            SuspendLayout();
            // 
            // NotificationAreaIcon
            // 
            NotifyIcon_Main.BalloonTipIcon = ToolTipIcon.Info;
            resources.ApplyResources(NotifyIcon_Main, "NotificationAreaIcon");
            NotifyIcon_Main.ContextMenuStrip = ContextMenu_NotificationArea;
            NotifyIcon_Main.MouseDoubleClick += NotifyIcon_Main_MouseDoubleClick;
            // 
            // NotificationAreaContextMenu
            // 
            resources.ApplyResources(ContextMenu_NotificationArea, "NotificationAreaContextMenu");
            ContextMenu_NotificationArea.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Terminate });
            ContextMenu_NotificationArea.Name = "contextMenuStrip1";
            // 
            // terminateToolStripMenuItem
            // 
            resources.ApplyResources(ToolStripMenuItem_Terminate, "terminateToolStripMenuItem");
            ToolStripMenuItem_Terminate.Name = "terminateToolStripMenuItem";
            ToolStripMenuItem_Terminate.Click += Terminator;
            // 
            // terminateButton
            // 
            resources.ApplyResources(Button_Terminate, "terminateButton");
            Button_Terminate.BackColor = Color.Firebrick;
            Button_Terminate.FlatAppearance.BorderSize = 0;
            Button_Terminate.ForeColor = Color.Gold;
            Button_Terminate.Name = "terminateButton";
            Button_Terminate.UseVisualStyleBackColor = false;
            Button_Terminate.Click += Terminator;
            // 
            // EndTimer
            // 
            Timer_End.Enabled = true;
            Timer_End.Tick += Timer_End_Tick;
            // 
            // HoursTextBox
            // 
            resources.ApplyResources(TextBox_Hours, "HoursTextBox");
            TextBox_Hours.BackColor = SystemColors.WindowText;
            TextBox_Hours.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Hours.CharacterCasing = CharacterCasing.Upper;
            TextBox_Hours.ForeColor = Color.Lime;
            TextBox_Hours.Name = "HoursTextBox";
            TextBox_Hours.Leave += UpdateUserTime;
            // 
            // MinutesTextBox
            // 
            resources.ApplyResources(TextBox_Minutes, "MinutesTextBox");
            TextBox_Minutes.BackColor = SystemColors.WindowText;
            TextBox_Minutes.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Minutes.CharacterCasing = CharacterCasing.Upper;
            TextBox_Minutes.ForeColor = Color.Lime;
            TextBox_Minutes.Name = "MinutesTextBox";
            TextBox_Minutes.Leave += UpdateUserTime;
            // 
            // SecondsTextBox
            // 
            resources.ApplyResources(TextBox_Seconds, "SecondsTextBox");
            TextBox_Seconds.BackColor = SystemColors.WindowText;
            TextBox_Seconds.BorderStyle = BorderStyle.FixedSingle;
            TextBox_Seconds.CharacterCasing = CharacterCasing.Upper;
            TextBox_Seconds.ForeColor = Color.Lime;
            TextBox_Seconds.Name = "SecondsTextBox";
            TextBox_Seconds.Leave += UpdateUserTime;
            // 
            // ClockTimer
            // 
            Timer_Clock.Enabled = true;
            Timer_Clock.Tick += Timer_Clock_Tick;
            // 
            // HoursRemaining
            // 
            resources.ApplyResources(Label_RemainingTime, "HoursRemaining");
            Label_RemainingTime.BackColor = Color.Black;
            Label_RemainingTime.ForeColor = Color.Lime;
            Label_RemainingTime.Name = "HoursRemaining";
            // 
            // StatusLabel
            // 
            resources.ApplyResources(Label_Status, "StatusLabel");
            Label_Status.ForeColor = SystemColors.WindowText;
            Label_Status.Name = "StatusLabel";
            // 
            // Brains
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(Label_RemainingTime);
            Controls.Add(Label_Status);
            Controls.Add(TextBox_Hours);
            Controls.Add(TextBox_Minutes);
            Controls.Add(TextBox_Seconds);
            Controls.Add(Button_Terminate);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Brains";
            ContextMenu_NotificationArea.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Terminate;
        private ContextMenuStrip ContextMenu_NotificationArea;
        private Label Label_RemainingTime;
        private Label Label_Status;
        private NotifyIcon NotifyIcon_Main;
        private TextBox TextBox_Hours;
        private TextBox TextBox_Minutes;
        private TextBox TextBox_Seconds;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Timer Timer_End;
        private ToolStripMenuItem ToolStripMenuItem_Terminate;
    }
}
