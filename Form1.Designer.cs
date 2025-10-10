namespace Led_Digital_Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            clock = new Label();
            SuspendLayout();
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("LCD2", 99F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clock.ForeColor = Color.Cyan;
            clock.Location = new Point(25, 86);
            clock.Name = "clock";
            clock.Size = new Size(793, 118);
            clock.TabIndex = 0;
            clock.Text = "00:00:00 AM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(847, 318);
            Controls.Add(clock);
            Name = "Form1";
            Text = "Clock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clock;
    }
}
