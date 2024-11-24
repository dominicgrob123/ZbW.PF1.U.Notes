namespace MB03.Aufgaben
{
    partial class A6_2_3
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
            LblZahl1 = new Label();
            LblZahl2 = new Label();
            Num1 = new NumericUpDown();
            Num2 = new NumericUpDown();
            CmdBestimmeGGT = new Button();
            TxtResultat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Num1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Num2).BeginInit();
            SuspendLayout();
            // 
            // LblZahl1
            // 
            LblZahl1.AutoSize = true;
            LblZahl1.Location = new Point(12, 18);
            LblZahl1.Name = "LblZahl1";
            LblZahl1.Size = new Size(42, 15);
            LblZahl1.TabIndex = 0;
            LblZahl1.Text = "Zahl 1:";
            // 
            // LblZahl2
            // 
            LblZahl2.AutoSize = true;
            LblZahl2.Location = new Point(12, 54);
            LblZahl2.Name = "LblZahl2";
            LblZahl2.Size = new Size(42, 15);
            LblZahl2.TabIndex = 0;
            LblZahl2.Text = "Zahl 2:";
            // 
            // Num1
            // 
            Num1.Location = new Point(60, 10);
            Num1.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            Num1.Name = "Num1";
            Num1.Size = new Size(176, 23);
            Num1.TabIndex = 1;
            // 
            // Num2
            // 
            Num2.Location = new Point(60, 46);
            Num2.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            Num2.Name = "Num2";
            Num2.Size = new Size(176, 23);
            Num2.TabIndex = 1;
            // 
            // CmdBestimmeGGT
            // 
            CmdBestimmeGGT.Location = new Point(12, 84);
            CmdBestimmeGGT.Name = "CmdBestimmeGGT";
            CmdBestimmeGGT.Size = new Size(75, 23);
            CmdBestimmeGGT.TabIndex = 2;
            CmdBestimmeGGT.Text = "Bestimme GGT";
            CmdBestimmeGGT.UseVisualStyleBackColor = true;
            CmdBestimmeGGT.Click += CmdBestimmeGGT_Click;
            // 
            // TxtResultat
            // 
            TxtResultat.Location = new Point(93, 84);
            TxtResultat.Name = "TxtResultat";
            TxtResultat.ReadOnly = true;
            TxtResultat.Size = new Size(143, 23);
            TxtResultat.TabIndex = 3;
            // 
            // A6_2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 144);
            Controls.Add(TxtResultat);
            Controls.Add(CmdBestimmeGGT);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(LblZahl2);
            Controls.Add(LblZahl1);
            Name = "A6_2_3";
            Text = "A6_2_3";
            ((System.ComponentModel.ISupportInitialize)Num1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Num2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZahl1;
        private Label LblZahl2;
        private NumericUpDown Num1;
        private NumericUpDown Num2;
        private Button CmdBestimmeGGT;
        private TextBox TxtResultat;
    }
}