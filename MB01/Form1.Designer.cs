namespace MB01
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
            LblShow = new Label();
            CmdHello = new Button();
            CmdEnd = new Button();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(55, 45);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(40, 25);
            LblShow.TabIndex = 1;
            LblShow.Text = "leer";
            // 
            // CmdHello
            // 
            CmdHello.Location = new Point(55, 101);
            CmdHello.Name = "CmdHello";
            CmdHello.Size = new Size(112, 34);
            CmdHello.TabIndex = 2;
            CmdHello.Text = "Hallo";
            CmdHello.UseVisualStyleBackColor = true;
            CmdHello.Click += CmdHello_Click;
            // 
            // CmdEnd
            // 
            CmdEnd.Location = new Point(249, 182);
            CmdEnd.Name = "CmdEnd";
            CmdEnd.Size = new Size(112, 34);
            CmdEnd.TabIndex = 3;
            CmdEnd.Text = "Ende";
            CmdEnd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdEnd);
            Controls.Add(CmdHello);
            Controls.Add(LblShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button CmdHello;
        private Button CmdEnd;
    }
}
