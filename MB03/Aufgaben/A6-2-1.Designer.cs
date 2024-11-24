namespace MB03.Aufgaben
{
    partial class A6_2_1
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
            LblLoops = new Label();
            TxtRandomZahl = new TextBox();
            TxtLoops = new TextBox();
            CmdRandomZahl = new Button();
            CmdStart = new Button();
            TxtCalc = new TextBox();
            SuspendLayout();
            // 
            // LblZahl
            // 
            LblZahl.AutoSize = true;
            LblZahl.Location = new Point(12, 21);
            LblZahl.Name = "LblZahl";
            LblZahl.Size = new Size(33, 15);
            LblZahl.TabIndex = 0;
            LblZahl.Text = "Zahl:";
            // 
            // LblLoops
            // 
            LblLoops.AutoSize = true;
            LblLoops.Location = new Point(12, 418);
            LblLoops.Name = "LblLoops";
            LblLoops.Size = new Size(183, 15);
            LblLoops.TabIndex = 0;
            LblLoops.Text = "Anzahl Schleifenwiederholungen:";
            // 
            // TxtRandomZahl
            // 
            TxtRandomZahl.Location = new Point(51, 18);
            TxtRandomZahl.Name = "TxtRandomZahl";
            TxtRandomZahl.ReadOnly = true;
            TxtRandomZahl.Size = new Size(161, 23);
            TxtRandomZahl.TabIndex = 1;
            TxtRandomZahl.Text = "0";
            // 
            // TxtLoops
            // 
            TxtLoops.Location = new Point(201, 415);
            TxtLoops.Name = "TxtLoops";
            TxtLoops.ReadOnly = true;
            TxtLoops.Size = new Size(116, 23);
            TxtLoops.TabIndex = 2;
            TxtLoops.TextChanged += textBox2_TextChanged;
            // 
            // CmdRandomZahl
            // 
            CmdRandomZahl.Location = new Point(218, 18);
            CmdRandomZahl.Name = "CmdRandomZahl";
            CmdRandomZahl.Size = new Size(125, 23);
            CmdRandomZahl.TabIndex = 3;
            CmdRandomZahl.Text = "Generiere Zufallszahl";
            CmdRandomZahl.UseVisualStyleBackColor = true;
            CmdRandomZahl.Click += CmdRandomZahl_Click;
            // 
            // CmdStart
            // 
            CmdStart.Location = new Point(349, 18);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(92, 23);
            CmdStart.TabIndex = 3;
            CmdStart.Text = "Start";
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // TxtCalc
            // 
            TxtCalc.Location = new Point(12, 47);
            TxtCalc.Multiline = true;
            TxtCalc.Name = "TxtCalc";
            TxtCalc.ReadOnly = true;
            TxtCalc.ScrollBars = ScrollBars.Vertical;
            TxtCalc.Size = new Size(428, 362);
            TxtCalc.TabIndex = 4;
            // 
            // A6_2_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(TxtCalc);
            Controls.Add(CmdStart);
            Controls.Add(CmdRandomZahl);
            Controls.Add(TxtLoops);
            Controls.Add(TxtRandomZahl);
            Controls.Add(LblLoops);
            Controls.Add(LblZahl);
            Name = "A6_2_1";
            Text = "A6_2_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl;
        private Label LblLoops;
        private TextBox TxtRandomZahl;
        private TextBox TxtLoops;
        private Button CmdRandomZahl;
        private Button CmdStart;
        private TextBox TxtCalc;
    }
}