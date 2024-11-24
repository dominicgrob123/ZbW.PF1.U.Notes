namespace MB03.Aufgaben
{
    partial class A6_2_2
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
            LblZahl = new Label();
            CmdBerechnen = new Button();
            TxtBi = new TextBox();
            NumZahl = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // LblZahl
            // 
            LblZahl.AutoSize = true;
            LblZahl.Location = new Point(21, 25);
            LblZahl.Name = "LblZahl";
            LblZahl.Size = new Size(120, 15);
            LblZahl.TabIndex = 0;
            LblZahl.Text = "Ganze Zahl eingeben:";
            // 
            // CmdBerechnen
            // 
            CmdBerechnen.Location = new Point(21, 78);
            CmdBerechnen.Name = "CmdBerechnen";
            CmdBerechnen.Size = new Size(128, 23);
            CmdBerechnen.TabIndex = 1;
            CmdBerechnen.Text = "Binärwert berechnen";
            CmdBerechnen.UseVisualStyleBackColor = true;
            CmdBerechnen.Click += CmdBerechnen_Click;
            // 
            // TxtBi
            // 
            TxtBi.Location = new Point(21, 122);
            TxtBi.Name = "TxtBi";
            TxtBi.ReadOnly = true;
            TxtBi.Size = new Size(280, 23);
            TxtBi.TabIndex = 2;
            // 
            // NumZahl
            // 
            NumZahl.Location = new Point(147, 23);
            NumZahl.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(154, 23);
            NumZahl.TabIndex = 3;
            // 
            // A6_2_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 203);
            Controls.Add(NumZahl);
            Controls.Add(TxtBi);
            Controls.Add(CmdBerechnen);
            Controls.Add(LblZahl);
            Name = "A6_2_2";
            Text = "A6_2_2";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl;
        private Button CmdBerechnen;
        private TextBox TxtBi;
        private NumericUpDown NumZahl;
    }
}