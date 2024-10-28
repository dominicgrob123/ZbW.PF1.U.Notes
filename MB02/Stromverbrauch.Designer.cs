namespace MB02
{
    partial class Stromverbrauch
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
            components = new System.ComponentModel.Container();
            ChkTuesday = new CheckBox();
            RadMonday = new RadioButton();
            GrpDays = new GroupBox();
            TmrTimer = new System.Windows.Forms.Timer(components);
            TrkTime = new TrackBar();
            GrpDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrkTime).BeginInit();
            SuspendLayout();
            // 
            // ChkTuesday
            // 
            ChkTuesday.AutoSize = true;
            ChkTuesday.Location = new Point(6, 92);
            ChkTuesday.Name = "ChkTuesday";
            ChkTuesday.Size = new Size(108, 29);
            ChkTuesday.TabIndex = 0;
            ChkTuesday.Text = "Dienstag";
            ChkTuesday.UseVisualStyleBackColor = true;
            ChkTuesday.CheckedChanged += Changed;
            // 
            // RadMonday
            // 
            RadMonday.AutoSize = true;
            RadMonday.Location = new Point(6, 41);
            RadMonday.Name = "RadMonday";
            RadMonday.Size = new Size(100, 29);
            RadMonday.TabIndex = 1;
            RadMonday.TabStop = true;
            RadMonday.Text = "Montag";
            RadMonday.UseVisualStyleBackColor = true;
            RadMonday.CheckedChanged += RadMonday_CheckedChanged;
            // 
            // GrpDays
            // 
            GrpDays.Controls.Add(RadMonday);
            GrpDays.Controls.Add(ChkTuesday);
            GrpDays.Location = new Point(26, 12);
            GrpDays.Name = "GrpDays";
            GrpDays.Size = new Size(300, 150);
            GrpDays.TabIndex = 2;
            GrpDays.TabStop = false;
            GrpDays.Text = "Tage";
            // 
            // TmrTimer
            // 
            TmrTimer.Tick += TmrTimer_Tick;
            // 
            // TrkTime
            // 
            TrkTime.Location = new Point(32, 205);
            TrkTime.Name = "TrkTime";
            TrkTime.Size = new Size(156, 69);
            TrkTime.TabIndex = 3;
            // 
            // Stromverbrauch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TrkTime);
            Controls.Add(GrpDays);
            Name = "Stromverbrauch";
            Text = "Form1";
            GrpDays.ResumeLayout(false);
            GrpDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrkTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkTuesday;
        private RadioButton RadMonday;
        private GroupBox GrpDays;
        private System.Windows.Forms.Timer TmrTimer;
        private TrackBar TrkTime;
    }
}
