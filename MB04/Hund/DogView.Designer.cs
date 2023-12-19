namespace MB04.Hund
{
    partial class DogView
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
            BtnCreate = new Button();
            TxtName = new TextBox();
            NuDAge = new NumericUpDown();
            BtnPlay = new Button();
            TxtNameBall = new TextBox();
            BtnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)NuDAge).BeginInit();
            SuspendLayout();
            // 
            // BtnCreate
            // 
            BtnCreate.Location = new Point(87, 146);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(180, 34);
            BtnCreate.TabIndex = 0;
            BtnCreate.Text = "Create";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(87, 31);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(180, 31);
            TxtName.TabIndex = 1;
            // 
            // NuDAge
            // 
            NuDAge.Location = new Point(87, 86);
            NuDAge.Name = "NuDAge";
            NuDAge.Size = new Size(180, 31);
            NuDAge.TabIndex = 2;
            // 
            // BtnPlay
            // 
            BtnPlay.Location = new Point(292, 146);
            BtnPlay.Name = "BtnPlay";
            BtnPlay.Size = new Size(112, 34);
            BtnPlay.TabIndex = 3;
            BtnPlay.Text = "Play";
            BtnPlay.UseVisualStyleBackColor = true;
            BtnPlay.Click += BtnPlay_Click;
            // 
            // TxtNameBall
            // 
            TxtNameBall.Location = new Point(305, 98);
            TxtNameBall.Name = "TxtNameBall";
            TxtNameBall.Size = new Size(150, 31);
            TxtNameBall.TabIndex = 4;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(87, 227);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(112, 34);
            BtnOk.TabIndex = 6;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // DogView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOk);
            Controls.Add(TxtNameBall);
            Controls.Add(BtnPlay);
            Controls.Add(NuDAge);
            Controls.Add(TxtName);
            Controls.Add(BtnCreate);
            Name = "DogView";
            Text = "DogView";
            ((System.ComponentModel.ISupportInitialize)NuDAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreate;
        private TextBox TxtName;
        private NumericUpDown NuDAge;
        private Button BtnPlay;
        private TextBox TxtNameBall;
        private Button BtnOk;
    }
}