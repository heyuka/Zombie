namespace Zombie
{
    partial class AlertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertForm));
            WarningLabel = new Label();
            AbortButton = new Button();
            TerminateButton = new Button();
            SanitationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // WarningLabel
            // 
            WarningLabel.AutoSize = true;
            WarningLabel.BackColor = Color.Gold;
            WarningLabel.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WarningLabel.ForeColor = Color.Black;
            WarningLabel.Location = new Point(12, 12);
            WarningLabel.Margin = new Padding(6);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(699, 76);
            WarningLabel.TabIndex = 0;
            WarningLabel.Text = "CONTAINMENT FAILED";
            // 
            // AbortButton
            // 
            AbortButton.BackColor = Color.Firebrick;
            AbortButton.FlatStyle = FlatStyle.Popup;
            AbortButton.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AbortButton.ForeColor = Color.Gold;
            AbortButton.Location = new Point(12, 97);
            AbortButton.Name = "AbortButton";
            AbortButton.Size = new Size(344, 76);
            AbortButton.TabIndex = 1;
            AbortButton.Text = "Abort";
            AbortButton.UseVisualStyleBackColor = false;
            AbortButton.Click += AbortButton_Click;
            // 
            // TerminateButton
            // 
            TerminateButton.BackColor = Color.Firebrick;
            TerminateButton.FlatStyle = FlatStyle.Popup;
            TerminateButton.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TerminateButton.ForeColor = Color.Gold;
            TerminateButton.Location = new Point(367, 97);
            TerminateButton.Name = "TerminateButton";
            TerminateButton.Size = new Size(344, 76);
            TerminateButton.TabIndex = 2;
            TerminateButton.Text = "Sanitize Facility";
            TerminateButton.UseVisualStyleBackColor = false;
            TerminateButton.Click += TerminateButton_Click;
            // 
            // SanitationTimer
            // 
            SanitationTimer.Enabled = true;
            SanitationTimer.Interval = 1000;
            SanitationTimer.Tick += SanitationTimer_Tick;
            // 
            // AlertForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(723, 185);
            ControlBox = false;
            Controls.Add(TerminateButton);
            Controls.Add(AbortButton);
            Controls.Add(WarningLabel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AlertForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WarningLabel;
        private Button AbortButton;
        private Button TerminateButton;
        private System.Windows.Forms.Timer SanitationTimer;
    }
}