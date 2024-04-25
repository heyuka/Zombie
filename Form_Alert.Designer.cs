namespace Zombie
{
    partial class Form_Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Alert));
            Label_Warning = new Label();
            Button_Abort = new Button();
            Button_Sanitize = new Button();
            Timer_Sanitation = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Label_Warning
            // 
            Label_Warning.AutoSize = true;
            Label_Warning.BackColor = Color.Gold;
            Label_Warning.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Warning.ForeColor = Color.Black;
            Label_Warning.Location = new Point(12, 12);
            Label_Warning.Margin = new Padding(6);
            Label_Warning.Name = "Label_Warning";
            Label_Warning.Size = new Size(699, 76);
            Label_Warning.TabIndex = 0;
            Label_Warning.Text = "CONTAINMENT FAILED";
            // 
            // Button_Abort
            // 
            Button_Abort.BackColor = Color.Firebrick;
            Button_Abort.FlatStyle = FlatStyle.Popup;
            Button_Abort.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Abort.ForeColor = Color.Gold;
            Button_Abort.Location = new Point(12, 97);
            Button_Abort.Name = "Button_Abort";
            Button_Abort.Size = new Size(344, 76);
            Button_Abort.TabIndex = 1;
            Button_Abort.Text = "Abort";
            Button_Abort.UseVisualStyleBackColor = false;
            Button_Abort.Click += Button_Abort_Click;
            // 
            // Button_Sanitize
            // 
            Button_Sanitize.BackColor = Color.Firebrick;
            Button_Sanitize.FlatStyle = FlatStyle.Popup;
            Button_Sanitize.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Sanitize.ForeColor = Color.Gold;
            Button_Sanitize.Location = new Point(367, 97);
            Button_Sanitize.Name = "Button_Sanitize";
            Button_Sanitize.Size = new Size(344, 76);
            Button_Sanitize.TabIndex = 2;
            Button_Sanitize.Text = "Sanitize Facility";
            Button_Sanitize.UseVisualStyleBackColor = false;
            Button_Sanitize.Click += Button_Sanitize_Click;
            // 
            // Timer_Sanitation
            // 
            Timer_Sanitation.Enabled = true;
            Timer_Sanitation.Interval = 1000;
            Timer_Sanitation.Tick += Timer_Sanitation_Tick;
            // 
            // Form_Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(723, 185);
            ControlBox = false;
            Controls.Add(Button_Sanitize);
            Controls.Add(Button_Abort);
            Controls.Add(Label_Warning);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Alert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Warning;
        private Button Button_Abort;
        private Button Button_Sanitize;
        private System.Windows.Forms.Timer Timer_Sanitation;
    }
}