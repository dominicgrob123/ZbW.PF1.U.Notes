namespace MB01
{
    partial class Uebung1
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
            LblShow = new Label();
            CmdMinus = new Button();
            CmdPlus = new Button();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(72, 47);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 0;
            LblShow.Text = "label1";
            // 
            // CmdMinus
            // 
            CmdMinus.Location = new Point(72, 99);
            CmdMinus.Name = "CmdMinus";
            CmdMinus.Size = new Size(112, 34);
            CmdMinus.TabIndex = 1;
            CmdMinus.Text = "-";
            CmdMinus.UseVisualStyleBackColor = true;
            CmdMinus.Click += CmdMinus_Click;
            // 
            // CmdPlus
            // 
            CmdPlus.Location = new Point(72, 163);
            CmdPlus.Name = "CmdPlus";
            CmdPlus.Size = new Size(112, 34);
            CmdPlus.TabIndex = 2;
            CmdPlus.Text = "+";
            CmdPlus.UseVisualStyleBackColor = true;
            CmdPlus.Click += CmdPlus_Click;
            // 
            // Uebung1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdPlus);
            Controls.Add(CmdMinus);
            Controls.Add(LblShow);
            Name = "Uebung1";
            Text = "Uebung1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button CmdMinus;
        private Button CmdPlus;
    }
}