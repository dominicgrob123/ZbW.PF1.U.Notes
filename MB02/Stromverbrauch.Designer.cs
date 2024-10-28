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
            ChkMonday = new CheckBox();
            RadTuesday = new RadioButton();
            TmrIntervall = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            TrkNum = new TrackBar();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrkNum).BeginInit();
            SuspendLayout();
            // 
            // ChkMonday
            // 
            ChkMonday.AutoSize = true;
            ChkMonday.Location = new Point(6, 41);
            ChkMonday.Name = "ChkMonday";
            ChkMonday.Size = new Size(101, 29);
            ChkMonday.TabIndex = 0;
            ChkMonday.Text = "Montag";
            ChkMonday.UseVisualStyleBackColor = true;
            ChkMonday.CheckedChanged += Checkbox_Changed;
            // 
            // RadTuesday
            // 
            RadTuesday.AutoSize = true;
            RadTuesday.Location = new Point(6, 86);
            RadTuesday.Name = "RadTuesday";
            RadTuesday.Size = new Size(107, 29);
            RadTuesday.TabIndex = 1;
            RadTuesday.TabStop = true;
            RadTuesday.Text = "Dienstag";
            RadTuesday.UseVisualStyleBackColor = true;
            // 
            // TmrIntervall
            // 
            TmrIntervall.Tick += TmrIntervall_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TrkNum);
            groupBox1.Controls.Add(ChkMonday);
            groupBox1.Controls.Add(RadTuesday);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 190);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tage";
            // 
            // TrkNum
            // 
            TrkNum.Location = new Point(6, 121);
            TrkNum.Name = "TrkNum";
            TrkNum.Size = new Size(156, 69);
            TrkNum.TabIndex = 3;
            // 
            // Stromverbrauch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Stromverbrauch";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrkNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox ChkMonday;
        private RadioButton RadTuesday;
        private System.Windows.Forms.Timer TmrIntervall;
        private GroupBox groupBox1;
        private TrackBar TrkNum;
    }
}
