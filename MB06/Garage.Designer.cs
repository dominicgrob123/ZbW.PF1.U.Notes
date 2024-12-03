namespace MB06
{
    partial class Garage
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
            TxtColor = new TextBox();
            NudWeight = new NumericUpDown();
            CmdCreate = new Button();
            LblShow = new Label();
            ((System.ComponentModel.ISupportInitialize)NudWeight).BeginInit();
            SuspendLayout();
            // 
            // TxtColor
            // 
            TxtColor.Location = new Point(98, 70);
            TxtColor.Name = "TxtColor";
            TxtColor.Size = new Size(181, 31);
            TxtColor.TabIndex = 0;
            // 
            // NudWeight
            // 
            NudWeight.Location = new Point(99, 128);
            NudWeight.Minimum = new decimal(new int[] { 20, 0, 0, int.MinValue });
            NudWeight.Name = "NudWeight";
            NudWeight.Size = new Size(180, 31);
            NudWeight.TabIndex = 1;
            // 
            // CmdCreate
            // 
            CmdCreate.Location = new Point(98, 186);
            CmdCreate.Name = "CmdCreate";
            CmdCreate.Size = new Size(181, 34);
            CmdCreate.TabIndex = 2;
            CmdCreate.Text = "Erzeuge Fahrrad";
            CmdCreate.UseVisualStyleBackColor = true;
            CmdCreate.Click += CmdCreate_Click;
            // 
            // LblShow
            // 
            LblShow.AutoSize = true;
            LblShow.Location = new Point(99, 243);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(59, 25);
            LblShow.TabIndex = 3;
            LblShow.Text = "label1";
            // 
            // Garage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblShow);
            Controls.Add(CmdCreate);
            Controls.Add(NudWeight);
            Controls.Add(TxtColor);
            Name = "Garage";
            Text = "Garage";
            ((System.ComponentModel.ISupportInitialize)NudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtColor;
        private NumericUpDown NudWeight;
        private Button CmdCreate;
        private Label LblShow;
    }
}