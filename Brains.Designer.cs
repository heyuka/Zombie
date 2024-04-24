
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
            pictureBox1 = new PictureBox();
            label = new Label();
            terminateButton = new Button();
            EndTimer = new System.Windows.Forms.Timer(components);
            HoursTextBox = new TextBox();
            MinutesTextBox = new TextBox();
            SecondsTextBox = new TextBox();
            ClockTimer = new System.Windows.Forms.Timer(components);
            NotificationAreaContextMenu = new ContextMenuStrip(components);
            terminateToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NotificationAreaContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // NotificationAreaIcon
            // 
            NotificationAreaIcon.BalloonTipIcon = ToolTipIcon.Info;
            resources.ApplyResources(NotificationAreaIcon, "NotificationAreaIcon");
            NotificationAreaIcon.ContextMenuStrip = NotificationAreaContextMenu;
            NotificationAreaIcon.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            resources.ApplyResources(label, "label");
            label.ForeColor = Color.Lime;
            label.Name = "label";
            // 
            // terminateButton
            // 
            resources.ApplyResources(terminateButton, "terminateButton");
            terminateButton.BackColor = Color.Firebrick;
            terminateButton.ForeColor = Color.Gold;
            terminateButton.Name = "terminateButton";
            terminateButton.UseVisualStyleBackColor = false;
            terminateButton.Click += TerminateButton_Click;
            // 
            // EndTimer
            // 
            EndTimer.Enabled = true;
            EndTimer.Tick += Timer1_Tick;
            // 
            // HoursTextBox
            // 
            resources.ApplyResources(HoursTextBox, "HoursTextBox");
            HoursTextBox.BackColor = SystemColors.WindowText;
            HoursTextBox.BorderStyle = BorderStyle.FixedSingle;
            HoursTextBox.CharacterCasing = CharacterCasing.Upper;
            HoursTextBox.ForeColor = Color.Lime;
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Leave += HoursTextBox_TextChanged;
            // 
            // MinutesTextBox
            // 
            resources.ApplyResources(MinutesTextBox, "MinutesTextBox");
            MinutesTextBox.BackColor = SystemColors.WindowText;
            MinutesTextBox.BorderStyle = BorderStyle.FixedSingle;
            MinutesTextBox.CharacterCasing = CharacterCasing.Upper;
            MinutesTextBox.ForeColor = Color.Lime;
            MinutesTextBox.Name = "MinutesTextBox";
            MinutesTextBox.Leave += MinutesTextBox_TextChanged;
            // 
            // SecondsTextBox
            // 
            resources.ApplyResources(SecondsTextBox, "SecondsTextBox");
            SecondsTextBox.BackColor = SystemColors.WindowText;
            SecondsTextBox.BorderStyle = BorderStyle.FixedSingle;
            SecondsTextBox.CharacterCasing = CharacterCasing.Upper;
            SecondsTextBox.ForeColor = Color.Lime;
            SecondsTextBox.Name = "SecondsTextBox";
            SecondsTextBox.Leave += SecondsTextBox_TextChanged;
            // 
            // ClockTimer
            // 
            ClockTimer.Enabled = true;
            ClockTimer.Tick += ClockTimer_Tick;
            // 
            // NotificationAreaContextMenu
            // 
            resources.ApplyResources(NotificationAreaContextMenu, "NotificationAreaContextMenu");
            NotificationAreaContextMenu.Items.AddRange(new ToolStripItem[] { terminateToolStripMenuItem });
            NotificationAreaContextMenu.Name = "contextMenuStrip1";
            NotificationAreaContextMenu.Opening += contextMenuStrip1_Opening;
            // 
            // terminateToolStripMenuItem
            // 
            resources.ApplyResources(terminateToolStripMenuItem, "terminateToolStripMenuItem");
            terminateToolStripMenuItem.Name = "terminateToolStripMenuItem";
            terminateToolStripMenuItem.Click += terminateToolStripMenuItem_Click;
            // 
            // Brains
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(SecondsTextBox);
            Controls.Add(MinutesTextBox);
            Controls.Add(HoursTextBox);
            Controls.Add(terminateButton);
            Controls.Add(label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Brains";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NotificationAreaContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon NotificationAreaIcon;
        private PictureBox pictureBox1;
        private Label label;
        private Button terminateButton;
        private System.Windows.Forms.Timer EndTimer;
        private TextBox HoursTextBox;
        private TextBox MinutesTextBox;
        private TextBox SecondsTextBox;
        private System.Windows.Forms.Timer ClockTimer;
        private ContextMenuStrip NotificationAreaContextMenu;
        private ToolStripMenuItem terminateToolStripMenuItem;
    }
}
