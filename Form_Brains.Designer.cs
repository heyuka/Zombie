
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
            NotifyIcon_Main = new NotifyIcon(components);
            ContextMenu_NotificationArea = new ContextMenuStrip(components);
            ToolStripMenuItem_Terminate = new ToolStripMenuItem();
            Button_Terminate = new Button();
            Timer_Clock = new System.Windows.Forms.Timer(components);
            Timer_End = new System.Windows.Forms.Timer(components);
            TextBox_Hours = new TextBox();
            TextBox_Minutes = new TextBox();
            TextBox_Seconds = new TextBox();
            Label_Searching = new Label();
            pictureBox_RemainingTime_HoursTens = new PictureBox();
            pictureBox_RemainingTime_HoursOnes = new PictureBox();
            pictureBox_RemainingTime_Separator1 = new PictureBox();
            pictureBox_RemainingTime_MinutesTens = new PictureBox();
            pictureBox_RemainingTime_MinutesOnes = new PictureBox();
            pictureBox_RemainingTime_Separator2 = new PictureBox();
            pictureBox_RemainingTime_SecondsTens = new PictureBox();
            pictureBox_RemainingTime_SecondsOnes = new PictureBox();
            panel_RemainingTime = new Panel();
            Label_Feeding = new Label();
            ContextMenu_NotificationArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_HoursTens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_HoursOnes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_Separator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_MinutesTens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_MinutesOnes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_Separator2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_SecondsTens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_SecondsOnes).BeginInit();
            panel_RemainingTime.SuspendLayout();
            SuspendLayout();
            // 
            // NotifyIcon_Main
            // 
            NotifyIcon_Main.BalloonTipIcon = ToolTipIcon.Info;
            resources.ApplyResources(NotifyIcon_Main, "NotifyIcon_Main");
            NotifyIcon_Main.ContextMenuStrip = ContextMenu_NotificationArea;
            NotifyIcon_Main.MouseDoubleClick += NotifyIcon_Main_MouseDoubleClick;
            // 
            // ContextMenu_NotificationArea
            // 
            resources.ApplyResources(ContextMenu_NotificationArea, "ContextMenu_NotificationArea");
            ContextMenu_NotificationArea.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_Terminate });
            ContextMenu_NotificationArea.Name = "contextMenuStrip1";
            // 
            // ToolStripMenuItem_Terminate
            // 
            resources.ApplyResources(ToolStripMenuItem_Terminate, "ToolStripMenuItem_Terminate");
            ToolStripMenuItem_Terminate.Name = "ToolStripMenuItem_Terminate";
            ToolStripMenuItem_Terminate.Click += Terminator;
            // 
            // Button_Terminate
            // 
            resources.ApplyResources(Button_Terminate, "Button_Terminate");
            Button_Terminate.BackColor = Color.Firebrick;
            Button_Terminate.FlatAppearance.BorderSize = 2;
            Button_Terminate.ForeColor = Color.Gold;
            Button_Terminate.Name = "Button_Terminate";
            Button_Terminate.UseVisualStyleBackColor = false;
            Button_Terminate.Click += Terminator;
            // 
            // Timer_Clock
            // 
            Timer_Clock.Enabled = true;
            Timer_Clock.Tick += Timer_Clock_Tick;
            // 
            // Timer_End
            // 
            Timer_End.Enabled = true;
            Timer_End.Tick += Timer_End_Tick;
            // 
            // TextBox_Hours
            // 
            resources.ApplyResources(TextBox_Hours, "TextBox_Hours");
            TextBox_Hours.BackColor = SystemColors.WindowText;
            TextBox_Hours.CharacterCasing = CharacterCasing.Upper;
            TextBox_Hours.ForeColor = Color.LimeGreen;
            TextBox_Hours.Name = "TextBox_Hours";
            TextBox_Hours.Leave += UpdateUserTime;
            // 
            // TextBox_Minutes
            // 
            resources.ApplyResources(TextBox_Minutes, "TextBox_Minutes");
            TextBox_Minutes.BackColor = SystemColors.WindowText;
            TextBox_Minutes.CharacterCasing = CharacterCasing.Upper;
            TextBox_Minutes.ForeColor = Color.LimeGreen;
            TextBox_Minutes.Name = "TextBox_Minutes";
            TextBox_Minutes.Leave += UpdateUserTime;
            // 
            // TextBox_Seconds
            // 
            resources.ApplyResources(TextBox_Seconds, "TextBox_Seconds");
            TextBox_Seconds.BackColor = SystemColors.WindowText;
            TextBox_Seconds.CharacterCasing = CharacterCasing.Upper;
            TextBox_Seconds.ForeColor = Color.LimeGreen;
            TextBox_Seconds.Name = "TextBox_Seconds";
            TextBox_Seconds.Leave += UpdateUserTime;
            // 
            // Label_Searching
            // 
            resources.ApplyResources(Label_Searching, "Label_Searching");
            Label_Searching.BackColor = Color.Black;
            Label_Searching.BorderStyle = BorderStyle.Fixed3D;
            Label_Searching.FlatStyle = FlatStyle.System;
            Label_Searching.ForeColor = Color.Gold;
            Label_Searching.Name = "Label_Searching";
            // 
            // pictureBox_RemainingTime_HoursTens
            // 
            resources.ApplyResources(pictureBox_RemainingTime_HoursTens, "pictureBox_RemainingTime_HoursTens");
            pictureBox_RemainingTime_HoursTens.Name = "pictureBox_RemainingTime_HoursTens";
            pictureBox_RemainingTime_HoursTens.TabStop = false;
            // 
            // pictureBox_RemainingTime_HoursOnes
            // 
            resources.ApplyResources(pictureBox_RemainingTime_HoursOnes, "pictureBox_RemainingTime_HoursOnes");
            pictureBox_RemainingTime_HoursOnes.Name = "pictureBox_RemainingTime_HoursOnes";
            pictureBox_RemainingTime_HoursOnes.TabStop = false;
            // 
            // pictureBox_RemainingTime_Separator1
            // 
            resources.ApplyResources(pictureBox_RemainingTime_Separator1, "pictureBox_RemainingTime_Separator1");
            pictureBox_RemainingTime_Separator1.Name = "pictureBox_RemainingTime_Separator1";
            pictureBox_RemainingTime_Separator1.TabStop = false;
            // 
            // pictureBox_RemainingTime_MinutesTens
            // 
            resources.ApplyResources(pictureBox_RemainingTime_MinutesTens, "pictureBox_RemainingTime_MinutesTens");
            pictureBox_RemainingTime_MinutesTens.Name = "pictureBox_RemainingTime_MinutesTens";
            pictureBox_RemainingTime_MinutesTens.TabStop = false;
            // 
            // pictureBox_RemainingTime_MinutesOnes
            // 
            resources.ApplyResources(pictureBox_RemainingTime_MinutesOnes, "pictureBox_RemainingTime_MinutesOnes");
            pictureBox_RemainingTime_MinutesOnes.Name = "pictureBox_RemainingTime_MinutesOnes";
            pictureBox_RemainingTime_MinutesOnes.TabStop = false;
            // 
            // pictureBox_RemainingTime_Separator2
            // 
            resources.ApplyResources(pictureBox_RemainingTime_Separator2, "pictureBox_RemainingTime_Separator2");
            pictureBox_RemainingTime_Separator2.Name = "pictureBox_RemainingTime_Separator2";
            pictureBox_RemainingTime_Separator2.TabStop = false;
            // 
            // pictureBox_RemainingTime_SecondsTens
            // 
            resources.ApplyResources(pictureBox_RemainingTime_SecondsTens, "pictureBox_RemainingTime_SecondsTens");
            pictureBox_RemainingTime_SecondsTens.Name = "pictureBox_RemainingTime_SecondsTens";
            pictureBox_RemainingTime_SecondsTens.TabStop = false;
            // 
            // pictureBox_RemainingTime_SecondsOnes
            // 
            resources.ApplyResources(pictureBox_RemainingTime_SecondsOnes, "pictureBox_RemainingTime_SecondsOnes");
            pictureBox_RemainingTime_SecondsOnes.Name = "pictureBox_RemainingTime_SecondsOnes";
            pictureBox_RemainingTime_SecondsOnes.TabStop = false;
            // 
            // panel_RemainingTime
            // 
            resources.ApplyResources(panel_RemainingTime, "panel_RemainingTime");
            panel_RemainingTime.BackColor = Color.Black;
            panel_RemainingTime.BorderStyle = BorderStyle.Fixed3D;
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_HoursTens);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_SecondsOnes);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_HoursOnes);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_SecondsTens);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_Separator1);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_Separator2);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_MinutesTens);
            panel_RemainingTime.Controls.Add(pictureBox_RemainingTime_MinutesOnes);
            panel_RemainingTime.Name = "panel_RemainingTime";
            panel_RemainingTime.Paint += panel_RemainingTime_Paint;
            // 
            // Label_Feeding
            // 
            resources.ApplyResources(Label_Feeding, "Label_Feeding");
            Label_Feeding.BackColor = Color.Black;
            Label_Feeding.BorderStyle = BorderStyle.Fixed3D;
            Label_Feeding.FlatStyle = FlatStyle.System;
            Label_Feeding.ForeColor = Color.Firebrick;
            Label_Feeding.Name = "Label_Feeding";
            Label_Feeding.Click += label1_Click;
            // 
            // Form_Brains
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(Label_Feeding);
            Controls.Add(panel_RemainingTime);
            Controls.Add(Label_Searching);
            Controls.Add(TextBox_Hours);
            Controls.Add(TextBox_Minutes);
            Controls.Add(TextBox_Seconds);
            Controls.Add(Button_Terminate);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form_Brains";
            ContextMenu_NotificationArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_HoursTens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_HoursOnes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_Separator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_MinutesTens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_MinutesOnes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_Separator2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_SecondsTens).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_RemainingTime_SecondsOnes).EndInit();
            panel_RemainingTime.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_Terminate;
        private ContextMenuStrip ContextMenu_NotificationArea;
        private Label Label_Searching;
        private NotifyIcon NotifyIcon_Main;
        private TextBox TextBox_Hours;
        private TextBox TextBox_Minutes;
        private TextBox TextBox_Seconds;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.Timer Timer_End;
        private ToolStripMenuItem ToolStripMenuItem_Terminate;
        private PictureBox pictureBox_RemainingTime_HoursTens;
        private PictureBox pictureBox_RemainingTime_HoursOnes;
        private PictureBox pictureBox_RemainingTime_Separator1;
        private PictureBox pictureBox_RemainingTime_MinutesTens;
        private PictureBox pictureBox_RemainingTime_MinutesOnes;
        private PictureBox pictureBox_RemainingTime_Separator2;
        private PictureBox pictureBox_RemainingTime_SecondsTens;
        private PictureBox pictureBox_RemainingTime_SecondsOnes;
        private Panel panel_RemainingTime;
        private Label Label_Feeding;
    }
}
