namespace MB03.Aufgaben
{
    partial class A6_2_4
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
            LblZahl2 = new Label();
            LblZahl1 = new Label();
            Num1 = new NumericUpDown();
            Num2 = new NumericUpDown();
            CmdKgV = new Button();
            TxtResultat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num2).BeginInit();
            SuspendLayout();
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(12, 38);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(42, 15);
            LblZahl2.TabIndex = 0;
            LblZahl2.Text = "Zahl 2:";
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(12, 9);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(42, 15);
            LblZahl1.TabIndex = 0;
            LblZahl1.Text = "Zahl 1:";
            // 
            // Num1
            // 
            Num1.Location = new Point(60, 7);
            Num1.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            Num1.Name = "Num1";
            Num1.Size = new Size(163, 23);
            Num1.TabIndex = 1;
            // 
            // Num2
            // 
            Num2.Location = new Point(60, 36);
            Num2.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            Num2.Name = "Num2";
            Num2.Size = new Size(163, 23);
            Num2.TabIndex = 1;
            // 
            // CmdKgV
            // 
            CmdKgV.Location = new Point(12, 77);
            CmdKgV.Name = "CmdKgV";
            CmdKgV.Size = new Size(75, 23);
            CmdKgV.TabIndex = 2;
            CmdKgV.Text = "Bestimme kgV";
            CmdKgV.UseVisualStyleBackColor = true;
            CmdKgV.Click += CmdKgV_Click;
            // 
            // TxtResultat
            // 
            TxtResultat.Location = new Point(93, 78);
            TxtResultat.Name = "TxtResultat";
            TxtResultat.ReadOnly = true;
            TxtResultat.Size = new Size(130, 23);
            TxtResultat.TabIndex = 3;
            // 
            // A6_2_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 150);
            Controls.Add(TxtResultat);
            Controls.Add(CmdKgV);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(LblZahl1);
            Controls.Add(LblZahl2);
            Name = "A6_2_4";
            Text = "A6_2_4";
            ((System.ComponentModel.ISupportInitialize)Num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl2;
        private Label LblZahl1;
        private NumericUpDown Num1;
        private NumericUpDown Num2;
        private Button CmdKgV;
        private TextBox TxtResultat;
    }
}