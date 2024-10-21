namespace MB01
{
    partial class Uebung2
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
            label1 = new Label();
            label2 = new Label();
            CmdOutput = new Button();
            CmdDelete = new Button();
            LblShow = new Label();
            TxtInput = new TextBox();
            NumLetterCounter = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumLetterCounter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Eingabe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 147);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 1;
            label2.Text = "Anzahl Wörter:";
            // 
            // CmdOutput
            // 
            CmdOutput.Location = new Point(178, 221);
            CmdOutput.Name = "CmdOutput";
            CmdOutput.Size = new Size(112, 34);
            CmdOutput.TabIndex = 2;
            CmdOutput.Text = "Ausgeben";
            CmdOutput.UseVisualStyleBackColor = true;
            CmdOutput.Click += CmdOutput_Click;
            // 
            // CmdDelete
            // 
            CmdDelete.Location = new Point(307, 221);
            CmdDelete.Name = "CmdDelete";
            CmdDelete.Size = new Size(112, 34);
            CmdDelete.TabIndex = 3;
            CmdDelete.Text = "Löschen";
            CmdDelete.UseVisualStyleBackColor = true;
            CmdDelete.Click += CmdDelete_Click;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(178, 296);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 4;
            LblShow.Text = "label3";
            // 
            // TxtInput
            // 
            TxtInput.Location = new Point(178, 41);
            TxtInput.Multiline = true;
            TxtInput.Name = "TxtInput";
            TxtInput.Size = new Size(241, 71);
            TxtInput.TabIndex = 5;
            TxtInput.TextChanged += TxtInput_TextChanged;
            // 
            // NumLetterCounter
            // 
            NumLetterCounter.Location = new Point(178, 145);
            NumLetterCounter.Name = "NumLetterCounter";
            NumLetterCounter.ReadOnly = true;
            NumLetterCounter.Size = new Size(241, 31);
            NumLetterCounter.TabIndex = 6;
            // 
            // Uebung2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumLetterCounter);
            Controls.Add(TxtInput);
            Controls.Add(LblShow);
            Controls.Add(CmdDelete);
            Controls.Add(CmdOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Uebung2";
            Text = "Uebung2";
            ((System.ComponentModel.ISupportInitialize)NumLetterCounter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button CmdOutput;
        private Button CmdDelete;
        private Label LblShow;
        private TextBox TxtInput;
        private NumericUpDown NumLetterCounter;
    }
}