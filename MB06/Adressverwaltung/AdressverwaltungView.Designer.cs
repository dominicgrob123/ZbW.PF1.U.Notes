namespace MB06.Adressverwaltung
{
    partial class AdressverwaltungView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            CmdCreateP = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // CmdCreateP
            // 
            CmdCreateP.Location = new Point(86, 123);
            CmdCreateP.Margin = new Padding(4, 3, 4, 3);
            CmdCreateP.Name = "CmdCreateP";
            CmdCreateP.Size = new Size(120, 27);
            CmdCreateP.TabIndex = 4;
            CmdCreateP.Text = "Erzeuge Person";
            CmdCreateP.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 167);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 314);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(86, 83);
            numericUpDown1.Minimum = new decimal(new int[] { 22, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Vorname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Alter";
            // 
            // AdressverwaltungView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 496);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CmdCreateP);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdressverwaltungView";
            Text = "Adressverwaltung";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdCreateP;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}

