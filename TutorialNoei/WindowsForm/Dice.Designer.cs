namespace WindowsForm
{
    partial class Dice
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
            TimerLabel = new Label();
            SuspendLayout();
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Font = new Font("Segoe UI", 49F);
            TimerLabel.Location = new Point(32, 12);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(73, 88);
            TimerLabel.TabIndex = 0;
            TimerLabel.Text = "6";
            // 
            // Dice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(139, 117);
            Controls.Add(TimerLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dice";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Dice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimerLabel;
    }
}