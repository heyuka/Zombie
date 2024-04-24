
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
            notifyIcon1 = new NotifyIcon(components);
            pictureBox1 = new PictureBox();
            label = new Label();
            terminateButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            HoursTextBox = new TextBox();
            MinutesTextBox = new TextBox();
            SecondsTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Hi";
            notifyIcon1.BalloonTipTitle = "brains?";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "brains..?";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Chiller", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.DarkGreen;
            label.Location = new Point(76, 6);
            label.Margin = new Padding(6);
            label.Name = "label";
            label.Size = new Size(130, 19);
            label.TabIndex = 99;
            label.Text = "Searching for brains...";
            // 
            // terminateButton
            // 
            terminateButton.BackColor = Color.Firebrick;
            terminateButton.FlatStyle = FlatStyle.Flat;
            terminateButton.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            terminateButton.ForeColor = Color.Gold;
            terminateButton.Location = new Point(76, 27);
            terminateButton.Margin = new Padding(6);
            terminateButton.Name = "terminateButton";
            terminateButton.Size = new Size(134, 43);
            terminateButton.TabIndex = 3;
            terminateButton.Text = "TERMINATE";
            terminateButton.UseVisualStyleBackColor = false;
            terminateButton.Click += TerminateButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // HoursTextBox
            // 
            HoursTextBox.BackColor = SystemColors.WindowText;
            HoursTextBox.BorderStyle = BorderStyle.FixedSingle;
            HoursTextBox.CharacterCasing = CharacterCasing.Upper;
            HoursTextBox.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HoursTextBox.ForeColor = Color.Lime;
            HoursTextBox.Location = new Point(6, 76);
            HoursTextBox.Margin = new Padding(6);
            HoursTextBox.MaxLength = 2;
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Size = new Size(64, 63);
            HoursTextBox.TabIndex = 100;
            HoursTextBox.Text = "00";
            HoursTextBox.TextAlign = HorizontalAlignment.Right;
            HoursTextBox.WordWrap = false;
            HoursTextBox.Leave += HoursTextBox_TextChanged;
            // 
            // MinutesTextBox
            // 
            MinutesTextBox.BackColor = SystemColors.WindowText;
            MinutesTextBox.BorderStyle = BorderStyle.FixedSingle;
            MinutesTextBox.CharacterCasing = CharacterCasing.Upper;
            MinutesTextBox.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinutesTextBox.ForeColor = Color.Lime;
            MinutesTextBox.Location = new Point(76, 76);
            MinutesTextBox.Margin = new Padding(6);
            MinutesTextBox.MaxLength = 2;
            MinutesTextBox.Name = "MinutesTextBox";
            MinutesTextBox.Size = new Size(64, 63);
            MinutesTextBox.TabIndex = 102;
            MinutesTextBox.Text = "00";
            MinutesTextBox.TextAlign = HorizontalAlignment.Right;
            MinutesTextBox.WordWrap = false;
            MinutesTextBox.Leave += MinutesTextBox_TextChanged;
            // 
            // SecondsTextBox
            // 
            SecondsTextBox.BackColor = SystemColors.WindowText;
            SecondsTextBox.BorderStyle = BorderStyle.FixedSingle;
            SecondsTextBox.CharacterCasing = CharacterCasing.Upper;
            SecondsTextBox.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecondsTextBox.ForeColor = Color.Lime;
            SecondsTextBox.Location = new Point(146, 76);
            SecondsTextBox.Margin = new Padding(6);
            SecondsTextBox.MaxLength = 2;
            SecondsTextBox.Name = "SecondsTextBox";
            SecondsTextBox.Size = new Size(64, 63);
            SecondsTextBox.TabIndex = 104;
            SecondsTextBox.Text = "00";
            SecondsTextBox.TextAlign = HorizontalAlignment.Right;
            SecondsTextBox.WordWrap = false;
            SecondsTextBox.Leave += SecondsTextBox_TextChanged;
            // 
            // Brains
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(393, 298);
            Controls.Add(SecondsTextBox);
            Controls.Add(MinutesTextBox);
            Controls.Add(HoursTextBox);
            Controls.Add(terminateButton);
            Controls.Add(label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Brains";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "brains..?";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox1;
        private Label label;
        private Button terminateButton;
        private System.Windows.Forms.Timer timer1;
        private Button updateButton;
        private TextBox HoursTextBox;
        private TextBox MinutesTextBox;
        private TextBox SecondsTextBox;
    }
}
